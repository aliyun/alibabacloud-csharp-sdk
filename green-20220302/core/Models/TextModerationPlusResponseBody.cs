// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class TextModerationPlusResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data that is returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TextModerationPlusResponseBodyData Data { get; set; }
        public class TextModerationPlusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AccountId from the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The suggested actions.</para>
            /// </summary>
            [NameInMap("Advice")]
            [Validation(Required=false)]
            public List<TextModerationPlusResponseBodyDataAdvice> Advice { get; set; }
            public class TextModerationPlusResponseBodyDataAdvice : TeaModel {
                /// <summary>
                /// <para>The suggested answer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX</para>
                /// </summary>
                [NameInMap("Answer")]
                [Validation(Required=false)]
                public string Answer { get; set; }

                /// <summary>
                /// <para>The label that was hit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX</para>
                /// </summary>
                [NameInMap("HitLabel")]
                [Validation(Required=false)]
                public string HitLabel { get; set; }

                /// <summary>
                /// <para>The name of the keyword library that was hit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX</para>
                /// </summary>
                [NameInMap("HitLibName")]
                [Validation(Required=false)]
                public string HitLibName { get; set; }

            }

            /// <summary>
            /// <para>The attack level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("AttackLevel")]
            [Validation(Required=false)]
            public string AttackLevel { get; set; }

            /// <summary>
            /// <para>The prompt attack detection results.</para>
            /// </summary>
            [NameInMap("AttackResult")]
            [Validation(Required=false)]
            public List<TextModerationPlusResponseBodyDataAttackResult> AttackResult { get; set; }
            public class TextModerationPlusResponseBodyDataAttackResult : TeaModel {
                /// <summary>
                /// <para>The attack level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("AttackLevel")]
                [Validation(Required=false)]
                public string AttackLevel { get; set; }

                /// <summary>
                /// <para>The confidence score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>safe</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>safe</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            /// <summary>
            /// <para>The ID of the data that was moderated.</para>
            /// <remarks>
            /// <para>If you specify the \<c>dataId\\</c> parameter in the request, the value of this parameter is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>text1234</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>The detected language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>en</para>
            /// </summary>
            [NameInMap("DetectedLanguage")]
            [Validation(Required=false)]
            public string DetectedLanguage { get; set; }

            /// <summary>
            /// <para>The auxiliary information.</para>
            /// </summary>
            [NameInMap("Ext")]
            [Validation(Required=false)]
            public TextModerationPlusResponseBodyDataExt Ext { get; set; }
            public class TextModerationPlusResponseBodyDataExt : TeaModel {
                /// <summary>
                /// <para>The LLM output.</para>
                /// </summary>
                [NameInMap("LlmContent")]
                [Validation(Required=false)]
                public TextModerationPlusResponseBodyDataExtLlmContent LlmContent { get; set; }
                public class TextModerationPlusResponseBodyDataExtLlmContent : TeaModel {
                    /// <summary>
                    /// <para>The output.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>正常。文本中无风险内容。</para>
                    /// </summary>
                    [NameInMap("OutputText")]
                    [Validation(Required=false)]
                    public string OutputText { get; set; }

                }

            }

            /// <summary>
            /// <para>The ID of the manual review task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxx-xxxxx</para>
            /// </summary>
            [NameInMap("ManualTaskId")]
            [Validation(Required=false)]
            public string ManualTaskId { get; set; }

            /// <summary>
            /// <para>The moderation results.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<TextModerationPlusResponseBodyDataResult> Result { get; set; }
            public class TextModerationPlusResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The confidence score. The value ranges from 0 to 100. The value is accurate to two decimal places.</para>
                /// 
                /// <b>Example:</b>
                /// <para>81.22</para>
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                /// <summary>
                /// <para>The custom keywords that were hit.</para>
                /// </summary>
                [NameInMap("CustomizedHit")]
                [Validation(Required=false)]
                public List<TextModerationPlusResponseBodyDataResultCustomizedHit> CustomizedHit { get; set; }
                public class TextModerationPlusResponseBodyDataResultCustomizedHit : TeaModel {
                    /// <summary>
                    /// <para>The keywords that were hit, separated by commas.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("KeyWords")]
                    [Validation(Required=false)]
                    public string KeyWords { get; set; }

                    /// <summary>
                    /// <para>The name of the keyword library.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>测试词库</para>
                    /// </summary>
                    [NameInMap("LibName")]
                    [Validation(Required=false)]
                    public string LibName { get; set; }

                }

                /// <summary>
                /// <para>The description of the label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>未检测出风险</para>
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
                /// <para>The position information of the risk words.</para>
                /// </summary>
                [NameInMap("RiskPositions")]
                [Validation(Required=false)]
                public List<TextModerationPlusResponseBodyDataResultRiskPositions> RiskPositions { get; set; }
                public class TextModerationPlusResponseBodyDataResultRiskPositions : TeaModel {
                    /// <summary>
                    /// <para>The end position of the non-compliant word.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
                    [NameInMap("EndPos")]
                    [Validation(Required=false)]
                    public int? EndPos { get; set; }

                    /// <summary>
                    /// <para>The non-compliant word.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>词A</para>
                    /// </summary>
                    [NameInMap("RiskWord")]
                    [Validation(Required=false)]
                    public string RiskWord { get; set; }

                    /// <summary>
                    /// <para>The start position of the non-compliant word.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("StartPos")]
                    [Validation(Required=false)]
                    public int? StartPos { get; set; }

                }

                /// <summary>
                /// <para>The risk keywords that were hit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX</para>
                /// </summary>
                [NameInMap("RiskWords")]
                [Validation(Required=false)]
                public string RiskWords { get; set; }

            }

            /// <summary>
            /// <para>The risk level.</para>
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
            /// <para>The sensitivity level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S0</para>
            /// </summary>
            [NameInMap("SensitiveLevel")]
            [Validation(Required=false)]
            public string SensitiveLevel { get; set; }

            /// <summary>
            /// <para>The sensitive data detection results.</para>
            /// </summary>
            [NameInMap("SensitiveResult")]
            [Validation(Required=false)]
            public List<TextModerationPlusResponseBodyDataSensitiveResult> SensitiveResult { get; set; }
            public class TextModerationPlusResponseBodyDataSensitiveResult : TeaModel {
                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>省份</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The list of sensitive data.</para>
                /// </summary>
                [NameInMap("SensitiveData")]
                [Validation(Required=false)]
                public List<string> SensitiveData { get; set; }

                /// <summary>
                /// <para>The sensitivity level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S1</para>
                /// </summary>
                [NameInMap("SensitiveLevel")]
                [Validation(Required=false)]
                public string SensitiveLevel { get; set; }

            }

            /// <summary>
            /// <para>The translated content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello</para>
            /// </summary>
            [NameInMap("TranslatedContent")]
            [Validation(Required=false)]
            public string TranslatedContent { get; set; }

        }

        /// <summary>
        /// <para>A human-readable description of the error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
