// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class CheckAgentConfigSupportedRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the component to update. You can obtain the component ID from the ListAgents operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74a86327-3170-412c-8e67-da3389ec56a9</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The configuration dimension to check, such as cluster or node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("checkType")]
        [Validation(Required=false)]
        public string CheckType { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c726e7497b7d246d09d8644ed62effacc</para>
        /// </summary>
        [NameInMap("clusters")]
        [Validation(Required=false)]
        public string Clusters { get; set; }

        /// <summary>
        /// <para>The ID of the component configuration to install.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4d5ecf02-3d01-11f0-8c90-00163e1029a</para>
        /// </summary>
        [NameInMap("configId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>The configuration content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;code\&quot;: \&quot;BABA\&quot;, \&quot;changeRate\&quot;: \&quot;-1.434%\&quot;, \&quot;exchange\&quot;: \&quot;NYSE\&quot;, \&quot;price\&quot;: \&quot;112.690\&quot;, \&quot;changePrice\&quot;: \&quot;-$1.640\&quot;, \&quot;currency\&quot;: \&quot;USD\&quot;, \&quot;date\&quot;: \&quot;2026-06-11T20:01 EDT\&quot;}</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The list of instances. Separate multiple instance IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp10ktsji8vsbd8gco5i,i-bp1163pp7k7njfggvuqp,i-bp12ytprghv6rwzfgypm</para>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public string Instances { get; set; }

    }

}
