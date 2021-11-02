// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecurityStatInfoResponseBody : TeaModel {
        [NameInMap("AttackEvent")]
        [Validation(Required=false)]
        public DescribeSecurityStatInfoResponseBodyAttackEvent AttackEvent { get; set; }
        public class DescribeSecurityStatInfoResponseBodyAttackEvent : TeaModel {
            [NameInMap("DateArray")]
            [Validation(Required=false)]
            public List<string> DateArray { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("ValueArray")]
            [Validation(Required=false)]
            public List<string> ValueArray { get; set; }
        };

        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public DescribeSecurityStatInfoResponseBodyHealthCheck HealthCheck { get; set; }
        public class DescribeSecurityStatInfoResponseBodyHealthCheck : TeaModel {
            [NameInMap("DateArray")]
            [Validation(Required=false)]
            public List<string> DateArray { get; set; }
            [NameInMap("HighCount")]
            [Validation(Required=false)]
            public int? HighCount { get; set; }
            [NameInMap("HighList")]
            [Validation(Required=false)]
            public List<string> HighList { get; set; }
            [NameInMap("LevelsOn")]
            [Validation(Required=false)]
            public List<string> LevelsOn { get; set; }
            [NameInMap("LowCount")]
            [Validation(Required=false)]
            public int? LowCount { get; set; }
            [NameInMap("LowList")]
            [Validation(Required=false)]
            public List<string> LowList { get; set; }
            [NameInMap("MediumCount")]
            [Validation(Required=false)]
            public int? MediumCount { get; set; }
            [NameInMap("MediumList")]
            [Validation(Required=false)]
            public List<string> MediumList { get; set; }
            [NameInMap("TimeArray")]
            [Validation(Required=false)]
            public List<string> TimeArray { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("ValueArray")]
            [Validation(Required=false)]
            public List<string> ValueArray { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityEvent")]
        [Validation(Required=false)]
        public DescribeSecurityStatInfoResponseBodySecurityEvent SecurityEvent { get; set; }
        public class DescribeSecurityStatInfoResponseBodySecurityEvent : TeaModel {
            [NameInMap("DateArray")]
            [Validation(Required=false)]
            public List<string> DateArray { get; set; }
            [NameInMap("LevelsOn")]
            [Validation(Required=false)]
            public List<string> LevelsOn { get; set; }
            [NameInMap("RemindCount")]
            [Validation(Required=false)]
            public int? RemindCount { get; set; }
            [NameInMap("RemindList")]
            [Validation(Required=false)]
            public List<string> RemindList { get; set; }
            [NameInMap("SeriousCount")]
            [Validation(Required=false)]
            public int? SeriousCount { get; set; }
            [NameInMap("SeriousList")]
            [Validation(Required=false)]
            public List<string> SeriousList { get; set; }
            [NameInMap("SuspiciousCount")]
            [Validation(Required=false)]
            public int? SuspiciousCount { get; set; }
            [NameInMap("SuspiciousList")]
            [Validation(Required=false)]
            public List<string> SuspiciousList { get; set; }
            [NameInMap("TimeArray")]
            [Validation(Required=false)]
            public List<string> TimeArray { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("ValueArray")]
            [Validation(Required=false)]
            public List<string> ValueArray { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Vulnerability")]
        [Validation(Required=false)]
        public DescribeSecurityStatInfoResponseBodyVulnerability Vulnerability { get; set; }
        public class DescribeSecurityStatInfoResponseBodyVulnerability : TeaModel {
            [NameInMap("AsapCount")]
            [Validation(Required=false)]
            public int? AsapCount { get; set; }
            [NameInMap("AsapList")]
            [Validation(Required=false)]
            public List<string> AsapList { get; set; }
            [NameInMap("DateArray")]
            [Validation(Required=false)]
            public List<string> DateArray { get; set; }
            [NameInMap("LaterCount")]
            [Validation(Required=false)]
            public int? LaterCount { get; set; }
            [NameInMap("LaterList")]
            [Validation(Required=false)]
            public List<string> LaterList { get; set; }
            [NameInMap("LevelsOn")]
            [Validation(Required=false)]
            public List<string> LevelsOn { get; set; }
            [NameInMap("NntfCount")]
            [Validation(Required=false)]
            public int? NntfCount { get; set; }
            [NameInMap("NntfList")]
            [Validation(Required=false)]
            public List<string> NntfList { get; set; }
            [NameInMap("TimeArray")]
            [Validation(Required=false)]
            public List<string> TimeArray { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("ValueArray")]
            [Validation(Required=false)]
            public List<string> ValueArray { get; set; }
        };

    }

}
