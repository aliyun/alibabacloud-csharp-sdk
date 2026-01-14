// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeCommodityResponseBody : TeaModel {
        /// <summary>
        /// <para>The commodity code.</para>
        /// <para>Examples for the China site (aliyun.com):</para>
        /// <list type="bullet">
        /// <item><description><b>ga_gapluspre_public_cn</b>: GA instance.</description></item>
        /// <item><description><b>ga_plusbwppre_public_cn</b>: basic bandwidth plan.</description></item>
        /// </list>
        /// <para>Examples for the international site (alibabacloud.com):</para>
        /// <list type="bullet">
        /// <item><description><b>ga_pluspre_public_intl</b>: GA instance.</description></item>
        /// <item><description><b>ga_bwppreintl_public_intl</b>: basic bandwidth plan.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ga_gapluspre_public_cn</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The name of the commodity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Global Accelerator_Instance Type (Subscription)</para>
        /// </summary>
        [NameInMap("CommodityName")]
        [Validation(Required=false)]
        public string CommodityName { get; set; }

        /// <summary>
        /// <para>The information about the commodity modules.</para>
        /// <para>The returned information varies based on the commodity.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<DescribeCommodityResponseBodyComponents> Components { get; set; }
        public class DescribeCommodityResponseBodyComponents : TeaModel {
            /// <summary>
            /// <para>The code of the commodity module.</para>
            /// <para>The returned information varies based on the commodity module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Duration</para>
            /// </summary>
            [NameInMap("ComponentCode")]
            [Validation(Required=false)]
            public string ComponentCode { get; set; }

            /// <summary>
            /// <para>The name of the commodity module.</para>
            /// <para>The returned information varies based on the commodity module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Duration</para>
            /// </summary>
            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// <para>The attributes of the commodity module.</para>
            /// <para>The returned information varies based on the commodity module.</para>
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public List<DescribeCommodityResponseBodyComponentsProperties> Properties { get; set; }
            public class DescribeCommodityResponseBodyComponentsProperties : TeaModel {
                /// <summary>
                /// <para>The code of the attribute.</para>
                /// <para>The returned information varies based on the commodity module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ord_time</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The name of the attribute.</para>
                /// <para>The returned information varies based on the commodity module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Duration</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The list of attribute values of the commodity module.</para>
                /// <para>The returned information varies based on the commodity module.</para>
                /// </summary>
                [NameInMap("PropertyValueList")]
                [Validation(Required=false)]
                public List<DescribeCommodityResponseBodyComponentsPropertiesPropertyValueList> PropertyValueList { get; set; }
                public class DescribeCommodityResponseBodyComponentsPropertiesPropertyValueList : TeaModel {
                    /// <summary>
                    /// <para>The sequence number of the attribute.</para>
                    /// <para>The returned information varies based on the commodity module.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("OrderIndex")]
                    [Validation(Required=false)]
                    public long? OrderIndex { get; set; }

                    /// <summary>
                    /// <para>The content of the attribute.</para>
                    /// <para>The returned information varies based on the commodity module.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1 Month</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <para>The message of the attribute.</para>
                    /// <para>The returned information varies based on the commodity module.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1 Month</para>
                    /// </summary>
                    [NameInMap("Tips")]
                    [Validation(Required=false)]
                    public string Tips { get; set; }

                    /// <summary>
                    /// <para>The value of the attribute.</para>
                    /// <para>The returned information varies based on the commodity module.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1:Month</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
