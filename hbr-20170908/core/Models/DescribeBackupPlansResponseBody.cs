// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeBackupPlansResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried backup plans.</para>
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
                /// <para>The ID of the data source group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>System-Database</para>
                /// </summary>
                [NameInMap("BackupSourceGroupId")]
                [Validation(Required=false)]
                public string BackupSourceGroupId { get; set; }

                /// <summary>
                /// <para>The backup type. Valid value: <b>COMPLETE</b>, which indicates full backup.</para>
                /// 
                /// <b>Example:</b>
                /// <para>COMPLETE</para>
                /// </summary>
                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                /// <summary>
                /// <para>This parameter is valid only when <b>SourceType</b> is set to <b>OSS</b>. This parameter indicates the name of the OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hbr-backup-oss</para>
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>The configurations of the incremental file synchronization. This parameter is returned only for data synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;dataSourceId&quot;: &quot;ds-123456789&quot;, &quot;path&quot;: &quot;/changelist&quot;}</para>
                /// </summary>
                [NameInMap("ChangeListPath")]
                [Validation(Required=false)]
                public string ChangeListPath { get; set; }

                /// <summary>
                /// <para>The ID of the backup client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c-000ge4w*****1qb</para>
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>The ID of the client group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cl-000ht6o9******h</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>This parameter is valid only when <b>SourceType</b> is set to <b>NAS</b>. This parameter indicates the time when the file system was created. This value is a UNIX timestamp. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1554347313</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>Indicates whether a backup plan is automatically created based on tags.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("CreatedByTag")]
                [Validation(Required=false)]
                public bool? CreatedByTag { get; set; }

                /// <summary>
                /// <para>The time when the backup plan was created. This value is a UNIX timestamp. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1554347313</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <para>The name of the Resource Access Management (RAM) role that is created within the source Alibaba Cloud account and assigned to the current Alibaba Cloud account to authorize the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BackupRole</para>
                /// </summary>
                [NameInMap("CrossAccountRoleName")]
                [Validation(Required=false)]
                public string CrossAccountRoleName { get; set; }

                /// <summary>
                /// <para>Indicates whether data is backed up within the same Alibaba Cloud account or across Alibaba Cloud accounts. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SELF_ACCOUNT</description></item>
                /// <item><description>CROSS_ACCOUNT</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CROSS_ACCOUNT</para>
                /// </summary>
                [NameInMap("CrossAccountType")]
                [Validation(Required=false)]
                public string CrossAccountType { get; set; }

                /// <summary>
                /// <para>The ID of the source Alibaba Cloud account that authorizes the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1841642xxxxx9795</para>
                /// </summary>
                [NameInMap("CrossAccountUserId")]
                [Validation(Required=false)]
                public long? CrossAccountUserId { get; set; }

                /// <summary>
                /// <para>The ID of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds-000ht6o9*****w61</para>
                /// </summary>
                [NameInMap("DataSourceId")]
                [Validation(Required=false)]
                public string DataSourceId { get; set; }

                /// <summary>
                /// <para>The data source details at the destination. This parameter is returned only for data synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;prefix\&quot;:\&quot;/\&quot;}</para>
                /// </summary>
                [NameInMap("DestDataSourceDetail")]
                [Validation(Required=false)]
                public string DestDataSourceDetail { get; set; }

                /// <summary>
                /// <para>The data source ID at the destination. This parameter is returned only for data synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds-*********************</para>
                /// </summary>
                [NameInMap("DestDataSourceId")]
                [Validation(Required=false)]
                public string DestDataSourceId { get; set; }

                /// <summary>
                /// <para>The data source type at the destination. This parameter is returned only for data synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("DestSourceType")]
                [Validation(Required=false)]
                public string DestSourceType { get; set; }

                /// <summary>
                /// <para>The details about ECS instance backup.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;doCopy\&quot;:true,\&quot;doBackup\&quot;:false,\&quot;instanceName\&quot;:\&quot;instance example\&quot;,\&quot;appConsistent\&quot;:false,\&quot;destinationRegionId\&quot;:\&quot;cn-shanghai\&quot;,\&quot;enableFsFreeze\&quot;:true,\&quot;osNameEn\&quot;:\&quot;Windows Server  2019 Data Center Edition 64bit Chinese Edition\&quot;,\&quot;osName\&quot;:\&quot;Windows Server  2019 Data Center Edition 64bit Chinese Edition\&quot;,\&quot;diskIdList\&quot;:[],\&quot;backupVaultId\&quot;:\&quot;\&quot;,\&quot;snapshotGroup\&quot;:true,\&quot;destinationRetention\&quot;:35,\&quot;platform\&quot;:\&quot;Windows Server 2012\&quot;,\&quot;timeoutInSeconds\&quot;:60,\&quot;backupRetention\&quot;:1,\&quot;osType\&quot;:\&quot;windows\&quot;,\&quot;preScriptPath\&quot;:\&quot;\&quot;,\&quot;postScriptPath\&quot;:\&quot;\&quot;,\&quot;enableWriters\&quot;:true,\&quot;ecsDeleted\&quot;:false}</para>
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <para>Indicates whether the backup plan is disabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The backup plan is disabled.</description></item>
                /// <item><description>false: The backup plan is enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                /// <summary>
                /// <para>This parameter is valid only when <b>SourceType</b> is set to <b>ECS_FILE</b>. This parameter indicates the paths to the files that are excluded from the backup job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;/var&quot;, &quot;/proc&quot;]</para>
                /// </summary>
                [NameInMap("Exclude")]
                [Validation(Required=false)]
                public string Exclude { get; set; }

                /// <summary>
                /// <para>This parameter is valid only when <b>SourceType</b> is set to <b>NAS</b>. This parameter indicates the ID of the NAS file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00594</para>
                /// </summary>
                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                /// <summary>
                /// <para>The matched tag rules.</para>
                /// </summary>
                [NameInMap("HitTags")]
                [Validation(Required=false)]
                public DescribeBackupPlansResponseBodyBackupPlansBackupPlanHitTags HitTags { get; set; }
                public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanHitTags : TeaModel {
                    [NameInMap("HitTag")]
                    [Validation(Required=false)]
                    public List<DescribeBackupPlansResponseBodyBackupPlansBackupPlanHitTagsHitTag> HitTag { get; set; }
                    public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanHitTagsHitTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>type</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag-based matching rule. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>EQUAL</b>: Both the tag key and tag value are matched.</description></item>
                        /// <item><description><b>NOT</b>: The tag key is matched and the tag value is not matched.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>EQUAL</para>
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>This parameter is valid only when <b>SourceType</b> is set to <b>ECS_FILE</b>. This parameter indicates the paths to the files that are backed up.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;/home/alice/<em>.pdf&quot;, &quot;/home/bob/</em>.txt&quot;]</para>
                /// </summary>
                [NameInMap("Include")]
                [Validation(Required=false)]
                public string Include { get; set; }

                /// <summary>
                /// <para>The ID of the instance group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-**</para>
                /// </summary>
                [NameInMap("InstanceGroupId")]
                [Validation(Required=false)]
                public string InstanceGroupId { get; set; }

                /// <summary>
                /// <para>This parameter is valid only when <b>SourceType</b> is set to <b>ECS_FILE</b>. This parameter indicates the ID of the ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-*********************</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the Tablestore instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instancename</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>Indicates whether the feature of keeping at least one backup version is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: The feature is disabled.</description></item>
                /// <item><description>1: The feature is enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("KeepLatestSnapshots")]
                [Validation(Required=false)]
                public long? KeepLatestSnapshots { get; set; }

                /// <summary>
                /// <para>The latest execution job id of plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job-12345678</para>
                /// </summary>
                [NameInMap("LatestExecuteJobId")]
                [Validation(Required=false)]
                public string LatestExecuteJobId { get; set; }

                /// <summary>
                /// <para>This parameter is valid only when <b>SourceType</b> is set to <b>ECS_FILE</b>. This parameter indicates whether Windows Volume Shadow Copy Service (VSS) is used to define a source path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;UseVSS&quot;:false}</para>
                /// </summary>
                [NameInMap("Options")]
                [Validation(Required=false)]
                public string Options { get; set; }

                /// <summary>
                /// <para>The details about the Tablestore instance.</para>
                /// </summary>
                [NameInMap("OtsDetail")]
                [Validation(Required=false)]
                public DescribeBackupPlansResponseBodyBackupPlansBackupPlanOtsDetail OtsDetail { get; set; }
                public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanOtsDetail : TeaModel {
                    /// <summary>
                    /// <para>The names of the tables in the Tablestore instance.</para>
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
                /// <para>The source paths. This parameter is valid only when <b>SourceType</b> is set to <b>ECS_FILE</b>.</para>
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
                /// <para>The ID of the backup plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>plan-*********************</para>
                /// </summary>
                [NameInMap("PlanId")]
                [Validation(Required=false)]
                public string PlanId { get; set; }

                /// <summary>
                /// <para>The name of the backup plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>planname</para>
                /// </summary>
                [NameInMap("PlanName")]
                [Validation(Required=false)]
                public string PlanName { get; set; }

                /// <summary>
                /// <para>This parameter is valid only when <b>SourceType</b> is set to <b>OSS</b>. This parameter indicates the prefix of the objects that are backed up.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-prefix</para>
                /// </summary>
                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

                /// <summary>
                /// <para>The backup resources. This parameter is valid only for disk backup.</para>
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
                        /// <para>Additional information about the data source.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{\&quot;doBackup\&quot;:false,\&quot;diskName\&quot;:\&quot;data_disk\&quot;,\&quot;size\&quot;:100,\&quot;type\&quot;:\&quot;data\&quot;,\&quot;category\&quot;:\&quot;cloud_essd\&quot;,\&quot;imageId\&quot;:\&quot;\&quot;,\&quot;device\&quot;:\&quot;/dev/xvdb\&quot;,\&quot;encrypted\&quot;:false}</para>
                        /// </summary>
                        [NameInMap("Extra")]
                        [Validation(Required=false)]
                        public string Extra { get; set; }

                        /// <summary>
                        /// <para>The ID of the data source.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>d-j6cgioir6m******lu4</para>
                        /// </summary>
                        [NameInMap("ResourceId")]
                        [Validation(Required=false)]
                        public string ResourceId { get; set; }

                        /// <summary>
                        /// <para>The type of the data source. Valid value: <b>UDM_DISK</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>UDMDISK</para>
                        /// </summary>
                        [NameInMap("SourceType")]
                        [Validation(Required=false)]
                        public string SourceType { get; set; }

                    }

                }

                /// <summary>
                /// <para>The retention period of the backup data. Unit: days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("Retention")]
                [Validation(Required=false)]
                public long? Retention { get; set; }

                /// <summary>
                /// <para>The backup policies. This parameter is valid only for disk backup.</para>
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
                        /// <para>The backup type. Valid value: <b>COMPLETE</b>, which indicates full backup.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>COMPLETE</para>
                        /// </summary>
                        [NameInMap("BackupType")]
                        [Validation(Required=false)]
                        public string BackupType { get; set; }

                        /// <summary>
                        /// <para>The ID of the region in which the remote backup vault resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-shanghai</para>
                        /// </summary>
                        [NameInMap("DestinationRegionId")]
                        [Validation(Required=false)]
                        public string DestinationRegionId { get; set; }

                        /// <summary>
                        /// <para>The retention period of the backup data in remote backup mode. Unit: days.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>90</para>
                        /// </summary>
                        [NameInMap("DestinationRetention")]
                        [Validation(Required=false)]
                        public long? DestinationRetention { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the policy is disabled.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Disabled")]
                        [Validation(Required=false)]
                        public bool? Disabled { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the snapshot data is backed up to the backup vault.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("DoCopy")]
                        [Validation(Required=false)]
                        public bool? DoCopy { get; set; }

                        /// <summary>
                        /// <para>The retention period of the backup data. Unit: days.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>90</para>
                        /// </summary>
                        [NameInMap("Retention")]
                        [Validation(Required=false)]
                        public long? Retention { get; set; }

                        /// <summary>
                        /// <para>The policy ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>rule-0008i52rf0ulpni6kn6m</para>
                        /// </summary>
                        [NameInMap("RuleId")]
                        [Validation(Required=false)]
                        public string RuleId { get; set; }

                        /// <summary>
                        /// <para>The policy name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Disk Golden Rule</para>
                        /// </summary>
                        [NameInMap("RuleName")]
                        [Validation(Required=false)]
                        public string RuleName { get; set; }

                        /// <summary>
                        /// <para>The backup policy. Format: <c>I|{startTime}|{interval}</c>. The system runs the first backup job at a point in time that is specified by <c>{startTime}</c> and the subsequent backup jobs at an interval that is specified by <c>{interval}</c>. The system does not run a backup job before the specified point in time. Each backup job, except the first one, starts only after the previous backup job is completed. For example, <c>I|1631685600|P1D</c> indicates that the system runs the first backup job at 14:00:00 on September 15, 2021 and the subsequent backup jobs once a day.</para>
                        /// <list type="bullet">
                        /// <item><description><c>startTime</c>: the time at which the system starts to run a backup job. The time follows the UNIX time format. Unit: seconds.</description></item>
                        /// <item><description><c>interval</c>: the interval at which the system runs a backup job. The interval follows the ISO 8601 standard. For example, PT1H indicates an interval of 1 hour. P1D indicates an interval of one day.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>I|1631685600|P1D</para>
                        /// </summary>
                        [NameInMap("Schedule")]
                        [Validation(Required=false)]
                        public string Schedule { get; set; }

                    }

                }

                /// <summary>
                /// <para>The backup policy. Format: <c>I|{startTime}|{interval}</c>. The system runs the first backup job at a point in time that is specified by <c>{startTime}</c> and the subsequent backup jobs at an interval that is specified by <c>{interval}</c>. The system does not run a backup job before the specified point in time. Each backup job, except the first one, starts only after the previous backup job is completed. For example, <c>I|1631685600|P1D</c> indicates that the system runs the first backup job at 14:00:00 on September 15, 2021 and the subsequent backup jobs once a day.</para>
                /// <list type="bullet">
                /// <item><description><b>startTime</b>: the time at which the system starts to run a backup job. The time follows the UNIX time format. Unit: seconds.</description></item>
                /// <item><description><b>interval</b>: the interval at which the system runs a backup job. The interval follows the ISO 8601 standard. For example, PT1H indicates an interval of 1 hour. P1D indicates an interval of one day.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>I|1602673264|P1D</para>
                /// </summary>
                [NameInMap("Schedule")]
                [Validation(Required=false)]
                public string Schedule { get; set; }

                /// <summary>
                /// <para>The type of the data source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ECS_FILE</b>: ECS files</description></item>
                /// <item><description><b>OSS</b>: OSS buckets</description></item>
                /// <item><description><b>NAS</b>: NAS file systems</description></item>
                /// <item><description><b>OTS</b>: Tablestore instances</description></item>
                /// <item><description><b>UDM_ECS</b>: ECS instances</description></item>
                /// <item><description><b>SYNC</b>: data synchronization</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ECS_FILE</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>This parameter is valid only when <b>SourceType</b> is set to <b>ECS_FILE</b>. This parameter indicates the throttling rules. Format: <c>{start}|{end}|{bandwidth}</c>. Multiple throttling rules are separated with vertical bars (<c>|</c>). A time range cannot overlap with another one.</para>
                /// <list type="bullet">
                /// <item><description>start: the start hour.</description></item>
                /// <item><description>end: the end hour.</description></item>
                /// <item><description>bandwidth: the bandwidth. Unit: KB.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0:24:5120</para>
                /// </summary>
                [NameInMap("SpeedLimit")]
                [Validation(Required=false)]
                public string SpeedLimit { get; set; }

                /// <summary>
                /// <para>The free trial information.</para>
                /// </summary>
                [NameInMap("TrialInfo")]
                [Validation(Required=false)]
                public DescribeBackupPlansResponseBodyBackupPlansBackupPlanTrialInfo TrialInfo { get; set; }
                public class DescribeBackupPlansResponseBodyBackupPlansBackupPlanTrialInfo : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether you are billed based on the pay-as-you-go method after the free trial ends.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("KeepAfterTrialExpiration")]
                    [Validation(Required=false)]
                    public bool? KeepAfterTrialExpiration { get; set; }

                    /// <summary>
                    /// <para>The expiration time of the free trial.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1584597600</para>
                    /// </summary>
                    [NameInMap("TrialExpireTime")]
                    [Validation(Required=false)]
                    public long? TrialExpireTime { get; set; }

                    /// <summary>
                    /// <para>The start time of the free trial.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1579413159</para>
                    /// </summary>
                    [NameInMap("TrialStartTime")]
                    [Validation(Required=false)]
                    public long? TrialStartTime { get; set; }

                    /// <summary>
                    /// <para>The time when the free-trial backup vault is released.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1594965600</para>
                    /// </summary>
                    [NameInMap("TrialVaultReleaseTime")]
                    [Validation(Required=false)]
                    public long? TrialVaultReleaseTime { get; set; }

                }

                /// <summary>
                /// <para>The time when the backup plan was updated. This value is a UNIX timestamp. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1554347313</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

                /// <summary>
                /// <para>The ID of the backup vault.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v-*********************</para>
                /// </summary>
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
