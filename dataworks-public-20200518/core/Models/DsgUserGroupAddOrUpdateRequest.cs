// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgUserGroupAddOrUpdateRequest : TeaModel {
        /// <summary>
        /// <para>The user group information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserGroups")]
        [Validation(Required=false)]
        public List<DsgUserGroupAddOrUpdateRequestUserGroups> UserGroups { get; set; }
        public class DsgUserGroupAddOrUpdateRequestUserGroups : TeaModel {
            /// <summary>
            /// <para>The list of users in the user group.</para>
            /// <list type="bullet">
            /// <item><description>For user groups created based on Alibaba Cloud accounts and RAM roles, you can call the <a href="https://help.aliyun.com/document_detail/2786445.html">DsgUserGroupQueryUserList</a> operation to query the user list.</description></item>
            /// <item><description>For user groups created based on MaxCompute roles, you can call the <a href="https://help.aliyun.com/document_detail/2785695.html">DsgUserGroupGetOdpsRoleGroups</a> operation to query the user list.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Accounts")]
            [Validation(Required=false)]
            public List<string> Accounts { get; set; }

            /// <summary>
            /// <para>The ID of the user group.</para>
            /// <list type="bullet">
            /// <item><description>If you do not specify this parameter, a user group is created.</description></item>
            /// <item><description>If you specify this parameter, the specified user group is modified. You can call the <a href="https://help.aliyun.com/document_detail/2786441.html">DsgUserGroupQueryList</a> operation to query the user group ID.</description></item>
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
            /// <para>The name of the MaxCompute project. This parameter is required when you create a MaxCompute user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev_project</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The type of the user group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Alibaba Cloud user.</description></item>
            /// <item><description>2: RAM role.</description></item>
            /// <item><description>3: MaxCompute role.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserGroupType")]
            [Validation(Required=false)]
            public int? UserGroupType { get; set; }

            /// <summary>
            /// <para>The list of projects associated with the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[
            ///   { &quot;projectName&quot;: &quot;demo_project_a&quot;, &quot;accounts&quot;: &quot;role_read,role_write&quot; },
            ///   { &quot;projectName&quot;: &quot;demo_project_b&quot;, &quot;accounts&quot;: &quot;role_analyst&quot; }
            /// ]</para>
            /// </summary>
            [NameInMap("projects")]
            [Validation(Required=false)]
            public string Projects { get; set; }

        }

    }

}
