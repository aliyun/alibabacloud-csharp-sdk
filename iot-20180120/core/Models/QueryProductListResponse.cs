// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryProductListResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryProductListResponseData Data { get; set; }
        public class QueryProductListResponseData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=true)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageCount")]
            [Validation(Required=true)]
            public int? PageCount { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }
            [NameInMap("List")]
            [Validation(Required=true)]
            public QueryProductListResponseDataList List { get; set; }
            public class QueryProductListResponseDataList : TeaModel {
                [NameInMap("ProductInfo")]
                [Validation(Required=true)]
                public List<QueryProductListResponseDataListProductInfo> ProductInfo { get; set; }
                public class QueryProductListResponseDataListProductInfo : TeaModel {
                    [NameInMap("GmtCreate")]
                    [Validation(Required=true)]
                    public long? GmtCreate { get; set; }

                    [NameInMap("DataFormat")]
                    [Validation(Required=true)]
                    public int? DataFormat { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=true)]
                    public string Description { get; set; }

                    [NameInMap("DeviceCount")]
                    [Validation(Required=true)]
                    public int? DeviceCount { get; set; }

                    [NameInMap("NodeType")]
                    [Validation(Required=true)]
                    public int? NodeType { get; set; }

                    [NameInMap("ProductKey")]
                    [Validation(Required=true)]
                    public string ProductKey { get; set; }

                    [NameInMap("ProductName")]
                    [Validation(Required=true)]
                    public string ProductName { get; set; }

                    [NameInMap("AuthType")]
                    [Validation(Required=true)]
                    public string AuthType { get; set; }

                }

            }
        };

    }

}
