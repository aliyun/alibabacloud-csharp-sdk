// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetGwpInventoryConstituteResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetGwpInventoryConstituteResponseBodyData Data { get; set; }
        public class GetGwpInventoryConstituteResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Aggregated by resource type of an inventory.</para>
            /// </summary>
            [NameInMap("byResourceType")]
            [Validation(Required=false)]
            public List<GwpInventoryConstitute> ByResourceType { get; set; }

            /// <summary>
            /// <para>Emission quantity: may be positive, negative, or 0. To ensure the calculation accuracy, 24 decimal places are reserved for the calculation process. We recommend that you intercept data based on your business requirements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1009.976265540000000000000000000000</para>
            /// </summary>
            [NameInMap("carbonEmission")]
            [Validation(Required=false)]
            public double? CarbonEmission { get; set; }

            /// <summary>
            /// <para>Organized by hierarchy from high to low, according to the flow-&gt; process-&gt; inventory hierarchy.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<GwpInventoryConstitute> Items { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is not used for displaying</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Emission Unit.</para>
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
        /// <para>06DA2909-7736-5738-AA31-ACD617D828F1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
