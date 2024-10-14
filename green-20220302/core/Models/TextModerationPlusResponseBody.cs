// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class TextModerationPlusResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned HTTP status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The moderation results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TextModerationPlusResponseBodyData Data { get; set; }
        public class TextModerationPlusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The suggestion.</para>
            /// </summary>
            [NameInMap("Advice")]
            [Validation(Required=false)]
            public List<TextModerationPlusResponseBodyDataAdvice> Advice { get; set; }
            public class TextModerationPlusResponseBodyDataAdvice : TeaModel {
                /// <summary>
                /// <para>The answer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX</para>
                /// </summary>
                [NameInMap("Answer")]
                [Validation(Required=false)]
                public string Answer { get; set; }

                /// <summary>
                /// <para>Hit Label</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("HitLabel")]
                [Validation(Required=false)]
                public string HitLabel { get; set; }

                /// <summary>
                /// <para>Hit Library Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("HitLibName")]
                [Validation(Required=false)]
                public string HitLibName { get; set; }

            }

            /// <summary>
            /// <para>The results.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<TextModerationPlusResponseBodyDataResult> Result { get; set; }
            public class TextModerationPlusResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The score of the confidence level. Valid values: 0 to 100. The value is accurate to two decimal places.</para>
                /// 
                /// <b>Example:</b>
                /// <para>81.22</para>
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                /// <summary>
                /// <para>The custom term hit by the moderated content.</para>
                /// </summary>
                [NameInMap("CustomizedHit")]
                [Validation(Required=false)]
                public List<TextModerationPlusResponseBodyDataResultCustomizedHit> CustomizedHit { get; set; }
                public class TextModerationPlusResponseBodyDataResultCustomizedHit : TeaModel {
                    /// <summary>
                    /// <para>The terms that are hit. Multiple terms are separated by commas (,).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("KeyWords")]
                    [Validation(Required=false)]
                    public string KeyWords { get; set; }

                    /// <summary>
                    /// <para>The library name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("LibName")]
                    [Validation(Required=false)]
                    public string LibName { get; set; }

                }

                /// <summary>
                /// <para>The description of the label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>porn</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The term hit by the moderated content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX</para>
                /// </summary>
                [NameInMap("RiskWords")]
                [Validation(Required=false)]
                public string RiskWords { get; set; }

            }

            /// <summary>
            /// <para>Risk Level</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The score.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public float? Score { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned in response to the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
