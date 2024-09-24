// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteUniBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the anti-ransomware policy.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeUniBackupPolicies~~">DescribeUniBackupPolicies</a> operation to query the IDs of anti-ransomware policies. You must specify at least one of the PolicyId parameter and the <b>PolicyIds</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        /// <summary>
        /// <para>The IDs of anti-ransomware policies.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeUniBackupPolicies~~">DescribeUniBackupPolicies</a> operation to query the IDs of anti-ransomware policies. You must specify at least one of the <b>PolicyId</b> parameter and the PolicyIds parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123,124</para>
        /// </summary>
        [NameInMap("PolicyIds")]
        [Validation(Required=false)]
        public string PolicyIds { get; set; }

    }

}
