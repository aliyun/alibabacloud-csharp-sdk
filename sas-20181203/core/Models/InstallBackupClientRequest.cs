// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class InstallBackupClientRequest : TeaModel {
        /// <summary>
        /// <para>The version of the mitigation policies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1.0.0</b>: The version of the mitigation policies is 1.0.0.</description></item>
        /// <item><description><b>2.0.0</b>: The version of the mitigation policies is 2.0.0.</description></item>
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
        /// <para>The UUID of the server on which you want to install the anti-ransomware client.</para>
        /// <remarks>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to obtain this value. UuidList and Uuid cannot both be empty.</para>
        /// </remarks>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>inet-617eddab-7df4-4a51-b217-a3f59194****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>The list of UUIDs of the servers that you want to protect.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;3bb30859-b3b5-4f28-868f-b0892c98****&quot;, &quot;3bb30859-b3b5-4f28-868f-b0892c98****&quot;]</para>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
