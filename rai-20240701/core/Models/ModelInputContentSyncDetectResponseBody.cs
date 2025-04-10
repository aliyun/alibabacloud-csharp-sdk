// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class ModelInputContentSyncDetectResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RiskResult")]
        [Validation(Required=false)]
        public int? RiskResult { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TraceInfo")]
        [Validation(Required=false)]
        public ModelInputContentSyncDetectResponseBodyTraceInfo TraceInfo { get; set; }
        public class ModelInputContentSyncDetectResponseBodyTraceInfo : TeaModel {
            [NameInMap("BlockWord")]
            [Validation(Required=false)]
            public ModelInputContentSyncDetectResponseBodyTraceInfoBlockWord BlockWord { get; set; }
            public class ModelInputContentSyncDetectResponseBodyTraceInfoBlockWord : TeaModel {
                [NameInMap("BlockWordGroupInfoList")]
                [Validation(Required=false)]
                public List<ModelInputContentSyncDetectResponseBodyTraceInfoBlockWordBlockWordGroupInfoList> BlockWordGroupInfoList { get; set; }
                public class ModelInputContentSyncDetectResponseBodyTraceInfoBlockWordBlockWordGroupInfoList : TeaModel {
                    [NameInMap("BlockWordList")]
                    [Validation(Required=false)]
                    public List<ModelInputContentSyncDetectResponseBodyTraceInfoBlockWordBlockWordGroupInfoListBlockWordList> BlockWordList { get; set; }
                    public class ModelInputContentSyncDetectResponseBodyTraceInfoBlockWordBlockWordGroupInfoListBlockWordList : TeaModel {
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

                [NameInMap("RiskResult")]
                [Validation(Required=false)]
                public int? RiskResult { get; set; }

            }

            [NameInMap("HarmfulCategories")]
            [Validation(Required=false)]
            public ModelInputContentSyncDetectResponseBodyTraceInfoHarmfulCategories HarmfulCategories { get; set; }
            public class ModelInputContentSyncDetectResponseBodyTraceInfoHarmfulCategories : TeaModel {
                [NameInMap("ConfidenceScore")]
                [Validation(Required=false)]
                public double? ConfidenceScore { get; set; }

                [NameInMap("HarmfulCategoryInfoList")]
                [Validation(Required=false)]
                public List<ModelInputContentSyncDetectResponseBodyTraceInfoHarmfulCategoriesHarmfulCategoryInfoList> HarmfulCategoryInfoList { get; set; }
                public class ModelInputContentSyncDetectResponseBodyTraceInfoHarmfulCategoriesHarmfulCategoryInfoList : TeaModel {
                    [NameInMap("CategoryLabel")]
                    [Validation(Required=false)]
                    public string CategoryLabel { get; set; }

                    [NameInMap("CategoryType")]
                    [Validation(Required=false)]
                    public int? CategoryType { get; set; }

                    [NameInMap("RiskResult")]
                    [Validation(Required=false)]
                    public int? RiskResult { get; set; }

                    [NameInMap("SecurityLevel")]
                    [Validation(Required=false)]
                    public int? SecurityLevel { get; set; }

                }

                [NameInMap("RiskResult")]
                [Validation(Required=false)]
                public int? RiskResult { get; set; }

            }

            [NameInMap("PromptAttack")]
            [Validation(Required=false)]
            public ModelInputContentSyncDetectResponseBodyTraceInfoPromptAttack PromptAttack { get; set; }
            public class ModelInputContentSyncDetectResponseBodyTraceInfoPromptAttack : TeaModel {
                [NameInMap("ConfidenceScore")]
                [Validation(Required=false)]
                public double? ConfidenceScore { get; set; }

                [NameInMap("PromptAttackInfo")]
                [Validation(Required=false)]
                public string PromptAttackInfo { get; set; }

                [NameInMap("RiskResult")]
                [Validation(Required=false)]
                public int? RiskResult { get; set; }

                [NameInMap("SecurityLevel")]
                [Validation(Required=false)]
                public int? SecurityLevel { get; set; }

            }

        }

    }

}
