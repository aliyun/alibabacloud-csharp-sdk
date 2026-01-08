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
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

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
            /// <para>The level of prompt attack</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("AttackLevel")]
            [Validation(Required=false)]
            public string AttackLevel { get; set; }

            /// <summary>
            /// <para>The result of prompt attack detect</para>
            /// </summary>
            [NameInMap("AttackResult")]
            [Validation(Required=false)]
            public List<TextModerationPlusResponseBodyDataAttackResult> AttackResult { get; set; }
            public class TextModerationPlusResponseBodyDataAttackResult : TeaModel {
                /// <summary>
                /// <para>The level of prompt attack</para>
                /// 
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("AttackLevel")]
                [Validation(Required=false)]
                public string AttackLevel { get; set; }

                /// <summary>
                /// <para>The confidence</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                /// <summary>
                /// <para>Description</para>
                /// 
                /// <b>Example:</b>
                /// <para>safe</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The label</para>
                /// 
                /// <b>Example:</b>
                /// <para>safe</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            /// <summary>
            /// <para>The id of data</para>
            /// 
            /// <b>Example:</b>
            /// <para>text1234</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("DetectedLanguage")]
            [Validation(Required=false)]
            public string DetectedLanguage { get; set; }

            [NameInMap("Ext")]
            [Validation(Required=false)]
            public TextModerationPlusResponseBodyDataExt Ext { get; set; }
            public class TextModerationPlusResponseBodyDataExt : TeaModel {
                [NameInMap("LlmContent")]
                [Validation(Required=false)]
                public TextModerationPlusResponseBodyDataExtLlmContent LlmContent { get; set; }
                public class TextModerationPlusResponseBodyDataExtLlmContent : TeaModel {
                    [NameInMap("OutputText")]
                    [Validation(Required=false)]
                    public string OutputText { get; set; }

                }

            }

            [NameInMap("ManualTaskId")]
            [Validation(Required=false)]
            public string ManualTaskId { get; set; }

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

            /// <summary>
            /// <para>The level of sensitivity data</para>
            /// 
            /// <b>Example:</b>
            /// <para>S0</para>
            /// </summary>
            [NameInMap("SensitiveLevel")]
            [Validation(Required=false)]
            public string SensitiveLevel { get; set; }

            /// <summary>
            /// <para>The result of sensitivity data detect</para>
            /// </summary>
            [NameInMap("SensitiveResult")]
            [Validation(Required=false)]
            public List<TextModerationPlusResponseBodyDataSensitiveResult> SensitiveResult { get; set; }
            public class TextModerationPlusResponseBodyDataSensitiveResult : TeaModel {
                /// <summary>
                /// <para>Description</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The label</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The sensitive data.</para>
                /// </summary>
                [NameInMap("SensitiveData")]
                [Validation(Required=false)]
                public List<string> SensitiveData { get; set; }

                /// <summary>
                /// <para>The level of sensitivity data</para>
                /// 
                /// <b>Example:</b>
                /// <para>S1</para>
                /// </summary>
                [NameInMap("SensitiveLevel")]
                [Validation(Required=false)]
                public string SensitiveLevel { get; set; }

            }

            [NameInMap("TranslatedContent")]
            [Validation(Required=false)]
            public string TranslatedContent { get; set; }

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
