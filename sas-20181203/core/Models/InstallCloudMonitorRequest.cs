// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class InstallCloudMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The AccessKey required to install the CloudMonitor agent. You can call the <a href="https://help.aliyun.com/document_detail/114948.html">DescribeMonitoringAgentAccessKey</a> operation to obtain this parameter.</para>
        /// <remarks>
        /// <para>This parameter is required only when you install the CloudMonitor agent on a non-Alibaba Cloud server.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>usY*****R_U</para>
        /// </summary>
        [NameInMap("AgentAccessKey")]
        [Validation(Required=false)]
        public string AgentAccessKey { get; set; }

        /// <summary>
        /// <para>The AccessSecret required to install the CloudMonitor agent. You can call the <a href="https://help.aliyun.com/document_detail/114948.html">DescribeMonitoringAgentAccessKey</a> operation to obtain this parameter.</para>
        /// <remarks>
        /// <para>This parameter is required only when you install the CloudMonitor agent on a non-Alibaba Cloud server.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>UCxF2R1sIO90XlU9****</para>
        /// </summary>
        [NameInMap("AgentSecretKey")]
        [Validation(Required=false)]
        public string AgentSecretKey { get; set; }

        /// <summary>
        /// <para>The version of the CloudMonitor agent to install. You can obtain the latest CloudMonitor agent version from <a href="https://help.aliyun.com/document_detail/183431.html">Plugin overview</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.5.6</para>
        /// </summary>
        [NameInMap("ArgusVersion")]
        [Validation(Required=false)]
        public string ArgusVersion { get; set; }

        /// <summary>
        /// <para>The list of instance IDs of the servers on which you want to install the CloudMonitor agent. Separate multiple IDs with commas (,).</para>
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

        /// <summary>
        /// <para>The list of UUIDs of the servers on which you want to install the CloudMonitor agent. Separate multiple UUIDs with commas (,).</para>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
