// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class InstallCloudMonitorRequest : TeaModel {
        /// <summary>
        /// 非阿里云主机安装云监控插件时所需要的AccessKey
        /// </summary>
        [NameInMap("AgentAccessKey")]
        [Validation(Required=false)]
        public string AgentAccessKey { get; set; }

        /// <summary>
        /// 非阿里云主机安装云监控插件时所需要的AccessSecret
        /// </summary>
        [NameInMap("AgentSecretKey")]
        [Validation(Required=false)]
        public string AgentSecretKey { get; set; }

        /// <summary>
        /// 云监控版本
        /// </summary>
        [NameInMap("ArgusVersion")]
        [Validation(Required=false)]
        public string ArgusVersion { get; set; }

        /// <summary>
        /// 实例 instanceId
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

        /// <summary>
        /// uuid 列表
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
