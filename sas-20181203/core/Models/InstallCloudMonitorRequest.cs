// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class InstallCloudMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The AccessKey ID that is required to install the CloudMonitor agent. You can call the <a href="https://help.aliyun.com/document_detail/114948.html">DescribeMonitoringAgentAccessKey</a> operation to query the AccessKey ID.</para>
        /// <remarks>
        /// <para>This parameter is required only when you install the CloudMonitor agent on servers that are not deployed on Alibaba Cloud.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>usY*****R_U</para>
        /// </summary>
        [NameInMap("AgentAccessKey")]
        [Validation(Required=false)]
        public string AgentAccessKey { get; set; }

        /// <summary>
        /// <para>The AccessKey secret that is required to install the CloudMonitor agent. You can call the <a href="https://help.aliyun.com/document_detail/114948.html">DescribeMonitoringAgentAccessKey</a> operation to query the AccessKey secret.</para>
        /// <remarks>
        /// <para>This parameter is required only when you install the CloudMonitor agent on servers that are not deployed on Alibaba Cloud.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>UCxF2R1sIO90XlU9****</para>
        /// </summary>
        [NameInMap("AgentSecretKey")]
        [Validation(Required=false)]
        public string AgentSecretKey { get; set; }

        /// <summary>
        /// <para>The version of the CloudMonitor agent that you want to install on the servers. For more information about the latest version of the CloudMonitor agent, see <a href="https://help.aliyun.com/document_detail/183431.html">Overview</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.5.6</para>
        /// </summary>
        [NameInMap("ArgusVersion")]
        [Validation(Required=false)]
        public string ArgusVersion { get; set; }

        /// <summary>
        /// <para>The IDs of the servers on which you want to install the CloudMonitor agent. Separate multiple IDs with commas (,).</para>
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers on which you want to install the CloudMonitor agent. Separate multiple UUIDs with commas (,).</para>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
