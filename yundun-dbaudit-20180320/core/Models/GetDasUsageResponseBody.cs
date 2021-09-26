// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetDasUsageResponseBody : TeaModel {
        [NameInMap("Over1sSqlCount")]
        [Validation(Required=false)]
        public long? Over1sSqlCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SessionTotalCount")]
        [Validation(Required=false)]
        public long? SessionTotalCount { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("SqlTotalCount")]
        [Validation(Required=false)]
        public long? SqlTotalCount { get; set; }

        [NameInMap("AuditAsset")]
        [Validation(Required=false)]
        public GetDasUsageResponseBodyAuditAsset AuditAsset { get; set; }
        public class GetDasUsageResponseBodyAuditAsset : TeaModel {
            [NameInMap("DbCount")]
            [Validation(Required=false)]
            public int? DbCount { get; set; }
            [NameInMap("DbTypes")]
            [Validation(Required=false)]
            public List<GetDasUsageResponseBodyAuditAssetDbTypes> DbTypes { get; set; }
            public class GetDasUsageResponseBodyAuditAssetDbTypes : TeaModel {
                public string DbType { get; set; }
                public int? DbCount { get; set; }
            }
        };

        [NameInMap("ConsoleAccess")]
        [Validation(Required=false)]
        public GetDasUsageResponseBodyConsoleAccess ConsoleAccess { get; set; }
        public class GetDasUsageResponseBodyConsoleAccess : TeaModel {
            [NameInMap("LastAccessTime")]
            [Validation(Required=false)]
            public string LastAccessTime { get; set; }
            [NameInMap("Day90AccessCount")]
            [Validation(Required=false)]
            public int? Day90AccessCount { get; set; }
            [NameInMap("Day15AccessCount")]
            [Validation(Required=false)]
            public int? Day15AccessCount { get; set; }
            [NameInMap("Day30AccessCount")]
            [Validation(Required=false)]
            public int? Day30AccessCount { get; set; }
            [NameInMap("Day180AccessCount")]
            [Validation(Required=false)]
            public int? Day180AccessCount { get; set; }
        };

        [NameInMap("Agent")]
        [Validation(Required=false)]
        public GetDasUsageResponseBodyAgent Agent { get; set; }
        public class GetDasUsageResponseBodyAgent : TeaModel {
            [NameInMap("HasFlow")]
            [Validation(Required=false)]
            public bool? HasFlow { get; set; }
            [NameInMap("InstState")]
            [Validation(Required=false)]
            public string InstState { get; set; }
            [NameInMap("ActiveCount")]
            [Validation(Required=false)]
            public int? ActiveCount { get; set; }
        };

        [NameInMap("NoticeState")]
        [Validation(Required=false)]
        public GetDasUsageResponseBodyNoticeState NoticeState { get; set; }
        public class GetDasUsageResponseBodyNoticeState : TeaModel {
            [NameInMap("RiskNotice")]
            [Validation(Required=false)]
            public bool? RiskNotice { get; set; }
            [NameInMap("SysNotice")]
            [Validation(Required=false)]
            public bool? SysNotice { get; set; }
        };

        [NameInMap("RiskAsset")]
        [Validation(Required=false)]
        public GetDasUsageResponseBodyRiskAsset RiskAsset { get; set; }
        public class GetDasUsageResponseBodyRiskAsset : TeaModel {
            [NameInMap("RiskDBCount")]
            [Validation(Required=false)]
            public int? RiskDBCount { get; set; }
            [NameInMap("Day30RiskDBCount")]
            [Validation(Required=false)]
            public int? Day30RiskDBCount { get; set; }
        };

        [NameInMap("RiskRule")]
        [Validation(Required=false)]
        public GetDasUsageResponseBodyRiskRule RiskRule { get; set; }
        public class GetDasUsageResponseBodyRiskRule : TeaModel {
            [NameInMap("Day30RiskCount")]
            [Validation(Required=false)]
            public long? Day30RiskCount { get; set; }
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }
            [NameInMap("MaxHitRule")]
            [Validation(Required=false)]
            public GetDasUsageResponseBodyRiskRuleMaxHitRule MaxHitRule { get; set; }
            public class GetDasUsageResponseBodyRiskRuleMaxHitRule : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }
            [NameInMap("Day30MaxHitRule")]
            [Validation(Required=false)]
            public GetDasUsageResponseBodyRiskRuleDay30MaxHitRule Day30MaxHitRule { get; set; }
            public class GetDasUsageResponseBodyRiskRuleDay30MaxHitRule : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }
        };

        [NameInMap("WpAsset")]
        [Validation(Required=false)]
        public GetDasUsageResponseBodyWpAsset WpAsset { get; set; }
        public class GetDasUsageResponseBodyWpAsset : TeaModel {
            [NameInMap("AvgTime")]
            [Validation(Required=false)]
            public long? AvgTime { get; set; }
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }
        };

    }

}
