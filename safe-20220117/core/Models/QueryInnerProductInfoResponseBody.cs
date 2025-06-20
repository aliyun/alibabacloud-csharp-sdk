// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safe20220117.Models
{
    public class QueryInnerProductInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryInnerProductInfoResponseBodyData Data { get; set; }
        public class QueryInnerProductInfoResponseBodyData : TeaModel {
            [NameInMap("DataInfo")]
            [Validation(Required=false)]
            public List<QueryInnerProductInfoResponseBodyDataDataInfo> DataInfo { get; set; }
            public class QueryInnerProductInfoResponseBodyDataDataInfo : TeaModel {
                [NameInMap("InnerProductCode")]
                [Validation(Required=false)]
                public string InnerProductCode { get; set; }

                [NameInMap("InnerProductName")]
                [Validation(Required=false)]
                public string InnerProductName { get; set; }

                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

            }

            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public QueryInnerProductInfoResponseBodyDataPagination Pagination { get; set; }
            public class QueryInnerProductInfoResponseBodyDataPagination : TeaModel {
                [NameInMap("Limit")]
                [Validation(Required=false)]
                public int? Limit { get; set; }

                [NameInMap("Page")]
                [Validation(Required=false)]
                public int? Page { get; set; }

            }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
