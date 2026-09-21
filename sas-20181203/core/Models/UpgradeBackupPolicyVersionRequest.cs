// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpgradeBackupPolicyVersionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the anti-ransomware mitigation policies.</para>
        /// <remarks>
        /// <para>You can invoke <a href="~~DescribeBackupPolicies~~">DescribeBackupPolicies</a> to obtain this parameter.</para>
        /// </remarks>
        /// <para>Only policy IDs with PolicyVersion set to 1.0.0 and UpgradeStatus set to NotUpgraded are supported. Otherwise, the API returns an InvalidParam fault.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
