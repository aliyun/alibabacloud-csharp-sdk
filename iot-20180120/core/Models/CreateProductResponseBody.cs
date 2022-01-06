// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateProductResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateProductResponseBodyData Data { get; set; }
        public class CreateProductResponseBodyData : TeaModel {
            [NameInMap("AliyunCommodityCode")]
            [Validation(Required=false)]
            public string AliyunCommodityCode { get; set; }
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }
            [NameInMap("DataFormat")]
            [Validation(Required=false)]
            public int? DataFormat { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Id2")]
            [Validation(Required=false)]
            public bool? Id2 { get; set; }
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public int? NodeType { get; set; }
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }
            [NameInMap("ProductSecret")]
            [Validation(Required=false)]
            public string ProductSecret { get; set; }
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
