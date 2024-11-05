// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostGroupsForUserRequest : TeaModel {
        /// <summary>
        /// <para>The name of the host group to query. The name can be up to 128 characters in length. Only exact match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group</para>
        /// </summary>
        [NameInMap("HostGroupName")]
        [Validation(Required=false)]
        public string HostGroupName { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host whose user you want to query.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the bastion host ID.</para>
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
        /// <para>The category of the host groups to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Authorized</b> (default): queries the host groups that the user is authorized to manage.</description></item>
        /// <item><description><b>Unauthorized</b>: queries the host groups that the user is not authorized to manage.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Authorized</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>１</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.\
        /// Valid values: 1 to 100. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.</para>
        /// <remarks>
        /// <para> We recommend that you do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host whose user you want to query.</para>
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
        /// <para>The user ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/204522.html">ListUsers</a> operation to query the user ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>１</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
