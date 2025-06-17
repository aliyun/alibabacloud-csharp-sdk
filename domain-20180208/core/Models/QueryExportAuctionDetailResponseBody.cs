// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class QueryExportAuctionDetailResponseBody : TeaModel {
        [NameInMap("AuctionEndTime")]
        [Validation(Required=false)]
        public string AuctionEndTime { get; set; }

        [NameInMap("AuctionId")]
        [Validation(Required=false)]
        public string AuctionId { get; set; }

        [NameInMap("AuctionStatus")]
        [Validation(Required=false)]
        public string AuctionStatus { get; set; }

        [NameInMap("BookEndTime")]
        [Validation(Required=false)]
        public string BookEndTime { get; set; }

        [NameInMap("BuyerStatus")]
        [Validation(Required=false)]
        public string BuyerStatus { get; set; }

        [NameInMap("CurrentPrice")]
        [Validation(Required=false)]
        public double? CurrentPrice { get; set; }

        [NameInMap("IncreasePrice")]
        [Validation(Required=false)]
        public double? IncreasePrice { get; set; }

        [NameInMap("MyPrice")]
        [Validation(Required=false)]
        public double? MyPrice { get; set; }

        [NameInMap("MyProxyPrice")]
        [Validation(Required=false)]
        public double? MyProxyPrice { get; set; }

        [NameInMap("OthersMaxProxyPrice")]
        [Validation(Required=false)]
        public double? OthersMaxProxyPrice { get; set; }

        [NameInMap("ProxyPrice")]
        [Validation(Required=false)]
        public double? ProxyPrice { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
