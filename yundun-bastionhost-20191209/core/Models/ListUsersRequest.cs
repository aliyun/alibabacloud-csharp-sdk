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
        /// <para>testuser</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The instance ID of the bastion host for which you want to query the user list.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain this parameter.</para>
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
        /// <para>The page number of the current page in a paging query. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in a paging query.<br>The maximum value of the PageSize parameter is 100. The default number of entries per page is 20. If PageSize is left empty, 20 entries are returned by default.</para>
        /// <remarks>
        /// <para>Do not leave PageSize empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host for which you want to query the user list.</para>
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
        /// <para>The source of the user that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Local</b>: local user</description></item>
        /// <item><description><b>Ram</b>: Resource Access Management (RAM) user</description></item>
        /// <item><description><b>AD</b>: AD user</description></item>
        /// <item><description><b>LDAP</b>: LDAP user</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Local</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The unique identity of the user that you want to query. Only exact match is supported.</para>
        /// <remarks>
        /// <para>This parameter is the unique identity of the Resource Access Management (RAM) user that corresponds to the bastion host user. This parameter takes effect when the source of the newly created user is a RAM user (that is, <b>Source</b> is set to <b>Ram</b>). You can invoke the <a href="https://help.aliyun.com/document_detail/28684.html">ListUsers</a> operation of access control and obtain this parameter from the <b>UserId</b> field in the response.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>122748924538****</para>
        /// </summary>
        [NameInMap("SourceUserId")]
        [Validation(Required=false)]
        public string SourceUserId { get; set; }

        /// <summary>
        /// <para>The ID of the user group that you want to query.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/204509.html">ListUserGroups</a> operation to obtain this parameter.</para>
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
        /// <para>The status of the user that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: normal</description></item>
        /// <item><description><b>Frozen</b>: locked</description></item>
        /// <item><description><b>Expired</b>: expired</description></item>
        /// <item><description><b>RemoteDeleted</b>: user source deleted</description></item>
        /// <item><description><b>Inactive</b>: inactive due to prolonged absence of logon</description></item>
        /// <item><description><b>PasswordExpired</b>: password expired</description></item>
        /// <item><description><b>RemoteDNChanged</b>: user DN updated</description></item>
        /// <item><description><b>RemoteFrozen</b>: frozen on the RAM side</description></item>
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
