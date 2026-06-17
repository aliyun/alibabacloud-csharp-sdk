// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class InstallMonitoringAgentRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to forcibly install the CloudMonitor agent. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true (default): Forcibly installs the agent.</para>
        /// </description></item>
        /// <item><description><para>false: Does not forcibly install the agent.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The installation command. This command installs the CloudMonitor agent on all Alibaba Cloud hosts that belong to your Alibaba Cloud account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>onlyInstallNotHasAgent</c>: Installs the latest version of the CloudMonitor agent only on Alibaba Cloud hosts where the agent is not installed.</para>
        /// </description></item>
        /// <item><description><para><c>onlyUpgradeAgent</c>: Upgrades the CloudMonitor agent only on Alibaba Cloud hosts where an earlier version of the agent is installed.</para>
        /// </description></item>
        /// <item><description><para><c>installAndUpgrade</c>: Installs the latest version of the CloudMonitor agent on Alibaba Cloud hosts where the agent is not installed, and upgrades the agent on Alibaba Cloud hosts where an earlier version of the agent is installed.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set this parameter, the <c>InstanceIds</c> parameter is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>onlyInstallNotHasAgent</para>
        /// </summary>
        [NameInMap("InstallCommand")]
        [Validation(Required=false)]
        public string InstallCommand { get; set; }

        /// <summary>
        /// <para>The IDs of the Alibaba Cloud hosts.</para>
        /// <para>You can specify from 1 to 10 instance IDs.</para>
        /// <remarks>
        /// <para>You must specify either <c>InstallCommand</c> or <c>InstanceIds</c>.</para>
        /// </remarks>
        /// 
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
