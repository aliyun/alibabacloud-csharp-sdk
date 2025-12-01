// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeBackupPlanListResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameterValid</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter %s value is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Details of the backup plans.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupPlanListResponseBodyItems Items { get; set; }
        public class DescribeBackupPlanListResponseBodyItems : TeaModel {
            [NameInMap("BackupPlanDetail")]
            [Validation(Required=false)]
            public List<DescribeBackupPlanListResponseBodyItemsBackupPlanDetail> BackupPlanDetail { get; set; }
            public class DescribeBackupPlanListResponseBodyItemsBackupPlanDetail : TeaModel {
                /// <summary>
                /// <para>Backup gateway ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>827362187368736</para>
                /// </summary>
                [NameInMap("BackupGatewayId")]
                [Validation(Required=false)]
                public long? BackupGatewayId { get; set; }

                /// <summary>
                /// <para>Backup method. The return values are as follows:</para>
                /// <list type="bullet">
                /// <item><description><b>logical</b>: Logical backup</description></item>
                /// <item><description><b>physical</b>: Physical backup</description></item>
                /// <item><description><b>duplication</b>: Replication backup</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>logical</para>
                /// </summary>
                [NameInMap("BackupMethod")]
                [Validation(Required=false)]
                public string BackupMethod { get; set; }

                /// <summary>
                /// <para>Backup objects.</para>
                /// </summary>
                [NameInMap("BackupObjects")]
                [Validation(Required=false)]
                public string BackupObjects { get; set; }

                /// <summary>
                /// <para>Full backup cycle. The return values are as follows:</para>
                /// <list type="bullet">
                /// <item><description><b>Monday</b>: Monday</description></item>
                /// <item><description><b>Tuesday</b>: Tuesday</description></item>
                /// <item><description><b>Wednesday</b>: Wednesday</description></item>
                /// <item><description><b>Thursday</b>: Thursday</description></item>
                /// <item><description><b>Friday</b>: Friday</description></item>
                /// <item><description><b>Saturday</b>: Saturday</description></item>
                /// <item><description><b>Sunday</b>: Sunday</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Monday</para>
                /// </summary>
                [NameInMap("BackupPeriod")]
                [Validation(Required=false)]
                public string BackupPeriod { get; set; }

                /// <summary>
                /// <para>Timestamp of the backup plan creation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1582527713000</para>
                /// </summary>
                [NameInMap("BackupPlanCreateTime")]
                [Validation(Required=false)]
                public long? BackupPlanCreateTime { get; set; }

                /// <summary>
                /// <para>Backup plan ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dbstooi01eXXXX</para>
                /// </summary>
                [NameInMap("BackupPlanId")]
                [Validation(Required=false)]
                public string BackupPlanId { get; set; }

                /// <summary>
                /// <para>Backup plan name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dbstooi01e****</para>
                /// </summary>
                [NameInMap("BackupPlanName")]
                [Validation(Required=false)]
                public string BackupPlanName { get; set; }

                /// <summary>
                /// <para>Backup plan status. The return values are as follows:</para>
                /// <list type="bullet">
                /// <item><description><b>wait</b>: Not configured</description></item>
                /// <item><description><b>init</b>: Not started (pre-check failed)</description></item>
                /// <item><description><b>running</b>: Running</description></item>
                /// <item><description><b>stop</b>: Failed</description></item>
                /// <item><description><b>pause</b>: Paused</description></item>
                /// <item><description><b>locked</b>: Locked</description></item>
                /// <item><description><b>check_pass</b>: Pre-check passed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>init</para>
                /// </summary>
                [NameInMap("BackupPlanStatus")]
                [Validation(Required=false)]
                public string BackupPlanStatus { get; set; }

                /// <summary>
                /// <para>Backup data retention period, with a value range of 0 to 1825 days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>365</para>
                /// </summary>
                [NameInMap("BackupRetentionPeriod")]
                [Validation(Required=false)]
                public int? BackupRetentionPeriod { get; set; }

                /// <summary>
                /// <para>Download server directory of the backup set</para>
                /// </summary>
                [NameInMap("BackupSetDownloadDir")]
                [Validation(Required=false)]
                public string BackupSetDownloadDir { get; set; }

                /// <summary>
                /// <para>Full data format for backup set download:</para>
                /// <list type="bullet">
                /// <item><description><b>Native</b></description></item>
                /// <item><description><b>SQL</b></description></item>
                /// <item><description><b>CSV</b></description></item>
                /// <item><description><b>JSON</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SQL</para>
                /// </summary>
                [NameInMap("BackupSetDownloadFullDataFormat")]
                [Validation(Required=false)]
                public string BackupSetDownloadFullDataFormat { get; set; }

                /// <summary>
                /// <para>Backup set download backup gateway ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123123</para>
                /// </summary>
                [NameInMap("BackupSetDownloadGatewayId")]
                [Validation(Required=false)]
                public long? BackupSetDownloadGatewayId { get; set; }

                /// <summary>
                /// <para>Backup set download full data format:</para>
                /// <list type="bullet">
                /// <item><description><b>Native</b></description></item>
                /// <item><description><b>SQL</b></description></item>
                /// <item><description><b>CSV</b></description></item>
                /// <item><description><b>JSON</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SQL</para>
                /// </summary>
                [NameInMap("BackupSetDownloadIncrementDataFormat")]
                [Validation(Required=false)]
                public string BackupSetDownloadIncrementDataFormat { get; set; }

                /// <summary>
                /// <para>Backup set download target type.</para>
                /// <remarks>
                /// <para>The only value is: agent, indicating that the backup gateway is installed.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>agent</para>
                /// </summary>
                [NameInMap("BackupSetDownloadTargetType")]
                [Validation(Required=false)]
                public string BackupSetDownloadTargetType { get; set; }

                /// <summary>
                /// <para>Full backup start time, in the format HH:mm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14:22</para>
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                /// <summary>
                /// <para>Built-in storage type. The return values are as follows:</para>
                /// <list type="bullet">
                /// <item><description>Empty (default): Backup data is stored on the user\&quot;s OSS.</description></item>
                /// <item><description>system: Backup data is stored on the built-in OSS of DBS.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("BackupStorageType")]
                [Validation(Required=false)]
                public string BackupStorageType { get; set; }

                /// <summary>
                /// <para>Start time for the database restore period, with a return value of 1554560477000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1554560477000</para>
                /// </summary>
                [NameInMap("BeginTimestampForRestore")]
                [Validation(Required=false)]
                public long? BeginTimestampForRestore { get; set; }

                /// <summary>
                /// <para>UID for cross-Aliyun account backup.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2xxx7778xxxxxxxxxx</para>
                /// </summary>
                [NameInMap("CrossAliyunId")]
                [Validation(Required=false)]
                public string CrossAliyunId { get; set; }

                /// <summary>
                /// <para>RAM role name for cross-Aliyun account backup.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test123</para>
                /// </summary>
                [NameInMap("CrossRoleName")]
                [Validation(Required=false)]
                public string CrossRoleName { get; set; }

                /// <summary>
                /// <para>Database type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("DatabaseType")]
                [Validation(Required=false)]
                public string DatabaseType { get; set; }

                /// <summary>
                /// <para>Time (in days) to convert to archive cold backup storage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>365</para>
                /// </summary>
                [NameInMap("DuplicationArchivePeriod")]
                [Validation(Required=false)]
                public int? DuplicationArchivePeriod { get; set; }

                /// <summary>
                /// <para>Time (in days) to convert to infrequent access storage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>180</para>
                /// </summary>
                [NameInMap("DuplicationInfrequentAccessPeriod")]
                [Validation(Required=false)]
                public int? DuplicationInfrequentAccessPeriod { get; set; }

                /// <summary>
                /// <para>Indicates whether incremental log backup is enabled, with return values as follows:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled</description></item>
                /// <item><description><b>false</b>: Disabled</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableBackupLog")]
                [Validation(Required=false)]
                public bool? EnableBackupLog { get; set; }

                /// <summary>
                /// <para>End time of the database restorable period, in timestamp format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1554560477000</para>
                /// </summary>
                [NameInMap("EndTimestampForRestore")]
                [Validation(Required=false)]
                public long? EndTimestampForRestore { get; set; }

                /// <summary>
                /// <para>Pre-check task error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>can not connect to oracle instance orcl with user dbs</para>
                /// </summary>
                [NameInMap("ErrMessage")]
                [Validation(Required=false)]
                public string ErrMessage { get; set; }

                /// <summary>
                /// <para>Instance class, with return values as follows:</para>
                /// <list type="bullet">
                /// <item><description><b>micro</b>: Entry-level</description></item>
                /// <item><description><b>small</b>: Low-spec</description></item>
                /// <item><description><b>medium</b>: Medium-spec</description></item>
                /// <item><description><b>large</b>: High-spec</description></item>
                /// <item><description><b>xlarge</b>: High-spec (no traffic limit)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>micro</para>
                /// </summary>
                [NameInMap("InstanceClass")]
                [Validation(Required=false)]
                public string InstanceClass { get; set; }

                /// <summary>
                /// <para>OSS Bucket name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dbs-backup-1857XXXXX489</para>
                /// </summary>
                [NameInMap("OSSBucketName")]
                [Validation(Required=false)]
                public string OSSBucketName { get; set; }

                /// <summary>
                /// <para>OSS Bucket region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("OSSBucketRegion")]
                [Validation(Required=false)]
                public string OSSBucketRegion { get; set; }

                /// <summary>
                /// <para>Indicates whether the automatic backup set download feature is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("OpenBackupSetAutoDownload")]
                [Validation(Required=false)]
                public bool? OpenBackupSetAutoDownload { get; set; }

                /// <summary>
                /// <para>Resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aekzecovzti****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Database name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("SourceEndpointDatabaseName")]
                [Validation(Required=false)]
                public string SourceEndpointDatabaseName { get; set; }

                /// <summary>
                /// <para>Database instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("SourceEndpointInstanceID")]
                [Validation(Required=false)]
                public string SourceEndpointInstanceID { get; set; }

                /// <summary>
                /// <para>Location of the database, the return values are as follows:</para>
                /// <list type="bullet">
                /// <item><description><b>rds</b></description></item>
                /// <item><description><b>ecs</b></description></item>
                /// <item><description><b>express</b>: Database connected via dedicated line/VPN gateway/smart gateway</description></item>
                /// <item><description><b>agent</b>: Database connected via backup gateway</description></item>
                /// <item><description><b>dds</b>: Cloud MongoDB</description></item>
                /// <item><description><b>other</b>: Database connected directly via IP:Port</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("SourceEndpointInstanceType")]
                [Validation(Required=false)]
                public string SourceEndpointInstanceType { get; set; }

                /// <summary>
                /// <para>Database connection address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.<em>.</em>.10:33204</para>
                /// </summary>
                [NameInMap("SourceEndpointIpPort")]
                [Validation(Required=false)]
                public string SourceEndpointIpPort { get; set; }

                /// <summary>
                /// <para>Oracle SID name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("SourceEndpointOracleSID")]
                [Validation(Required=false)]
                public string SourceEndpointOracleSID { get; set; }

                /// <summary>
                /// <para>Database region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("SourceEndpointRegion")]
                [Validation(Required=false)]
                public string SourceEndpointRegion { get; set; }

                /// <summary>
                /// <para>Database username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("SourceEndpointUserName")]
                [Validation(Required=false)]
                public string SourceEndpointUserName { get; set; }

            }

        }

        /// <summary>
        /// <para>Page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>Number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F1888AC-1138-4995-B9FE-D2734F61C058</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Total number of backup plans.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalElements")]
        [Validation(Required=false)]
        public int? TotalElements { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
