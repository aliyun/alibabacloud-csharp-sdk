// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class UpdatePartnerReservePriceRequest : TeaModel {
        [NameInMap("BiddingId")]
        [Validation(Required=false)]
        public int? BiddingId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("PartnerType")]
        [Validation(Required=false)]
        public string PartnerType { get; set; }

        [NameInMap("ReservePrice")]
        [Validation(Required=false)]
        public double? ReservePrice { get; set; }

    }

}
