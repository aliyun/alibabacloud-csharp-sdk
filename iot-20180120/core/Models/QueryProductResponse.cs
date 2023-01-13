// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryProductResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryProductResponseData Data { get; set; }
        public class QueryProductResponseData : TeaModel {
            [NameInMap("AliyunCommodityCode")]
            [Validation(Required=true)]
            public string AliyunCommodityCode { get; set; }

            [NameInMap("AuthType")]
            [Validation(Required=true)]
            public string AuthType { get; set; }

            [NameInMap("CategoryKey")]
            [Validation(Required=true)]
            public string CategoryKey { get; set; }

            [NameInMap("CategoryName")]
            [Validation(Required=true)]
            public string CategoryName { get; set; }

            [NameInMap("DataFormat")]
            [Validation(Required=true)]
            public int? DataFormat { get; set; }

            [NameInMap("Description")]
            [Validation(Required=true)]
            public string Description { get; set; }

            [NameInMap("DeviceCount")]
            [Validation(Required=true)]
            public int? DeviceCount { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=true)]
            public long? GmtCreate { get; set; }

            [NameInMap("Id2")]
            [Validation(Required=true)]
            public bool? Id2 { get; set; }

            [NameInMap("NetType")]
            [Validation(Required=true)]
            public int? NetType { get; set; }

            [NameInMap("NodeType")]
            [Validation(Required=true)]
            public int? NodeType { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=true)]
            public bool? Owner { get; set; }

            [NameInMap("ProductKey")]
            [Validation(Required=true)]
            public string ProductKey { get; set; }

            [NameInMap("ProductName")]
            [Validation(Required=true)]
            public string ProductName { get; set; }

            [NameInMap("ProductSecret")]
            [Validation(Required=true)]
            public string ProductSecret { get; set; }

            [NameInMap("ProductStatus")]
            [Validation(Required=true)]
            public string ProductStatus { get; set; }

            [NameInMap("ProtocolType")]
            [Validation(Required=true)]
            public string ProtocolType { get; set; }

            [NameInMap("ValidateType")]
            [Validation(Required=true)]
            public int? ValidateType { get; set; }

        }

    }

}
