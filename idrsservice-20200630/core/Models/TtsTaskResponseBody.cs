// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class TtsTaskResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public TtsTaskResponseBodyData Data { get; set; }
        public class TtsTaskResponseBodyData : TeaModel {
            [NameInMap("Answer")]
            [Validation(Required=false)]
            public string Answer { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public double? Duration { get; set; }

            [NameInMap("Question")]
            [Validation(Required=false)]
            public string Question { get; set; }

            [NameInMap("SpeechRate")]
            [Validation(Required=false)]
            public int? SpeechRate { get; set; }

        }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
