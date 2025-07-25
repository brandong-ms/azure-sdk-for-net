﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;
using Azure.Generator.Tests.Common;
using Azure.Generator.Tests.TestHelpers;
using Azure.Generator.Visitors;
using Microsoft.TypeSpec.Generator.ClientModel.Providers;
using Microsoft.TypeSpec.Generator.Input;
using Microsoft.TypeSpec.Generator.Primitives;
using NUnit.Framework;

namespace Azure.Generator.Tests.Visitors
{
    public class RequestClientIdHeaderVisitorTests
    {
        [Test]
        public void RemovesTheRequestClientIdHeaderParameterFromServiceMethods()
        {
            var visitor = new TestRequestClientIdHeaderVisitor();
            var parameters = CreateParameters();
            var responseModel = InputFactory.Model("foo");
            var operation = InputFactory.Operation(
                "foo",
                parameters: parameters,
                responses: [InputFactory.OperationResponse(bodytype: responseModel)]);
            var serviceMethod = InputFactory.LongRunningServiceMethod(
                "foo",
                operation,
                parameters: parameters,
                response: InputFactory.ServiceMethodResponse(responseModel, ["result"]));
            var inputClient = InputFactory.Client("TestClient", methods: [serviceMethod]);
            MockHelpers.LoadMockGenerator(clients: () => [inputClient]);

            var clientProvider = AzureClientGenerator.Instance.TypeFactory.CreateClient(inputClient);
            Assert.IsNotNull(clientProvider);

            var responseModelProvider = AzureClientGenerator.Instance.TypeFactory.CreateModel(responseModel);
            Assert.IsNotNull(responseModelProvider);

            var methodCollection = new ScmMethodProviderCollection(serviceMethod, clientProvider!);
            methodCollection = visitor.InvokeVisitServiceMethod(serviceMethod, clientProvider!, methodCollection);

            foreach (var method in methodCollection!)
            {
                Assert.IsFalse(method.Signature.Parameters.Any(p => p.Name == "client-request-id"));
            }

            var writer = new TypeProviderWriter(clientProvider!.RestClient);
            var file = writer.Write();

            Assert.AreEqual(Helpers.GetExpectedFromFile(), file.Content);
        }

        [Test]
        public void DoesNotChangeExistingParameters()
        {
            var visitor = new TestRequestClientIdHeaderVisitor();
            var operationParameters = CreateParameters();
            var serviceMethodParameters = CreateParameters();
            var responseModel = InputFactory.Model("foo");
            var operation = InputFactory.Operation(
                "foo",
                parameters: operationParameters,
                responses: [InputFactory.OperationResponse(bodytype: responseModel)]);
            var serviceMethod = InputFactory.LongRunningServiceMethod(
                "foo",
                operation,
                parameters: serviceMethodParameters,
                response: InputFactory.ServiceMethodResponse(responseModel, ["result"]));
            var inputClient = InputFactory.Client("TestClient", methods: [serviceMethod]);
            MockHelpers.LoadMockGenerator(clients: () => [inputClient]);

            var clientProvider = AzureClientGenerator.Instance.TypeFactory.CreateClient(inputClient);
            Assert.IsNotNull(clientProvider);

            var responseModelProvider = AzureClientGenerator.Instance.TypeFactory.CreateModel(responseModel);
            Assert.IsNotNull(responseModelProvider);

            var methodCollection = new ScmMethodProviderCollection(serviceMethod, clientProvider!);
            methodCollection = visitor.InvokeVisitServiceMethod(serviceMethod, clientProvider!, methodCollection);

            Assert.AreEqual(1, serviceMethod.Parameters.Count);
            Assert.AreSame(serviceMethodParameters.Last(), serviceMethod.Parameters[0]);

            Assert.AreEqual(1, serviceMethod.Operation.Parameters.Count);
            Assert.AreSame(operationParameters.Last(), serviceMethod.Operation.Parameters[0]);

            Assert.AreNotSame(serviceMethodParameters[0], serviceMethod.Parameters[0]);
        }

        private static List<InputParameter> CreateParameters()
        {
            List<InputParameter> parameters =
            [
                InputFactory.Parameter(
                    "client-request-id",
                    type: InputPrimitiveType.String,
                    nameInRequest: "client-request-id",
                    location: InputRequestLocation.Header),
                InputFactory.Parameter(
                    "some-other-parameter",
                    type: InputPrimitiveType.String,
                    nameInRequest: "some-other-parameter",
                    location: InputRequestLocation.Header)
            ];
            return parameters;
        }

        private class TestRequestClientIdHeaderVisitor : RequestClientIdHeaderVisitor
        {
            public ScmMethodProviderCollection? InvokeVisitServiceMethod(
                InputServiceMethod serviceMethod,
                ClientProvider client,
                ScmMethodProviderCollection? methodCollection)
            {
                return base.Visit(serviceMethod, client, methodCollection);
            }
        }
    }
}