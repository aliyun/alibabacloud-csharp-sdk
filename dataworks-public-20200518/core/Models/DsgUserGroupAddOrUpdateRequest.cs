// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgUserGroupAddOrUpdateRequest : TeaModel {
        /// <summary>
        /// <para>The information about the user group.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserGroups")]
        [Validation(Required=false)]
        public List<DsgUserGroupAddOrUpdateRequestUserGroups> UserGroups { get; set; }
        public class DsgUserGroupAddOrUpdateRequestUserGroups : TeaModel {
            /// <summary>
            /// <para>The users in the group.</para>
            /// <list type="bullet">
            /// <item><description>If a user group is created by using an Alibaba Cloud account and a RAM role, you can call the <a href="https://help.aliyun.com/document_detail/2786445.html">DsgUserGroupQueryUserList</a> operation to query the users in the group.</description></item>
            /// <item><description>If a user group is created by using a MaxCompute role, you can call the <a href="https://help.aliyun.com/document_detail/2785695.html">DsgUserGroupQueryUserList</a> operation to query the users in the group.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Accounts")]
            [Validation(Required=false)]
            public List<string> Accounts { get; set; }

            /// <summary>
            /// <para>The user group ID.</para>
            /// <list type="bullet">
            /// <item><description>If you do not configure this parameter, the current operation is to add a user group.</description></item>
            /// <item><description>If you configure this parameter, the current operation is to modify a user group. You can call the <a href="https://help.aliyun.com/document_detail/2786441.html">DsgUserGroupQueryList</a> operation to query the user group ID.</description></item>
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
            /// <para>The name of the MaxCompute project. You must configure this parameter when you create a MaxCompute user group.</para>
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
            /// <item><description>1: Alibaba Cloud account</description></item>
            /// <item><description>2: RAM role</description></item>
            /// <item><description>3: MaxCompute role</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserGroupType")]
            [Validation(Required=false)]
            public int? UserGroupType { get; set; }

        }

    }

}
