// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class VoiceModerationResultResponseBody : TeaModel {
        /// <summary>
        /// The returned HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public VoiceModerationResultResponseBodyData Data { get; set; }
        public class VoiceModerationResultResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the moderated object.
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// The unique ID of the live stream.
            /// </summary>
            [NameInMap("LiveId")]
            [Validation(Required=false)]
            public string LiveId { get; set; }

            /// <summary>
            /// The details about the audio segments.
            /// </summary>
            [NameInMap("SliceDetails")]
            [Validation(Required=false)]
            public List<VoiceModerationResultResponseBodyDataSliceDetails> SliceDetails { get; set; }
            public class VoiceModerationResultResponseBodyDataSliceDetails : TeaModel {
                /// <summary>
                /// The end time of the text after audio-to-text conversion. Unit: seconds.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// The end timestamp of the segment. Unit: milliseconds.
                /// </summary>
                [NameInMap("EndTimestamp")]
                [Validation(Required=false)]
                public long? EndTimestamp { get; set; }

                /// <summary>
                /// A reserved parameter.
                /// </summary>
                [NameInMap("Extend")]
                [Validation(Required=false)]
                public string Extend { get; set; }

                /// <summary>
                /// The details of the labels.
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// Reserved field.
                /// </summary>
                [NameInMap("OriginAlgoResult")]
                [Validation(Required=false)]
                public Dictionary<string, object> OriginAlgoResult { get; set; }

                /// <summary>
                /// The risk details that are hit.
                /// </summary>
                [NameInMap("RiskTips")]
                [Validation(Required=false)]
                public string RiskTips { get; set; }

                /// <summary>
                /// The risk words that are hit.
                /// </summary>
                [NameInMap("RiskWords")]
                [Validation(Required=false)]
                public string RiskWords { get; set; }

                /// <summary>
                /// Risk score, default range 0-99.
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// The start time of the text after audio-to-text conversion. Unit: seconds.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// The start timestamp of the segment. Unit: milliseconds.
                /// </summary>
                [NameInMap("StartTimestamp")]
                [Validation(Required=false)]
                public long? StartTimestamp { get; set; }

                /// <summary>
                /// The text converted from voice.
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// The temporary access address of the audio segment. The validity period of the URL is 30 minutes. You must prepare another URL to store the audio segment at the earliest opportunity.
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// The task ID.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The URL of the moderation object.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// The message that is returned in response to the request.
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
