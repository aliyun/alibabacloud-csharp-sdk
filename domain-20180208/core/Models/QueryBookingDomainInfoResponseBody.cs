// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class QueryBookingDomainInfoResponseBody : TeaModel {
        [NameInMap("AuctionId")]
        [Validation(Required=false)]
        public int? AuctionId { get; set; }

        [NameInMap("BookEndTime")]
        [Validation(Required=false)]
        public long? BookEndTime { get; set; }

        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        [NameInMap("MaxBid")]
        [Validation(Required=false)]
        public float? MaxBid { get; set; }

        [NameInMap("PartnerType")]
        [Validation(Required=false)]
        public string PartnerType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TransferInPrice")]
        [Validation(Required=false)]
        public float? TransferInPrice { get; set; }

    }

}
