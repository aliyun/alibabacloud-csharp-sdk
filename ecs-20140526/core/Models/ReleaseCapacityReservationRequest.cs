// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ReleaseCapacityReservationRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public ReleaseCapacityReservationRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class ReleaseCapacityReservationRequestPrivatePoolOptions : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=true)]
            public string Id { get; set; }
        };

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
