// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class InstallCloudMonitorRequest : TeaModel {
        /// <summary>
        /// The AccessKey ID that is required to install the CloudMonitor agent. You can call the [DescribeMonitoringAgentAccessKey](~~114948~~) operation to query the AccessKey ID.
        /// 
        /// > This parameter is required only when you install the CloudMonitor agent on servers that are not deployed on Alibaba Cloud.
        /// </summary>
        [NameInMap("AgentAccessKey")]
        [Validation(Required=false)]
        public string AgentAccessKey { get; set; }

        /// <summary>
        /// The AccessKey secret that is required to install the CloudMonitor agent. You can call the [DescribeMonitoringAgentAccessKey](~~114948~~) operation to query the AccessKey secret.
        /// 
        /// > This parameter is required only when you install the CloudMonitor agent on servers that are not deployed on Alibaba Cloud.
        /// </summary>
        [NameInMap("AgentSecretKey")]
        [Validation(Required=false)]
        public string AgentSecretKey { get; set; }

        /// <summary>
        /// The version of the CloudMonitor agent that you want to install on the servers. For more information about the latest version of the CloudMonitor agent, see [Overview](~~183431~~).
        /// </summary>
        [NameInMap("ArgusVersion")]
        [Validation(Required=false)]
        public string ArgusVersion { get; set; }

        /// <summary>
        /// The IDs of the servers on which you want to install the CloudMonitor agent. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

        /// <summary>
        /// The UUIDs of the servers on which you want to install the CloudMonitor agent. Separate multiple UUIDs with commas (,).
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
