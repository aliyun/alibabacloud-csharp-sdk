// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpgradeBackupPolicyVersionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the anti-ransomware protection policy.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeBackupPolicies~~">DescribeBackupPolicies</a> operation to obtain this parameter.</para>
        /// </remarks>
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
