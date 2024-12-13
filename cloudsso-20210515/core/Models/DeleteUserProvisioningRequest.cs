// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class DeleteUserProvisioningRequest : TeaModel {
        /// <summary>
        /// <para>The deletion policy. The policy is used to manage synchronized users when you delete the RAM user provisioning. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Delete: When you delete the RAM user provisioning, the system deletes the synchronized users.</description></item>
        /// <item><description>Keep: When you delete the RAM user provisioning, the system retains the synchronized users.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify this parameter, the deletion policy that is configured when you create the RAM user provisioning is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Delete</para>
        /// </summary>
        [NameInMap("DeletionStrategy")]
        [Validation(Required=false)]
        public string DeletionStrategy { get; set; }

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
        /// <para>The ID of the RAM user provisioning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>up-002axzhapcbz6e63****</para>
        /// </summary>
        [NameInMap("UserProvisioningId")]
        [Validation(Required=false)]
        public string UserProvisioningId { get; set; }

    }

}
