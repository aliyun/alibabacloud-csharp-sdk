// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Snsuapi20180709.Models
{
    public class MobileStartSpeedUpRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("PublicIp")]
        [Validation(Required=false)]
        public string PublicIp { get; set; }

        [NameInMap("PublicPort")]
        [Validation(Required=false)]
        public string PublicPort { get; set; }

        [NameInMap("DestinationIpAddress")]
        [Validation(Required=false)]
        public string DestinationIpAddress { get; set; }

    }

}
