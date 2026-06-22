// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the mitigation policies that you want to delete.</para>
        /// <remarks>
        /// <para>Invoke the <a href="~~DescribeBackupPolicies~~">DescribeBackupPolicies</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The version of the mitigation policies that you want to delete. You can invoke the <a href="~~DescribeBackupPolicies~~">DescribeBackupPolicies</a> operation to query this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1.0.0</b>: The mitigation policies version is 1.0.0.</description></item>
        /// <item><description><b>2.0.0</b>: The mitigation policies version is 2.0.0.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.0</para>
        /// </summary>
        [NameInMap("PolicyVersion")]
        [Validation(Required=false)]
        public string PolicyVersion { get; set; }

    }

}
