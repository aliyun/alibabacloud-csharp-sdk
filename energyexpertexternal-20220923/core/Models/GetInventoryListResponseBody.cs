// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetInventoryListResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetInventoryListResponseBodyData Data { get; set; }
        public class GetInventoryListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Inventory detail.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<GetInventoryListResponseBodyDataItems> Items { get; set; }
            public class GetInventoryListResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>Emission quantity: may be positive, negative, or 0. To ensure the calculation accuracy, 24 decimal places are reserved for the calculation process. We recommend that you intercept data based on your business requirements.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000.000000000000000000000000000000</para>
                /// </summary>
                [NameInMap("carbonEmission")]
                [Validation(Required=false)]
                public double? CarbonEmission { get; set; }

                /// <summary>
                /// <para>Name </para>
                /// <remarks>
                /// <para>The name is related to the request parameters group. Request parameters: resource, return name parameter meaning: list name; request parameters: process, return name parameter meaning: process name; request parameters: resourceType, return name parameter meaning: inventory resource type name; request parameters: processType, return name parameter meaning: flow name.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Energy</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Percentage</para>
                /// 
                /// <b>Example:</b>
                /// <para>99.01</para>
                /// </summary>
                [NameInMap("percent")]
                [Validation(Required=false)]
                public string Percent { get; set; }

                /// <summary>
                /// <para>Process Name: It is only meaningful when the request parameters group is resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Process-1</para>
                /// </summary>
                [NameInMap("processName")]
                [Validation(Required=false)]
                public string ProcessName { get; set; }

            }

            /// <summary>
            /// <para>Unit of product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kg</para>
            /// </summary>
            [NameInMap("productUnit")]
            [Validation(Required=false)]
            public string ProductUnit { get; set; }

            /// <summary>
            /// <para>Emission Unit: The default value is kgCO₂ /productUnit. productUnit is the unit selected for the product. The unit value is changed to tCO₂ e/productUnit or gCO₂ e/productUnit based on the emission quantity. For more information, see the quantity column.</para>
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
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
