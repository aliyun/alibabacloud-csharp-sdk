// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListDeliveryPackageRequest : TeaModel {
        [NameInMap("deliverableUID")]
        [Validation(Required=false)]
        public string DeliverableUID { get; set; }

        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

    }

}
