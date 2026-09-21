// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUniBackupPolicyDetailRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the anti-ransomware backup policy for databases.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeUniBackupPolicies~~">DescribeUniBackupPolicies</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>If DescribeUniBackupPolicies returns an empty list, activate the anti-ransomware feature of Security Center first, make sure that the Security Center agent is installed on the ECS instance and the database has been discovered, and then call CreateUniBackupPolicy to create a backup policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
