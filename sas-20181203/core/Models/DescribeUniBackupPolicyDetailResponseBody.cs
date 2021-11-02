// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUniBackupPolicyDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UniBackupPolicyDTO")]
        [Validation(Required=false)]
        public DescribeUniBackupPolicyDetailResponseBodyUniBackupPolicyDTO UniBackupPolicyDTO { get; set; }
        public class DescribeUniBackupPolicyDetailResponseBodyUniBackupPolicyDTO : TeaModel {
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public string AgentStatus { get; set; }
            [NameInMap("DatabaseType")]
            [Validation(Required=false)]
            public string DatabaseType { get; set; }
            [NameInMap("FullPlan")]
            [Validation(Required=false)]
            public DescribeUniBackupPolicyDetailResponseBodyUniBackupPolicyDTOFullPlan FullPlan { get; set; }
            public class DescribeUniBackupPolicyDetailResponseBodyUniBackupPolicyDTOFullPlan : TeaModel {
                [NameInMap("Days")]
                [Validation(Required=false)]
                public List<string> Days { get; set; }

                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                [NameInMap("PlanType")]
                [Validation(Required=false)]
                public string PlanType { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }
            [NameInMap("IncPlan")]
            [Validation(Required=false)]
            public DescribeUniBackupPolicyDetailResponseBodyUniBackupPolicyDTOIncPlan IncPlan { get; set; }
            public class DescribeUniBackupPolicyDetailResponseBodyUniBackupPolicyDTOIncPlan : TeaModel {
                [NameInMap("Days")]
                [Validation(Required=false)]
                public List<string> Days { get; set; }

                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                [NameInMap("PlanType")]
                [Validation(Required=false)]
                public string PlanType { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }
            [NameInMap("PolicyStatus")]
            [Validation(Required=false)]
            public string PolicyStatus { get; set; }
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public int? Retention { get; set; }
            [NameInMap("SpeedLimiter")]
            [Validation(Required=false)]
            public long? SpeedLimiter { get; set; }
            [NameInMap("UniBackUpCount")]
            [Validation(Required=false)]
            public int? UniBackUpCount { get; set; }
        };

    }

}
