// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class DeleteUserProvisioningRequest : TeaModel {
        /// <summary>
        /// <para>The deletion policy. The policy for processing synchronized RAM users when a RAM user synchronization is deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Delete: Deletes the RAM users that have been synchronized from CloudSSO to Resource Access Management (RAM) user synchronization is deleted.</description></item>
        /// <item><description>Keep: Retains the RAM users that have been synchronized from CloudSSO to Resource Access Management (RAM) user synchronization is deleted.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is left empty, the deletion policy specified when the RAM user synchronization was created is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Delete</para>
        /// </summary>
        [NameInMap("DeletionStrategy")]
        [Validation(Required=false)]
        public string DeletionStrategy { get; set; }

        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-003qew84****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

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
