// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetLabelAnalysisResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success. Other values indicate failure. You can use this field to determine the cause of the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLabelAnalysisResultResponseBodyData Data { get; set; }
        public class GetLabelAnalysisResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The total number of input tokens for this task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7371</para>
            /// </summary>
            [NameInMap("InputTokens")]
            [Validation(Required=false)]
            public long? InputTokens { get; set; }

            /// <summary>
            /// <para>The total number of output tokens for this task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>355</para>
            /// </summary>
            [NameInMap("OutputTokens")]
            [Validation(Required=false)]
            public long? OutputTokens { get; set; }

            /// <summary>
            /// <para>The tree-structured tag results.</para>
            /// </summary>
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<GetLabelAnalysisResultResponseBodyDataTagList> TagList { get; set; }
            public class GetLabelAnalysisResultResponseBodyDataTagList : TeaModel {
                /// <summary>
                /// <para>The list of child nodes.</para>
                /// </summary>
                [NameInMap("Children")]
                [Validation(Required=false)]
                public List<GetLabelAnalysisResultResponseBodyDataTagListChildren> Children { get; set; }
                public class GetLabelAnalysisResultResponseBodyDataTagListChildren : TeaModel {
                    /// <summary>
                    /// <para>The list of child nodes.</para>
                    /// </summary>
                    [NameInMap("Children")]
                    [Validation(Required=false)]
                    public List<GetLabelAnalysisResultResponseBodyDataTagListChildrenChildren> Children { get; set; }
                    public class GetLabelAnalysisResultResponseBodyDataTagListChildrenChildren : TeaModel {
                        /// <summary>
                        /// <para>The list of child nodes.</para>
                        /// </summary>
                        [NameInMap("Children")]
                        [Validation(Required=false)]
                        public List<GetLabelAnalysisResultResponseBodyDataTagListChildrenChildrenChildren> Children { get; set; }
                        public class GetLabelAnalysisResultResponseBodyDataTagListChildrenChildrenChildren : TeaModel {
                            /// <summary>
                            /// <para>The list of child nodes.</para>
                            /// </summary>
                            [NameInMap("Children")]
                            [Validation(Required=false)]
                            public List<GetLabelAnalysisResultResponseBodyDataTagListChildrenChildrenChildrenChildren> Children { get; set; }
                            public class GetLabelAnalysisResultResponseBodyDataTagListChildrenChildrenChildrenChildren : TeaModel {
                                /// <summary>
                                /// <para>The tag analysis description.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>No valid tag was matched at the current level</para>
                                /// </summary>
                                [NameInMap("Remarks")]
                                [Validation(Required=false)]
                                public string Remarks { get; set; }

                                /// <summary>
                                /// <para>The tag name.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>Invalid session</para>
                                /// </summary>
                                [NameInMap("TagName")]
                                [Validation(Required=false)]
                                public string TagName { get; set; }

                            }

                            /// <summary>
                            /// <para>The tag analysis description.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The user failed to pay 17 CNY for an Amap ride-hailing service within Qwen. After switching to Alipay, the price changed to the original price. Customer service investigated the payment failure, balance, real-name verification, and authorization binding. The issue occurred in the scenario where Qwen calls the Amap ride-hailing service, which belongs to Qwen × Amap</para>
                            /// </summary>
                            [NameInMap("Remarks")]
                            [Validation(Required=false)]
                            public string Remarks { get; set; }

                            /// <summary>
                            /// <para>The tag name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Qwen × Amap</para>
                            /// </summary>
                            [NameInMap("TagName")]
                            [Validation(Required=false)]
                            public string TagName { get; set; }

                        }

                        /// <summary>
                        /// <para>The tag analysis description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The user failed to pay 17 CNY for an Amap ride-hailing service within Qwen. After switching to Alipay, the price changed to the original price. Customer service investigated the payment failure, balance, real-name verification, and authorization binding. The issue occurred in the scenario where Qwen calls the Amap ride-hailing service, which belongs to Qwen × Amap</para>
                        /// </summary>
                        [NameInMap("Remarks")]
                        [Validation(Required=false)]
                        public string Remarks { get; set; }

                        /// <summary>
                        /// <para>The tag name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Qwen × Amap</para>
                        /// </summary>
                        [NameInMap("TagName")]
                        [Validation(Required=false)]
                        public string TagName { get; set; }

                    }

                    /// <summary>
                    /// <para>The tag analysis description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The user failed to pay 17 CNY for an Amap ride-hailing service within Qwen. After switching to Alipay, the price changed to the original price. Customer service investigated the payment failure, balance, real-name verification, and authorization binding. The issue occurred in the scenario where Qwen calls the Amap ride-hailing service, which belongs to Qwen × Amap</para>
                    /// </summary>
                    [NameInMap("Remarks")]
                    [Validation(Required=false)]
                    public string Remarks { get; set; }

                    /// <summary>
                    /// <para>The tag name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Qwen × Amap</para>
                    /// </summary>
                    [NameInMap("TagName")]
                    [Validation(Required=false)]
                    public string TagName { get; set; }

                }

                /// <summary>
                /// <para>The tag analysis description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The user failed to pay 17 CNY for an Amap ride-hailing service within Qwen. After switching to Alipay, the price changed to the original price. Customer service investigated the payment failure, balance, real-name verification, and authorization binding. The issue occurred in the scenario where Qwen calls the Amap ride-hailing service, which belongs to Qwen × Amap</para>
                /// </summary>
                [NameInMap("Remarks")]
                [Validation(Required=false)]
                public string Remarks { get; set; }

                /// <summary>
                /// <para>The tag name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Qwen × Amap</para>
                /// </summary>
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

            /// <summary>
            /// <para>The total number of tokens for this task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7726</para>
            /// </summary>
            [NameInMap("TotalTokens")]
            [Validation(Required=false)]
            public long? TotalTokens { get; set; }

            /// <summary>
            /// <para>The total number of times the Qwen-Plus model was called for this task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TyxmPlusCount")]
            [Validation(Required=false)]
            public long? TyxmPlusCount { get; set; }

            /// <summary>
            /// <para>The total number of times the Qwen-Turbo model was called for this task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TyxmTurboCount")]
            [Validation(Required=false)]
            public long? TyxmTurboCount { get; set; }

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
        /// <para>3CEA0495-341B-4482-9AD9-8191EF4***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values: true: The call was successful. false: The call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
