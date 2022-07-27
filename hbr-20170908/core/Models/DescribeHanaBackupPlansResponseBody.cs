// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeHanaBackupPlansResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HanaBackupPlans")]
        [Validation(Required=false)]
        public DescribeHanaBackupPlansResponseBodyHanaBackupPlans HanaBackupPlans { get; set; }
        public class DescribeHanaBackupPlansResponseBodyHanaBackupPlans : TeaModel {
            [NameInMap("HanaBackupPlan")]
            [Validation(Required=false)]
            public List<DescribeHanaBackupPlansResponseBodyHanaBackupPlansHanaBackupPlan> HanaBackupPlan { get; set; }
            public class DescribeHanaBackupPlansResponseBodyHanaBackupPlansHanaBackupPlan : TeaModel {
                public string BackupPrefix { get; set; }
                public string BackupType { get; set; }
                public string ClusterId { get; set; }
                public string DatabaseName { get; set; }
                public bool? Disabled { get; set; }
                public string PlanId { get; set; }
                public string PlanName { get; set; }
                public string Schedule { get; set; }
                public string VaultId { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
