// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeCommodityResponseBody : TeaModel {
        /// <summary>
        /// The commodity code.
        /// 
        /// Examples for the China site (aliyun.com):
        /// 
        /// *   **ga_gapluspre_public_cn**: GA instance.
        /// *   **ga_plusbwppre_public_cn**: basic bandwidth plan.
        /// 
        /// Examples for the international site (alibabacloud.com):
        /// 
        /// *   **ga_pluspre_public_intl**: GA instance.
        /// *   **ga_bwppreintl_public_intl**: basic bandwidth plan.
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// The name of the commodity.
        /// </summary>
        [NameInMap("CommodityName")]
        [Validation(Required=false)]
        public string CommodityName { get; set; }

        /// <summary>
        /// The information about the commodity modules.
        /// 
        /// The returned information varies based on the commodity.
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<DescribeCommodityResponseBodyComponents> Components { get; set; }
        public class DescribeCommodityResponseBodyComponents : TeaModel {
            /// <summary>
            /// The code of the commodity module.
            /// 
            /// The returned information varies based on the commodity module.
            /// </summary>
            [NameInMap("ComponentCode")]
            [Validation(Required=false)]
            public string ComponentCode { get; set; }

            /// <summary>
            /// The name of the commodity module.
            /// 
            /// The returned information varies based on the commodity module.
            /// </summary>
            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// The attributes of the commodity module.
            /// 
            /// The returned information varies based on the commodity module.
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public List<DescribeCommodityResponseBodyComponentsProperties> Properties { get; set; }
            public class DescribeCommodityResponseBodyComponentsProperties : TeaModel {
                /// <summary>
                /// The code of the attribute.
                /// 
                /// The returned information varies based on the commodity module.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The name of the attribute.
                /// 
                /// The returned information varies based on the commodity module.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The list of attribute values of the commodity module.
                /// 
                /// The returned information varies based on the commodity module.
                /// </summary>
                [NameInMap("PropertyValueList")]
                [Validation(Required=false)]
                public List<DescribeCommodityResponseBodyComponentsPropertiesPropertyValueList> PropertyValueList { get; set; }
                public class DescribeCommodityResponseBodyComponentsPropertiesPropertyValueList : TeaModel {
                    /// <summary>
                    /// The sequence number of the attribute.
                    /// 
                    /// The returned information varies based on the commodity module.
                    /// </summary>
                    [NameInMap("OrderIndex")]
                    [Validation(Required=false)]
                    public long? OrderIndex { get; set; }

                    /// <summary>
                    /// The content of the attribute.
                    /// 
                    /// The returned information varies based on the commodity module.
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// The message of the attribute.
                    /// 
                    /// The returned information varies based on the commodity module.
                    /// </summary>
                    [NameInMap("Tips")]
                    [Validation(Required=false)]
                    public string Tips { get; set; }

                    /// <summary>
                    /// The value of the attribute.
                    /// 
                    /// The returned information varies based on the commodity module.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
