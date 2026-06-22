// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupMachineStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the anti-ransomware backup policy.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeBackupPolicies~~">DescribeBackupPolicies</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        /// <summary>
        /// <para>The version of the protection policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1.0.0</b>: The version of the protection policy is 1.0.0.</description></item>
        /// <item><description><b>2.0.0</b>: The version of the protection policy is 2.0.0.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.0</para>
        /// </summary>
        [NameInMap("PolicyVersion")]
        [Validation(Required=false)]
        public string PolicyVersion { get; set; }

        /// <summary>
        /// <para>The UUID of the server to query.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeBackupPolicy~~">DescribeBackupPolicy</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eb2c782e-64f2-4590-a86c-d90164df****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
