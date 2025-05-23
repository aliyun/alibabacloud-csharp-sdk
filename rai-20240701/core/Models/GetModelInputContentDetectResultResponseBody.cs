// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class GetModelInputContentDetectResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>00000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DetectResultList")]
        [Validation(Required=false)]
        public List<GetModelInputContentDetectResultResponseBodyDetectResultList> DetectResultList { get; set; }
        public class GetModelInputContentDetectResultResponseBodyDetectResultList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RiskResult")]
            [Validation(Required=false)]
            public int? RiskResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("TraceInfo")]
            [Validation(Required=false)]
            public GetModelInputContentDetectResultResponseBodyDetectResultListTraceInfo TraceInfo { get; set; }
            public class GetModelInputContentDetectResultResponseBodyDetectResultListTraceInfo : TeaModel {
                [NameInMap("BlockWord")]
                [Validation(Required=false)]
                public GetModelInputContentDetectResultResponseBodyDetectResultListTraceInfoBlockWord BlockWord { get; set; }
                public class GetModelInputContentDetectResultResponseBodyDetectResultListTraceInfoBlockWord : TeaModel {
                    [NameInMap("BlockWordGroupInfoList")]
                    [Validation(Required=false)]
                    public List<GetModelInputContentDetectResultResponseBodyDetectResultListTraceInfoBlockWordBlockWordGroupInfoList> BlockWordGroupInfoList { get; set; }
                    public class GetModelInputContentDetectResultResponseBodyDetectResultListTraceInfoBlockWordBlockWordGroupInfoList : TeaModel {
                        [NameInMap("BlockWordList")]
                        [Validation(Required=false)]
                        public List<GetModelInputContentDetectResultResponseBodyDetectResultListTraceInfoBlockWordBlockWordGroupInfoListBlockWordList> BlockWordList { get; set; }
                        public class GetModelInputContentDetectResultResponseBodyDetectResultListTraceInfoBlockWordBlockWordGroupInfoListBlockWordList : TeaModel {
                            [NameInMap("Word")]
                            [Validation(Required=false)]
                            public string Word { get; set; }

                            [NameInMap("WordLabel")]
                            [Validation(Required=false)]
                            public string WordLabel { get; set; }

                        }

                        [NameInMap("GroupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("RiskResult")]
                    [Validation(Required=false)]
                    public int? RiskResult { get; set; }

                }

                [NameInMap("HarmfulCategories")]
                [Validation(Required=false)]
                public GetModelInputContentDetectResultResponseBodyDetectResultListTraceInfoHarmfulCategories HarmfulCategories { get; set; }
                public class GetModelInputContentDetectResultResponseBodyDetectResultListTraceInfoHarmfulCategories : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.85</para>
                    /// </summary>
                    [NameInMap("ConfidenceScore")]
                    [Validation(Required=false)]
                    public double? ConfidenceScore { get; set; }

                    [NameInMap("HarmfulCategoryInfoList")]
                    [Validation(Required=false)]
                    public List<GetModelInputContentDetectResultResponseBodyDetectResultListTraceInfoHarmfulCategoriesHarmfulCategoryInfoList> HarmfulCategoryInfoList { get; set; }
                    public class GetModelInputContentDetectResultResponseBodyDetectResultListTraceInfoHarmfulCategoriesHarmfulCategoryInfoList : TeaModel {
                        [NameInMap("CategoryLabel")]
                        [Validation(Required=false)]
                        public string CategoryLabel { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("CategoryType")]
                        [Validation(Required=false)]
                        public int? CategoryType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("RiskResult")]
                        [Validation(Required=false)]
                        public int? RiskResult { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("SecurityLevel")]
                        [Validation(Required=false)]
                        public int? SecurityLevel { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("RiskResult")]
                    [Validation(Required=false)]
                    public int? RiskResult { get; set; }

                }

                [NameInMap("PromptAttack")]
                [Validation(Required=false)]
                public GetModelInputContentDetectResultResponseBodyDetectResultListTraceInfoPromptAttack PromptAttack { get; set; }
                public class GetModelInputContentDetectResultResponseBodyDetectResultListTraceInfoPromptAttack : TeaModel {
                    [NameInMap("PromptAttackInfo")]
                    [Validation(Required=false)]
                    public string PromptAttackInfo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("RiskResult")]
                    [Validation(Required=false)]
                    public int? RiskResult { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SecurityLevel")]
                    [Validation(Required=false)]
                    public int? SecurityLevel { get; set; }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProcessedCount")]
        [Validation(Required=false)]
        public int? ProcessedCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5d85cd38-03b2-49fd-86b2-be85c4b13215</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public int? TaskStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
