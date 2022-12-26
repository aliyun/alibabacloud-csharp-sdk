// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileDetectApiInvokeInfoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileDetectApiInvokeInfoResponseBodyData Data { get; set; }
        public class GetFileDetectApiInvokeInfoResponseBodyData : TeaModel {
            [NameInMap("AuthCount")]
            [Validation(Required=false)]
            public long? AuthCount { get; set; }

            [NameInMap("Expire")]
            [Validation(Required=false)]
            public long? Expire { get; set; }

            [NameInMap("FlowRate")]
            [Validation(Required=false)]
            public int? FlowRate { get; set; }

            [NameInMap("RemainAuthCount")]
            [Validation(Required=false)]
            public long? RemainAuthCount { get; set; }

            [NameInMap("SaleVersion")]
            [Validation(Required=false)]
            public int? SaleVersion { get; set; }

            [NameInMap("TimeUnit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
