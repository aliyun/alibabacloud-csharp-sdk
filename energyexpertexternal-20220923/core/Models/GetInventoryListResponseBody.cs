// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetInventoryListResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetInventoryListResponseBodyData Data { get; set; }
        public class GetInventoryListResponseBodyData : TeaModel {
            /// <summary>
            /// Inventory detail.
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<GetInventoryListResponseBodyDataItems> Items { get; set; }
            public class GetInventoryListResponseBodyDataItems : TeaModel {
                /// <summary>
                /// Emission quantity: may be positive, negative, or 0. To ensure the calculation accuracy, 24 decimal places are reserved for the calculation process. We recommend that you intercept data based on your business requirements.
                /// </summary>
                [NameInMap("carbonEmission")]
                [Validation(Required=false)]
                public double? CarbonEmission { get; set; }

                /// <summary>
                /// Name 
                /// 
                /// > The name is related to the request parameters group. Request parameters: resource, return name parameter meaning: list name; request parameters: process, return name parameter meaning: process name; request parameters: resourceType, return name parameter meaning: inventory resource type name; request parameters: processType, return name parameter meaning: flow name.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Percentage
                /// </summary>
                [NameInMap("percent")]
                [Validation(Required=false)]
                public string Percent { get; set; }

                /// <summary>
                /// Process Name: It is only meaningful when the request parameters group is resource.
                /// </summary>
                [NameInMap("processName")]
                [Validation(Required=false)]
                public string ProcessName { get; set; }

            }

            /// <summary>
            /// Unit of product.
            /// </summary>
            [NameInMap("productUnit")]
            [Validation(Required=false)]
            public string ProductUnit { get; set; }

            /// <summary>
            /// Emission Unit: The default value is kgCO₂ /productUnit. productUnit is the unit selected for the product. The unit value is changed to tCO₂ e/productUnit or gCO₂ e/productUnit based on the emission quantity. For more information, see the quantity column.
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
