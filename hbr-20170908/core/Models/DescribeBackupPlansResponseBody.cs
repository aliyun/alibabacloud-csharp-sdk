// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeBackupPlansResponseBody : TeaModel {
        /// <summary>
        /// The returned backup plans that meet the specified conditions.
        /// </summary>
        [NameInMap("BackupPlans")]
        [Validation(Required=false)]
        public DescribeBackupPlansResponseBodyBackupPlans BackupPlans { get; set; }
        public class DescribeBackupPlansResponseBodyBackupPlans : TeaModel {
            [NameInMap("BackupPlan")]
            [Validation(Required=false)]
            public List<DescribeBackupPlansResponseBodyBackupPlansBackupPlan> BackupPlan { get; set; }
            public class DescribeBackupPlansResponseBodyBackupPlansBackupPlan : TeaModel {
                /// <summary>
                /// The ID of the data source group for backup.
                /// </summary>
                [NameInMap("BackupSourceGroupId")]
                [Validation(Required=false)]
                public string BackupSourceGroupId { get; set; }

                /// <summary>
                /// The backup type. Only **COMPLETE** may be returned, which indicates full backup.
                /// </summary>
                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                /// <summary>
                /// This parameter is valid only if **SourceType** is set to **OSS**. This parameter indicates the name of the OSS bucket.
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                [NameInMap("ChangeListPath")]
                [Validation(Required=false)]
                public string ChangeListPath { get; set; }

                /// <summary>
                /// The ID of a backup client.
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// The ID of the client group.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// This parameter is valid only if **SourceType** is set to **NAS**. This parameter indicates the time when the file system was created. The value is a UNIX timestamp. Unit: seconds.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The time when the backup plan was created. The value is a UNIX timestamp. Unit: seconds.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// The name of the Resource Access Management (RAM) role that is created within the source Alibaba Cloud account and assigned to the current Alibaba Cloud account to authorize the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.
                /// </summary>
                [NameInMap("CrossAccountRoleName")]
                [Validation(Required=false)]
                public string CrossAccountRoleName { get; set; }

                /// <summary>
                /// Indicates whether data is backed up within the same Alibaba Cloud account or across Alibaba Cloud accounts. Valid values:
                /// 
                /// *   SELF_ACCOUNT
                /// *   CROSS_ACCOUNT
                /// </summary>
                [NameInMap("CrossAccountType")]
                [Validation(Required=false)]
                public string CrossAccountType { get; set; }

                /// <summary>
                /// The ID of the source Alibaba Cloud account that authorizes the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.
                /// </summary>
                [NameInMap("CrossAccountUserId")]
                [Validation(Required=false)]
                public long? CrossAccountUserId { get; set; }

                /// <summary>
                /// The ID of the data source.
                /// </summary>
                [NameInMap("DataSourceId")]
                [Validation(Required=false)]
                public string DataSourceId { get; set; }

                /// <summary>
                /// The data source details at the destination. This parameter is required only for data synchronization.
                /// </summary>
                [NameInMap("DestDataSourceDetail")]
                [Validation(Required=false)]
                public string DestDataSourceDetail { get; set; }

                /// <summary>
                /// The data source ID at the destination. This parameter is required only for data synchronization.
                /// </summary>
                [NameInMap("DestDataSourceId")]
                [Validation(Required=false)]
                public string DestDataSourceId { get; set; }

                /// <summary>
                /// The data source type at the destination. This parameter is required only for data synchronization.
                /// </summary>
                [NameInMap("DestSourceType")]
                [Validation(Required=false)]
                public string DestSourceType { get; set; }

                /// <summary>
                /// The details about ECS instance backup.
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

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
                /// This parameter is valid only if **SourceType** is set to **ECS_FILE**. This parameter indicates the paths to the files that are excluded from the backup job.
                /// </summary>
                [NameInMap("Exclude")]
                [Validation(Required=false)]
                public string Exclude { get; set; }

                /// <summary>
                /// This parameter is valid only if **SourceType** is set to **NAS**. This parameter indicates the ID of the NAS file system.
                /// </summary>
                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                /// <summary>
                /// This parameter is valid only if **SourceType** is set to **ECS_FILE**. This parameter indicates the paths to the files that are backed up.
                /// </summary>
                [NameInMap("Include")]
                [Validation(Required=false)]
                public string Include { get; set; }

                /// <summary>
                /// The ID of the group to which the instance belongs.
                /// </summary>
                [NameInMap("InstanceGroupId")]
                [Validation(Required=false)]
                public string InstanceGroupId { get; set; }

                /// <summary>
                /// This parameter is valid only if **SourceType** is set to **ECS_FILE**. This parameter indicates the ID of the ECS instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the Tablestore instance.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// Indicates whether the feature of keeping at least one backup version is enabled. Valid values:
                /// 
                /// *   0: The feature is disabled.
                /// *   1: The feature is enabled.
                /// </summary>
                [NameInMap("KeepLatestSnapshots")]
                [Validation(Required=false)]
                public long? KeepLatestSnapshots { get; set; }

                /// <summary>
                /// This parameter is valid only if **SourceType** is set to **ECS_FILE**. This parameter indicates whether Windows Volume Shadow Copy Service (VSS) is used to define a source path.
                /// </summary>
                [NameInMap("Options")]
                [Validation(Required=false)]
                public string Options { get; set; }

                /// <summary>
                /// The details about the Tablestore instance.
                /// </summary>
                [NameInMap("OtsDetail")]
                [Validation(Required=false)]
                public DescribeBackupPlansResponseBodyBackupPlansBackupPlanOtsDetail OtsDetail { get; set; }
                public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanOtsDetail : TeaModel {
                    /// <summary>
                    /// The names of the tables in the Tablestore instance.
                    /// </summary>
                    [NameInMap("TableNames")]
                    [Validation(Required=false)]
                    public DescribeBackupPlansResponseBodyBackupPlansBackupPlanOtsDetailTableNames TableNames { get; set; }
                    public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanOtsDetailTableNames : TeaModel {
                        [NameInMap("TableName")]
                        [Validation(Required=false)]
                        public List<string> TableName { get; set; }

                    }

                }

                /// <summary>
                /// The source paths. This parameter is valid only if **SourceType** is set to **ECS_FILE**.
                /// </summary>
                [NameInMap("Paths")]
                [Validation(Required=false)]
                public DescribeBackupPlansResponseBodyBackupPlansBackupPlanPaths Paths { get; set; }
                public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanPaths : TeaModel {
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public List<string> Path { get; set; }

                }

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
                /// This parameter is valid only if **SourceType** is set to **OSS**. This parameter indicates the prefix of objects that are backed up.
                /// </summary>
                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

                /// <summary>
                /// The backup resources. This parameter is valid only for disk backup.
                /// </summary>
                [NameInMap("Resources")]
                [Validation(Required=false)]
                public DescribeBackupPlansResponseBodyBackupPlansBackupPlanResources Resources { get; set; }
                public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanResources : TeaModel {
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public List<DescribeBackupPlansResponseBodyBackupPlansBackupPlanResourcesResource> Resource { get; set; }
                    public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanResourcesResource : TeaModel {
                        /// <summary>
                        /// Additional information about the data source.
                        /// </summary>
                        [NameInMap("Extra")]
                        [Validation(Required=false)]
                        public string Extra { get; set; }

                        /// <summary>
                        /// The ID of the data source.
                        /// </summary>
                        [NameInMap("ResourceId")]
                        [Validation(Required=false)]
                        public string ResourceId { get; set; }

                        /// <summary>
                        /// The type of the data source. Only **UDM_DISK** may be returned.
                        /// </summary>
                        [NameInMap("SourceType")]
                        [Validation(Required=false)]
                        public string SourceType { get; set; }

                    }

                }

                /// <summary>
                /// The retention period of the backup data. Unit: day.
                /// </summary>
                [NameInMap("Retention")]
                [Validation(Required=false)]
                public long? Retention { get; set; }

                /// <summary>
                /// The backup policies. This parameter is valid only for disk backup.
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public DescribeBackupPlansResponseBodyBackupPlansBackupPlanRules Rules { get; set; }
                public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanRules : TeaModel {
                    [NameInMap("Rule")]
                    [Validation(Required=false)]
                    public List<DescribeBackupPlansResponseBodyBackupPlansBackupPlanRulesRule> Rule { get; set; }
                    public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanRulesRule : TeaModel {
                        /// <summary>
                        /// The backup type. Only **COMPLETE** may be returned, which indicates full backup.
                        /// </summary>
                        [NameInMap("BackupType")]
                        [Validation(Required=false)]
                        public string BackupType { get; set; }

                        /// <summary>
                        /// The ID of the region in which the remote backup vault resides.
                        /// </summary>
                        [NameInMap("DestinationRegionId")]
                        [Validation(Required=false)]
                        public string DestinationRegionId { get; set; }

                        /// <summary>
                        /// The retention period of the backup data in remote backup mode. Unit: day.
                        /// </summary>
                        [NameInMap("DestinationRetention")]
                        [Validation(Required=false)]
                        public long? DestinationRetention { get; set; }

                        /// <summary>
                        /// Indicates whether the policy is disabled.
                        /// </summary>
                        [NameInMap("Disabled")]
                        [Validation(Required=false)]
                        public bool? Disabled { get; set; }

                        /// <summary>
                        /// Indicates whether the snapshot data is backed up to the backup vault.
                        /// </summary>
                        [NameInMap("DoCopy")]
                        [Validation(Required=false)]
                        public bool? DoCopy { get; set; }

                        /// <summary>
                        /// The retention period of the backup data. Unit: day.
                        /// </summary>
                        [NameInMap("Retention")]
                        [Validation(Required=false)]
                        public long? Retention { get; set; }

                        /// <summary>
                        /// The ID of the policy.
                        /// </summary>
                        [NameInMap("RuleId")]
                        [Validation(Required=false)]
                        public string RuleId { get; set; }

                        /// <summary>
                        /// The name of the policy.
                        /// </summary>
                        [NameInMap("RuleName")]
                        [Validation(Required=false)]
                        public string RuleName { get; set; }

                        /// <summary>
                        /// The backup policy. Format: `I|{startTime}|{interval}`. The system runs the first backup job at a point in time that is specified by `{startTime}` and the subsequent backup jobs at an interval that is specified by `{interval}`. The system does not run a backup job before the specified point in time. Each backup job, except the first one, starts only after the previous backup job is complete. For example, `I|1631685600|P1D` indicates that the system runs the first backup job at 14:00:00 on September 15, 2021 and the subsequent backup jobs once a day.
                        /// 
                        /// *   `startTime`: the time at which the system starts to run a backup job. The value is a UNIX timestamp. Unit: seconds.
                        /// *   `interval`: the interval at which the system runs a backup job. The interval follows the ISO 8601 standard. For example, PT1H indicates an interval of 1 hour. P1D indicates an interval of one day.
                        /// </summary>
                        [NameInMap("Schedule")]
                        [Validation(Required=false)]
                        public string Schedule { get; set; }

                    }

                }

                /// <summary>
                /// The backup policy. Format: `I|{startTime}|{interval}`. The system runs the first backup job at a point in time that is specified by `{startTime}` and the subsequent backup jobs at an interval that is specified by `{interval}`. The system does not run a backup job before the specified point in time. Each backup job, except the first one, starts only after the previous backup job is complete. For example, `I|1631685600|P1D` indicates that the system runs the first backup job at 14:00:00 on September 15, 2021 and the subsequent backup jobs once a day.
                /// 
                /// *   **startTime**: the time at which the system starts to run a backup job. The value is a UNIX timestamp. Unit: seconds.
                /// *   **interval**: the interval at which the system runs a backup job. The interval follows the ISO 8601 standard. For example, PT1H indicates an interval of 1 hour. P1D indicates an interval of one day.
                /// </summary>
                [NameInMap("Schedule")]
                [Validation(Required=false)]
                public string Schedule { get; set; }

                /// <summary>
                /// The type of the data source. Valid values:
                /// 
                /// *   **ECS_FILE**: ECS files
                /// *   **OSS**: OSS buckets
                /// *   **NAS**: NAS file systems
                /// *   **OTS**: Tablestore instances
                /// *   **UDM_ECS**: ECS instances
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// This parameter is valid only if **SourceType** is set to **ECS_FILE**. This parameter indicates the throttling rules. Format: `{start}|{end}|{bandwidth}`. Multiple throttling rules are separated with vertical bars (`|`). A time range cannot overlap with another one.
                /// 
                /// *   start: the start hour.
                /// *   end: the end hour.
                /// *   bandwidth: the bandwidth. Unit: KB/s.
                /// </summary>
                [NameInMap("SpeedLimit")]
                [Validation(Required=false)]
                public string SpeedLimit { get; set; }

                /// <summary>
                /// The free trial information.
                /// </summary>
                [NameInMap("TrialInfo")]
                [Validation(Required=false)]
                public DescribeBackupPlansResponseBodyBackupPlansBackupPlanTrialInfo TrialInfo { get; set; }
                public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanTrialInfo : TeaModel {
                    /// <summary>
                    /// Indicates whether you are billed based on the pay-as-you-go method after the free trial ends.
                    /// </summary>
                    [NameInMap("KeepAfterTrialExpiration")]
                    [Validation(Required=false)]
                    public bool? KeepAfterTrialExpiration { get; set; }

                    /// <summary>
                    /// The expiration time of the free trial.
                    /// </summary>
                    [NameInMap("TrialExpireTime")]
                    [Validation(Required=false)]
                    public long? TrialExpireTime { get; set; }

                    /// <summary>
                    /// The start time of the free trial.
                    /// </summary>
                    [NameInMap("TrialStartTime")]
                    [Validation(Required=false)]
                    public long? TrialStartTime { get; set; }

                    /// <summary>
                    /// The time when the free-trial backup vault was released.
                    /// </summary>
                    [NameInMap("TrialVaultReleaseTime")]
                    [Validation(Required=false)]
                    public long? TrialVaultReleaseTime { get; set; }

                }

                /// <summary>
                /// The time when the backup plan was updated. The value is a UNIX timestamp. Unit: seconds.
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

                /// <summary>
                /// The ID of the backup vault.
                /// </summary>
                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

            }

        }

        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the call is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// The total number of returned backup plans that meet the specified conditions.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
