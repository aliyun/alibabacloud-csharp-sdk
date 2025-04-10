// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class ModelOutputContentSyncDetectResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>00000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("RiskInfo")]
        [Validation(Required=false)]
        public string RiskInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RiskResult")]
        [Validation(Required=false)]
        public int? RiskResult { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TraceInfo")]
        [Validation(Required=false)]
        public ModelOutputContentSyncDetectResponseBodyTraceInfo TraceInfo { get; set; }
        public class ModelOutputContentSyncDetectResponseBodyTraceInfo : TeaModel {
            [NameInMap("BlockWord")]
            [Validation(Required=false)]
            public ModelOutputContentSyncDetectResponseBodyTraceInfoBlockWord BlockWord { get; set; }
            public class ModelOutputContentSyncDetectResponseBodyTraceInfoBlockWord : TeaModel {
                [NameInMap("BlockWordGroupInfoList")]
                [Validation(Required=false)]
                public List<ModelOutputContentSyncDetectResponseBodyTraceInfoBlockWordBlockWordGroupInfoList> BlockWordGroupInfoList { get; set; }
                public class ModelOutputContentSyncDetectResponseBodyTraceInfoBlockWordBlockWordGroupInfoList : TeaModel {
                    [NameInMap("BlockWordList")]
                    [Validation(Required=false)]
                    public List<ModelOutputContentSyncDetectResponseBodyTraceInfoBlockWordBlockWordGroupInfoListBlockWordList> BlockWordList { get; set; }
                    public class ModelOutputContentSyncDetectResponseBodyTraceInfoBlockWordBlockWordGroupInfoListBlockWordList : TeaModel {
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
            public ModelOutputContentSyncDetectResponseBodyTraceInfoHarmfulCategories HarmfulCategories { get; set; }
            public class ModelOutputContentSyncDetectResponseBodyTraceInfoHarmfulCategories : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.85</para>
                /// </summary>
                [NameInMap("ConfidenceScore")]
                [Validation(Required=false)]
                public double? ConfidenceScore { get; set; }

                [NameInMap("HarmfulCategoryInfoList")]
                [Validation(Required=false)]
                public List<ModelOutputContentSyncDetectResponseBodyTraceInfoHarmfulCategoriesHarmfulCategoryInfoList> HarmfulCategoryInfoList { get; set; }
                public class ModelOutputContentSyncDetectResponseBodyTraceInfoHarmfulCategoriesHarmfulCategoryInfoList : TeaModel {
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
                    /// <para>1</para>
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
            public ModelOutputContentSyncDetectResponseBodyTraceInfoPromptAttack PromptAttack { get; set; }
            public class ModelOutputContentSyncDetectResponseBodyTraceInfoPromptAttack : TeaModel {
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

}
