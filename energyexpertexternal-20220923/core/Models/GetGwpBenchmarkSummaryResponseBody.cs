// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetGwpBenchmarkSummaryResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetGwpBenchmarkSummaryResponseBodyData Data { get; set; }
        public class GetGwpBenchmarkSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// Carbon Reduction Contribution Top4 Details.
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<GetGwpBenchmarkSummaryResponseBodyDataItems> Items { get; set; }
            public class GetGwpBenchmarkSummaryResponseBodyDataItems : TeaModel {
                /// <summary>
                /// Name of carbon reduction details.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Percentage of emissions. The value is of the string type. Two decimal places are reserved for numbers. For example, "99.01" indicates the 99.01% of this type of emissions to the total emissions. Note that the returned string itself does not contain a percent sign.
                /// </summary>
                [NameInMap("percent")]
                [Validation(Required=false)]
                public string Percent { get; set; }

                /// <summary>
                /// Emission amount is presented with four decimal places. Normally, modeling doesn\\"t result in negative values, but users can represent carbon reductions as negatives. The amount, paired with the unit, defines the emissions. Both are dynamically adjusted. If emissions exceed `1000 kgCO₂e/productUnit`, they convert to `tCO₂e/productUnit`. If they fall below `1 kgCO₂e/productUnit`, they convert to `gCO₂e/productUnit`. Otherwise, they stay in `kgCO₂e/productUnit`.
                /// </summary>
                [NameInMap("quantity")]
                [Validation(Required=false)]
                public long? Quantity { get; set; }

                /// <summary>
                /// Unit of emissions. The default value is `kgCO₂e/productUnit.` `productUnit` is the unit selected for the product. The unit value is changed to `tCO₂e/productUnit` or `gCO₂e/productUnit`. For more information, see the remarks in the quantity column.
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

            /// <summary>
            /// Emission amount is presented with four decimal places. Normally, modeling doesn\\"t result in negative values, but users can represent carbon reductions as negatives. The amount, paired with the unit, defines the emissions. Both are dynamically adjusted. If emissions exceed `1000 kgCO₂e/productUnit`, they convert to `tCO₂e/productUnit`. If they fall below `1 kgCO₂e/productUnit`, they convert to `gCO₂e/productUnit`. Otherwise, they stay in `kgCO₂e/productUnit`.
            /// </summary>
            [NameInMap("quantity")]
            [Validation(Required=false)]
            public long? Quantity { get; set; }

            /// <summary>
            /// Unit of emissions. The default value is `kgCO₂e/productUnit.` `productUnit` is the unit selected for the product. The unit value is changed to `tCO₂e/productUnit` or `gCO₂e/productUnit`. For more information, see the remarks in the quantity column.
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
