// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class CreateNamespaceRequest : TeaModel {
        /// <summary>
        /// <para>The workspace description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用于管理客服场景的Prompt</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The workspace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>我的Prompt空间</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The scan policy.</para>
        /// <para>This parameter contains two configuration items:</para>
        /// <list type="bullet">
        /// <item><description>minBlockRiskLevel: the risk level for blocking.<list type="bullet">
        /// <item><description>high: blocks high-risk items.</description></item>
        /// <item><description>medium: blocks medium-risk and high-risk items.</description></item>
        /// <item><description>low: blocks all risk levels including high, medium, and low.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>maxSkipRatio: the max false positive rate. If the scan skip ratio exceeds this value, the scan is considered as failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;minBlockRiskLevel&quot;:&quot;medium&quot;,&quot;maxSkipRatio&quot;:0.2}</para>
        /// </summary>
        [NameInMap("ScanPolicy")]
        [Validation(Required=false)]
        public string ScanPolicy { get; set; }

        /// <summary>
        /// <para>The tags. Separate multiple tags with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customer-service,production</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
