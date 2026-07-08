// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SaveDataSourceOrderConfigRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2587494.html">AgentKey</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c160c841c8e54295bf2f441432785944_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The generation technology for Miaosou. This parameter is valid only when \<c>ProductCode\\</c> is set to \<c>miaosou\\</c>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>copilotPrecise</para>
        /// </description></item>
        /// <item><description><para>copilotReference</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>copilotReference</para>
        /// </summary>
        [NameInMap("GenerateTechnology")]
        [Validation(Required=false)]
        public string GenerateTechnology { get; set; }

        /// <summary>
        /// <para>The product type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>miaobi</para>
        /// </description></item>
        /// <item><description><para>miaosou</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>miaobi</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The data source configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserConfigDataSourceList")]
        [Validation(Required=false)]
        public List<SaveDataSourceOrderConfigRequestUserConfigDataSourceList> UserConfigDataSourceList { get; set; }
        public class SaveDataSourceOrderConfigRequestUserConfigDataSourceList : TeaModel {
            /// <summary>
            /// <para>Code description</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QuarkCommonNews</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the data source.</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>夸克通用搜索</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Quantity</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            /// <summary>
            /// <para>The type of the data source.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SystemSearch</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
