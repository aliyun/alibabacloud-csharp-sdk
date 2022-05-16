// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkcard20210520.Models
{
    public class RenewRequest : TeaModel {
        [NameInMap("ApiProduct")]
        [Validation(Required=false)]
        public string ApiProduct { get; set; }

        [NameInMap("ApiRevision")]
        [Validation(Required=false)]
        public string ApiRevision { get; set; }

        [NameInMap("BuyNum")]
        [Validation(Required=false)]
        public int? BuyNum { get; set; }

        [NameInMap("Iccid")]
        [Validation(Required=false)]
        public string Iccid { get; set; }

        [NameInMap("OfferCode")]
        [Validation(Required=false)]
        public string OfferCode { get; set; }

        [NameInMap("RechargeType")]
        [Validation(Required=false)]
        public string RechargeType { get; set; }

        [NameInMap("SerialNo")]
        [Validation(Required=false)]
        public string SerialNo { get; set; }

    }

}
