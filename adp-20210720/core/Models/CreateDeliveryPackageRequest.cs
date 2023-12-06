// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class CreateDeliveryPackageRequest : TeaModel {
        [NameInMap("deliverableUID")]
        [Validation(Required=false)]
        public string DeliverableUID { get; set; }

        [NameInMap("deliveryInstanceUID")]
        [Validation(Required=false)]
        public string DeliveryInstanceUID { get; set; }

        [NameInMap("originDeliverableUID")]
        [Validation(Required=false)]
        public string OriginDeliverableUID { get; set; }

        [NameInMap("packageContentType")]
        [Validation(Required=false)]
        public string PackageContentType { get; set; }

        [NameInMap("packageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

    }

}
