// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListDataSetTaskResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public int? DataSize { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataSetTaskResponseBodyData Data { get; set; }
        public class ListDataSetTaskResponseBodyData : TeaModel {
            [NameInMap("PageTaskInfo")]
            [Validation(Required=false)]
            public List<ListDataSetTaskResponseBodyDataPageTaskInfo> PageTaskInfo { get; set; }
            public class ListDataSetTaskResponseBodyDataPageTaskInfo : TeaModel {
                public int? Status { get; set; }
                public bool? IsTaskComplete { get; set; }
                public ListDataSetTaskResponseBodyDataPageTaskInfoRuleNameInfoList RuleNameInfoList { get; set; }
                public class ListDataSetTaskResponseBodyDataPageTaskInfoRuleNameInfoList : TeaModel {
                    [NameInMap("RuleNameInfo")]
                    [Validation(Required=false)]
                    public List<ListDataSetTaskResponseBodyDataPageTaskInfoRuleNameInfoListRuleNameInfo> RuleNameInfo { get; set; }
                    public class ListDataSetTaskResponseBodyDataPageTaskInfoRuleNameInfoListRuleNameInfo : TeaModel {
                        [NameInMap("RuleName")]
                        [Validation(Required=false)]
                        public string RuleName { get; set; }

                        [NameInMap("Rid")]
                        [Validation(Required=false)]
                        public int? Rid { get; set; }

                    }

                }
                public float? ScheduleRatio { get; set; }
                public bool? TaskComplete { get; set; }
                public ListDataSetTaskResponseBodyDataPageTaskInfoDataSets DataSets { get; set; }
                public class ListDataSetTaskResponseBodyDataPageTaskInfoDataSets : TeaModel {
                    [NameInMap("dataSets")]
                    [Validation(Required=false)]
                    public List<string> DataSets { get; set; }

                }
                public int? DataSetSize { get; set; }
                public int? RuleSize { get; set; }
                public string JobName { get; set; }
                public string TaskId { get; set; }
            }
        };

        [NameInMap("IsAllcomplete")]
        [Validation(Required=false)]
        public int? IsAllcomplete { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
