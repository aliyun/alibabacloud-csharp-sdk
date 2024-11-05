// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class AttachHostAccountsToHostShareKeyRequest : TeaModel {
        /// <summary>
        /// <para>The host account IDs.</para>
        /// <remarks>
        /// <para> You must specify this parameter. You can call the <a href="https://help.aliyun.com/document_detail/462937.html">ListHostAccounts</a> operation to query the host account IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1&quot;,&quot;2&quot;,&quot;3&quot;]</para>
        /// </summary>
        [NameInMap("HostAccountIds")]
        [Validation(Required=false)]
        public string HostAccountIds { get; set; }

        /// <summary>
        /// <para>The shared key ID.</para>
        /// <remarks>
        /// <para> You must specify this parameter. You can call the <a href="https://help.aliyun.com/document_detail/462973.html">ListHostShareKeys</a> operation to query the shared key ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10267</para>
        /// </summary>
        [NameInMap("HostShareKeyId")]
        [Validation(Required=false)]
        public string HostShareKeyId { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host. You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the ID of the bastion host.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-st220aw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host. For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
