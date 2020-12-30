// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeFullNodesSummaryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FullNodesSummary")]
        [Validation(Required=false)]
        public DescribeFullNodesSummaryResponseBodyFullNodesSummary FullNodesSummary { get; set; }
        public class DescribeFullNodesSummaryResponseBodyFullNodesSummary : TeaModel {
            [NameInMap("CleanCount")]
            [Validation(Required=false)]
            public int? CleanCount { get; set; }
            [NameInMap("HolingNodes")]
            [Validation(Required=false)]
            public List<DescribeFullNodesSummaryResponseBodyFullNodesSummaryHolingNodes> HolingNodes { get; set; }
            public class DescribeFullNodesSummaryResponseBodyFullNodesSummaryHolingNodes : TeaModel {
                public int? Type { get; set; }
                public string BizId { get; set; }
                public string Ip { get; set; }
                public string RegionId { get; set; }
                public string AppName { get; set; }
                public string RegionName { get; set; }
                public string GroupId { get; set; }
                public string AppId { get; set; }
                public int? InUse { get; set; }
                public string BizName { get; set; }
                public int? DdosStatus { get; set; }
                public bool? IsDisabled { get; set; }
                public int? Threshold { get; set; }
                public string EsnBizId { get; set; }
            }
            [NameInMap("HoleCount")]
            [Validation(Required=false)]
            public int? HoleCount { get; set; }
            [NameInMap("CleaningNodes")]
            [Validation(Required=false)]
            public List<DescribeFullNodesSummaryResponseBodyFullNodesSummaryCleaningNodes> CleaningNodes { get; set; }
            public class DescribeFullNodesSummaryResponseBodyFullNodesSummaryCleaningNodes : TeaModel {
                public int? Type { get; set; }
                public string BizId { get; set; }
                public string Ip { get; set; }
                public string RegionId { get; set; }
                public string AppName { get; set; }
                public string RegionName { get; set; }
                public string GroupId { get; set; }
                public string AppId { get; set; }
                public int? InUse { get; set; }
                public string BizName { get; set; }
                public int? DdosStatus { get; set; }
                public bool? IsDisabled { get; set; }
                public int? Threshold { get; set; }
                public string EsnBizId { get; set; }
            }
            [NameInMap("UsedCount")]
            [Validation(Required=false)]
            public int? UsedCount { get; set; }
            [NameInMap("UnUsedCount")]
            [Validation(Required=false)]
            public int? UnUsedCount { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

    }

}
