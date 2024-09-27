// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetGwpBenchmarkListResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetGwpBenchmarkListResponseBodyData Data { get; set; }
        public class GetGwpBenchmarkListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Active carbon reduction ranking list.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<GetGwpBenchmarkListResponseBodyDataItems> Items { get; set; }
            public class GetGwpBenchmarkListResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para><c>activeReduction=benchmarkEmission-carbonEmission</c> Generally, baseline emissions are greater than inventory emissions. Maintain four decimal places. Unit pertains to a higher-level unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2169</para>
                /// </summary>
                [NameInMap("activeReduction")]
                [Validation(Required=false)]
                public double? ActiveReduction { get; set; }

                /// <summary>
                /// <para>Benchmark emissions. Maintain four decimal places. Unit pertains to a higher-level unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0108</para>
                /// </summary>
                [NameInMap("benchmarkEmission")]
                [Validation(Required=false)]
                public double? BenchmarkEmission { get; set; }

                /// <summary>
                /// <para>Benchmark name</para>
                /// 
                /// <b>Example:</b>
                /// <para>old-energy</para>
                /// </summary>
                [NameInMap("benchmarkName")]
                [Validation(Required=false)]
                public string BenchmarkName { get; set; }

                /// <summary>
                /// <para>Inventory emissions. Maintain four decimal places. Unit pertains to a higher-level unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-0.2061</para>
                /// </summary>
                [NameInMap("carbonEmission")]
                [Validation(Required=false)]
                public double? CarbonEmission { get; set; }

                /// <summary>
                /// <para>name</para>
                /// 
                /// <b>Example:</b>
                /// <para>new-energy</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Unused temporarily.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("percent")]
                [Validation(Required=false)]
                public string Percent { get; set; }

            }

            /// <summary>
            /// <para>unit of emissions. The default value is <c>kgCO₂e/productUnit</c>. 
            /// The <c>productUnit</c> is the unit selected for the product. The unit value is changed to <c>tCO₂e/productUnit</c> or <c>gCO₂e/productUnit</c>. For more information, see the remarks in the quantity column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kgCO₂e/kg</para>
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The value is unique for each request. This facilitates subsequent troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A8AEC6D9-A359-5169-BD1A-BD848BA60D65</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
