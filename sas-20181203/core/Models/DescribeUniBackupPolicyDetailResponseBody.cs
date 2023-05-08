// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUniBackupPolicyDetailResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("UniBackupPolicyDTO")]
        [Validation(Required=false)]
        public DescribeUniBackupPolicyDetailResponseBodyUniBackupPolicyDTO UniBackupPolicyDTO { get; set; }
        public class DescribeUniBackupPolicyDetailResponseBodyUniBackupPolicyDTO : TeaModel {
            /// <summary>
            /// The status of the database client. Valid values:
            /// 
            /// *   **UNKNOWN**: unknown
            /// *   **INSTALLED**: installed
            /// *   **INSTALL_FAILED**: installation failed
            /// *   **UNINSTALL_FAILED**: uninstallation failed
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// The ID of the anti-ransomware policy.
            /// </summary>
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public string AgentStatus { get; set; }

            /// <summary>
            /// The status of the anti-ransomware policy. Valid values:
            /// 
            /// *   **initiating**: initializing
            /// *   **opening**: enabled
            /// *   **closing**: disabled
            /// *   **deleting**: deleting
            /// </summary>
            [NameInMap("DatabaseType")]
            [Validation(Required=false)]
            public string DatabaseType { get; set; }

            /// <summary>
            /// The name of the database account.
            /// </summary>
            [NameInMap("FullPlan")]
            [Validation(Required=false)]
            public DescribeUniBackupPolicyDetailResponseBodyUniBackupPolicyDTOFullPlan FullPlan { get; set; }
            public class DescribeUniBackupPolicyDetailResponseBodyUniBackupPolicyDTOFullPlan : TeaModel {
                /// <summary>
                /// The interval of backup tasks.
                /// </summary>
                [NameInMap("Days")]
                [Validation(Required=false)]
                public List<string> Days { get; set; }

                /// <summary>
                /// The unit of the interval. Valid values:
                /// 
                /// *   **hourly**: hour
                /// *   **daily**: day
                /// *   **weekly**: week
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// The time when the full backup started. The time is in the HH:mm:ss format.
                /// </summary>
                [NameInMap("PlanType")]
                [Validation(Required=false)]
                public string PlanType { get; set; }

                /// <summary>
                /// The details of the policy for full backup.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// The day of a week on which the backup is performed. Valid values:
            /// 
            /// *   **0**: Sunday
            /// *   **1**: Monday
            /// *   **2**: Tuesday
            /// *   **3**: Wednesday
            /// *   **4**: Thursday
            /// *   **5**: Friday
            /// *   **6**: Saturday
            /// </summary>
            [NameInMap("IncPlan")]
            [Validation(Required=false)]
            public DescribeUniBackupPolicyDetailResponseBodyUniBackupPolicyDTOIncPlan IncPlan { get; set; }
            public class DescribeUniBackupPolicyDetailResponseBodyUniBackupPolicyDTOIncPlan : TeaModel {
                /// <summary>
                /// The interval of backup tasks.
                /// </summary>
                [NameInMap("Days")]
                [Validation(Required=false)]
                public List<string> Days { get; set; }

                /// <summary>
                /// The unit of the interval. Valid values:
                /// 
                /// *   **hourly**: hour
                /// *   **daily**: day
                /// *   **weekly**: week
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// The time when the incremental backup started. The time is in the HH:mm:ss format.
                /// </summary>
                [NameInMap("PlanType")]
                [Validation(Required=false)]
                public string PlanType { get; set; }

                /// <summary>
                /// The details of the policy for incremental backup.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// The name of the anti-ransomware policy.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The type of the database. Valid values:
            /// 
            /// *   **MYSQL**
            /// *   **MSSQL**
            /// *   **Oracle**
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The ID of the server.
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            /// <summary>
            /// The maximum network bandwidth that is allowed during data backup. Unit: bytes.
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// The details of the anti-ransomware policy.
            /// </summary>
            [NameInMap("PolicyStatus")]
            [Validation(Required=false)]
            public string PolicyStatus { get; set; }

            /// <summary>
            /// The name of the server.
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public int? Retention { get; set; }

            /// <summary>
            /// The retention period of the backup snapshot.
            /// </summary>
            [NameInMap("SpeedLimiter")]
            [Validation(Required=false)]
            public long? SpeedLimiter { get; set; }

        }

    }

}
