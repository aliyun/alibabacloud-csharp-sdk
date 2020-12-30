// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Snsuapi20180709.Models
{
    public class MobileStopSpeedUpRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("CorrelationId")]
        [Validation(Required=false)]
        public string CorrelationId { get; set; }

    }

}
