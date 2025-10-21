// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class GetModelOutputContentDetectResultResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code, 00000 indicates success; others indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>List of detection result objects</para>
        /// </summary>
        [NameInMap("DetectResultList")]
        [Validation(Required=false)]
        public List<GetModelOutputContentDetectResultResponseBodyDetectResultList> DetectResultList { get; set; }
        public class GetModelOutputContentDetectResultResponseBodyDetectResultList : TeaModel {
            /// <summary>
            /// <para>0: No risk
            /// 1: Risk exists</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RiskResult")]
            [Validation(Required=false)]
            public int? RiskResult { get; set; }

            /// <summary>
            /// <para>0: Queued
            /// 1: Processing
            /// 2: Completed
            /// 3: Failed</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Inspection results</para>
            /// </summary>
            [NameInMap("TraceInfo")]
            [Validation(Required=false)]
            public GetModelOutputContentDetectResultResponseBodyDetectResultListTraceInfo TraceInfo { get; set; }
            public class GetModelOutputContentDetectResultResponseBodyDetectResultListTraceInfo : TeaModel {
                /// <summary>
                /// <para>Detected keywords</para>
                /// </summary>
                [NameInMap("BlockWord")]
                [Validation(Required=false)]
                public GetModelOutputContentDetectResultResponseBodyDetectResultListTraceInfoBlockWord BlockWord { get; set; }
                public class GetModelOutputContentDetectResultResponseBodyDetectResultListTraceInfoBlockWord : TeaModel {
                    /// <summary>
                    /// <para>List of keyword detection result objects</para>
                    /// </summary>
                    [NameInMap("BlockWordGroupInfoList")]
                    [Validation(Required=false)]
                    public List<GetModelOutputContentDetectResultResponseBodyDetectResultListTraceInfoBlockWordBlockWordGroupInfoList> BlockWordGroupInfoList { get; set; }
                    public class GetModelOutputContentDetectResultResponseBodyDetectResultListTraceInfoBlockWordBlockWordGroupInfoList : TeaModel {
                        /// <summary>
                        /// <para>List of keyword detection results</para>
                        /// </summary>
                        [NameInMap("BlockWordList")]
                        [Validation(Required=false)]
                        public List<GetModelOutputContentDetectResultResponseBodyDetectResultListTraceInfoBlockWordBlockWordGroupInfoListBlockWordList> BlockWordList { get; set; }
                        public class GetModelOutputContentDetectResultResponseBodyDetectResultListTraceInfoBlockWordBlockWordGroupInfoListBlockWordList : TeaModel {
                            /// <summary>
                            /// <para>Word</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>testWord</para>
                            /// </summary>
                            [NameInMap("Word")]
                            [Validation(Required=false)]
                            public string Word { get; set; }

                            /// <summary>
                            /// <para>Label</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>testLabel</para>
                            /// </summary>
                            [NameInMap("WordLabel")]
                            [Validation(Required=false)]
                            public string WordLabel { get; set; }

                        }

                        /// <summary>
                        /// <para>Keyword group name</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testGroup</para>
                        /// </summary>
                        [NameInMap("GroupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                    }

                    /// <summary>
                    /// <para>0: No risk
                    /// 1: Risk exists</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("RiskResult")]
                    [Validation(Required=false)]
                    public int? RiskResult { get; set; }

                }

                /// <summary>
                /// <para>Sensitive topic object list</para>
                /// </summary>
                [NameInMap("DenyTopics")]
                [Validation(Required=false)]
                public GetModelOutputContentDetectResultResponseBodyDetectResultListTraceInfoDenyTopics DenyTopics { get; set; }
                public class GetModelOutputContentDetectResultResponseBodyDetectResultListTraceInfoDenyTopics : TeaModel {
                    /// <summary>
                    /// <para>Confidence score</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("ConfidenceScore")]
                    [Validation(Required=false)]
                    public double? ConfidenceScore { get; set; }

                    /// <summary>
                    /// <para>0: No risk
                    /// 1: Risk exists</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("RiskResult")]
                    [Validation(Required=false)]
                    public int? RiskResult { get; set; }

                    /// <summary>
                    /// <para>List of sensitive topics</para>
                    /// </summary>
                    [NameInMap("TopicInfoList")]
                    [Validation(Required=false)]
                    public List<GetModelOutputContentDetectResultResponseBodyDetectResultListTraceInfoDenyTopicsTopicInfoList> TopicInfoList { get; set; }
                    public class GetModelOutputContentDetectResultResponseBodyDetectResultListTraceInfoDenyTopicsTopicInfoList : TeaModel {
                        /// <summary>
                        /// <para>0: Text
                        /// 1: Image</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("CategoryType")]
                        [Validation(Required=false)]
                        public int? CategoryType { get; set; }

                        /// <summary>
                        /// <para>0: No risk
                        /// 1: Risk exists</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("RiskResult")]
                        [Validation(Required=false)]
                        public int? RiskResult { get; set; }

                        /// <summary>
                        /// <para>Security level
                        /// 0: Low
                        /// 1: Medium
                        /// 2: High</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("SecurityLevel")]
                        [Validation(Required=false)]
                        public int? SecurityLevel { get; set; }

                        /// <summary>
                        /// <para>Topic name</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Buss.</para>
                        /// </summary>
                        [NameInMap("TopicName")]
                        [Validation(Required=false)]
                        public string TopicName { get; set; }

                    }

                }

                /// <summary>
                /// <para>List of harmful category result objects</para>
                /// </summary>
                [NameInMap("HarmfulCategories")]
                [Validation(Required=false)]
                public GetModelOutputContentDetectResultResponseBodyDetectResultListTraceInfoHarmfulCategories HarmfulCategories { get; set; }
                public class GetModelOutputContentDetectResultResponseBodyDetectResultListTraceInfoHarmfulCategories : TeaModel {
                    /// <summary>
                    /// <para>Confidence score</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("ConfidenceScore")]
                    [Validation(Required=false)]
                    public double? ConfidenceScore { get; set; }

                    /// <summary>
                    /// <para>List of harmful category objects</para>
                    /// </summary>
                    [NameInMap("HarmfulCategoryInfoList")]
                    [Validation(Required=false)]
                    public List<GetModelOutputContentDetectResultResponseBodyDetectResultListTraceInfoHarmfulCategoriesHarmfulCategoryInfoList> HarmfulCategoryInfoList { get; set; }
                    public class GetModelOutputContentDetectResultResponseBodyDetectResultListTraceInfoHarmfulCategoriesHarmfulCategoryInfoList : TeaModel {
                        /// <summary>
                        /// <para>Category name</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Morality</para>
                        /// </summary>
                        [NameInMap("CategoryLabel")]
                        [Validation(Required=false)]
                        public string CategoryLabel { get; set; }

                        /// <summary>
                        /// <para>0: Text
                        /// 1: Image</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("CategoryType")]
                        [Validation(Required=false)]
                        public int? CategoryType { get; set; }

                        /// <summary>
                        /// <para>0: No risk
                        /// 1: Risk exists</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("RiskResult")]
                        [Validation(Required=false)]
                        public int? RiskResult { get; set; }

                        /// <summary>
                        /// <para>Security level
                        /// 0: Low
                        /// 1: Medium
                        /// 2: High</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("SecurityLevel")]
                        [Validation(Required=false)]
                        public int? SecurityLevel { get; set; }

                        /// <summary>
                        /// <para>Sub-category label</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>morality_ethics</para>
                        /// </summary>
                        [NameInMap("SubCategoryLabel")]
                        [Validation(Required=false)]
                        public string SubCategoryLabel { get; set; }

                    }

                    /// <summary>
                    /// <para>0: No risk
                    /// 1: Risk exists</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("RiskResult")]
                    [Validation(Required=false)]
                    public int? RiskResult { get; set; }

                }

                /// <summary>
                /// <para>PromptAttack</para>
                /// </summary>
                [NameInMap("PromptAttack")]
                [Validation(Required=false)]
                public GetModelOutputContentDetectResultResponseBodyDetectResultListTraceInfoPromptAttack PromptAttack { get; set; }
                public class GetModelOutputContentDetectResultResponseBodyDetectResultListTraceInfoPromptAttack : TeaModel {
                    /// <summary>
                    /// <para>Confidence score</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("ConfidenceScore")]
                    [Validation(Required=false)]
                    public double? ConfidenceScore { get; set; }

                    /// <summary>
                    /// <para>Prompt attack detection result object</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Role Play</para>
                    /// </summary>
                    [NameInMap("PromptAttackInfo")]
                    [Validation(Required=false)]
                    public string PromptAttackInfo { get; set; }

                    /// <summary>
                    /// <para>Prompt attack list</para>
                    /// </summary>
                    [NameInMap("PromptAttackInfoList")]
                    [Validation(Required=false)]
                    public List<GetModelOutputContentDetectResultResponseBodyDetectResultListTraceInfoPromptAttackPromptAttackInfoList> PromptAttackInfoList { get; set; }
                    public class GetModelOutputContentDetectResultResponseBodyDetectResultListTraceInfoPromptAttackPromptAttackInfoList : TeaModel {
                        /// <summary>
                        /// <para>Category name</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Role Play</para>
                        /// </summary>
                        [NameInMap("CategoryLabel")]
                        [Validation(Required=false)]
                        public string CategoryLabel { get; set; }

                        /// <summary>
                        /// <para>0: Text
                        /// 1: Image</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("CategoryType")]
                        [Validation(Required=false)]
                        public int? CategoryType { get; set; }

                        /// <summary>
                        /// <para>0: No risk
                        /// 1: Risk exists</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("RiskResult")]
                        [Validation(Required=false)]
                        public int? RiskResult { get; set; }

                        /// <summary>
                        /// <para>Security level
                        /// 0: Low
                        /// 1: Medium
                        /// 2: High</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("SecurityLevel")]
                        [Validation(Required=false)]
                        public int? SecurityLevel { get; set; }

                    }

                    /// <summary>
                    /// <para>0: No risk
                    /// 1: Risk exists</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("RiskResult")]
                    [Validation(Required=false)]
                    public int? RiskResult { get; set; }

                    /// <summary>
                    /// <para>Security level
                    /// 0: Low
                    /// 1: Medium
                    /// 2: High</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SecurityLevel")]
                    [Validation(Required=false)]
                    public int? SecurityLevel { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Number of processed items in the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProcessedCount")]
        [Validation(Required=false)]
        public int? ProcessedCount { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the operation was successful. true indicates success, false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5d85cd38-03b2-49fd-86b2-be85c4b13215</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>Task processing status:
        /// 0: Queued
        /// 1: Processing
        /// 2: Completed
        /// 3: Failed</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public int? TaskStatus { get; set; }

        /// <summary>
        /// <para>Total number of items</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
