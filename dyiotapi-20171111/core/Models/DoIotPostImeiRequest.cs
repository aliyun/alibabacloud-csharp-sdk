// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyiotapi20171111.Models
{
    public class DoIotPostImeiRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Imei")]
        [Validation(Required=false)]
        public string Imei { get; set; }

        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

    }

}
