// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
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
                public string BackupSourceGroupId { get; set; }
                public string BackupType { get; set; }
                public string Bucket { get; set; }
                public string ClientId { get; set; }
                public string ClusterId { get; set; }
                public long? CreateTime { get; set; }
                public long? CreatedTime { get; set; }
                public string CrossAccountRoleName { get; set; }
                public string CrossAccountType { get; set; }
                public long? CrossAccountUserId { get; set; }
                public string DataSourceId { get; set; }
                public string Detail { get; set; }
                public bool? Disabled { get; set; }
                public string Exclude { get; set; }
                public string FileSystemId { get; set; }
                public string Include { get; set; }
                public string InstanceGroupId { get; set; }
                public string InstanceId { get; set; }
                public string InstanceName { get; set; }
                public string Options { get; set; }
                public DescribeBackupPlansResponseBodyBackupPlansBackupPlanOtsDetail OtsDetail { get; set; }
                public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanOtsDetail : TeaModel {
                    [NameInMap("TableNames")]
                    [Validation(Required=false)]
                    public DescribeBackupPlansResponseBodyBackupPlansBackupPlanOtsDetailTableNames TableNames { get; set; }
                    public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanOtsDetailTableNames : TeaModel {
                        [NameInMap("TableName")]
                        [Validation(Required=false)]
                        public List<string> TableName { get; set; }
                    };

                }
                public DescribeBackupPlansResponseBodyBackupPlansBackupPlanPaths Paths { get; set; }
                public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanPaths : TeaModel {
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public List<string> Path { get; set; }

                }
                public string PlanId { get; set; }
                public string PlanName { get; set; }
                public string Prefix { get; set; }
                public DescribeBackupPlansResponseBodyBackupPlansBackupPlanResources Resources { get; set; }
                public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanResources : TeaModel {
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public List<DescribeBackupPlansResponseBodyBackupPlansBackupPlanResourcesResource> Resource { get; set; }
                    public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanResourcesResource : TeaModel {
                        [NameInMap("Extra")]
                        [Validation(Required=false)]
                        public string Extra { get; set; }

                        [NameInMap("ResourceId")]
                        [Validation(Required=false)]
                        public string ResourceId { get; set; }

                        [NameInMap("SourceType")]
                        [Validation(Required=false)]
                        public string SourceType { get; set; }

                    }

                }
                public long? Retention { get; set; }
                public DescribeBackupPlansResponseBodyBackupPlansBackupPlanRules Rules { get; set; }
                public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanRules : TeaModel {
                    [NameInMap("Rule")]
                    [Validation(Required=false)]
                    public List<DescribeBackupPlansResponseBodyBackupPlansBackupPlanRulesRule> Rule { get; set; }
                    public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanRulesRule : TeaModel {
                        [NameInMap("BackupType")]
                        [Validation(Required=false)]
                        public string BackupType { get; set; }

                        [NameInMap("DestinationRegionId")]
                        [Validation(Required=false)]
                        public string DestinationRegionId { get; set; }

                        [NameInMap("DestinationRetention")]
                        [Validation(Required=false)]
                        public long? DestinationRetention { get; set; }

                        [NameInMap("Disabled")]
                        [Validation(Required=false)]
                        public bool? Disabled { get; set; }

                        [NameInMap("DoCopy")]
                        [Validation(Required=false)]
                        public bool? DoCopy { get; set; }

                        [NameInMap("Retention")]
                        [Validation(Required=false)]
                        public long? Retention { get; set; }

                        [NameInMap("RuleId")]
                        [Validation(Required=false)]
                        public string RuleId { get; set; }

                        [NameInMap("RuleName")]
                        [Validation(Required=false)]
                        public string RuleName { get; set; }

                        [NameInMap("Schedule")]
                        [Validation(Required=false)]
                        public string Schedule { get; set; }

                    }

                }
                public string Schedule { get; set; }
                public string SourceType { get; set; }
                public string SpeedLimit { get; set; }
                public DescribeBackupPlansResponseBodyBackupPlansBackupPlanTrialInfo TrialInfo { get; set; }
                public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanTrialInfo : TeaModel {
                    [NameInMap("KeepAfterTrialExpiration")]
                    [Validation(Required=false)]
                    public bool? KeepAfterTrialExpiration { get; set; }

                    [NameInMap("TrialExpireTime")]
                    [Validation(Required=false)]
                    public long? TrialExpireTime { get; set; }

                    [NameInMap("TrialStartTime")]
                    [Validation(Required=false)]
                    public long? TrialStartTime { get; set; }

                    [NameInMap("TrialVaultReleaseTime")]
                    [Validation(Required=false)]
                    public long? TrialVaultReleaseTime { get; set; }

                }
                public long? UpdatedTime { get; set; }
                public string VaultId { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
