// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class UpdateDeliveryInstanceRequest : TeaModel {
        [NameInMap("deliverableConfigUID")]
        [Validation(Required=false)]
        public string DeliverableConfigUID { get; set; }

        [NameInMap("deliverableUID")]
        [Validation(Required=false)]
        public string DeliverableUID { get; set; }

        [NameInMap("desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

    }

}
