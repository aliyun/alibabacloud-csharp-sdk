// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DetachHostAccountsFromUserGroupRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the host and host account on which you want to revoke permissions from the user group.</para>
        /// <para>You can specify up to 10 host IDs and up to 10 host account IDs for each host. You can specify only host IDs. In this case, the permissions on both the specified hosts and all host accounts of the hosts are revoked from the user group. For more information about this parameter, see the &quot;Description of the Hosts parameter&quot; section of this topic.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/200665.html">ListHosts</a> operation to query the ID of the host and the <a href="https://help.aliyun.com/document_detail/204372.html">ListHostAccounts</a> operation to query the ID of the host account.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ {&quot;HostId&quot;:&quot;1&quot;}, {&quot;HostId&quot;:&quot;2&quot;,&quot;HostAccountIds&quot;:[&quot;1&quot;,&quot;2&quot;,&quot;3&quot;,...]}, {&quot;HostId&quot;:&quot;3&quot;,&quot;HostAccountIds&quot;:[&quot;4&quot;,&quot;5&quot;,&quot;6&quot;]}, {&quot;HostId&quot;:&quot;4&quot;,&quot;HostAccountIds&quot;:[&quot;9&quot;,&quot;8&quot;,&quot;7&quot;]} ]</para>
        /// </summary>
        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public string Hosts { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host in which you want to revoke permissions on the specified hosts and host accounts from the user group.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the ID of the bastion host.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-st220aw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host in which you want to revoke permissions on the specified hosts and host accounts from the user group.</para>
        /// <remarks>
        /// <para> For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the user group from which you want to revoke permissions on the specified hosts and host accounts.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/204509.html">ListUserGroups</a> operation to query the ID of the user group.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>１</para>
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

    }

}
