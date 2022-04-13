// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class QueryMailAddressByParamResponseBody : TeaModel {
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

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryMailAddressByParamResponseBodyData Data { get; set; }
        public class QueryMailAddressByParamResponseBodyData : TeaModel {
            [NameInMap("mailAddress")]
            [Validation(Required=false)]
            public List<QueryMailAddressByParamResponseBodyDataMailAddress> MailAddress { get; set; }
            public class QueryMailAddressByParamResponseBodyDataMailAddress : TeaModel {
                public string AccountName { get; set; }
                public string AccountStatus { get; set; }
                public string CreateTime { get; set; }
                public string DailyCount { get; set; }
                public string DailyReqCount { get; set; }
                public string DomainStatus { get; set; }
                public string MailAddressId { get; set; }
                public string MonthCount { get; set; }
                public string MonthReqCount { get; set; }
                public string ReplyAddress { get; set; }
                public string ReplyStatus { get; set; }
                public string Sendtype { get; set; }
            }
        };

    }

}
