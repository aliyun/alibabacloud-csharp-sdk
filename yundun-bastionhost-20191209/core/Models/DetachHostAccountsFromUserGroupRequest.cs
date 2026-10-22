// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DetachHostAccountsFromUserGroupRequest : TeaModel {
        /// <summary>
        /// <para>The host IDs and host account IDs that you want to remove from the user group.<br>You can specify up to 10 host IDs, and each host supports up to 10 host account IDs. You do not need to specify host account IDs. If you do not specify host account IDs, the authorized host and all authorized host accounts of the host are removed from the user group. For the specific structure of this parameter, see the Hosts parameter structure description below the request parameters list.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/200665.html">ListHosts</a> operation to query host IDs and call the <a href="https://help.aliyun.com/document_detail/204372.html">ListHostAccounts</a> operation to query host account IDs.</para>
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
        /// <para>The instance ID of the bastion host where the user group from which you want to remove authorization for hosts and host accounts resides.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query this parameter.</para>
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
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host instance where the user group from which you want to remove authorized hosts and host accounts resides.</para>
        /// <remarks>
        /// <para>For the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the user group from which you want to remove authorized hosts and host accounts.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/204509.html">ListUserGroups</a> operation to query this parameter.</para>
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
