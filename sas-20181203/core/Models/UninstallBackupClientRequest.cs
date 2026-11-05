// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UninstallBackupClientRequest : TeaModel {
        /// <summary>
        /// <para>The version of the protection policy. You can call the <a href="~~DescribeBackupPolicies~~">DescribeBackupPolicies</a> operation to query the version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1.0.0</b>: The version of the protection policy is 1.0.0.</description></item>
        /// <item><description><b>2.0.0</b>: The version of the protection policy is 2.0.0.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.0</para>
        /// </summary>
        [NameInMap("PolicyVersion")]
        [Validation(Required=false)]
        public string PolicyVersion { get; set; }

        /// <summary>
        /// <para>The UUID of the server from which you want to uninstall the anti-ransomware client.</para>
        /// <remarks>
        /// <para>UuidList.N and UUID cannot both be empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>D0D6E6E4-CB8C-4897-B852-46AEFDA0****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>The list of UUIDs of the servers from which you want to uninstall the anti-ransomware client.</para>
        /// <remarks>
        /// <para>UuidList and UUID cannot both be empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;D0D6E6E4-CB8C-4897-B852-46AEFDA0****&quot;, &quot;3bb30859-b3b5-4f28-868f-b0892c98****&quot;]</para>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
