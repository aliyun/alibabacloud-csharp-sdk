// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20140828.Models
{
    public class DetachVServerGroupsRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ForceDetach")]
        [Validation(Required=false)]
        public bool? ForceDetach { get; set; }

        [NameInMap("VServerGroup")]
        [Validation(Required=false)]
        public List<DetachVServerGroupsRequestVServerGroup> VServerGroup { get; set; }
        public class DetachVServerGroupsRequestVServerGroup : TeaModel {
            [NameInMap("VServerGroupAttribute")]
            [Validation(Required=false)]
            public List<DetachVServerGroupsRequestVServerGroupVServerGroupAttribute> VServerGroupAttribute { get; set; }
            public class DetachVServerGroupsRequestVServerGroupVServerGroupAttribute : TeaModel {
                [NameInMap("VServerGroupId")]
                [Validation(Required=false)]
                public string VServerGroupId { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

        }

    }

}
