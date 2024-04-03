// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetGwpBenchmarkListResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetGwpBenchmarkListResponseBodyData Data { get; set; }
        public class GetGwpBenchmarkListResponseBodyData : TeaModel {
            /// <summary>
            /// Active carbon reduction ranking list.
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<GetGwpBenchmarkListResponseBodyDataItems> Items { get; set; }
            public class GetGwpBenchmarkListResponseBodyDataItems : TeaModel {
                /// <summary>
                /// `activeReduction=benchmarkEmission-carbonEmission` Generally, baseline emissions are greater than inventory emissions. Maintain four decimal places. Unit pertains to a higher-level unit.
                /// </summary>
                [NameInMap("activeReduction")]
                [Validation(Required=false)]
                public double? ActiveReduction { get; set; }

                /// <summary>
                /// Benchmark emissions. Maintain four decimal places. Unit pertains to a higher-level unit.
                /// </summary>
                [NameInMap("benchmarkEmission")]
                [Validation(Required=false)]
                public double? BenchmarkEmission { get; set; }

                /// <summary>
                /// Benchmark name
                /// </summary>
                [NameInMap("benchmarkName")]
                [Validation(Required=false)]
                public string BenchmarkName { get; set; }

                /// <summary>
                /// Inventory emissions. Maintain four decimal places. Unit pertains to a higher-level unit.
                /// </summary>
                [NameInMap("carbonEmission")]
                [Validation(Required=false)]
                public double? CarbonEmission { get; set; }

                /// <summary>
                /// name
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Unused temporarily.
                /// </summary>
                [NameInMap("percent")]
                [Validation(Required=false)]
                public string Percent { get; set; }

            }

            /// <summary>
            /// unit of emissions. The default value is `kgCO₂e/productUnit`. 
            /// The `productUnit` is the unit selected for the product. The unit value is changed to `tCO₂e/productUnit` or `gCO₂e/productUnit`. For more information, see the remarks in the quantity column.
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
