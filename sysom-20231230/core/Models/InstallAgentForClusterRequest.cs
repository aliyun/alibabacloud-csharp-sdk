// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class InstallAgentForClusterRequest : TeaModel {
        [NameInMap("X-Debug-Id")]
        [Validation(Required=false)]
        public string XDebugId { get; set; }

        /// <summary>
        /// <para>The component ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74a86327-3170-412c-8e67-da3389ec56a9</para>
        /// </summary>
        [NameInMap("agent_id")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The component version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.4.0-1</para>
        /// </summary>
        [NameInMap("agent_version")]
        [Validation(Required=false)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>Pass the ID of the ACK cluster for this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c9d7f3fc3d42942afbcb65c1100ffb19d</para>
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The component configuration ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8gj86wrt7-3170-412c-8e67-da3389ecg6a9</para>
        /// </summary>
        [NameInMap("config_id")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>The canary release environment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;numeric&quot;,&quot;config&quot;:{&quot;value&quot;:2}}</para>
        /// </summary>
        [NameInMap("grayscale_config")]
        [Validation(Required=false)]
        public string GrayscaleConfig { get; set; }

        [NameInMap("x-sysom-invoke-source")]
        [Validation(Required=false)]
        public string XSysomInvokeSource { get; set; }

    }

}
