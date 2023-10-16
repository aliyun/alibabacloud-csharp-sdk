// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryTrademarkMonitorRulesResponseBody : TeaModel {
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTrademarkMonitorRulesResponseBodyData Data { get; set; }
        public class QueryTrademarkMonitorRulesResponseBodyData : TeaModel {
            [NameInMap("TmMonitorRule")]
            [Validation(Required=false)]
            public List<QueryTrademarkMonitorRulesResponseBodyDataTmMonitorRule> TmMonitorRule { get; set; }
            public class QueryTrademarkMonitorRulesResponseBodyDataTmMonitorRule : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("LastFinishTime")]
                [Validation(Required=false)]
                public string LastFinishTime { get; set; }

                [NameInMap("LastRunTime")]
                [Validation(Required=false)]
                public string LastRunTime { get; set; }

                [NameInMap("LastUpdateTime")]
                [Validation(Required=false)]
                public string LastUpdateTime { get; set; }

                [NameInMap("NotifyUpdate")]
                [Validation(Required=false)]
                public int? NotifyUpdate { get; set; }

                [NameInMap("RuleDetail")]
                [Validation(Required=false)]
                public string RuleDetail { get; set; }

                [NameInMap("RuleExtend")]
                [Validation(Required=false)]
                public string RuleExtend { get; set; }

                [NameInMap("RuleKeyword")]
                [Validation(Required=false)]
                public string RuleKeyword { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("RuleSource")]
                [Validation(Required=false)]
                public string RuleSource { get; set; }

                [NameInMap("RuleStatus")]
                [Validation(Required=false)]
                public string RuleStatus { get; set; }

                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public int? RuleType { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

        }

        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
