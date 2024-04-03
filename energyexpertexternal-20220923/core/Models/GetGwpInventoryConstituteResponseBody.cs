// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetGwpInventoryConstituteResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetGwpInventoryConstituteResponseBodyData Data { get; set; }
        public class GetGwpInventoryConstituteResponseBodyData : TeaModel {
            /// <summary>
            /// Aggregated by resource type of an inventory.
            /// </summary>
            [NameInMap("byResourceType")]
            [Validation(Required=false)]
            public List<GwpInventoryConstitute> ByResourceType { get; set; }

            /// <summary>
            /// Emission quantity: may be positive, negative, or 0. To ensure the calculation accuracy, 24 decimal places are reserved for the calculation process. We recommend that you intercept data based on your business requirements.
            /// </summary>
            [NameInMap("carbonEmission")]
            [Validation(Required=false)]
            public double? CarbonEmission { get; set; }

            /// <summary>
            /// Organized by hierarchy from high to low, according to the flow-> process-> inventory hierarchy.
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<GwpInventoryConstitute> Items { get; set; }

            /// <summary>
            /// The name.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Emission Unit.
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// The ID of the request. The value is unique for each request. This facilitates subsequent troubleshooting.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
