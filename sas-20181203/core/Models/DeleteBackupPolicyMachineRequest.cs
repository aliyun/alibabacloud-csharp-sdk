// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteBackupPolicyMachineRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the anti-ransomware policy.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeBackupPolicies~~">DescribeBackupPolicies</a> operation to query the IDs of anti-ransomware policies.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        /// <summary>
        /// <para>The version of the anti-ransomware policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1.0.0</b></description></item>
        /// <item><description><b>2.0.0</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeBackupPolicies~~">DescribeBackupPolicies</a> operation to query the versions of anti-ransomware policies.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.0</para>
        /// </summary>
        [NameInMap("PolicyVersion")]
        [Validation(Required=false)]
        public string PolicyVersion { get; set; }

        /// <summary>
        /// <para>The UUID of the server to which the anti-ransomware policy is applied.</para>
        /// <remarks>
        /// <para>You must specify at least one of the <c>UuidList</c> and <c>Uuid</c> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>083036e9-8411-4a9d-83af-9acbd****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers to which the anti-ransomware policy is applied.</para>
        /// <remarks>
        /// <para>You must specify at least one of the <c>UuidList</c> and <c>Uuid</c> parameters.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
