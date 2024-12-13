// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class CreateUserProvisioningRequest : TeaModel {
        /// <summary>
        /// <para>The deletion policy. The policy is used to manage synchronized users when you delete the RAM user provisioning. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Delete: When you delete the RAM user provisioning, the system deletes the synchronized users.</description></item>
        /// <item><description>Keep: When you delete the RAM user provisioning, the system retains the synchronized users.</description></item>
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
        /// <para>The ID of the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-003qew84****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The conflict handling policy. The policy is used when a RAM user has the same username as the CloudSSO user who is synchronized to RAM. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>KeepBoth: When a CloudSSO user is synchronized to RAM, if a RAM user who has the same username as the CloudSSO user exists, the system creates a RAM user whose username is the username of the CloudSSO user plus the suffix <c>_sso</c>.</description></item>
        /// <item><description>TakeOver: When a CloudSSO user is synchronized to RAM, if a RAM user who has the same username as the CloudSSO user exists, the system replaces the RAM user with the CloudSSO user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KeepBoth</para>
        /// </summary>
        [NameInMap("DuplicationStrategy")]
        [Validation(Required=false)]
        public string DuplicationStrategy { get; set; }

        /// <summary>
        /// <para>The identity ID of the RAM user provisioning. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If you set the <c>PrincipalType</c> parameter to <c>Group</c>, the value of this parameter is the ID of a CloudSSO user group (g-\<em>\</em>\<em>\</em>\<em>\</em>\<em>\</em>).</description></item>
        /// <item><description>If you set the <c>PrincipalType</c> parameter to <c>User</c>, the value of this parameter is the ID of a CloudSSO user (u-\<em>\</em>\<em>\</em>\<em>\</em>\<em>\</em>).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>g-02ha881d*****</para>
        /// </summary>
        [NameInMap("PrincipalId")]
        [Validation(Required=false)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// <para>The identity type of the RAM user provisioning. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>User: The identity of the RAM user provisioning is a CloudSSO user.</description></item>
        /// <item><description>Group: The identity of the RAM user provisioning is a CloudSSO user group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Group</para>
        /// </summary>
        [NameInMap("PrincipalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

        /// <summary>
        /// <para>The ID of the object for which you create the RAM user provisioning. The value is fixed as the ID of the member in the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1743382******</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The object for which you create the RAM user provisioning. The value is fixed as <c>RD-Account</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RD-Account</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
