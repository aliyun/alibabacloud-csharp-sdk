// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryTrademarkOnSaleResponseBody : TeaModel {
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
        public List<QueryTrademarkOnSaleResponseBodyTrademarks> Trademarks { get; set; }
        public class QueryTrademarkOnSaleResponseBodyTrademarks : TeaModel {
            [NameInMap("AuditResult")]
            [Validation(Required=false)]
            public string AuditResult { get; set; }

            [NameInMap("Classification")]
            [Validation(Required=false)]
            public string Classification { get; set; }

            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("OrderPrice")]
            [Validation(Required=false)]
            public string OrderPrice { get; set; }

            [NameInMap("RegistrationNumber")]
            [Validation(Required=false)]
            public string RegistrationNumber { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("TmType")]
            [Validation(Required=false)]
            public string TmType { get; set; }

            [NameInMap("TrademarkName")]
            [Validation(Required=false)]
            public string TrademarkName { get; set; }

        }

    }

}
