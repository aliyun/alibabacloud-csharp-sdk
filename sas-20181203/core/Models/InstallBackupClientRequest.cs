// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class InstallBackupClientRequest : TeaModel {
        /// <summary>
        /// <para>The version of the anti-ransomware policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1.0.0</b></description></item>
        /// <item><description><b>2.0.0</b></description></item>
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
        /// <para>The UUID of the server on which you want to install the anti-ransomware agent.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to query the UUIDs of servers. You must specify at least one of the UuidList and Uuid parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>inet-617eddab-7df4-4a51-b217-a3f59194****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>The UUIDs of servers on which you want to install the anti-ransomware agent.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to query the UUIDs of servers.</para>
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
