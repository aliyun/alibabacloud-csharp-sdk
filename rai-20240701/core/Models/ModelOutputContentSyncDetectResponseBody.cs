// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class ModelOutputContentSyncDetectResponseBody : TeaModel {
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
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Risk labels, separated by commas if multiple.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("RiskInfo")]
        [Validation(Required=false)]
        public string RiskInfo { get; set; }

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

        [NameInMap("SafeAnswer")]
        [Validation(Required=false)]
        public string SafeAnswer { get; set; }

        /// <summary>
        /// <para>操作是否成功。true表示成功，false表示失败。</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Inspection result</para>
        /// </summary>
        [NameInMap("TraceInfo")]
        [Validation(Required=false)]
        public ModelOutputContentSyncDetectResponseBodyTraceInfo TraceInfo { get; set; }
        public class ModelOutputContentSyncDetectResponseBodyTraceInfo : TeaModel {
            /// <summary>
            /// <para>Detected keywords</para>
            /// </summary>
            [NameInMap("BlockWord")]
            [Validation(Required=false)]
            public ModelOutputContentSyncDetectResponseBodyTraceInfoBlockWord BlockWord { get; set; }
            public class ModelOutputContentSyncDetectResponseBodyTraceInfoBlockWord : TeaModel {
                /// <summary>
                /// <para>List of keyword detection result objects</para>
                /// </summary>
                [NameInMap("BlockWordGroupInfoList")]
                [Validation(Required=false)]
                public List<ModelOutputContentSyncDetectResponseBodyTraceInfoBlockWordBlockWordGroupInfoList> BlockWordGroupInfoList { get; set; }
                public class ModelOutputContentSyncDetectResponseBodyTraceInfoBlockWordBlockWordGroupInfoList : TeaModel {
                    /// <summary>
                    /// <para>List of keyword detection result objects</para>
                    /// </summary>
                    [NameInMap("BlockWordList")]
                    [Validation(Required=false)]
                    public List<ModelOutputContentSyncDetectResponseBodyTraceInfoBlockWordBlockWordGroupInfoListBlockWordList> BlockWordList { get; set; }
                    public class ModelOutputContentSyncDetectResponseBodyTraceInfoBlockWordBlockWordGroupInfoListBlockWordList : TeaModel {
                        /// <summary>
                        /// <para>Keyword</para>
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
            public ModelOutputContentSyncDetectResponseBodyTraceInfoDenyTopics DenyTopics { get; set; }
            public class ModelOutputContentSyncDetectResponseBodyTraceInfoDenyTopics : TeaModel {
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
                /// 1: Risk present</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RiskResult")]
                [Validation(Required=false)]
                public int? RiskResult { get; set; }

                /// <summary>
                /// <para>Sensitive topic list</para>
                /// </summary>
                [NameInMap("TopicInfoList")]
                [Validation(Required=false)]
                public List<ModelOutputContentSyncDetectResponseBodyTraceInfoDenyTopicsTopicInfoList> TopicInfoList { get; set; }
                public class ModelOutputContentSyncDetectResponseBodyTraceInfoDenyTopicsTopicInfoList : TeaModel {
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
                    /// 1: Risk present</para>
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
            /// <para>HarmfulCategories</para>
            /// </summary>
            [NameInMap("HarmfulCategories")]
            [Validation(Required=false)]
            public ModelOutputContentSyncDetectResponseBodyTraceInfoHarmfulCategories HarmfulCategories { get; set; }
            public class ModelOutputContentSyncDetectResponseBodyTraceInfoHarmfulCategories : TeaModel {
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
                public List<ModelOutputContentSyncDetectResponseBodyTraceInfoHarmfulCategoriesHarmfulCategoryInfoList> HarmfulCategoryInfoList { get; set; }
                public class ModelOutputContentSyncDetectResponseBodyTraceInfoHarmfulCategoriesHarmfulCategoryInfoList : TeaModel {
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
                    /// <para>Subcategory label</para>
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
            /// <para>Prompt attack information</para>
            /// </summary>
            [NameInMap("PromptAttack")]
            [Validation(Required=false)]
            public ModelOutputContentSyncDetectResponseBodyTraceInfoPromptAttack PromptAttack { get; set; }
            public class ModelOutputContentSyncDetectResponseBodyTraceInfoPromptAttack : TeaModel {
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
                /// <para>List of prompt attacks</para>
                /// </summary>
                [NameInMap("PromptAttackInfoList")]
                [Validation(Required=false)]
                public List<ModelOutputContentSyncDetectResponseBodyTraceInfoPromptAttackPromptAttackInfoList> PromptAttackInfoList { get; set; }
                public class ModelOutputContentSyncDetectResponseBodyTraceInfoPromptAttackPromptAttackInfoList : TeaModel {
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
                    /// 1: Risk present</para>
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
                /// <para>0</para>
                /// </summary>
                [NameInMap("SecurityLevel")]
                [Validation(Required=false)]
                public int? SecurityLevel { get; set; }

            }

            [NameInMap("SensitiveType")]
            [Validation(Required=false)]
            public ModelOutputContentSyncDetectResponseBodyTraceInfoSensitiveType SensitiveType { get; set; }
            public class ModelOutputContentSyncDetectResponseBodyTraceInfoSensitiveType : TeaModel {
                [NameInMap("MaskedContent")]
                [Validation(Required=false)]
                public string MaskedContent { get; set; }

                [NameInMap("RiskResult")]
                [Validation(Required=false)]
                public int? RiskResult { get; set; }

                [NameInMap("SensitiveTypeInfoList")]
                [Validation(Required=false)]
                public List<ModelOutputContentSyncDetectResponseBodyTraceInfoSensitiveTypeSensitiveTypeInfoList> SensitiveTypeInfoList { get; set; }
                public class ModelOutputContentSyncDetectResponseBodyTraceInfoSensitiveTypeSensitiveTypeInfoList : TeaModel {
                    [NameInMap("ActionType")]
                    [Validation(Required=false)]
                    public int? ActionType { get; set; }

                    [NameInMap("MaskedContent")]
                    [Validation(Required=false)]
                    public string MaskedContent { get; set; }

                    [NameInMap("SensitiveCategory")]
                    [Validation(Required=false)]
                    public int? SensitiveCategory { get; set; }

                    [NameInMap("SensitiveContent")]
                    [Validation(Required=false)]
                    public string SensitiveContent { get; set; }

                    [NameInMap("SensitiveTypeName")]
                    [Validation(Required=false)]
                    public string SensitiveTypeName { get; set; }

                }

            }

        }

    }

}
