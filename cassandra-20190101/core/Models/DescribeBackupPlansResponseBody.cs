// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class DescribeBackupPlansResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BackupPlans")]
        [Validation(Required=false)]
        public DescribeBackupPlansResponseBodyBackupPlans BackupPlans { get; set; }
        public class DescribeBackupPlansResponseBodyBackupPlans : TeaModel {
            [NameInMap("BackupPlan")]
            [Validation(Required=false)]
            public List<DescribeBackupPlansResponseBodyBackupPlansBackupPlan> BackupPlan { get; set; }
            public class DescribeBackupPlansResponseBodyBackupPlansBackupPlan : TeaModel {
                public bool? Active { get; set; }
                public string BackupPeriod { get; set; }
                public int? RetentionPeriod { get; set; }
                public string CreatedTime { get; set; }
                public string BackupTime { get; set; }
                public string ClusterId { get; set; }
                public string DataCenterId { get; set; }
            }
        };

    }

}
