// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryProductListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryProductListResponseBodyData Data { get; set; }
        public class QueryProductListResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
            [NameInMap("List")]
            [Validation(Required=false)]
            public QueryProductListResponseBodyDataList List { get; set; }
            public class QueryProductListResponseBodyDataList : TeaModel {
                [NameInMap("ProductInfo")]
                [Validation(Required=false)]
                public List<QueryProductListResponseBodyDataListProductInfo> ProductInfo { get; set; }
                public class QueryProductListResponseBodyDataListProductInfo : TeaModel {
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public long? GmtCreate { get; set; }

                    [NameInMap("DataFormat")]
                    [Validation(Required=false)]
                    public int? DataFormat { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("DeviceCount")]
                    [Validation(Required=false)]
                    public int? DeviceCount { get; set; }

                    [NameInMap("NodeType")]
                    [Validation(Required=false)]
                    public int? NodeType { get; set; }

                    [NameInMap("ProductKey")]
                    [Validation(Required=false)]
                    public string ProductKey { get; set; }

                    [NameInMap("ProductName")]
                    [Validation(Required=false)]
                    public string ProductName { get; set; }

                    [NameInMap("AuthType")]
                    [Validation(Required=false)]
                    public string AuthType { get; set; }

                }

            }
        };

    }

}
