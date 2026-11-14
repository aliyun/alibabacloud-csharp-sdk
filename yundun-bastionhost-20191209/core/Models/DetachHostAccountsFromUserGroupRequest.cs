// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DetachHostAccountsFromUserGroupRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the IDs of the hosts and host accounts whose authorization you want to remove from the user group.<br>You can specify up to 10 host IDs, and up to 10 host account IDs for each host. You can leave the host account IDs empty. If you do not specify host account IDs, the host and all its authorized host accounts are removed from the user group. For more information about the structure of this parameter, see the Hosts parameter structure description in the request parameters section.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/200665.html">ListHosts</a> operation to obtain host IDs and call the <a href="https://help.aliyun.com/document_detail/204372.html">ListHostAccounts</a> operation to obtain host account IDs.</para>
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
        /// <para>Specifies the instance ID of the Bastionhost instance that manages the user group for which you want to remove the authorization of hosts and host accounts.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain the value of this parameter.</para>
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
        /// <para>Specifies the region ID of the Bastionhost instance that manages the user group from which you want to remove authorized hosts and host accounts.</para>
        /// <remarks>
        /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies the ID of the user group from which you want to remove authorized hosts and host accounts.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/204509.html">ListUserGroups</a> operation to obtain the value of this parameter.</para>
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
