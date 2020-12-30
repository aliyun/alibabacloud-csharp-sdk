// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Snsuapi20180709.Models
{
    public class BandStartSpeedUpRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        [NameInMap("BandId")]
        [Validation(Required=false)]
        public long? BandId { get; set; }

        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        [NameInMap("TargetBandwidth")]
        [Validation(Required=false)]
        public long? TargetBandwidth { get; set; }

        [NameInMap("BandScene")]
        [Validation(Required=false)]
        public string BandScene { get; set; }

    }

}
