// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeUdmSnapshotsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. A value of 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The message that is returned. If the request was successful, <b>successful</b> is returned. If the request failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51CDEECB-7001-51CC-94AC-2A0F2A4B71D2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the snapshots.</para>
        /// </summary>
        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public List<DescribeUdmSnapshotsResponseBodySnapshots> Snapshots { get; set; }
        public class DescribeUdmSnapshotsResponseBodySnapshots : TeaModel {
            /// <summary>
            /// <para>The actual size of the snapshot. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("ActualBytes")]
            [Validation(Required=false)]
            public string ActualBytes { get; set; }

            /// <summary>
            /// <para>The special retention type. This parameter is valid only for special retention backups. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>WEEKLY</b>: weekly special retention backup</para>
            /// </description></item>
            /// <item><description><para><b>MONTHLY</b>: monthly special retention backup</para>
            /// </description></item>
            /// <item><description><para><b>YEARLY</b>: yearly special retention backup</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WEEKLY</para>
            /// </summary>
            [NameInMap("AdvancedRetentionType")]
            [Validation(Required=false)]
            public string AdvancedRetentionType { get; set; }

            /// <summary>
            /// <para>The error message that is returned if the archiving fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InternalError</para>
            /// </summary>
            [NameInMap("ArchiveErrorMessage")]
            [Validation(Required=false)]
            public string ArchiveErrorMessage { get; set; }

            /// <summary>
            /// <para>The archiving status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ARCHIVED</para>
            /// </summary>
            [NameInMap("ArchiveStatus")]
            [Validation(Required=false)]
            public string ArchiveStatus { get; set; }

            /// <summary>
            /// <para>The time when the archiving was triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1763373304</para>
            /// </summary>
            [NameInMap("ArchiveTriggerTime")]
            [Validation(Required=false)]
            public long? ArchiveTriggerTime { get; set; }

            /// <summary>
            /// <para>The backup type. The value <b>COMPLETE</b> indicates a full backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// <para>The total size of the data source. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("BytesTotal")]
            [Validation(Required=false)]
            public long? BytesTotal { get; set; }

            /// <summary>
            /// <para>Indicates whether the disk backup point can be deleted. This parameter is valid only if <b>SourceType</b> is set to <b>UDM_ECS_DISK</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("CanBeDeleted")]
            [Validation(Required=false)]
            public bool? CanBeDeleted { get; set; }

            /// <summary>
            /// <para>The time when the backup snapshot was completed. This value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1646895666</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public long? CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the backup snapshot was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1607436917</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the backup snapshot was created. This value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1642496679</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The details of the snapshot.</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public DescribeUdmSnapshotsResponseBodySnapshotsDetail Detail { get; set; }
            public class DescribeUdmSnapshotsResponseBodySnapshotsDetail : TeaModel {
                /// <summary>
                /// <para>The consistency level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CRASH</para>
                /// </summary>
                [NameInMap("ConsistentLevel")]
                [Validation(Required=false)]
                public string ConsistentLevel { get; set; }

                /// <summary>
                /// <para>Indicates whether the system disk is included.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ContainOsDisk")]
                [Validation(Required=false)]
                public bool? ContainOsDisk { get; set; }

                /// <summary>
                /// <para>The type of the source disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("DiskCategory")]
                [Validation(Required=false)]
                public string DiskCategory { get; set; }

                /// <summary>
                /// <para>The name of the disk device.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/dev/xvdb</para>
                /// </summary>
                [NameInMap("DiskDevName")]
                [Validation(Required=false)]
                public string DiskDevName { get; set; }

                /// <summary>
                /// <para>The mapping between devices and backup point IDs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;/dev/xvdb&quot;:&quot;s-0000u7y6wm3v1e7hxh5a&quot;,					 
                ///     &quot;/dev/xvda&quot;:&quot;s-0004bl6yr5pt89jjsv5a&quot;
                /// }</para>
                /// </summary>
                [NameInMap("DiskHbrSnapshotIdWithDeviceMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> DiskHbrSnapshotIdWithDeviceMap { get; set; }

                /// <summary>
                /// <para>The list of disk IDs that are included in the backup point.</para>
                /// </summary>
                [NameInMap("DiskIdList")]
                [Validation(Required=false)]
                public List<string> DiskIdList { get; set; }

                /// <summary>
                /// <para>The reason for the downgrade.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HBR.NoRamRoleBound</para>
                /// </summary>
                [NameInMap("DowngradeReason")]
                [Validation(Required=false)]
                public string DowngradeReason { get; set; }

                /// <summary>
                /// <para>The hostname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iZbpxxxxxxxxxxxxxxxxe2Z</para>
                /// </summary>
                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                /// <summary>
                /// <para>The mapping between instance IDs and disk IDs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;i-bp1dlp0keohh7ids4uo6&quot;:&quot;d-bp1e6427vhd320hifvs&quot;,					 
                ///     &quot;i-bp1dlp0keohh7ids4uo6&quot;:&quot;d-bp1e6427vhd320hifvd&quot;
                /// }</para>
                /// </summary>
                [NameInMap("InstanceIdWithDiskIdListMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> InstanceIdWithDiskIdListMap { get; set; }

                /// <summary>
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>swh-hbr</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The instance type of the source instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.c6.xlarge</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>Indicates whether the backup is created for the instant clone feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("InstantAccess")]
                [Validation(Required=false)]
                public bool? InstantAccess { get; set; }

                /// <summary>
                /// <para>The list of native snapshot IDs. The native snapshot IDs in this list have a one-to-one correspondence with the disk IDs in the DiskIdList.</para>
                /// </summary>
                [NameInMap("NativeSnapshotIdList")]
                [Validation(Required=false)]
                public List<string> NativeSnapshotIdList { get; set; }

                /// <summary>
                /// <para>The ID of the system disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-bp1e6427vhd320hifvc</para>
                /// </summary>
                [NameInMap("OsDiskId")]
                [Validation(Required=false)]
                public string OsDiskId { get; set; }

                /// <summary>
                /// <para>The name of the operating system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Debian 10.10 64-bit (UEFI)</para>
                /// </summary>
                [NameInMap("OsName")]
                [Validation(Required=false)]
                public string OsName { get; set; }

                /// <summary>
                /// <para>The English name of the operating system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Debian  11.1 64 bit</para>
                /// </summary>
                [NameInMap("OsNameEn")]
                [Validation(Required=false)]
                public string OsNameEn { get; set; }

                /// <summary>
                /// <para>The type of the operating system. Valid values: linux, windows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>windows</para>
                /// </summary>
                [NameInMap("OsType")]
                [Validation(Required=false)]
                public string OsType { get; set; }

                /// <summary>
                /// <para>The performance level of the source disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PL0</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>The operating system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS</para>
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// <para>The ID of the snapshot group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ssg-uf6856txcaq31uj***</para>
                /// </summary>
                [NameInMap("SnapshotGroupId")]
                [Validation(Required=false)]
                public string SnapshotGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether the disk is a system disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SystemDisk")]
                [Validation(Required=false)]
                public bool? SystemDisk { get; set; }

                /// <summary>
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BNSHSVR42 IPGUARD</para>
                /// </summary>
                [NameInMap("VmName")]
                [Validation(Required=false)]
                public string VmName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the disk. The disk can be a cloud disk or a local disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-2ze86h5fga5rfwxxa8ef</para>
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// <para>The time when the backup expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640334062</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The ID of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1f0pe78dxizrsdcgxd</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the backup job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-00030j3chkt******2</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The ID of the native snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-00047mg17p26x*****b</para>
            /// </summary>
            [NameInMap("NativeSnapshotId")]
            [Validation(Required=false)]
            public string NativeSnapshotId { get; set; }

            /// <summary>
            /// <para>The information about the native snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///                     &quot;sourceDiskId&quot;:&quot;d-bp17misjuy636t82v7b0&quot;,
            ///                     &quot;lastModifiedTime&quot;:&quot;2022-03-09T11:35:12Z&quot;,
            ///                     &quot;snapshotSN&quot;:&quot;64588-429372675-857161235&quot;,
            ///                     &quot;snapshotId&quot;:&quot;s-bp1fbtwv3e6xr6wpe9e0&quot;,
            ///                     &quot;creationTime&quot;:&quot;2022-03-09T11:31:12Z&quot;,
            ///                     &quot;snapshotType&quot;:&quot;user&quot;,
            ///                     &quot;usage&quot;:&quot;none&quot;,
            ///                     &quot;description&quot;:&quot;&quot;,
            ///                     &quot;sourceStorageType&quot;:&quot;disk&quot;,
            ///                     &quot;tags&quot;:[
            ///                         {
            ///                             &quot;tagValue&quot;:&quot;job-0007e0wqjl0imbrtkmnm&quot;,
            ///                             &quot;tagKey&quot;:&quot;HBR JobId&quot;
            ///                         }
            ///                     ],
            ///                     &quot;productCode&quot;:&quot;&quot;,
            ///                     &quot;encrypted&quot;:false,
            ///                     &quot;sourceDiskType&quot;:&quot;system&quot;,
            ///                     &quot;retentionDays&quot;:30,
            ///                     &quot;snapshotName&quot;:&quot;Created-from-HBR-job:job-0007e0wqjl0imbrtkmnm&quot;,
            ///                     &quot;kMSKeyId&quot;:&quot;&quot;,
            ///                     &quot;progress&quot;:&quot;100%&quot;,
            ///                     &quot;category&quot;:&quot;standard&quot;,
            ///                     &quot;sourceDiskSize&quot;:&quot;20&quot;,
            ///                     &quot;status&quot;:&quot;accomplished&quot;
            ///                 }</para>
            /// </summary>
            [NameInMap("NativeSnapshotInfo")]
            [Validation(Required=false)]
            public string NativeSnapshotInfo { get; set; }

            /// <summary>
            /// <para>The hash value of the parent snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f2fe..</para>
            /// </summary>
            [NameInMap("ParentSnapshotHash")]
            [Validation(Required=false)]
            public string ParentSnapshotHash { get; set; }

            /// <summary>
            /// <para>The prefix of the snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example/</para>
            /// </summary>
            [NameInMap("Prefix")]
            [Validation(Required=false)]
            public string Prefix { get; set; }

            /// <summary>
            /// <para>The timestamp of the snapshot. This value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1642496679</para>
            /// </summary>
            [NameInMap("RealSnapshotTime")]
            [Validation(Required=false)]
            public long? RealSnapshotTime { get; set; }

            /// <summary>
            /// <para>The retention period of the snapshot in days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public long? Retention { get; set; }

            /// <summary>
            /// <para>The hash value of the snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f2fe...</para>
            /// </summary>
            [NameInMap("SnapshotHash")]
            [Validation(Required=false)]
            public string SnapshotHash { get; set; }

            /// <summary>
            /// <para>The ID of the backup snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-00047mxg17p26*****b</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// <para>The type of the data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>UDM_ECS</b>: ECS instance backup</para>
            /// </description></item>
            /// <item><description><para><b>UDM_ECS_DISK</b>: a disk backup subtask of an ECS instance backup</para>
            /// </description></item>
            /// <item><description><para><b>UDM_DISK</b>: disk backup</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UDM_ECS</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The time when the snapshot was started. This value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1554347313</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The status of the backup snapshot. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>COMPLETE</b>: The backup is successful.</para>
            /// </description></item>
            /// <item><description><para><b>PARTIAL_COMPLETE</b>: The backup is partially successful.</para>
            /// </description></item>
            /// <item><description><para><b>FAILED</b>: The backup failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the backup snapshot was updated. This value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1642496679</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of snapshots.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
