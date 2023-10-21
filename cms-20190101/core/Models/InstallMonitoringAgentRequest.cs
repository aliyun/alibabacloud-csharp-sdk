// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class InstallMonitoringAgentRequest : TeaModel {
        /// <summary>
        /// Specifies whether to install the CloudMonitor agent. Valid values:
        /// 
        /// *   true (default value): yes
        /// *   false: no
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// Specifies whether to install the CloudMonitor agent on all ECS instances that belong to the current Alibaba Cloud account. Valid values:
        /// 
        /// *   `onlyInstallNotHasAgent`: installs the latest version of the CloudMonitor agent only on ECS instances on which the agent is not installed.
        /// *   `onlyUpgradeAgent`: upgrades the CloudMonitor agent to the latest version only for ECS instances on which an earlier version of the agent is installed.
        /// *   `installAndUpgrade`: installs the latest version of the CloudMonitor agent on ECS instances on which the agent is not installed, and upgrades the CloudMonitor agent to the latest version for ECS instances on which an earlier version of the agent is installed.
        /// 
        /// >  If you set the InstallCommand parameter, the `InstanceIds` parameter does not take effect.
        /// </summary>
        [NameInMap("InstallCommand")]
        [Validation(Required=false)]
        public string InstallCommand { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
