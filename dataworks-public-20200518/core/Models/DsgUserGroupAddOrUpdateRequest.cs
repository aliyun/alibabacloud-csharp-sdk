// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgUserGroupAddOrUpdateRequest : TeaModel {
        /// <summary>
        /// <para>The user groups.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserGroups")]
        [Validation(Required=false)]
        public List<DsgUserGroupAddOrUpdateRequestUserGroups> UserGroups { get; set; }
        public class DsgUserGroupAddOrUpdateRequestUserGroups : TeaModel {
            /// <summary>
            /// <para>The users in the user group.</para>
            /// <list type="bullet">
            /// <item><description><para>For user groups created based on Alibaba Cloud accounts and Resource Access Management (RAM) roles, call the <a href="https://help.aliyun.com/document_detail/2786445.html">DsgUserGroupQueryUserList</a> API to query the user list.</para>
            /// </description></item>
            /// <item><description><para>For user groups created based on MaxCompute roles, call the <a href="https://help.aliyun.com/document_detail/2785695.html">DsgUserGroupGetOdpsRoleGroups</a> API to query the user list.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("Accounts")]
            [Validation(Required=false)]
            public List<string> Accounts { get; set; }

            /// <summary>
            /// <para>The ID of the user group.</para>
            /// <list type="bullet">
            /// <item><description><para>If you do not specify this parameter, a new user group is created.</para>
            /// </description></item>
            /// <item><description><para>If you specify this parameter, the specified user group is modified. You can call the <a href="https://help.aliyun.com/document_detail/2786441.html">DsgUserGroupQueryList</a> operation to query the ID of the user group.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the user group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yun_group</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The owner of the user group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The name of the MaxCompute project. Set this parameter when you create a MaxCompute user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev_project</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The type of the user group. The following values are valid:</para>
            /// <list type="bullet">
            /// <item><description><para>1: Alibaba Cloud user</para>
            /// </description></item>
            /// <item><description><para>2: RAM Role</para>
            /// </description></item>
            /// <item><description><para>3: MaxCompute Role</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserGroupType")]
            [Validation(Required=false)]
            public int? UserGroupType { get; set; }

            [NameInMap("projects")]
            [Validation(Required=false)]
            public string Projects { get; set; }

        }

    }

}
