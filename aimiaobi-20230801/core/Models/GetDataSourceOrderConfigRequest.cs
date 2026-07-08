// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetDataSourceOrderConfigRequest : TeaModel {
        /// <summary>
        /// <para>Unique identifier for the workspace: <a href="https://help.aliyun.com/document_detail/2587494.html">AgentKey</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d9a1f6146a37446495d9985c2e7b267e_p_outbound_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>When productCode=miaosou, this corresponds to Miaosou: generation technology. Possible values:</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>copilotPrecise</para>
        /// </description></item>
        /// <item><description><para>copilotReference</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>copilotPrecise</para>
        /// </summary>
        [NameInMap("GenerateTechnology")]
        [Validation(Required=false)]
        public string GenerateTechnology { get; set; }

        /// <summary>
        /// <para>Configuration type. Possible values:</para>
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

    }

}
