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
                [NameInMap("BackupSourceGroupId")]
                [Validation(Required=false)]
                public string BackupSourceGroupId { get; set; }

                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                [NameInMap("ChangeListPath")]
                [Validation(Required=false)]
                public string ChangeListPath { get; set; }

                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("CreatedByTag")]
                [Validation(Required=false)]
                public bool? CreatedByTag { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                [NameInMap("CrossAccountRoleName")]
                [Validation(Required=false)]
                public string CrossAccountRoleName { get; set; }

                [NameInMap("CrossAccountType")]
                [Validation(Required=false)]
                public string CrossAccountType { get; set; }

                [NameInMap("CrossAccountUserId")]
                [Validation(Required=false)]
                public long? CrossAccountUserId { get; set; }

                [NameInMap("DataSourceId")]
                [Validation(Required=false)]
                public string DataSourceId { get; set; }

                [NameInMap("DestDataSourceDetail")]
                [Validation(Required=false)]
                public string DestDataSourceDetail { get; set; }

                [NameInMap("DestDataSourceId")]
                [Validation(Required=false)]
                public string DestDataSourceId { get; set; }

                [NameInMap("DestSourceType")]
                [Validation(Required=false)]
                public string DestSourceType { get; set; }

                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                [NameInMap("Exclude")]
                [Validation(Required=false)]
                public string Exclude { get; set; }

                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                [NameInMap("HitTags")]
                [Validation(Required=false)]
                public DescribeBackupPlansResponseBodyBackupPlansBackupPlanHitTags HitTags { get; set; }
                public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanHitTags : TeaModel {
                    [NameInMap("HitTag")]
                    [Validation(Required=false)]
                    public List<DescribeBackupPlansResponseBodyBackupPlansBackupPlanHitTagsHitTag> HitTag { get; set; }
                    public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanHitTagsHitTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("Include")]
                [Validation(Required=false)]
                public string Include { get; set; }

                [NameInMap("InstanceGroupId")]
                [Validation(Required=false)]
                public string InstanceGroupId { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("KeepLatestSnapshots")]
                [Validation(Required=false)]
                public long? KeepLatestSnapshots { get; set; }

                [NameInMap("LatestExecuteJobId")]
                [Validation(Required=false)]
                public string LatestExecuteJobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>job-00**************9khz</para>
                /// </summary>
                [NameInMap("LatestFinishJobId")]
                [Validation(Required=false)]
                public string LatestFinishJobId { get; set; }

                [NameInMap("Options")]
                [Validation(Required=false)]
                public string Options { get; set; }

                [NameInMap("OtsDetail")]
                [Validation(Required=false)]
                public DescribeBackupPlansResponseBodyBackupPlansBackupPlanOtsDetail OtsDetail { get; set; }
                public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanOtsDetail : TeaModel {
                    [NameInMap("TableNames")]
                    [Validation(Required=false)]
                    public DescribeBackupPlansResponseBodyBackupPlansBackupPlanOtsDetailTableNames TableNames { get; set; }
                    public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanOtsDetailTableNames : TeaModel {
                        [NameInMap("TableName")]
                        [Validation(Required=false)]
                        public List<string> TableName { get; set; }

                    }

                }

                [NameInMap("Paths")]
                [Validation(Required=false)]
                public DescribeBackupPlansResponseBodyBackupPlansBackupPlanPaths Paths { get; set; }
                public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanPaths : TeaModel {
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public List<string> Path { get; set; }

                }

                [NameInMap("PlanId")]
                [Validation(Required=false)]
                public string PlanId { get; set; }

                [NameInMap("PlanName")]
                [Validation(Required=false)]
                public string PlanName { get; set; }

                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

                [NameInMap("Resources")]
                [Validation(Required=false)]
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

                [NameInMap("Retention")]
                [Validation(Required=false)]
                public long? Retention { get; set; }

                [NameInMap("Rules")]
                [Validation(Required=false)]
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

                [NameInMap("Schedule")]
                [Validation(Required=false)]
                public string Schedule { get; set; }

                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("SpeedLimit")]
                [Validation(Required=false)]
                public string SpeedLimit { get; set; }

                [NameInMap("TrialInfo")]
                [Validation(Required=false)]
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

                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The message that is returned. If the call is successful, &quot;successful&quot; is returned. If the call fails, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number of the returned page. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page. Valid values: 1 to 99. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of returned backup plans that meet the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
