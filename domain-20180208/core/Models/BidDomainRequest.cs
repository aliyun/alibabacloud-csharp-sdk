// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class BidDomainRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AuctionId")]
        [Validation(Required=false)]
        public string AuctionId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MaxBid")]
        [Validation(Required=false)]
        public float? MaxBid { get; set; }

    }

}
