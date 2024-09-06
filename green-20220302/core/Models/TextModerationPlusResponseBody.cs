// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class TextModerationPlusResponseBody : TeaModel {
        /// <summary>
        /// The returned HTTP status code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The moderation results.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TextModerationPlusResponseBodyData Data { get; set; }
        public class TextModerationPlusResponseBodyData : TeaModel {
            /// <summary>
            /// The suggestion.
            /// </summary>
            [NameInMap("Advice")]
            [Validation(Required=false)]
            public List<TextModerationPlusResponseBodyDataAdvice> Advice { get; set; }
            public class TextModerationPlusResponseBodyDataAdvice : TeaModel {
                /// <summary>
                /// The answer.
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
            /// The results.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<TextModerationPlusResponseBodyDataResult> Result { get; set; }
            public class TextModerationPlusResponseBodyDataResult : TeaModel {
                /// <summary>
                /// The score of the confidence level. Valid values: 0 to 100. The value is accurate to two decimal places.
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                /// <summary>
                /// The custom term hit by the moderated content.
                /// </summary>
                [NameInMap("CustomizedHit")]
                [Validation(Required=false)]
                public List<TextModerationPlusResponseBodyDataResultCustomizedHit> CustomizedHit { get; set; }
                public class TextModerationPlusResponseBodyDataResultCustomizedHit : TeaModel {
                    /// <summary>
                    /// The terms that are hit. Multiple terms are separated by commas (,).
                    /// </summary>
                    [NameInMap("KeyWords")]
                    [Validation(Required=false)]
                    public string KeyWords { get; set; }

                    /// <summary>
                    /// The library name.
                    /// </summary>
                    [NameInMap("LibName")]
                    [Validation(Required=false)]
                    public string LibName { get; set; }

                }

                /// <summary>
                /// The description of the label.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The label.
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// The term hit by the moderated content.
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
            /// The score.
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
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
