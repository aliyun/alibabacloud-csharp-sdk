// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetAgentTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAgentTaskResultResponseBodyData Data { get; set; }
        public class GetAgentTaskResultResponseBodyData : TeaModel {
            [NameInMap("Dialogues")]
            [Validation(Required=false)]
            public List<GetAgentTaskResultResponseBodyDataDialogues> Dialogues { get; set; }
            public class GetAgentTaskResultResponseBodyDataDialogues : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>980</para>
                /// </summary>
                [NameInMap("Begin")]
                [Validation(Required=false)]
                public long? Begin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("EmotionValue")]
                [Validation(Required=false)]
                public int? EmotionValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>80000</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public long? End { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>00:08</para>
                /// </summary>
                [NameInMap("HourMinSec")]
                [Validation(Required=false)]
                public string HourMinSec { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>客服</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("SpeechRate")]
                [Validation(Required=false)]
                public int? SpeechRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>你好有什么可以帮您</para>
                /// </summary>
                [NameInMap("Words")]
                [Validation(Required=false)]
                public string Words { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The request ID returned by the large language model service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>106C6CA0-282D-4AF7-85F0-D2D24***</para>
            /// </summary>
            [NameInMap("LlmRequestId")]
            [Validation(Required=false)]
            public string LlmRequestId { get; set; }

            /// <summary>
            /// <para>The result of the computation task.</para>
            /// </summary>
            [NameInMap("Response")]
            [Validation(Required=false)]
            public GetAgentTaskResultResponseBodyDataResponse Response { get; set; }
            public class GetAgentTaskResultResponseBodyDataResponse : TeaModel {
                /// <summary>
                /// <para>The result of the custom prompt.</para>
                /// </summary>
                [NameInMap("CustomerPromptResponse")]
                [Validation(Required=false)]
                public GetAgentTaskResultResponseBodyDataResponseCustomerPromptResponse CustomerPromptResponse { get; set; }
                public class GetAgentTaskResultResponseBodyDataResponseCustomerPromptResponse : TeaModel {
                    /// <summary>
                    /// <para>The result returned by the large language model.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>175/XL the fabric feels very comfortable, looks slim when worn, great clothes super good-looking, quality and feel are top-notch, very satisfied with this purchase</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                /// <summary>
                /// <para>The attribute extraction result.</para>
                /// </summary>
                [NameInMap("FieldResponse")]
                [Validation(Required=false)]
                public GetAgentTaskResultResponseBodyDataResponseFieldResponse FieldResponse { get; set; }
                public class GetAgentTaskResultResponseBodyDataResponseFieldResponse : TeaModel {
                    /// <summary>
                    /// <para>The list of attributes.</para>
                    /// </summary>
                    [NameInMap("FieldVoList")]
                    [Validation(Required=false)]
                    public List<GetAgentTaskResultResponseBodyDataResponseFieldResponseFieldVoList> FieldVoList { get; set; }
                    public class GetAgentTaskResultResponseBodyDataResponseFieldResponseFieldVoList : TeaModel {
                        /// <summary>
                        /// <para>The attribute name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>phone</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The sentences referenced in the reasoning.</para>
                        /// </summary>
                        [NameInMap("OriginalUtterances")]
                        [Validation(Required=false)]
                        public List<int?> OriginalUtterances { get; set; }

                        /// <summary>
                        /// <para>The reasoning for the judgment.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Determined based on the first sentence of the agent</para>
                        /// </summary>
                        [NameInMap("Remarks")]
                        [Validation(Required=false)]
                        public string Remarks { get; set; }

                        /// <summary>
                        /// <para>The attribute value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1234561</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("MultiLevelTagResponse")]
                [Validation(Required=false)]
                public GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponse MultiLevelTagResponse { get; set; }
                public class GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponse : TeaModel {
                    [NameInMap("TagList")]
                    [Validation(Required=false)]
                    public List<GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponseTagList> TagList { get; set; }
                    public class GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponseTagList : TeaModel {
                        [NameInMap("Children")]
                        [Validation(Required=false)]
                        public List<GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponseTagListChildren> Children { get; set; }
                        public class GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponseTagListChildren : TeaModel {
                            [NameInMap("Children")]
                            [Validation(Required=false)]
                            public List<GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponseTagListChildrenChildren> Children { get; set; }
                            public class GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponseTagListChildrenChildren : TeaModel {
                                [NameInMap("Children")]
                                [Validation(Required=false)]
                                public List<GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponseTagListChildrenChildrenChildren> Children { get; set; }
                                public class GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponseTagListChildrenChildrenChildren : TeaModel {
                                    [NameInMap("Children")]
                                    [Validation(Required=false)]
                                    public List<GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponseTagListChildrenChildrenChildrenChildren> Children { get; set; }
                                    public class GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponseTagListChildrenChildrenChildrenChildren : TeaModel {
                                        [NameInMap("Remarks")]
                                        [Validation(Required=false)]
                                        public string Remarks { get; set; }

                                        [NameInMap("TagName")]
                                        [Validation(Required=false)]
                                        public string TagName { get; set; }

                                    }

                                    [NameInMap("Remarks")]
                                    [Validation(Required=false)]
                                    public string Remarks { get; set; }

                                    [NameInMap("TagName")]
                                    [Validation(Required=false)]
                                    public string TagName { get; set; }

                                }

                                [NameInMap("Remarks")]
                                [Validation(Required=false)]
                                public string Remarks { get; set; }

                                [NameInMap("TagName")]
                                [Validation(Required=false)]
                                public string TagName { get; set; }

                            }

                            [NameInMap("Remarks")]
                            [Validation(Required=false)]
                            public string Remarks { get; set; }

                            [NameInMap("TagName")]
                            [Validation(Required=false)]
                            public string TagName { get; set; }

                        }

                        [NameInMap("Remarks")]
                        [Validation(Required=false)]
                        public string Remarks { get; set; }

                        [NameInMap("TagName")]
                        [Validation(Required=false)]
                        public string TagName { get; set; }

                    }

                }

                /// <summary>
                /// <para>The service quality inspection result.</para>
                /// </summary>
                [NameInMap("ServiceInspectionResponse")]
                [Validation(Required=false)]
                public GetAgentTaskResultResponseBodyDataResponseServiceInspectionResponse ServiceInspectionResponse { get; set; }
                public class GetAgentTaskResultResponseBodyDataResponseServiceInspectionResponse : TeaModel {
                    /// <summary>
                    /// <para>The list of inspection items.</para>
                    /// </summary>
                    [NameInMap("ServiceInspectionVoList")]
                    [Validation(Required=false)]
                    public List<GetAgentTaskResultResponseBodyDataResponseServiceInspectionResponseServiceInspectionVoList> ServiceInspectionVoList { get; set; }
                    public class GetAgentTaskResultResponseBodyDataResponseServiceInspectionResponseServiceInspectionVoList : TeaModel {
                        /// <summary>
                        /// <para>The inspection dimension.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Service attitude</para>
                        /// </summary>
                        [NameInMap("Dimension")]
                        [Validation(Required=false)]
                        public string Dimension { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the tag is matched.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("IsMatch")]
                        [Validation(Required=false)]
                        public bool? IsMatch { get; set; }

                        /// <summary>
                        /// <para>The sentences referenced in the reasoning.</para>
                        /// </summary>
                        [NameInMap("OriginalUtterances")]
                        [Validation(Required=false)]
                        public List<string> OriginalUtterances { get; set; }

                        /// <summary>
                        /// <para>The reasoning for the judgment.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Determined based on the first sentence of the agent</para>
                        /// </summary>
                        [NameInMap("Remarks")]
                        [Validation(Required=false)]
                        public string Remarks { get; set; }

                    }

                }

                /// <summary>
                /// <para>The tag categorization result.</para>
                /// </summary>
                [NameInMap("TagCategoryResponse")]
                [Validation(Required=false)]
                public GetAgentTaskResultResponseBodyDataResponseTagCategoryResponse TagCategoryResponse { get; set; }
                public class GetAgentTaskResultResponseBodyDataResponseTagCategoryResponse : TeaModel {
                    /// <summary>
                    /// <para>The list of tags.</para>
                    /// </summary>
                    [NameInMap("TagCategoryVoList")]
                    [Validation(Required=false)]
                    public List<GetAgentTaskResultResponseBodyDataResponseTagCategoryResponseTagCategoryVoList> TagCategoryVoList { get; set; }
                    public class GetAgentTaskResultResponseBodyDataResponseTagCategoryResponseTagCategoryVoList : TeaModel {
                        /// <summary>
                        /// <para>The tag dimension.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Customer intent</para>
                        /// </summary>
                        [NameInMap("Dimension")]
                        [Validation(Required=false)]
                        public string Dimension { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the tag is matched.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("IsMatch")]
                        [Validation(Required=false)]
                        public bool? IsMatch { get; set; }

                        /// <summary>
                        /// <para>The sentences referenced in the reasoning.</para>
                        /// </summary>
                        [NameInMap("OriginalUtterances")]
                        [Validation(Required=false)]
                        public List<string> OriginalUtterances { get; set; }

                        /// <summary>
                        /// <para>The reasoning for the judgment.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Determined based on the first sentence of the agent</para>
                        /// </summary>
                        [NameInMap("Remarks")]
                        [Validation(Required=false)]
                        public string Remarks { get; set; }

                        /// <summary>
                        /// <para>The list of matched labels.</para>
                        /// </summary>
                        [NameInMap("ResultLabels")]
                        [Validation(Required=false)]
                        public List<string> ResultLabels { get; set; }

                    }

                }

                [NameInMap("VoiceprintResponse")]
                [Validation(Required=false)]
                public GetAgentTaskResultResponseBodyDataResponseVoiceprintResponse VoiceprintResponse { get; set; }
                public class GetAgentTaskResultResponseBodyDataResponseVoiceprintResponse : TeaModel {
                    [NameInMap("Dialogue")]
                    [Validation(Required=false)]
                    public List<GetAgentTaskResultResponseBodyDataResponseVoiceprintResponseDialogue> Dialogue { get; set; }
                    public class GetAgentTaskResultResponseBodyDataResponseVoiceprintResponseDialogue : TeaModel {
                        [NameInMap("Additions")]
                        [Validation(Required=false)]
                        public GetAgentTaskResultResponseBodyDataResponseVoiceprintResponseDialogueAdditions Additions { get; set; }
                        public class GetAgentTaskResultResponseBodyDataResponseVoiceprintResponseDialogueAdditions : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>38</para>
                            /// </summary>
                            [NameInMap("Age")]
                            [Validation(Required=false)]
                            public string Age { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>中年</para>
                            /// </summary>
                            [NameInMap("AgeGroup")]
                            [Validation(Required=false)]
                            public string AgeGroup { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0.9</para>
                            /// </summary>
                            [NameInMap("AgeScore")]
                            [Validation(Required=false)]
                            public float? AgeScore { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0.6</para>
                            /// </summary>
                            [NameInMap("BestVoiceprintScore")]
                            [Validation(Required=false)]
                            public float? BestVoiceprintScore { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>中立/neutral</para>
                            /// </summary>
                            [NameInMap("Emotion")]
                            [Validation(Required=false)]
                            public string Emotion { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0.9</para>
                            /// </summary>
                            [NameInMap("EmotionScore")]
                            [Validation(Required=false)]
                            public float? EmotionScore { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>女</para>
                            /// </summary>
                            [NameInMap("Gender")]
                            [Validation(Required=false)]
                            public string Gender { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0.8</para>
                            /// </summary>
                            [NameInMap("GenderScore")]
                            [Validation(Required=false)]
                            public float? GenderScore { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("IsKnownVoiceprint")]
                            [Validation(Required=false)]
                            public bool? IsKnownVoiceprint { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>12</para>
                            /// </summary>
                            [NameInMap("Speaker")]
                            [Validation(Required=false)]
                            public string Speaker { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>443</para>
                        /// </summary>
                        [NameInMap("Begin")]
                        [Validation(Required=false)]
                        public long? Begin { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1767492840000</para>
                        /// </summary>
                        [NameInMap("End")]
                        [Validation(Required=false)]
                        public long? End { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>不清楚</para>
                        /// </summary>
                        [NameInMap("Words")]
                        [Validation(Required=false)]
                        public string Words { get; set; }

                    }

                    [NameInMap("Errors")]
                    [Validation(Required=false)]
                    public List<GetAgentTaskResultResponseBodyDataResponseVoiceprintResponseErrors> Errors { get; set; }
                    public class GetAgentTaskResultResponseBodyDataResponseVoiceprintResponseErrors : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>200</para>
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>successful</para>
                        /// </summary>
                        [NameInMap("Message")]
                        [Validation(Required=false)]
                        public string Message { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: pending.</description></item>
            /// <item><description>2: running.</description></item>
            /// <item><description>3: succeeded.</description></item>
            /// <item><description>4: failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A6BEC8D-9A5B-4BE5-8432-4F635E***</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public GetAgentTaskResultResponseBodyDataUsage Usage { get; set; }
            public class GetAgentTaskResultResponseBodyDataUsage : TeaModel {
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public string InputTokens { get; set; }

                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public string OutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public string TotalTokens { get; set; }

                [NameInMap("TymxPlusCount")]
                [Validation(Required=false)]
                public string TymxPlusCount { get; set; }

                [NameInMap("TymxTurboCount")]
                [Validation(Required=false)]
                public string TymxTurboCount { get; set; }

            }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6fa76916-3ce6-45d8-ac64-01b7f31***</para>
            /// </summary>
            [NameInMap("Vid")]
            [Validation(Required=false)]
            public string Vid { get; set; }

        }

        /// <summary>
        /// <para>The error message returned when an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F190ADE9-619A-447D-84E3-7E241A5C428E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. You can use this field to determine whether the request was successful:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: successful.</description></item>
        /// <item><description><b>false/null</b>: failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
