// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class CreateUserProvisioningResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F6F90F3D-4502-5877-B80B-97476F6AE2CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Resource Access Management (RAM) user synchronization information.</para>
        /// </summary>
        [NameInMap("UserProvisioning")]
        [Validation(Required=false)]
        public CreateUserProvisioningResponseBodyUserProvisioning UserProvisioning { get; set; }
        public class CreateUserProvisioningResponseBodyUserProvisioning : TeaModel {
            /// <summary>
            /// <para>The creation time. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-28T03:55:42Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The deletion policy. This policy specifies how to handle the synchronized Resource Access Management (RAM) users when the Resource Access Management (RAM) user synchronization is deleted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Delete: Delete. When the Resource Access Management (RAM) user synchronization is deleted, the Resource Access Management (RAM) users that have been synchronized from CloudSSO to RAM are deleted.</description></item>
            /// <item><description>Keep: Keep. When the Resource Access Management (RAM) user synchronization is deleted, the Resource Access Management (RAM) users that have been synchronized from CloudSSO to RAM are retained.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Delete</para>
            /// </summary>
            [NameInMap("DeletionStrategy")]
            [Validation(Required=false)]
            public string DeletionStrategy { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a user provisioning.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the CloudSSO directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-003qew84****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The conflict resolution policy. This policy specifies how to handle conflicts when a CloudSSO user is synchronized to Resource Access Management (RAM) user with the same name already exists. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>KeepBoth: Keep both. When a CloudSSO user is synchronized to Resource Access Management (RAM) user with the same name already exists, the system appends the _sso suffix to the username of the CloudSSO user and attempts to create a RAM user with the new username.</description></item>
            /// <item><description>TakeOver: Take over. When a CloudSSO user is synchronized to Resource Access Management (RAM) user with the same name already exists, the system directly replaces the existing RAM user with the synchronized CloudSSO user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>KeepBoth</para>
            /// </summary>
            [NameInMap("DuplicationStrategy")]
            [Validation(Required=false)]
            public string DuplicationStrategy { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the CloudSSO directory belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639738******</para>
            /// </summary>
            [NameInMap("OwnerPk")]
            [Validation(Required=false)]
            public string OwnerPk { get; set; }

            /// <summary>
            /// <para>The ID of the identity for the Resource Access Management (RAM) user synchronization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If <c>PrincipalType</c> is set to <c>Group</c>, the value is the ID of the CloudSSO group (g-********).</description></item>
            /// <item><description>If <c>PrincipalType</c> is set to <c>User</c>, the value is the ID of the CloudSSO user (u-********).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>g-02ha881d*****</para>
            /// </summary>
            [NameInMap("PrincipalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            /// <summary>
            /// <para>The name of the identity for the Resource Access Management (RAM) user synchronization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If <c>PrincipalType</c> is set to <c>Group</c>, the value is the name of the CloudSSO group.</description></item>
            /// <item><description>If <c>PrincipalType</c> is set to <c>User</c>, the value is the CloudSSO username.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>testGroupName</para>
            /// </summary>
            [NameInMap("PrincipalName")]
            [Validation(Required=false)]
            public string PrincipalName { get; set; }

            /// <summary>
            /// <para>The type of the Resource Access Management (RAM) user synchronization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>User: The Resource Access Management (RAM) user synchronization is a CloudSSO user.</description></item>
            /// <item><description>Group: The Resource Access Management (RAM) user synchronization is a CloudSSO group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Group</para>
            /// </summary>
            [NameInMap("PrincipalType")]
            [Validation(Required=false)]
            public string PrincipalType { get; set; }

            /// <summary>
            /// <para>The status of the Resource Access Management (RAM) user synchronization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled: The Resource Access Management (RAM) user synchronization is enabled.</description></item>
            /// <item><description>Disabled: The Resource Access Management (RAM) user synchronization is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the destination for the Resource Access Management (RAM) user synchronization. Currently, the value is the ID of the account in a resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1743382******</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The name of the destination for the Resource Access Management (RAM) user synchronization. Currently, the value is the name of the account in a resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testTargetName</para>
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// <para>The path of the destination account in a resource directory for the Resource Access Management (RAM) user synchronization.</para>
            /// </summary>
            [NameInMap("TargetPath")]
            [Validation(Required=false)]
            public string TargetPath { get; set; }

            /// <summary>
            /// <para>The type of the destination for the Resource Access Management (RAM) user synchronization. Currently, the value is <c>RD-Account</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RD-Account</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The update time. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-28T03:55:42Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the Resource Access Management (RAM) user synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>up-002axzhapcbz6e63****</para>
            /// </summary>
            [NameInMap("UserProvisioningId")]
            [Validation(Required=false)]
            public string UserProvisioningId { get; set; }

        }

    }

}
