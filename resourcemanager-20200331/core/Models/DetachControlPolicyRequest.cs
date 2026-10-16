// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class DetachControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the control policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cp-jExXAqIYkwHN****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The ID of the target node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Root ID: detaches the control policy from the Root resource folder.</description></item>
        /// <item><description>Resource folder ID: detaches the control policy from a resource folder.</description></item>
        /// <item><description>Member ID: detaches the control policy from a member.</description></item>
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
