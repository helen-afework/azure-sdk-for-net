// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> Contains the custom entity recognition job result. </summary>
    public partial class CustomEntityRecognitionOperationResult : AnalyzeTextOperationResult
    {
        /// <summary> Initializes a new instance of <see cref="CustomEntityRecognitionOperationResult"/>. </summary>
        /// <param name="lastUpdateDateTime"> The last updated time in UTC for the task. </param>
        /// <param name="status"> The status of the task at the mentioned last update time. </param>
        /// <param name="results"> List of results. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="results"/> is null. </exception>
        internal CustomEntityRecognitionOperationResult(DateTimeOffset lastUpdateDateTime, TextActionState status, CustomEntitiesResult results) : base(lastUpdateDateTime, status)
        {
            Argument.AssertNotNull(results, nameof(results));

            Kind = AnalyzeTextOperationResultsKind.CustomEntityRecognitionOperationResults;
            Results = results;
        }

        /// <summary> Initializes a new instance of <see cref="CustomEntityRecognitionOperationResult"/>. </summary>
        /// <param name="lastUpdateDateTime"> The last updated time in UTC for the task. </param>
        /// <param name="status"> The status of the task at the mentioned last update time. </param>
        /// <param name="name"> task name. </param>
        /// <param name="kind"> Kind of the task. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="results"> List of results. </param>
        internal CustomEntityRecognitionOperationResult(DateTimeOffset lastUpdateDateTime, TextActionState status, string name, AnalyzeTextOperationResultsKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, CustomEntitiesResult results) : base(lastUpdateDateTime, status, name, kind, serializedAdditionalRawData)
        {
            Results = results;
        }

        /// <summary> Initializes a new instance of <see cref="CustomEntityRecognitionOperationResult"/> for deserialization. </summary>
        internal CustomEntityRecognitionOperationResult()
        {
        }

        /// <summary> List of results. </summary>
        public CustomEntitiesResult Results { get; }
    }
}
