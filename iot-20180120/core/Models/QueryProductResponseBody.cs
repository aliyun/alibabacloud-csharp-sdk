// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryProductResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryProductResponseBodyData Data { get; set; }
        public class QueryProductResponseBodyData : TeaModel {
            [NameInMap("AliyunCommodityCode")]
            [Validation(Required=false)]
            public string AliyunCommodityCode { get; set; }

            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            [NameInMap("CategoryKey")]
            [Validation(Required=false)]
            public string CategoryKey { get; set; }

            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            [NameInMap("DataFormat")]
            [Validation(Required=false)]
            public int? DataFormat { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DeviceCount")]
            [Validation(Required=false)]
            public int? DeviceCount { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("Id2")]
            [Validation(Required=false)]
            public bool? Id2 { get; set; }

            [NameInMap("NetType")]
            [Validation(Required=false)]
            public int? NetType { get; set; }

            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public int? NodeType { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public bool? Owner { get; set; }

            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("ProductSecret")]
            [Validation(Required=false)]
            public string ProductSecret { get; set; }

            [NameInMap("ProductStatus")]
            [Validation(Required=false)]
            public string ProductStatus { get; set; }

            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            [NameInMap("ValidateType")]
            [Validation(Required=false)]
            public int? ValidateType { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
