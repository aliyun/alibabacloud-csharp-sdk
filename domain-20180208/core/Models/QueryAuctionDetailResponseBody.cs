// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class QueryAuctionDetailResponseBody : TeaModel {
        [NameInMap("AuctionEndTime")]
        [Validation(Required=false)]
        public long? AuctionEndTime { get; set; }

        [NameInMap("AuctionId")]
        [Validation(Required=false)]
        public string AuctionId { get; set; }

        [NameInMap("BookEndTime")]
        [Validation(Required=false)]
        public long? BookEndTime { get; set; }

        [NameInMap("BookedPartner")]
        [Validation(Required=false)]
        public string BookedPartner { get; set; }

        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        [NameInMap("DeliveryTime")]
        [Validation(Required=false)]
        public long? DeliveryTime { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        [NameInMap("FailCode")]
        [Validation(Required=false)]
        public string FailCode { get; set; }

        [NameInMap("HighBid")]
        [Validation(Required=false)]
        public float? HighBid { get; set; }

        [NameInMap("HighBidder")]
        [Validation(Required=false)]
        public string HighBidder { get; set; }

        [NameInMap("NextValidBid")]
        [Validation(Required=false)]
        public float? NextValidBid { get; set; }

        [NameInMap("PartnerType")]
        [Validation(Required=false)]
        public string PartnerType { get; set; }

        [NameInMap("PayEndTime")]
        [Validation(Required=false)]
        public long? PayEndTime { get; set; }

        [NameInMap("PayPrice")]
        [Validation(Required=false)]
        public float? PayPrice { get; set; }

        [NameInMap("PayStatus")]
        [Validation(Required=false)]
        public string PayStatus { get; set; }

        [NameInMap("ProduceStatus")]
        [Validation(Required=false)]
        public string ProduceStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ReserveMet")]
        [Validation(Required=false)]
        public bool? ReserveMet { get; set; }

        [NameInMap("ReservePrice")]
        [Validation(Required=false)]
        public float? ReservePrice { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TransferInPrice")]
        [Validation(Required=false)]
        public float? TransferInPrice { get; set; }

        [NameInMap("YourCurrentBid")]
        [Validation(Required=false)]
        public float? YourCurrentBid { get; set; }

        [NameInMap("YourMaxBid")]
        [Validation(Required=false)]
        public float? YourMaxBid { get; set; }

    }

}
