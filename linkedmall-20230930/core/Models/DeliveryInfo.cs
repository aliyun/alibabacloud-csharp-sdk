// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class DeliveryInfo : TeaModel {
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("postFee")]
        [Validation(Required=false)]
        public long? PostFee { get; set; }

        [NameInMap("serviceType")]
        [Validation(Required=false)]
        public long? ServiceType { get; set; }

    }

}
