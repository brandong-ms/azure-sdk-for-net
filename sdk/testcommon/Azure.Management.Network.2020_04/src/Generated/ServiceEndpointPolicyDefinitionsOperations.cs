// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> The ServiceEndpointPolicyDefinitions service client. </summary>
    public partial class ServiceEndpointPolicyDefinitionsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ServiceEndpointPolicyDefinitionsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of ServiceEndpointPolicyDefinitionsOperations for mocking. </summary>
        protected ServiceEndpointPolicyDefinitionsOperations()
        {
        }
        /// <summary> Initializes a new instance of ServiceEndpointPolicyDefinitionsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ServiceEndpointPolicyDefinitionsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ServiceEndpointPolicyDefinitionsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get the specified service endpoint policy definitions from service endpoint policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy name. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceEndpointPolicyDefinition>> GetAsync(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the specified service endpoint policy definitions from service endpoint policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy name. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceEndpointPolicyDefinition> Get(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all service endpoint policy definitions in a service end point policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="serviceEndpointPolicyName"/> is null. </exception>
        public virtual AsyncPageable<ServiceEndpointPolicyDefinition> ListByResourceGroupAsync(string resourceGroupName, string serviceEndpointPolicyName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }

            async Task<Page<ServiceEndpointPolicyDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, serviceEndpointPolicyName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServiceEndpointPolicyDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, serviceEndpointPolicyName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all service endpoint policy definitions in a service end point policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="serviceEndpointPolicyName"/> is null. </exception>
        public virtual Pageable<ServiceEndpointPolicyDefinition> ListByResourceGroup(string resourceGroupName, string serviceEndpointPolicyName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }

            Page<ServiceEndpointPolicyDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, serviceEndpointPolicyName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServiceEndpointPolicyDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, serviceEndpointPolicyName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Deletes the specified ServiceEndpoint policy definitions. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the Service Endpoint Policy. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serviceEndpointPolicyName"/>, or <paramref name="serviceEndpointPolicyDefinitionName"/> is null. </exception>
        public virtual async Task<ServiceEndpointPolicyDefinitionsDeleteOperation> StartDeleteAsync(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }
            if (serviceEndpointPolicyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName, cancellationToken).ConfigureAwait(false);
                return new ServiceEndpointPolicyDefinitionsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified ServiceEndpoint policy definitions. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the Service Endpoint Policy. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serviceEndpointPolicyName"/>, or <paramref name="serviceEndpointPolicyDefinitionName"/> is null. </exception>
        public virtual ServiceEndpointPolicyDefinitionsDeleteOperation StartDelete(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }
            if (serviceEndpointPolicyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName, cancellationToken);
                return new ServiceEndpointPolicyDefinitionsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a service endpoint policy definition in the specified service endpoint policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="serviceEndpointPolicyDefinitions"> Parameters supplied to the create or update service endpoint policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serviceEndpointPolicyName"/>, <paramref name="serviceEndpointPolicyDefinitionName"/>, or <paramref name="serviceEndpointPolicyDefinitions"/> is null. </exception>
        public virtual async Task<ServiceEndpointPolicyDefinitionsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, ServiceEndpointPolicyDefinition serviceEndpointPolicyDefinitions, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }
            if (serviceEndpointPolicyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitionName));
            }
            if (serviceEndpointPolicyDefinitions == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitions));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName, serviceEndpointPolicyDefinitions, cancellationToken).ConfigureAwait(false);
                return new ServiceEndpointPolicyDefinitionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName, serviceEndpointPolicyDefinitions).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a service endpoint policy definition in the specified service endpoint policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="serviceEndpointPolicyDefinitions"> Parameters supplied to the create or update service endpoint policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serviceEndpointPolicyName"/>, <paramref name="serviceEndpointPolicyDefinitionName"/>, or <paramref name="serviceEndpointPolicyDefinitions"/> is null. </exception>
        public virtual ServiceEndpointPolicyDefinitionsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, ServiceEndpointPolicyDefinition serviceEndpointPolicyDefinitions, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }
            if (serviceEndpointPolicyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitionName));
            }
            if (serviceEndpointPolicyDefinitions == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitions));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName, serviceEndpointPolicyDefinitions, cancellationToken);
                return new ServiceEndpointPolicyDefinitionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName, serviceEndpointPolicyDefinitions).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}