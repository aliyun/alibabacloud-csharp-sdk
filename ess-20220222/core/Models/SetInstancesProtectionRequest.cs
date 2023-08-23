// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class SetInstancesProtectionRequest : TeaModel {
        /// <summary>
        /// The IDs of the ECS instances.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Specifies whether to put ECS instances into the Protected state. Auto Scaling does not remove ECS instances in the Protected state from scaling groups during scale-in activities.
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("ProtectedFromScaleIn")]
        [Validation(Required=false)]
        public bool? ProtectedFromScaleIn { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The ID of the scaling group.
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
