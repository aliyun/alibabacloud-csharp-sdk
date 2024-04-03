// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetGwpInventorySummaryResponseBody : TeaModel {
        /// <summary>
        /// The returned results.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetGwpInventorySummaryResponseBodyData Data { get; set; }
        public class GetGwpInventorySummaryResponseBodyData : TeaModel {
            /// <summary>
            /// Top 4 types of carbon footprint contribution.
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<GetGwpInventorySummaryResponseBodyDataItems> Items { get; set; }
            public class GetGwpInventorySummaryResponseBodyDataItems : TeaModel {
                /// <summary>
                /// Inventory resource type name.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Percentage.
                /// </summary>
                [NameInMap("percent")]
                [Validation(Required=false)]
                public string Percent { get; set; }

                /// <summary>
                /// Quantity.
                /// </summary>
                [NameInMap("quantity")]
                [Validation(Required=false)]
                public double? Quantity { get; set; }

                /// <summary>
                /// The unit.
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

            /// <summary>
            /// The emission quantity.
            /// </summary>
            [NameInMap("quantity")]
            [Validation(Required=false)]
            public double? Quantity { get; set; }

            /// <summary>
            /// The time when the result was generated, in the millisecond timestamp format.
            /// </summary>
            [NameInMap("resultGenerateTime")]
            [Validation(Required=false)]
            public long? ResultGenerateTime { get; set; }

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
