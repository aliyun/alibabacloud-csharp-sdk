// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryTradeIntentionUserListResponseBody : TeaModel {
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTradeIntentionUserListResponseBodyData Data { get; set; }
        public class QueryTradeIntentionUserListResponseBodyData : TeaModel {
            [NameInMap("Trademark")]
            [Validation(Required=false)]
            public List<QueryTradeIntentionUserListResponseBodyDataTrademark> Trademark { get; set; }
            public class QueryTradeIntentionUserListResponseBodyDataTrademark : TeaModel {
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                [NameInMap("Classification")]
                [Validation(Required=false)]
                public string Classification { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DocumentDate")]
                [Validation(Required=false)]
                public string DocumentDate { get; set; }

                [NameInMap("DocumentName")]
                [Validation(Required=false)]
                public string DocumentName { get; set; }

                [NameInMap("DocumentUrl")]
                [Validation(Required=false)]
                public string DocumentUrl { get; set; }

                [NameInMap("Grade")]
                [Validation(Required=false)]
                public int? Grade { get; set; }

                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                [NameInMap("RegisterNumber")]
                [Validation(Required=false)]
                public string RegisterNumber { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
