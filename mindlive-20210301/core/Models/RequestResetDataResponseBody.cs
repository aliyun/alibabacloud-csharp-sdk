// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MindLive20210301.Models
{
    public class RequestResetDataResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RequestResetDataResponseBodyData Data { get; set; }
        public class RequestResetDataResponseBodyData : TeaModel {
            [NameInMap("FullUrl")]
            [Validation(Required=false)]
            public string FullUrl { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

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
