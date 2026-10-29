// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class InstallMonitoringAgentRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a dry run on the request. The dry run includes checks on permissions and instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): Sends a normal request. After the request passes the check, the name and description of the route table are directly modified.</description></item>
        /// <item><description><b>true</b>: Sends a dry run request. Only checks are performed, and the name and description of the route table are not modified. Check items include whether required parameters are specified and the request format. If the check fails, an error is returned. If the check succeeds, the DryRunOperation error code is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly install the CloudMonitor agent. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): Forcibly installs the agent.</description></item>
        /// <item><description>false: Does not forcibly install the agent.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>Installs the CloudMonitor agent on all Alibaba Cloud hosts within the current Alibaba Cloud account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>onlyInstallNotHasAgent: Installs the latest version of the agent only on Alibaba Cloud hosts on which the CloudMonitor agent is not installed.</para>
        /// </description></item>
        /// <item><description><para>onlyUpgradeAgent: Upgrades the agent only on Alibaba Cloud hosts on which a non-latest version of the CloudMonitor agent is installed.</para>
        /// </description></item>
        /// <item><description><para>installAndUpgrade: Installs the latest version of the agent on Alibaba Cloud hosts on which the CloudMonitor agent is not installed, and upgrades the agent on Alibaba Cloud hosts on which a non-latest version of the CloudMonitor agent is installed.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you specify this parameter, the InstanceIds parameter becomes invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>onlyInstallNotHasAgent</para>
        /// </summary>
        [NameInMap("InstallCommand")]
        [Validation(Required=false)]
        public string InstallCommand { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud host.</para>
        /// <para>Valid values of N: 1 to 10.</para>
        /// <remarks>
        /// <para>You must specify either InstallCommand or InstanceIds.</para>
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
