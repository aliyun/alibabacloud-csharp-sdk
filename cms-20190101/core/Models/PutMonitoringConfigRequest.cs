// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutMonitoringConfigRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is not used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoInstall")]
        [Validation(Required=false)]
        public bool? AutoInstall { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate the token on your client to ensure that the token is unique across different requests. The client token supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6868E9A1-56E6-5FD7-9684-E2963BBAFB5F</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: sends a check request without deleting the endpoint IPAM pool. The check items include whether required parameters are specified, the request format, and service limits. If the request fails the check, an error is returned. If the request passes the check, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default value): sends a normal request and directly deletes the endpoint IPAM pool if the request passes the check.
        /// Default value: <b>false</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically install the CloudMonitor agent on newly purchased ECS instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Automatically installs the CloudMonitor agent on newly purchased ECS instances.</description></item>
        /// <item><description>false: Does not automatically install the CloudMonitor agent on newly purchased ECS instances.
        /// Default value: true.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableInstallAgentNewECS")]
        [Validation(Required=false)]
        public bool? EnableInstallAgentNewECS { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
