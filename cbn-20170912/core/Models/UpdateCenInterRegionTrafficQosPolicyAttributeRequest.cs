// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class UpdateCenInterRegionTrafficQosPolicyAttributeRequest : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **UpdateCenInterRegionTrafficQosPolicyAttribute**.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("TrafficQosPolicyDescription")]
        [Validation(Required=false)]
        public string TrafficQosPolicyDescription { get; set; }

        /// <summary>
        /// The new description of the QoS policy.
        /// 
        /// The description must be 2 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The description must start with a letter.
        /// </summary>
        [NameInMap("TrafficQosPolicyId")]
        [Validation(Required=false)]
        public string TrafficQosPolicyId { get; set; }

        [NameInMap("TrafficQosPolicyName")]
        [Validation(Required=false)]
        public string TrafficQosPolicyName { get; set; }

    }

}
