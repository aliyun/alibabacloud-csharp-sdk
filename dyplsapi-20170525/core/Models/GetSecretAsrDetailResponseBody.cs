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

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSecretAsrDetailResponseBodyData Data { get; set; }
        public class GetSecretAsrDetailResponseBodyData : TeaModel {
            [NameInMap("BizDuration")]
            [Validation(Required=false)]
            public long? BizDuration { get; set; }

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

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("Sentences")]
            [Validation(Required=false)]
            public List<GetSecretAsrDetailResponseBodyDataSentences> Sentences { get; set; }
            public class GetSecretAsrDetailResponseBodyDataSentences : TeaModel {
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public long? BeginTime { get; set; }

                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public int? ChannelId { get; set; }

                [NameInMap("EmotionValue")]
                [Validation(Required=false)]
                public string EmotionValue { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("SilenceDuration")]
                [Validation(Required=false)]
                public long? SilenceDuration { get; set; }

                [NameInMap("SpeechRate")]
                [Validation(Required=false)]
                public int? SpeechRate { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
