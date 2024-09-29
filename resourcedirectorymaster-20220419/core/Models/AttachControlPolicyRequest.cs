// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class AttachControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the access control policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cp-jExXAqIYkwHN****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The ID of the object to which you want to attach the access control policy. Access control policies can be attached to the following objects:</para>
        /// <list type="bullet">
        /// <item><description>Root folder</description></item>
        /// <item><description>Subfolders of the Root folder</description></item>
        /// <item><description>Members</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fd-ZDNPiT****</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

    }

}
