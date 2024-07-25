// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class TextModerationPlusResponseBody : TeaModel {
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
        public TextModerationPlusResponseBodyData Data { get; set; }
        public class TextModerationPlusResponseBodyData : TeaModel {
            /// <summary>
            /// Advice
            /// </summary>
            [NameInMap("Advice")]
            [Validation(Required=false)]
            public List<TextModerationPlusResponseBodyDataAdvice> Advice { get; set; }
            public class TextModerationPlusResponseBodyDataAdvice : TeaModel {
                /// <summary>
                /// Answer
                /// </summary>
                [NameInMap("Answer")]
                [Validation(Required=false)]
                public string Answer { get; set; }

                /// <summary>
                /// Hit Label
                /// </summary>
                [NameInMap("HitLabel")]
                [Validation(Required=false)]
                public string HitLabel { get; set; }

                /// <summary>
                /// Hit Library Name
                /// </summary>
                [NameInMap("HitLibName")]
                [Validation(Required=false)]
                public string HitLibName { get; set; }

            }

            /// <summary>
            /// The moderation results.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<TextModerationPlusResponseBodyDataResult> Result { get; set; }
            public class TextModerationPlusResponseBodyDataResult : TeaModel {
                /// <summary>
                /// Confidence score, 0 to 100, reserved to 2 decimal places.
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                /// <summary>
                /// Custom keyword hits
                /// </summary>
                [NameInMap("CustomizedHit")]
                [Validation(Required=false)]
                public List<TextModerationPlusResponseBodyDataResultCustomizedHit> CustomizedHit { get; set; }
                public class TextModerationPlusResponseBodyDataResultCustomizedHit : TeaModel {
                    /// <summary>
                    /// Hit keywords, comma separated.
                    /// </summary>
                    [NameInMap("KeyWords")]
                    [Validation(Required=false)]
                    public string KeyWords { get; set; }

                    /// <summary>
                    /// Library Name
                    /// </summary>
                    [NameInMap("LibName")]
                    [Validation(Required=false)]
                    public string LibName { get; set; }

                }

                /// <summary>
                /// Labels.
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// Risk words
                /// </summary>
                [NameInMap("RiskWords")]
                [Validation(Required=false)]
                public string RiskWords { get; set; }

            }

            /// <summary>
            /// Risk Level
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// Score.
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public float? Score { get; set; }

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
