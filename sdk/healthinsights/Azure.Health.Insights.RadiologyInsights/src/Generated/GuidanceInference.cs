// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary> A guidance inference collects structured information about a specific finding in the report and can possibly propose appropriate follow-up recommendations, based upon established, evidence-based best practices i.e. ACR guidelines. </summary>
    public partial class GuidanceInference : RadiologyInsightsInference
    {
        /// <summary> Initializes a new instance of <see cref="GuidanceInference"/>. </summary>
        /// <param name="finding"> The finding associated with the guidance. </param>
        /// <param name="identifier"> The guidance identifier, as a concept. </param>
        /// <param name="ranking"> See doc of GuidanceRankingType. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="finding"/> or <paramref name="identifier"/> is null. </exception>
        internal GuidanceInference(FindingInference finding, FhirR4CodeableConcept identifier, GuidanceRankingType ranking)
        {
            Argument.AssertNotNull(finding, nameof(finding));
            Argument.AssertNotNull(identifier, nameof(identifier));

            Kind = RadiologyInsightsInferenceType.Guidance;
            Finding = finding;
            Identifier = identifier;
            PresentGuidanceInformation = new ChangeTrackingList<PresentGuidanceInformation>();
            Ranking = ranking;
            RecommendationProposals = new ChangeTrackingList<FollowupRecommendationInference>();
            MissingGuidanceInformation = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="GuidanceInference"/>. </summary>
        /// <param name="kind"> Discriminator property for RadiologyInsightsInference. </param>
        /// <param name="extension"> Additional Content defined by implementations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="finding"> The finding associated with the guidance. </param>
        /// <param name="identifier"> The guidance identifier, as a concept. </param>
        /// <param name="presentGuidanceInformation"> presentGuidanceInformation lists each item of the structured information (e.g. laterality) and corresponding details (left, right, bilateral) that is present in the document. </param>
        /// <param name="ranking"> See doc of GuidanceRankingType. </param>
        /// <param name="recommendationProposals"> The proposed follow-up recommendations, if any. If this is filled, missingGuidanceInformation cannot be filled (and vice versa). </param>
        /// <param name="missingGuidanceInformation"> Contains all missing items that are needed to determine follow-up. </param>
        internal GuidanceInference(RadiologyInsightsInferenceType kind, IReadOnlyList<FhirR4Extension> extension, IDictionary<string, BinaryData> serializedAdditionalRawData, FindingInference finding, FhirR4CodeableConcept identifier, IReadOnlyList<PresentGuidanceInformation> presentGuidanceInformation, GuidanceRankingType ranking, IReadOnlyList<FollowupRecommendationInference> recommendationProposals, IReadOnlyList<string> missingGuidanceInformation) : base(kind, extension, serializedAdditionalRawData)
        {
            Finding = finding;
            Identifier = identifier;
            PresentGuidanceInformation = presentGuidanceInformation;
            Ranking = ranking;
            RecommendationProposals = recommendationProposals;
            MissingGuidanceInformation = missingGuidanceInformation;
        }

        /// <summary> Initializes a new instance of <see cref="GuidanceInference"/> for deserialization. </summary>
        internal GuidanceInference()
        {
        }

        /// <summary> The finding associated with the guidance. </summary>
        public FindingInference Finding { get; }
        /// <summary> The guidance identifier, as a concept. </summary>
        public FhirR4CodeableConcept Identifier { get; }
        /// <summary> presentGuidanceInformation lists each item of the structured information (e.g. laterality) and corresponding details (left, right, bilateral) that is present in the document. </summary>
        public IReadOnlyList<PresentGuidanceInformation> PresentGuidanceInformation { get; }
        /// <summary> See doc of GuidanceRankingType. </summary>
        public GuidanceRankingType Ranking { get; }
        /// <summary> The proposed follow-up recommendations, if any. If this is filled, missingGuidanceInformation cannot be filled (and vice versa). </summary>
        public IReadOnlyList<FollowupRecommendationInference> RecommendationProposals { get; }
        /// <summary> Contains all missing items that are needed to determine follow-up. </summary>
        public IReadOnlyList<string> MissingGuidanceInformation { get; }
    }
}
