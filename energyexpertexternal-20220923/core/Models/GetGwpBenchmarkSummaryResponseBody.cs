// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetGwpBenchmarkSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetGwpBenchmarkSummaryResponseBodyData Data { get; set; }
        public class GetGwpBenchmarkSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Carbon Reduction Contribution Top4 Details.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<GetGwpBenchmarkSummaryResponseBodyDataItems> Items { get; set; }
            public class GetGwpBenchmarkSummaryResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>Name of carbon reduction details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Energy-Replacement</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Percentage of emissions. The value is of the string type. Two decimal places are reserved for numbers. For example, &quot;99.01&quot; indicates the 99.01% of this type of emissions to the total emissions. Note that the returned string itself does not contain a percent sign.</para>
                /// 
                /// <b>Example:</b>
                /// <para>99.01</para>
                /// </summary>
                [NameInMap("percent")]
                [Validation(Required=false)]
                public string Percent { get; set; }

                /// <summary>
                /// <para>Emission amount is presented with four decimal places. Normally, modeling doesn\&quot;t result in negative values, but users can represent carbon reductions as negatives. The amount, paired with the unit, defines the emissions. Both are dynamically adjusted. If emissions exceed <c>1000 kgCO₂e/productUnit</c>, they convert to <c>tCO₂e/productUnit</c>. If they fall below <c>1 kgCO₂e/productUnit</c>, they convert to <c>gCO₂e/productUnit</c>. Otherwise, they stay in <c>kgCO₂e/productUnit</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9.9763</para>
                /// </summary>
                [NameInMap("quantity")]
                [Validation(Required=false)]
                public long? Quantity { get; set; }

                /// <summary>
                /// <para>Unit of emissions. The default value is <c>kgCO₂e/productUnit.</c> <c>productUnit</c> is the unit selected for the product. The unit value is changed to <c>tCO₂e/productUnit</c> or <c>gCO₂e/productUnit</c>. For more information, see the remarks in the quantity column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kgCO₂e/kg</para>
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

            /// <summary>
            /// <para>Emission amount is presented with four decimal places. Normally, modeling doesn\&quot;t result in negative values, but users can represent carbon reductions as negatives. The amount, paired with the unit, defines the emissions. Both are dynamically adjusted. If emissions exceed <c>1000 kgCO₂e/productUnit</c>, they convert to <c>tCO₂e/productUnit</c>. If they fall below <c>1 kgCO₂e/productUnit</c>, they convert to <c>gCO₂e/productUnit</c>. Otherwise, they stay in <c>kgCO₂e/productUnit</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000.0000</para>
            /// </summary>
            [NameInMap("quantity")]
            [Validation(Required=false)]
            public long? Quantity { get; set; }

            /// <summary>
            /// <para>Unit of emissions. The default value is <c>kgCO₂e/productUnit.</c> <c>productUnit</c> is the unit selected for the product. The unit value is changed to <c>tCO₂e/productUnit</c> or <c>gCO₂e/productUnit</c>. For more information, see the remarks in the quantity column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kgCO₂e/t</para>
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The value is unique for each request. This facilitates subsequent troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
