// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyiotapi20171111.Models
{
    public class DoIotRechargeRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Iccid")]
        [Validation(Required=false)]
        public string Iccid { get; set; }

        [NameInMap("OfferIds")]
        [Validation(Required=false)]
        public string OfferIds { get; set; }

        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("Amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        [NameInMap("EffCode")]
        [Validation(Required=false)]
        public string EffCode { get; set; }

        [NameInMap("OrderNum")]
        [Validation(Required=false)]
        public int? OrderNum { get; set; }

    }

}
