// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20140828.Models
{
    public class DetachAlbServerGroupsRequest : TeaModel {
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

        [NameInMap("AlbServerGroup")]
        [Validation(Required=false)]
        public List<DetachAlbServerGroupsRequestAlbServerGroup> AlbServerGroup { get; set; }
        public class DetachAlbServerGroupsRequestAlbServerGroup : TeaModel {
            [NameInMap("AlbServerGroupId")]
            [Validation(Required=false)]
            public string AlbServerGroupId { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

        }

    }

}
