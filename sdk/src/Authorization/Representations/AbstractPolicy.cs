//-------------------------------------------------------------------------
// Copyright © 2020 Province of British Columbia
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-------------------------------------------------------------------------
namespace Keycloak.Authorization.Representation
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>A generic Policy to inherit from.</summary>
    public class AbstractPolicy : IPolicy
    {
        /// <inheritdoc/>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("policies")]
        public List<string> Policies { get; } = new List<string>();

        /// <inheritdoc/>
        [JsonPropertyName("resources")]
        public List<string> Resources { get; } = new List<string>();

        /// <inheritdoc/>
        [JsonPropertyName("scopes")]
        public List<string> Scopes { get; } = new List<string>();

        /// <inheritdoc/>
        [JsonPropertyName("logic")]
        public Logic Logic { get; set; } = Logic.Positive;

        /// <inheritdoc/>
        [JsonPropertyName("decision_strategy")]
        public DecisionStrategy DecisionStrategy { get; set; } = DecisionStrategy.Unanimous;

        /// <inheritdoc/>
        [JsonPropertyName("owner")]
        public string? Owner { get; set; }
    }
}