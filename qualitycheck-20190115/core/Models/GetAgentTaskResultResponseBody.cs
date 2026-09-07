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
            /// <summary>
            /// <para>The dialogue data.</para>
            /// </summary>
            [NameInMap("Dialogues")]
            [Validation(Required=false)]
            public List<GetAgentTaskResultResponseBodyDataDialogues> Dialogues { get; set; }
            public class GetAgentTaskResultResponseBodyDataDialogues : TeaModel {
                /// <summary>
                /// <para>The offset of the start time of this sentence relative to the overall start time of the dialogue, in milliseconds. For example, if the total recording duration is 2 minutes and 10 seconds, and a sentence spoken by the customer starts at 1 minute and 12 seconds and ends at 1 minute and 20 seconds, the value of begin is 72000 and the value of end is 80000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>980</para>
                /// </summary>
                [NameInMap("Begin")]
                [Validation(Required=false)]
                public long? Begin { get; set; }

                /// <summary>
                /// <para>The emotion energy value, calculated as the volume in decibels divided by 10. Valid values: 1 to 10. A higher value indicates a stronger emotion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("EmotionValue")]
                [Validation(Required=false)]
                public int? EmotionValue { get; set; }

                /// <summary>
                /// <para>The offset of the start time of this sentence relative to the overall start time of the dialogue, in milliseconds. For example, if the total recording duration is 2 minutes and 10 seconds, and a sentence spoken by the customer starts at 1 minute and 12 seconds and ends at 1 minute and 20 seconds, the value of begin is 72000 and the value of end is 80000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80000</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public long? End { get; set; }

                /// <summary>
                /// <para>The start time of this sentence in hours, minutes, and seconds format: hh:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:08</para>
                /// </summary>
                [NameInMap("HourMinSec")]
                [Validation(Required=false)]
                public string HourMinSec { get; set; }

                /// <summary>
                /// <para>The role of the speaker for this sentence. Valid values: agent and customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The average speech rate of this sentence. Unit: words per minute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("SpeechRate")]
                [Validation(Required=false)]
                public int? SpeechRate { get; set; }

                /// <summary>
                /// <para>The dialogue content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hello, how can I help you</para>
                /// </summary>
                [NameInMap("Words")]
                [Validation(Required=false)]
                public string Words { get; set; }

            }

            /// <summary>
            /// <para>The error details when the status is not 0 or 1.</para>
            /// 
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
                    /// <para>175/xl the fabric feels very comfortable, looks slim when worn, great clothes super good looking, quality and feel are top-notch, very satisfied with this purchase</para>
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
                        /// <para>Determined from the first sentence of the customer service representative</para>
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
                    /// <summary>
                    /// <para>The list of child nodes.</para>
                    /// </summary>
                    [NameInMap("TagList")]
                    [Validation(Required=false)]
                    public List<GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponseTagList> TagList { get; set; }
                    public class GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponseTagList : TeaModel {
                        /// <summary>
                        /// <para>The list of child nodes.</para>
                        /// </summary>
                        [NameInMap("Children")]
                        [Validation(Required=false)]
                        public List<GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponseTagListChildren> Children { get; set; }
                        public class GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponseTagListChildren : TeaModel {
                            /// <summary>
                            /// <para>The tag analysis description.</para>
                            /// </summary>
                            [NameInMap("Children")]
                            [Validation(Required=false)]
                            public List<GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponseTagListChildrenChildren> Children { get; set; }
                            public class GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponseTagListChildrenChildren : TeaModel {
                                /// <summary>
                                /// <para>The tag name.</para>
                                /// </summary>
                                [NameInMap("Children")]
                                [Validation(Required=false)]
                                public List<GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponseTagListChildrenChildrenChildren> Children { get; set; }
                                public class GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponseTagListChildrenChildrenChildren : TeaModel {
                                    /// <summary>
                                    /// <para>The list of child nodes.</para>
                                    /// </summary>
                                    [NameInMap("Children")]
                                    [Validation(Required=false)]
                                    public List<GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponseTagListChildrenChildrenChildrenChildren> Children { get; set; }
                                    public class GetAgentTaskResultResponseBodyDataResponseMultiLevelTagResponseTagListChildrenChildrenChildrenChildren : TeaModel {
                                        /// <summary>
                                        /// <para>The tag analysis description.</para>
                                        /// </summary>
                                        [NameInMap("Remarks")]
                                        [Validation(Required=false)]
                                        public string Remarks { get; set; }

                                        /// <summary>
                                        /// <para>The tag name.</para>
                                        /// </summary>
                                        [NameInMap("TagName")]
                                        [Validation(Required=false)]
                                        public string TagName { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>The tag analysis description.</para>
                                    /// </summary>
                                    [NameInMap("Remarks")]
                                    [Validation(Required=false)]
                                    public string Remarks { get; set; }

                                    /// <summary>
                                    /// <para>The tag name.</para>
                                    /// </summary>
                                    [NameInMap("TagName")]
                                    [Validation(Required=false)]
                                    public string TagName { get; set; }

                                }

                                /// <summary>
                                /// <para>The tag analysis description.</para>
                                /// </summary>
                                [NameInMap("Remarks")]
                                [Validation(Required=false)]
                                public string Remarks { get; set; }

                                /// <summary>
                                /// <para>The tag name.</para>
                                /// </summary>
                                [NameInMap("TagName")]
                                [Validation(Required=false)]
                                public string TagName { get; set; }

                            }

                            /// <summary>
                            /// <para>The tag analysis description.</para>
                            /// </summary>
                            [NameInMap("Remarks")]
                            [Validation(Required=false)]
                            public string Remarks { get; set; }

                            /// <summary>
                            /// <para>The tag name.</para>
                            /// </summary>
                            [NameInMap("TagName")]
                            [Validation(Required=false)]
                            public string TagName { get; set; }

                        }

                        /// <summary>
                        /// <para>The tag analysis description.</para>
                        /// </summary>
                        [NameInMap("Remarks")]
                        [Validation(Required=false)]
                        public string Remarks { get; set; }

                        /// <summary>
                        /// <para>The tag name.</para>
                        /// </summary>
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
                        /// <para>Determined from the first sentence of the customer service representative</para>
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
                        /// <para>Determined from the first sentence of the customer service representative</para>
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
                    /// <summary>
                    /// <para>The dialogue corpus.</para>
                    /// </summary>
                    [NameInMap("Dialogue")]
                    [Validation(Required=false)]
                    public List<GetAgentTaskResultResponseBodyDataResponseVoiceprintResponseDialogue> Dialogue { get; set; }
                    public class GetAgentTaskResultResponseBodyDataResponseVoiceprintResponseDialogue : TeaModel {
                        [NameInMap("Additions")]
                        [Validation(Required=false)]
                        public GetAgentTaskResultResponseBodyDataResponseVoiceprintResponseDialogueAdditions Additions { get; set; }
                        public class GetAgentTaskResultResponseBodyDataResponseVoiceprintResponseDialogueAdditions : TeaModel {
                            /// <summary>
                            /// <para>The age.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>38</para>
                            /// </summary>
                            [NameInMap("Age")]
                            [Validation(Required=false)]
                            public string Age { get; set; }

                            /// <summary>
                            /// <para>The age group (child, middle-aged, or elderly).</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Middle-aged</para>
                            /// </summary>
                            [NameInMap("AgeGroup")]
                            [Validation(Required=false)]
                            public string AgeGroup { get; set; }

                            /// <summary>
                            /// <para>The age group confidence score.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0.9</para>
                            /// </summary>
                            [NameInMap("AgeScore")]
                            [Validation(Required=false)]
                            public float? AgeScore { get; set; }

                            /// <summary>
                            /// <para>The highest voiceprint score.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0.6</para>
                            /// </summary>
                            [NameInMap("BestVoiceprintScore")]
                            [Validation(Required=false)]
                            public float? BestVoiceprintScore { get; set; }

                            /// <summary>
                            /// <para>The emotion type. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>angry</description></item>
                            /// <item><description>disgusted</description></item>
                            /// <item><description>fearful</description></item>
                            /// <item><description>happy</description></item>
                            /// <item><description>neutral</description></item>
                            /// <item><description>other</description></item>
                            /// <item><description>sad</description></item>
                            /// <item><description>surprised</description></item>
                            /// <item><description>unknown</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>neutral</para>
                            /// </summary>
                            [NameInMap("Emotion")]
                            [Validation(Required=false)]
                            public string Emotion { get; set; }

                            /// <summary>
                            /// <para>The emotion confidence score.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0.9</para>
                            /// </summary>
                            [NameInMap("EmotionScore")]
                            [Validation(Required=false)]
                            public float? EmotionScore { get; set; }

                            /// <summary>
                            /// <para>The gender.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Female</para>
                            /// </summary>
                            [NameInMap("Gender")]
                            [Validation(Required=false)]
                            public string Gender { get; set; }

                            /// <summary>
                            /// <para>The gender confidence score.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0.8</para>
                            /// </summary>
                            [NameInMap("GenderScore")]
                            [Validation(Required=false)]
                            public float? GenderScore { get; set; }

                            /// <summary>
                            /// <para>Indicates whether the speaker is the voiceprint owner.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("IsKnownVoiceprint")]
                            [Validation(Required=false)]
                            public bool? IsKnownVoiceprint { get; set; }

                            /// <summary>
                            /// <para>The speaker.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>12</para>
                            /// </summary>
                            [NameInMap("Speaker")]
                            [Validation(Required=false)]
                            public string Speaker { get; set; }

                        }

                        /// <summary>
                        /// <para>The start time of this sentence, which is the offset from the starting point in milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>443</para>
                        /// </summary>
                        [NameInMap("Begin")]
                        [Validation(Required=false)]
                        public long? Begin { get; set; }

                        /// <summary>
                        /// <para>The end time of this sentence, which is the offset from the starting point in milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1767492840000</para>
                        /// </summary>
                        [NameInMap("End")]
                        [Validation(Required=false)]
                        public long? End { get; set; }

                        /// <summary>
                        /// <para>The dialogue content.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Unclear</para>
                        /// </summary>
                        [NameInMap("Words")]
                        [Validation(Required=false)]
                        public string Words { get; set; }

                    }

                    /// <summary>
                    /// <para>The error information of each sub-publishing module. The key is the sub-publishing module and the value is the error message.</para>
                    /// </summary>
                    [NameInMap("Errors")]
                    [Validation(Required=false)]
                    public List<GetAgentTaskResultResponseBodyDataResponseVoiceprintResponseErrors> Errors { get; set; }
                    public class GetAgentTaskResultResponseBodyDataResponseVoiceprintResponseErrors : TeaModel {
                        /// <summary>
                        /// <para>The result code. A value of <b>200</b> indicates success. Any other value indicates failure. You can use this field to determine the cause of failure.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>200</para>
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// <para>The error details when an error occurs, or <b>successful</b> when the operation succeeds.</para>
                        /// 
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
            /// <item><description>1: pending</description></item>
            /// <item><description>2: running</description></item>
            /// <item><description>3: succeeded</description></item>
            /// <item><description>4: failed</description></item>
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

            /// <summary>
            /// <para>The token usage information.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public GetAgentTaskResultResponseBodyDataUsage Usage { get; set; }
            public class GetAgentTaskResultResponseBodyDataUsage : TeaModel {
                /// <summary>
                /// <para>The number of input tokens consumed by the LLM.</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public string InputTokens { get; set; }

                /// <summary>
                /// <para>The number of output tokens generated by the LLM.</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public string OutputTokens { get; set; }

                /// <summary>
                /// <para>The total number of tokens consumed by this task.</para>
                /// 
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
        /// <para>Indicates whether the request is successful. You can use this field to determine whether the request is successful:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false/null</b>: The request failed.</description></item>
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
