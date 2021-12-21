// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class UpdateTrafficMarkingPolicyAttributeRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

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

        [NameInMap("TrafficMarkingPolicyDescription")]
        [Validation(Required=false)]
        public string TrafficMarkingPolicyDescription { get; set; }

        [NameInMap("TrafficMarkingPolicyId")]
        [Validation(Required=false)]
        public string TrafficMarkingPolicyId { get; set; }

        [NameInMap("TrafficMarkingPolicyName")]
        [Validation(Required=false)]
        public string TrafficMarkingPolicyName { get; set; }

    }

}
