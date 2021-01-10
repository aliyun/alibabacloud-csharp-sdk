// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class RestartAsrTaskResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RestartAsrTaskResponseBodyData Data { get; set; }
        public class RestartAsrTaskResponseBodyData : TeaModel {
            [NameInMap("RestartResult")]
            [Validation(Required=false)]
            public List<RestartAsrTaskResponseBodyDataRestartResult> RestartResult { get; set; }
            public class RestartAsrTaskResponseBodyDataRestartResult : TeaModel {
                public string Data { get; set; }
                public bool? Success { get; set; }
                public string Message { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
