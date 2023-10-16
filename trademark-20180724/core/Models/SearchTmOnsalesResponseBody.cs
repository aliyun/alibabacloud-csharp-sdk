// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class SearchTmOnsalesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("TotalPageNumber")]
        [Validation(Required=false)]
        public int? TotalPageNumber { get; set; }

        [NameInMap("Trademarks")]
        [Validation(Required=false)]
        public List<SearchTmOnsalesResponseBodyTrademarks> Trademarks { get; set; }
        public class SearchTmOnsalesResponseBodyTrademarks : TeaModel {
            [NameInMap("Classification")]
            [Validation(Required=false)]
            public string Classification { get; set; }

            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("OrderPrice")]
            [Validation(Required=false)]
            public string OrderPrice { get; set; }

            [NameInMap("PartnerCode")]
            [Validation(Required=false)]
            public string PartnerCode { get; set; }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("ProductDesc")]
            [Validation(Required=false)]
            public string ProductDesc { get; set; }

            [NameInMap("RegistrationNumber")]
            [Validation(Required=false)]
            public string RegistrationNumber { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("TrademarkName")]
            [Validation(Required=false)]
            public string TrademarkName { get; set; }

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

    }

}
