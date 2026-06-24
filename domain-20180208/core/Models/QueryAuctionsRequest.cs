// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class QueryAuctionsRequest : TeaModel {
        [NameInMap("AuctionEndTimeOrder")]
        [Validation(Required=false)]
        public string AuctionEndTimeOrder { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public string Statuses { get; set; }

    }

}
