// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class InstallMonitoringAgentRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain a maximum of 64 ASCII characters and cannot contain non-ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6868E9A1-56E6-5FD7-9684-E2963BBAFB5F</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the request. The dry run includes permission and instance status checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): sends a normal request. If the request passes the check, the name and description of the route table are modified.</description></item>
        /// <item><description><b>true</b>: sends a dry run request. Only a check is performed, and the name and description of the route table are not modified. Check items include whether required parameters are specified and the request format. If the request fails the check, the corresponding error is returned. If the request passes the check, the DryRunOperation error code is returned.</description></item>
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
        /// <item><description>true (default): forcibly installs the agent.</description></item>
        /// <item><description>false: does not forcibly install the agent.</description></item>
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
        /// <item><description><para>onlyInstallNotHasAgent: installs the latest version of the agent only on Alibaba Cloud hosts on which the CloudMonitor agent is not installed.</para>
        /// </description></item>
        /// <item><description><para>onlyUpgradeAgent: upgrades the agent only on Alibaba Cloud hosts on which a non-latest version of the CloudMonitor agent is installed.</para>
        /// </description></item>
        /// <item><description><para>installAndUpgrade: installs the latest version of the agent on Alibaba Cloud hosts on which the CloudMonitor agent is not installed, and upgrades the agent on Alibaba Cloud hosts on which a non-latest version of the CloudMonitor agent is installed.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you specify this parameter, the InstanceIds parameter is ignored.</para>
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
