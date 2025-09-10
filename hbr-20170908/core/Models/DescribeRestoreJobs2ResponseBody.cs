// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeRestoreJobs2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message. If the request was successful, &quot;successful&quot; is returned. If the request failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 99. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried restore jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;RestoreJob\&quot;: []}</para>
        /// </summary>
        [NameInMap("RestoreJobs")]
        [Validation(Required=false)]
        public DescribeRestoreJobs2ResponseBodyRestoreJobs RestoreJobs { get; set; }
        public class DescribeRestoreJobs2ResponseBodyRestoreJobs : TeaModel {
            [NameInMap("RestoreJob")]
            [Validation(Required=false)]
            public List<DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJob> RestoreJob { get; set; }
            public class DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJob : TeaModel {
                /// <summary>
                /// <para>The actual amount of data that is restored after duplicates are removed. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("ActualBytes")]
                [Validation(Required=false)]
                public long? ActualBytes { get; set; }

                /// <summary>
                /// <para>This parameter is valid only if the <b>SourceType</b> parameter is set to <b>ECS_FILE</b>. This parameter indicates the actual number of objects that are restored by the restore job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("ActualItems")]
                [Validation(Required=false)]
                public long? ActualItems { get; set; }

                /// <summary>
                /// <para>The amount of data that was restored. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>800</para>
                /// </summary>
                [NameInMap("BytesDone")]
                [Validation(Required=false)]
                public long? BytesDone { get; set; }

                /// <summary>
                /// <para>The total amount of data that was backed up from the data source. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("BytesTotal")]
                [Validation(Required=false)]
                public long? BytesTotal { get; set; }

                /// <summary>
                /// <para>The ID of the client group used for restoration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cl-000******hp6</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The time when the restore job was completed. This value is a UNIX timestamp. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1554347313</para>
                /// </summary>
                [NameInMap("CompleteTime")]
                [Validation(Required=false)]
                public long? CompleteTime { get; set; }

                /// <summary>
                /// <para>The time when the restore job was created. This value is a UNIX timestamp. Unit: seconds.</para>
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
                /// <item><description>SELF_ACCOUNT: Data is backed up within the same Alibaba Cloud account.</description></item>
                /// <item><description>CROSS_ACCOUNT: Data is backed up across Alibaba Cloud accounts.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SELF_ACCOUNT</para>
                /// </summary>
                [NameInMap("CrossAccountType")]
                [Validation(Required=false)]
                public string CrossAccountType { get; set; }

                /// <summary>
                /// <para>The ID of the source Alibaba Cloud account that authorizes the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>158975xxxxxx4625</para>
                /// </summary>
                [NameInMap("CrossAccountUserId")]
                [Validation(Required=false)]
                public long? CrossAccountUserId { get; set; }

                /// <summary>
                /// <para>The files that failed to be restored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;test.csv&quot;</para>
                /// </summary>
                [NameInMap("ErrorFile")]
                [Validation(Required=false)]
                public string ErrorFile { get; set; }

                /// <summary>
                /// <para>The error message that is returned for the restore job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PARTIAL_COMPLETE</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>This parameter is valid only if the <b>SourceType</b> parameter is set to <b>ECS_FILE</b>. This parameter indicates the paths to the files that are excluded from the restore job. The value can be up to 255 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;/var&quot;, &quot;/proc&quot;]</para>
                /// </summary>
                [NameInMap("Exclude")]
                [Validation(Required=false)]
                public string Exclude { get; set; }

                /// <summary>
                /// <para>The time when the restore job expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1634714531</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// <para>The details about the VMware failback task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;cpu&quot;:4,&quot;extra&quot;:&quot;{\&quot;restoreVMNamePrefix\&quot;:\&quot;627-\&quot;,\&quot;dataCenterName\&quot;:\&quot;SDDC-Datacenter\&quot;,\&quot;dataStoreId\&quot;:\&quot;datastore-50\&quot;,\&quot;folderId\&quot;:\&quot;group-v49\&quot;,\&quot;resourcePoolId\&quot;:\&quot;resgroup-46\&quot;,\&quot;locationName\&quot;:\&quot;vcenter.pc-uf600arcwi9td3eyj641.acvs.aliyuncs.com/SDDC-Datacenter/Workloads\&quot;,\&quot;computeResourceName\&quot;:\&quot;SDDC-Datacenter/Default_c-uf600arcwi9td3eyj640\&quot;,\&quot;dataStoreName\&quot;:\&quot;Default_c-uf600arcwi9td3eyj640/WorkloadDatastore\&quot;,\&quot;networkMoReference\&quot;:\&quot;DistributedVirtualPortgroup:dvportgroup-1001\&quot;,\&quot;useHotAdd\&quot;:false}&quot;,&quot;instanceId&quot;:&quot;i-2vc357i2eannmmotcagz&quot;,&quot;memoryInMB&quot;:8192,&quot;serverId&quot;:&quot;0fdc0c86-eb92-4e05-91ab-eeaf9fb6ad01&quot;,&quot;uefiBoot&quot;:false}</para>
                /// </summary>
                [NameInMap("FailbackDetail")]
                [Validation(Required=false)]
                public string FailbackDetail { get; set; }

                /// <summary>
                /// <para>The paths to the files that are included in the restore job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;/home/alice/<em>.pdf&quot;, &quot;/home/bob/</em>.txt&quot;]</para>
                /// </summary>
                [NameInMap("Include")]
                [Validation(Required=false)]
                public string Include { get; set; }

                /// <summary>
                /// <para>This parameter is valid only if the <b>SourceType</b> parameter is set to <b>ECS_FILE</b>. This parameter indicates the number of restored objects.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("ItemsDone")]
                [Validation(Required=false)]
                public long? ItemsDone { get; set; }

                /// <summary>
                /// <para>This parameter is valid only if the <b>SourceType</b> parameter is set to <b>ECS_FILE</b>. This parameter indicates the total number of objects in the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ItemsTotal")]
                [Validation(Required=false)]
                public long? ItemsTotal { get; set; }

                /// <summary>
                /// <para>The amount of data that was restored. Unit: bytes. This parameter is valid only if the StorageClass parameter is set to ARCHIVE. The minimum billable size of the data stored at the Archive tier is 1 MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("MeteringBytesDone")]
                [Validation(Required=false)]
                public long? MeteringBytesDone { get; set; }

                /// <summary>
                /// <para>The total amount of data that was backed up from the data source. Unit: bytes. This parameter is valid only if the StorageClass parameter is set to ARCHIVE. The minimum billable size of the data stored at the Archive tier is 1 MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("MeteringBytesTotal")]
                [Validation(Required=false)]
                public long? MeteringBytesTotal { get; set; }

                /// <summary>
                /// <para>This parameter is valid only if the <b>SourceType</b> parameter is set to <b>ECS_FILE</b>. This parameter indicates whether Windows Volume Shadow Copy Service (VSS) is used to define a restoration path.</para>
                /// <list type="bullet">
                /// <item><description>This parameter is available only for Windows ECS instances.</description></item>
                /// <item><description>If data changes occur in the backup source, the source data must be the same as the data to be backed up before you can set this parameter to <c>[&quot;UseVSS&quot;:true]</c>.</description></item>
                /// <item><description>If you use VSS, you cannot restore data from multiple directories.</description></item>
                /// </list>
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
                public DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJobOtsDetail OtsDetail { get; set; }
                public class DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJobOtsDetail : TeaModel {
                    /// <summary>
                    /// <para>The number of channels processed by each Tablestore restore job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("BatchChannelCount")]
                    [Validation(Required=false)]
                    public int? BatchChannelCount { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the existing Tablestore restore job was overwritten.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("OverwriteExisting")]
                    [Validation(Required=false)]
                    public bool? OverwriteExisting { get; set; }

                }

                /// <summary>
                /// <para>The ID of the parent job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-0003hd2an3x4dyv0l18b</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// <para>The progress of the restore job. Valid values: [0,10000]. For example, 10000 indicates that the progress is 100%.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// <para>The report of the restore job.</para>
                /// </summary>
                [NameInMap("Report")]
                [Validation(Required=false)]
                public DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJobReport Report { get; set; }
                public class DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJobReport : TeaModel {
                    /// <summary>
                    /// <para>The files that failed to be executed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/temp/report/158975xxxxxx4625/r-0001hfxxxxxymsspjjtl/job-0001hfxxxxxymsspjjtl_failed.zip</para>
                    /// </summary>
                    [NameInMap("FailedFiles")]
                    [Validation(Required=false)]
                    public string FailedFiles { get; set; }

                    /// <summary>
                    /// <para>The status of the report generation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>COMPLETE</para>
                    /// </summary>
                    [NameInMap("ReportTaskStatus")]
                    [Validation(Required=false)]
                    public string ReportTaskStatus { get; set; }

                    /// <summary>
                    /// <para>The skipped files.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/temp/report/158975xxxxxx4625/r-0001hfxxxxxymsspjjtl/job-0001hfxxxxxymsspjjtl_skipped.zip</para>
                    /// </summary>
                    [NameInMap("SkippedFiles")]
                    [Validation(Required=false)]
                    public string SkippedFiles { get; set; }

                    /// <summary>
                    /// <para>The files that are successfully executed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/temp/report/158975xxxxxx4625/r-0001hfxxxxxymsspjjtl/job-0001hfxxxxxymsspjjtl_success.zip</para>
                    /// </summary>
                    [NameInMap("SuccessFiles")]
                    [Validation(Required=false)]
                    public string SuccessFiles { get; set; }

                    /// <summary>
                    /// <para>The full files that are restored based on the file list.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/temp/report/158975xxxxxx4625/job-0001hfxxxxxymsspjjtl/job-0001hfxxxxxymsspjjtl_total.csv</para>
                    /// </summary>
                    [NameInMap("TotalFiles")]
                    [Validation(Required=false)]
                    public string TotalFiles { get; set; }

                }

                /// <summary>
                /// <para>The ID of the restore job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-0003*****8a</para>
                /// </summary>
                [NameInMap("RestoreId")]
                [Validation(Required=false)]
                public string RestoreId { get; set; }

                /// <summary>
                /// <para>The type of the restore job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS_FILE</para>
                /// </summary>
                [NameInMap("RestoreType")]
                [Validation(Required=false)]
                public string RestoreType { get; set; }

                /// <summary>
                /// <para>The hash value of the backup snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f2fe...</para>
                /// </summary>
                [NameInMap("SnapshotHash")]
                [Validation(Required=false)]
                public string SnapshotHash { get; set; }

                /// <summary>
                /// <para>The ID of the snapshot used for restoration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s-0002******ga88</para>
                /// </summary>
                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

                [NameInMap("SourceInstanceId")]
                [Validation(Required=false)]
                public string SourceInstanceId { get; set; }

                /// <summary>
                /// <para>The type of the data source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ECS_FILE</b>: ECS files</description></item>
                /// <item><description><b>OSS</b>: Object Storage Service (OSS) buckets</description></item>
                /// <item><description><b>NAS</b>: Apsara File Storage NAS (NAS) file systems</description></item>
                /// <item><description><b>OTS_TABLE</b>: Tablestore instances</description></item>
                /// <item><description><b>UDM_ECS</b>: ECS instances</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ECS_FILE</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The average speed at which data is backed up. Unit: KB/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("Speed")]
                [Validation(Required=false)]
                public long? Speed { get; set; }

                /// <summary>
                /// <para>The time when the restore job started. This value is a UNIX timestamp. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1554347313</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The status of the restore job. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>COMPLETE</b>: The job is completed.</description></item>
                /// <item><description><b>PARTIAL_COMPLETE</b>: The job is partially completed.</description></item>
                /// <item><description><b>FAILED</b>: The job failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>COMPLETE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The storage class of the backup data. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>STANDARD</b></description></item>
                /// <item><description><b>ARCHIVE</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>STANDARD</para>
                /// </summary>
                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

                /// <summary>
                /// <para>The name of the destination OSS bucket. This parameter is returned only for OSS buckets.</para>
                /// 
                /// <b>Example:</b>
                /// <para>target-bucket</para>
                /// </summary>
                [NameInMap("TargetBucket")]
                [Validation(Required=false)]
                public string TargetBucket { get; set; }

                /// <summary>
                /// <para>The ID of the destination client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c-000e*****397</para>
                /// </summary>
                [NameInMap("TargetClientId")]
                [Validation(Required=false)]
                public string TargetClientId { get; set; }

                /// <summary>
                /// <para>The time when the file system was created. This parameter is returned only for NAS file systems.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1634714531</para>
                /// </summary>
                [NameInMap("TargetCreateTime")]
                [Validation(Required=false)]
                public long? TargetCreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the destination data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds-000*****997</para>
                /// </summary>
                [NameInMap("TargetDataSourceId")]
                [Validation(Required=false)]
                public string TargetDataSourceId { get; set; }

                /// <summary>
                /// <para>The ID of the destination NAS file system. This parameter is returned only for NAS file systems.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0be9****9c9</para>
                /// </summary>
                [NameInMap("TargetFileSystemId")]
                [Validation(Required=false)]
                public string TargetFileSystemId { get; set; }

                /// <summary>
                /// <para>The ID of the destination instance for the restore job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-2ze3m7ktcgw******cs</para>
                /// </summary>
                [NameInMap("TargetInstanceId")]
                [Validation(Required=false)]
                public string TargetInstanceId { get; set; }

                /// <summary>
                /// <para>The name of the destination Tablestore instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instancename</para>
                /// </summary>
                [NameInMap("TargetInstanceName")]
                [Validation(Required=false)]
                public string TargetInstanceName { get; set; }

                /// <summary>
                /// <para>The destination file path of the restore job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;D:\\rebk&quot;</para>
                /// </summary>
                [NameInMap("TargetPath")]
                [Validation(Required=false)]
                public string TargetPath { get; set; }

                /// <summary>
                /// <para>The prefix of the objects that are restored. This parameter is returned only for OSS buckets.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;/target&quot;</para>
                /// </summary>
                [NameInMap("TargetPrefix")]
                [Validation(Required=false)]
                public string TargetPrefix { get; set; }

                /// <summary>
                /// <para>The name of the destination table in the Tablestore instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tablename</para>
                /// </summary>
                [NameInMap("TargetTableName")]
                [Validation(Required=false)]
                public string TargetTableName { get; set; }

                /// <summary>
                /// <para>The time when the Tablestore instance was backed up. This value is a UNIX timestamp. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1642560261</para>
                /// </summary>
                [NameInMap("TargetTime")]
                [Validation(Required=false)]
                public long? TargetTime { get; set; }

                /// <summary>
                /// <para>The details about Elastic Compute Service (ECS) instance backup.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;doCopy\&quot;:true,\&quot;doBackup\&quot;:false,\&quot;instanceName\&quot;:\&quot;instance example\&quot;,\&quot;appConsistent\&quot;:false,\&quot;destinationRegionId\&quot;:\&quot;cn-shanghai\&quot;,\&quot;enableFsFreeze\&quot;:true,\&quot;osNameEn\&quot;:\&quot;Windows Server  2019 Data Center Edition 64bit Chinese Edition\&quot;,\&quot;osName\&quot;:\&quot;Windows Server  2019 Data Center Edition 64bit Chinese Edition\&quot;,\&quot;diskIdList\&quot;:[],\&quot;backupVaultId\&quot;:\&quot;\&quot;,\&quot;snapshotGroup\&quot;:true,\&quot;destinationRetention\&quot;:35,\&quot;platform\&quot;:\&quot;Windows Server 2012\&quot;,\&quot;timeoutInSeconds\&quot;:60,\&quot;backupRetention\&quot;:1,\&quot;osType\&quot;:\&quot;windows\&quot;,\&quot;preScriptPath\&quot;:\&quot;\&quot;,\&quot;postScriptPath\&quot;:\&quot;\&quot;,\&quot;enableWriters\&quot;:true,\&quot;ecsDeleted\&quot;:false}</para>
                /// </summary>
                [NameInMap("UdmDetail")]
                [Validation(Required=false)]
                public string UdmDetail { get; set; }

                /// <summary>
                /// <para>The time when the restore job was updated. This value is a UNIX timestamp. Unit: seconds.</para>
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
                /// <para>v-0006******q</para>
                /// </summary>
                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
