// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class GetSecretAsrDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSecretAsrDetailResponseBodyData Data { get; set; }
        public class GetSecretAsrDetailResponseBodyData : TeaModel {
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }
            [NameInMap("BusinessId")]
            [Validation(Required=false)]
            public string BusinessId { get; set; }
            [NameInMap("BusinessKey")]
            [Validation(Required=false)]
            public string BusinessKey { get; set; }
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }
            [NameInMap("BizDuration")]
            [Validation(Required=false)]
            public long? BizDuration { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("Sentences")]
            [Validation(Required=false)]
            public List<GetSecretAsrDetailResponseBodyDataSentences> Sentences { get; set; }
            public class GetSecretAsrDetailResponseBodyDataSentences : TeaModel {
                public long? EndTime { get; set; }
                public long? SilenceDuration { get; set; }
                public long? BeginTime { get; set; }
                public string Text { get; set; }
                public int? ChannelId { get; set; }
                public int? SpeechRate { get; set; }
                public string EmotionValue { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
