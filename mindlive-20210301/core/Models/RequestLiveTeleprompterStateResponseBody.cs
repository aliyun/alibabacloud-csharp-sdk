// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MindLive20210301.Models
{
    public class RequestLiveTeleprompterStateResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RequestLiveTeleprompterStateResponseBodyData Data { get; set; }
        public class RequestLiveTeleprompterStateResponseBodyData : TeaModel {
            [NameInMap("Display")]
            [Validation(Required=false)]
            public bool? Display { get; set; }

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
