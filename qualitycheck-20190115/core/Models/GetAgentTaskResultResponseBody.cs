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
            /// <para>The number of input tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("InputTokens")]
            [Validation(Required=false)]
            public string InputTokens { get; set; }

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
            /// <para>The number of output tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("OutputTokens")]
            [Validation(Required=false)]
            public string OutputTokens { get; set; }

            /// <summary>
            /// <para>The result of the computing task.</para>
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
                    /// <para>175/xl面料摸着很舒服,穿起来看着也挺修身的挺好的好衣服超好看,质量手感没得说一级棒,很满意的一次购物。</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                /// <summary>
                /// <para>The property extraction result.</para>
                /// </summary>
                [NameInMap("FieldResponse")]
                [Validation(Required=false)]
                public GetAgentTaskResultResponseBodyDataResponseFieldResponse FieldResponse { get; set; }
                public class GetAgentTaskResultResponseBodyDataResponseFieldResponse : TeaModel {
                    /// <summary>
                    /// <para>The list of properties.</para>
                    /// </summary>
                    [NameInMap("FieldVoList")]
                    [Validation(Required=false)]
                    public List<GetAgentTaskResultResponseBodyDataResponseFieldResponseFieldVoList> FieldVoList { get; set; }
                    public class GetAgentTaskResultResponseBodyDataResponseFieldResponseFieldVoList : TeaModel {
                        /// <summary>
                        /// <para>The property name.</para>
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
                        /// <para>通过客服第一句话判断</para>
                        /// </summary>
                        [NameInMap("Remarks")]
                        [Validation(Required=false)]
                        public string Remarks { get; set; }

                        /// <summary>
                        /// <para>The property value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1234561</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

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
                        /// <para>服务态度</para>
                        /// </summary>
                        [NameInMap("Dimension")]
                        [Validation(Required=false)]
                        public string Dimension { get; set; }

                        /// <summary>
                        /// <para>Indicates whether a match is found.</para>
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
                        /// <para>通过客服第一句话判断</para>
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
                    /// <para>The list of labels.</para>
                    /// </summary>
                    [NameInMap("TagCategoryVoList")]
                    [Validation(Required=false)]
                    public List<GetAgentTaskResultResponseBodyDataResponseTagCategoryResponseTagCategoryVoList> TagCategoryVoList { get; set; }
                    public class GetAgentTaskResultResponseBodyDataResponseTagCategoryResponseTagCategoryVoList : TeaModel {
                        /// <summary>
                        /// <para>The label dimension.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>客户意图</para>
                        /// </summary>
                        [NameInMap("Dimension")]
                        [Validation(Required=false)]
                        public string Dimension { get; set; }

                        /// <summary>
                        /// <para>Indicates whether a match is found.</para>
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
                        /// <para>通过客服第一句话判断</para>
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
            /// <para>The total number of tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("TotalTokens")]
            [Validation(Required=false)]
            public string TotalTokens { get; set; }

            /// <summary>
            /// <para>The number of times the plus model is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TyxmPlusCount")]
            [Validation(Required=false)]
            public string TyxmPlusCount { get; set; }

            /// <summary>
            /// <para>The number of times the turbo model is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TyxmTurboCount")]
            [Validation(Required=false)]
            public string TyxmTurboCount { get; set; }

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
        /// <item><description><b>true</b>: The request was successful.</description></item>
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
