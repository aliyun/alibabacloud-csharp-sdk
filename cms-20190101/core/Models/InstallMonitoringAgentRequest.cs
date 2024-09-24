// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class InstallMonitoringAgentRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to install the CloudMonitor agent. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default value): yes</description></item>
        /// <item><description>false: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>Specifies whether to install the CloudMonitor agent on all ECS instances that belong to the current Alibaba Cloud account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>onlyInstallNotHasAgent</c>: installs the latest version of the CloudMonitor agent only on ECS instances on which the agent is not installed.</description></item>
        /// <item><description><c>onlyUpgradeAgent</c>: upgrades the CloudMonitor agent to the latest version only for ECS instances on which an earlier version of the agent is installed.</description></item>
        /// <item><description><c>installAndUpgrade</c>: installs the latest version of the CloudMonitor agent on ECS instances on which the agent is not installed, and upgrades the CloudMonitor agent to the latest version for ECS instances on which an earlier version of the agent is installed.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set the InstallCommand parameter, the <c>InstanceIds</c> parameter does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>onlyInstallNotHasAgent</para>
        /// </summary>
        [NameInMap("InstallCommand")]
        [Validation(Required=false)]
        public string InstallCommand { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>i-m5e0k0bexac8tykr****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
