// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeHanaBackupPlansResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the call is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of the backup plan.
        /// </summary>
        [NameInMap("HanaBackupPlans")]
        [Validation(Required=false)]
        public DescribeHanaBackupPlansResponseBodyHanaBackupPlans HanaBackupPlans { get; set; }
        public class DescribeHanaBackupPlansResponseBodyHanaBackupPlans : TeaModel {
            [NameInMap("HanaBackupPlan")]
            [Validation(Required=false)]
            public List<DescribeHanaBackupPlansResponseBodyHanaBackupPlansHanaBackupPlan> HanaBackupPlan { get; set; }
            public class DescribeHanaBackupPlansResponseBodyHanaBackupPlansHanaBackupPlan : TeaModel {
                /// <summary>
                /// The backup prefix.
                /// </summary>
                [NameInMap("BackupPrefix")]
                [Validation(Required=false)]
                public string BackupPrefix { get; set; }

                /// <summary>
                /// The backup type. Valid values:
                /// 
                /// *   COMPLETE: full backup
                /// *   INCREMENTAL: incremental backup
                /// *   DIFFERENTIAL: differential backup
                /// </summary>
                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                /// <summary>
                /// The ID of the SAP HANA instance.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                /// <summary>
                /// Indicates whether the backup plan is disabled. Valid values:
                /// 
                /// *   true: The backup plan is disabled.
                /// *   false: The backup plan is enabled.
                /// </summary>
                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                /// <summary>
                /// The ID of the backup plan.
                /// </summary>
                [NameInMap("PlanId")]
                [Validation(Required=false)]
                public string PlanId { get; set; }

                /// <summary>
                /// The name of the backup plan.
                /// </summary>
                [NameInMap("PlanName")]
                [Validation(Required=false)]
                public string PlanName { get; set; }

                /// <summary>
                /// The backup policy. Format: `I|{startTime}|{interval}`. The system runs the first backup job at a point in time that is specified in the {startTime} parameter and the subsequent backup jobs at an interval that is specified in the {interval} parameter. The system does not run a backup job before the specified point in time. Each backup job, except the first one, starts only after the previous backup job is completed. For example, `I|1631685600|P1D` specifies that the system runs the first backup job at 14:00:00 on September 15, 2021 and the subsequent backup jobs once a day.
                /// 
                /// *   startTime: the time at which the system starts to run a backup job. The time follows the UNIX time format. Unit: seconds.
                /// *   interval: the interval at which the system runs a backup job. The interval follows the ISO 8601 standard. For example, PT1H indicates an interval of 1 hour. P1D indicates an interval of one day.
                /// </summary>
                [NameInMap("Schedule")]
                [Validation(Required=false)]
                public string Schedule { get; set; }

                /// <summary>
                /// The ID of the backup vault.
                /// </summary>
                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

            }

        }

        /// <summary>
        /// The message that is returned. If the call is successful, "successful" is returned. If the call fails, an error message is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number of the returned page. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page. Valid values: 1 to 99. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call is successful. Valid values:
        /// 
        /// *   true: The call is successful.
        /// *   false: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
