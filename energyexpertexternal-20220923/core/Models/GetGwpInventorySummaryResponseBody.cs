// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetGwpInventorySummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetGwpInventorySummaryResponseBodyData Data { get; set; }
        public class GetGwpInventorySummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Top 4 types of carbon footprint contribution.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<GetGwpInventorySummaryResponseBodyDataItems> Items { get; set; }
            public class GetGwpInventorySummaryResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>Inventory resource type name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Energy</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>99.01</para>
                /// </summary>
                [NameInMap("percent")]
                [Validation(Required=false)]
                public string Percent { get; set; }

                /// <summary>
                /// <para>Quantity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9.9763</para>
                /// </summary>
                [NameInMap("quantity")]
                [Validation(Required=false)]
                public double? Quantity { get; set; }

                /// <summary>
                /// <para>The unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kgCO₂e/Piece(s)</para>
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

            /// <summary>
            /// <para>The emission quantity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0100</para>
            /// </summary>
            [NameInMap("quantity")]
            [Validation(Required=false)]
            public double? Quantity { get; set; }

            /// <summary>
            /// <para>The time when the result was generated, in the millisecond timestamp format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1709108026000</para>
            /// </summary>
            [NameInMap("resultGenerateTime")]
            [Validation(Required=false)]
            public long? ResultGenerateTime { get; set; }

            /// <summary>
            /// <para>Emission Unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tCO₂e/Piece(s)</para>
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
