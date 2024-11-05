// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListUsersRequest : TeaModel {
        /// <summary>
        /// <para>The display name of the user that you want to query. Only exact match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host whose users you want to query.</para>
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
        /// <para>The mobile phone number of the user that you want to query. Only exact match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1359999****</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
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
        /// <para>The region ID of the bastion host whose users you want to query.</para>
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
        /// <para>The type of the user that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Local</b>: a local user.</description></item>
        /// <item><description><b>Ram</b>: a Resource Access Management (RAM) user.</description></item>
        /// <item><description><b>AD</b>: an Active Directory (AD)-authenticated user.</description></item>
        /// <item><description><b>LDAP</b>: a Lightweight Directory Access Protocol (LDAP)-authenticated user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Local</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The unique ID of the user that you want to query. Only exact match is supported.</para>
        /// <remarks>
        /// <para> This parameter uniquely identifies a RAM user of the bastion host. This parameter is valid if <b>Source</b> is set to <b>Ram</b>. You can call the <a href="https://help.aliyun.com/document_detail/28684.html">ListUsers</a> operation in RAM to obtain the unique ID of the user from the <b>UserId</b> response parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>122748924538****</para>
        /// </summary>
        [NameInMap("SourceUserId")]
        [Validation(Required=false)]
        public string SourceUserId { get; set; }

        /// <summary>
        /// <para>The ID of the user group to which the user you want to query belongs.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/204509.html">ListUserGroups</a> operation to query the user group ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

        /// <summary>
        /// <para>The logon name of the user that you want to query. Only exact match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The state of the user that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: The user is in normal state.</description></item>
        /// <item><description><b>Frozen</b>: The user is locked.</description></item>
        /// <item><description><b>Expired</b>: The user has expired.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("UserState")]
        [Validation(Required=false)]
        public string UserState { get; set; }

    }

}
