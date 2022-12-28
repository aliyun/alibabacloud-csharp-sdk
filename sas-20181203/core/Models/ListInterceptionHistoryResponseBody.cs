// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInterceptionHistoryResponseBody : TeaModel {
        [NameInMap("InterceptionHistoryList")]
        [Validation(Required=false)]
        public List<ListInterceptionHistoryResponseBodyInterceptionHistoryList> InterceptionHistoryList { get; set; }
        public class ListInterceptionHistoryResponseBodyInterceptionHistoryList : TeaModel {
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("DstAppName")]
            [Validation(Required=false)]
            public string DstAppName { get; set; }

            [NameInMap("DstNamespace")]
            [Validation(Required=false)]
            public string DstNamespace { get; set; }

            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public long? DstPort { get; set; }

            [NameInMap("DstRuleTargetName")]
            [Validation(Required=false)]
            public string DstRuleTargetName { get; set; }

            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InterceptionName")]
            [Validation(Required=false)]
            public long? InterceptionName { get; set; }

            [NameInMap("InterceptionType")]
            [Validation(Required=false)]
            public int? InterceptionType { get; set; }

            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            [NameInMap("RealDstAppName")]
            [Validation(Required=false)]
            public string RealDstAppName { get; set; }

            [NameInMap("RealDstImageName")]
            [Validation(Required=false)]
            public string RealDstImageName { get; set; }

            [NameInMap("RealDstNamespace")]
            [Validation(Required=false)]
            public string RealDstNamespace { get; set; }

            [NameInMap("RealDstPodName")]
            [Validation(Required=false)]
            public string RealDstPodName { get; set; }

            [NameInMap("RealInterceptionType")]
            [Validation(Required=false)]
            public int? RealInterceptionType { get; set; }

            [NameInMap("RealSrcAppName")]
            [Validation(Required=false)]
            public string RealSrcAppName { get; set; }

            [NameInMap("RealSrcImageName")]
            [Validation(Required=false)]
            public string RealSrcImageName { get; set; }

            [NameInMap("RealSrcNamespace")]
            [Validation(Required=false)]
            public string RealSrcNamespace { get; set; }

            [NameInMap("RealSrcPodName")]
            [Validation(Required=false)]
            public string RealSrcPodName { get; set; }

            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public long? RiskLevel { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("SrcAppName")]
            [Validation(Required=false)]
            public string SrcAppName { get; set; }

            [NameInMap("SrcNamespace")]
            [Validation(Required=false)]
            public string SrcNamespace { get; set; }

            [NameInMap("SrcRuleTargetName")]
            [Validation(Required=false)]
            public string SrcRuleTargetName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("TryCount")]
            [Validation(Required=false)]
            public int? TryCount { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListInterceptionHistoryResponseBodyPageInfo PageInfo { get; set; }
        public class ListInterceptionHistoryResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
