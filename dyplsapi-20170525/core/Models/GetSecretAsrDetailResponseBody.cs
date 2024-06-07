// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class GetSecretAsrDetailResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The ASR details.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSecretAsrDetailResponseBodyData Data { get; set; }
        public class GetSecretAsrDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The total duration of the audio file that was recognized. Unit: milliseconds.
            /// </summary>
            [NameInMap("BizDuration")]
            [Validation(Required=false)]
            public long? BizDuration { get; set; }

            /// <summary>
            /// The ID of the business process.
            /// </summary>
            [NameInMap("BusinessId")]
            [Validation(Required=false)]
            public string BusinessId { get; set; }

            /// <summary>
            /// The business keyword.
            /// </summary>
            [NameInMap("BusinessKey")]
            [Validation(Required=false)]
            public string BusinessKey { get; set; }

            /// <summary>
            /// The status code. The status code 21050000 indicates that the request was successful.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The description.
            /// </summary>
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// The request ID.
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// The ASR result.
            /// </summary>
            [NameInMap("Sentences")]
            [Validation(Required=false)]
            public List<GetSecretAsrDetailResponseBodyDataSentences> Sentences { get; set; }
            public class GetSecretAsrDetailResponseBodyDataSentences : TeaModel {
                /// <summary>
                /// The start time offset of the sentence. Unit: milliseconds.
                /// </summary>
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public long? BeginTime { get; set; }

                /// <summary>
                /// The ID of the audio track to which the sentence belongs.
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public int? ChannelId { get; set; }

                /// <summary>
                /// The emotion value. Value range: 1 to 10. The higher the value, the stronger the emotion.
                /// </summary>
                [NameInMap("EmotionValue")]
                [Validation(Required=false)]
                public string EmotionValue { get; set; }

                /// <summary>
                /// The end time offset of the sentence. Unit: milliseconds.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// The silence duration between the current sentence and the previous sentence. Unit: seconds.
                /// </summary>
                [NameInMap("SilenceDuration")]
                [Validation(Required=false)]
                public long? SilenceDuration { get; set; }

                /// <summary>
                /// The average speech rate of the sentence. Unit: number of words per minute.
                /// </summary>
                [NameInMap("SpeechRate")]
                [Validation(Required=false)]
                public int? SpeechRate { get; set; }

                /// <summary>
                /// The recognition result of the sentence.
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// The type.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
