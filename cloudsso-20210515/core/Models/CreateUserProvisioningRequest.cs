// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class CreateUserProvisioningRequest : TeaModel {
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
        /// <para>The ID of the destination for the Resource Access Management (RAM) user synchronization. Currently, the value is the ID of the account in a resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1743382******</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The type of the destination for the Resource Access Management (RAM) user synchronization. Currently, the value is <c>RD-Account</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RD-Account</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
