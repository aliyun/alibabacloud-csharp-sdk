// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class DescribeBackupPlansResponseBody : TeaModel {
        [NameInMap("BackupPlans")]
        [Validation(Required=false)]
        public DescribeBackupPlansResponseBodyBackupPlans BackupPlans { get; set; }
        public class DescribeBackupPlansResponseBodyBackupPlans : TeaModel {
            [NameInMap("BackupPlan")]
            [Validation(Required=false)]
            public List<DescribeBackupPlansResponseBodyBackupPlansBackupPlan> BackupPlan { get; set; }
            public class DescribeBackupPlansResponseBodyBackupPlansBackupPlan : TeaModel {
                [NameInMap("Active")]
                [Validation(Required=false)]
                public bool? Active { get; set; }

                [NameInMap("BackupPeriod")]
                [Validation(Required=false)]
                public string BackupPeriod { get; set; }

                [NameInMap("BackupTime")]
                [Validation(Required=false)]
                public string BackupTime { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("DataCenterId")]
                [Validation(Required=false)]
                public string DataCenterId { get; set; }

                [NameInMap("RetentionPeriod")]
                [Validation(Required=false)]
                public int? RetentionPeriod { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
