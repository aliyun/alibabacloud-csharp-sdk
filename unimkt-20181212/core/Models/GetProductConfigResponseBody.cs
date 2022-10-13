// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class GetProductConfigResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("Header")]
        [Validation(Required=false)]
        public GetProductConfigResponseBodyHeader Header { get; set; }
        public class GetProductConfigResponseBodyHeader : TeaModel {
            [NameInMap("CostTime")]
            [Validation(Required=false)]
            public long? CostTime { get; set; }

            [NameInMap("RpcId")]
            [Validation(Required=false)]
            public string RpcId { get; set; }

            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetProductConfigResponseBodyResult> Result { get; set; }
        public class GetProductConfigResponseBodyResult : TeaModel {
            [NameInMap("BusinessList")]
            [Validation(Required=false)]
            public List<GetProductConfigResponseBodyResultBusinessList> BusinessList { get; set; }
            public class GetProductConfigResponseBodyResultBusinessList : TeaModel {
                [NameInMap("BusinessCode")]
                [Validation(Required=false)]
                public string BusinessCode { get; set; }

                [NameInMap("BusinessCodeName")]
                [Validation(Required=false)]
                public string BusinessCodeName { get; set; }

            }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
