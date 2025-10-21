// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class ModelInputContentSyncDetectResponseBody : TeaModel {
        /// <summary>
        /// <para>Result code, 00000 indicates success; others indicate failure.</para>
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
        /// <para>Whether the operation was successful. true indicates success, false indicates failure.</para>
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
        public ModelInputContentSyncDetectResponseBodyTraceInfo TraceInfo { get; set; }
        public class ModelInputContentSyncDetectResponseBodyTraceInfo : TeaModel {
            /// <summary>
            /// <para>Detected keywords</para>
            /// </summary>
            [NameInMap("BlockWord")]
            [Validation(Required=false)]
            public ModelInputContentSyncDetectResponseBodyTraceInfoBlockWord BlockWord { get; set; }
            public class ModelInputContentSyncDetectResponseBodyTraceInfoBlockWord : TeaModel {
                /// <summary>
                /// <para>List of keyword detection result objects</para>
                /// </summary>
                [NameInMap("BlockWordGroupInfoList")]
                [Validation(Required=false)]
                public List<ModelInputContentSyncDetectResponseBodyTraceInfoBlockWordBlockWordGroupInfoList> BlockWordGroupInfoList { get; set; }
                public class ModelInputContentSyncDetectResponseBodyTraceInfoBlockWordBlockWordGroupInfoList : TeaModel {
                    /// <summary>
                    /// <para>List of keyword detection results</para>
                    /// </summary>
                    [NameInMap("BlockWordList")]
                    [Validation(Required=false)]
                    public List<ModelInputContentSyncDetectResponseBodyTraceInfoBlockWordBlockWordGroupInfoListBlockWordList> BlockWordList { get; set; }
                    public class ModelInputContentSyncDetectResponseBodyTraceInfoBlockWordBlockWordGroupInfoListBlockWordList : TeaModel {
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
            public ModelInputContentSyncDetectResponseBodyTraceInfoDenyTopics DenyTopics { get; set; }
            public class ModelInputContentSyncDetectResponseBodyTraceInfoDenyTopics : TeaModel {
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
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskResult")]
                [Validation(Required=false)]
                public int? RiskResult { get; set; }

                /// <summary>
                /// <para>Sensitive topic list</para>
                /// </summary>
                [NameInMap("TopicInfoList")]
                [Validation(Required=false)]
                public List<ModelInputContentSyncDetectResponseBodyTraceInfoDenyTopicsTopicInfoList> TopicInfoList { get; set; }
                public class ModelInputContentSyncDetectResponseBodyTraceInfoDenyTopicsTopicInfoList : TeaModel {
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
            /// <para>HarmfulCategories</para>
            /// </summary>
            [NameInMap("HarmfulCategories")]
            [Validation(Required=false)]
            public ModelInputContentSyncDetectResponseBodyTraceInfoHarmfulCategories HarmfulCategories { get; set; }
            public class ModelInputContentSyncDetectResponseBodyTraceInfoHarmfulCategories : TeaModel {
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
                public List<ModelInputContentSyncDetectResponseBodyTraceInfoHarmfulCategoriesHarmfulCategoryInfoList> HarmfulCategoryInfoList { get; set; }
                public class ModelInputContentSyncDetectResponseBodyTraceInfoHarmfulCategoriesHarmfulCategoryInfoList : TeaModel {
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
            public ModelInputContentSyncDetectResponseBodyTraceInfoPromptAttack PromptAttack { get; set; }
            public class ModelInputContentSyncDetectResponseBodyTraceInfoPromptAttack : TeaModel {
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
                /// <para>List of prompt attack objects</para>
                /// </summary>
                [NameInMap("PromptAttackInfoList")]
                [Validation(Required=false)]
                public List<ModelInputContentSyncDetectResponseBodyTraceInfoPromptAttackPromptAttackInfoList> PromptAttackInfoList { get; set; }
                public class ModelInputContentSyncDetectResponseBodyTraceInfoPromptAttackPromptAttackInfoList : TeaModel {
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

            [NameInMap("SensitiveType")]
            [Validation(Required=false)]
            public ModelInputContentSyncDetectResponseBodyTraceInfoSensitiveType SensitiveType { get; set; }
            public class ModelInputContentSyncDetectResponseBodyTraceInfoSensitiveType : TeaModel {
                [NameInMap("MaskedContent")]
                [Validation(Required=false)]
                public string MaskedContent { get; set; }

                [NameInMap("RiskResult")]
                [Validation(Required=false)]
                public int? RiskResult { get; set; }

                [NameInMap("SensitiveTypeInfoList")]
                [Validation(Required=false)]
                public List<ModelInputContentSyncDetectResponseBodyTraceInfoSensitiveTypeSensitiveTypeInfoList> SensitiveTypeInfoList { get; set; }
                public class ModelInputContentSyncDetectResponseBodyTraceInfoSensitiveTypeSensitiveTypeInfoList : TeaModel {
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
