// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class InstallUniBackupAgentRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the anti-ransomware backup policy for databases.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeUniBackupPolicies~~">DescribeUniBackupPolicies</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>Before calling this operation, call DescribeUniBackupPolicies to confirm that AgentStatus is not INSTALLING. If the status is INSTALLING, wait for the current installation to complete before calling this operation.</para>
        /// <para>Before obtaining a valid PolicyId, install the Security Center agent on the ECS instance, complete database discovery or manual registration, and then call CreateUniBackupPolicy to create a backup policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

    }

}
