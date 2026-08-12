// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeBackupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeBackupsResponseBodyData> Data { get; set; }
        public class DescribeBackupsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The end time of this backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1742179028000</para>
            /// </summary>
            [NameInMap("BackupFinishedTime")]
            [Validation(Required=false)]
            public long? BackupFinishedTime { get; set; }

            /// <summary>
            /// <para>The start time of this backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1742179018000</para>
            /// </summary>
            [NameInMap("BackupStartTime")]
            [Validation(Required=false)]
            public long? BackupStartTime { get; set; }

            /// <summary>
            /// <para>The backup task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bt-12sui21312dd</para>
            /// </summary>
            [NameInMap("BackupTaskId")]
            [Validation(Required=false)]
            public string BackupTaskId { get; set; }

            /// <summary>
            /// <para>The backup type:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Fast backup.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Consistent backup.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FullBackup</para>
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// <para>The task description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>任务描述</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The expiration time of the backup data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1742189008000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-d4be777ff5e8cXXX</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The backup instance information.</para>
            /// </summary>
            [NameInMap("InstanceSnapshot")]
            [Validation(Required=false)]
            public DescribeBackupsResponseBodyDataInstanceSnapshot InstanceSnapshot { get; set; }
            public class DescribeBackupsResponseBodyDataInstanceSnapshot : TeaModel {
                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c-37708ec80b5****</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The minor version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.3.13-1.0-1.7.2</para>
                /// </summary>
                [NameInMap("MinorVersion")]
                [Validation(Required=false)]
                public string MinorVersion { get; set; }

                /// <summary>
                /// <para>The compute group information.</para>
                /// </summary>
                [NameInMap("NodeGroups")]
                [Validation(Required=false)]
                public List<DescribeBackupsResponseBodyDataInstanceSnapshotNodeGroups> NodeGroups { get; set; }
                public class DescribeBackupsResponseBodyDataInstanceSnapshotNodeGroups : TeaModel {
                    /// <summary>
                    /// <para>The compute group type. Includes the following values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>FE</para>
                    /// </description></item>
                    /// <item><description><para>BE</para>
                    /// </description></item>
                    /// <item><description><para>CN</para>
                    /// </description></item>
                    /// <item><description><para>OBSERVER</para>
                    /// </description></item>
                    /// <item><description><para>AGENT</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FE</para>
                    /// </summary>
                    [NameInMap("ComponentType")]
                    [Validation(Required=false)]
                    public string ComponentType { get; set; }

                    /// <summary>
                    /// <para>The number of CUs. A CU (Compute Unit) is the basic unit of measurement for the service. 1 CU equals 1 CPU core + 4 GiB memory. If SpecType is memory-enhanced instance family, 1 CU equals 1 CPU core + 8 GiB memory.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("Cu")]
                    [Validation(Required=false)]
                    public int? Cu { get; set; }

                    /// <summary>
                    /// <para>The number of disks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("DiskNumber")]
                    [Validation(Required=false)]
                    public string DiskNumber { get; set; }

                    /// <summary>
                    /// <para>The node group\&quot;s local SSD instance type. This value is only meaningful for ECS instances where SpecType is local SSD or large-capacity storage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("LocalStorageInstanceType")]
                    [Validation(Required=false)]
                    public string LocalStorageInstanceType { get; set; }

                    /// <summary>
                    /// <para>The number of nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("ResidentNodeNumber")]
                    [Validation(Required=false)]
                    public string ResidentNodeNumber { get; set; }

                    /// <summary>
                    /// <para>The compute group specification type. Includes the following types:</para>
                    /// <list type="bullet">
                    /// <item><description><para>standard: Standard Edition.</para>
                    /// </description></item>
                    /// <item><description><para>localSSD: Local SSD.</para>
                    /// </description></item>
                    /// <item><description><para>bigData: Large-capacity storage.</para>
                    /// </description></item>
                    /// <item><description><para>ramEnhanced: Memory-enhanced instance family.</para>
                    /// </description></item>
                    /// <item><description><para>networkEnhanced: Network-enhanced.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>standard</para>
                    /// </summary>
                    [NameInMap("SpecType")]
                    [Validation(Required=false)]
                    public string SpecType { get; set; }

                    /// <summary>
                    /// <para>The performance level (PL) of the cloud disk. Includes the following values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>pl0: Maximum random read/write IOPS of 10,000 per disk.</para>
                    /// </description></item>
                    /// <item><description><para>pl1: Maximum random read/write IOPS of 50,000 per disk.</para>
                    /// </description></item>
                    /// <item><description><para>pl2: Maximum random read/write IOPS of 100,000 per disk.</para>
                    /// </description></item>
                    /// <item><description><para>pl3: Maximum random read/write IOPS of 1,000,000 per disk.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pl1</para>
                    /// </summary>
                    [NameInMap("StoragePerformanceLevel")]
                    [Validation(Required=false)]
                    public string StoragePerformanceLevel { get; set; }

                    /// <summary>
                    /// <para>The storage size in GiB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("StorageSize")]
                    [Validation(Required=false)]
                    public int? StorageSize { get; set; }

                }

                /// <summary>
                /// <para>The region ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aekzd7frphchx3a</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The cluster\&quot;s running mode:</para>
                /// <list type="bullet">
                /// <item><description><para>Shared-nothing.</para>
                /// </description></item>
                /// <item><description><para>Shared-data.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>shared_data</para>
                /// </summary>
                [NameInMap("RunMode")]
                [Validation(Required=false)]
                public string RunMode { get; set; }

                /// <summary>
                /// <para>The compute group specification type. Includes the following types:</para>
                /// <list type="bullet">
                /// <item><description><para>standard: Standard Edition.</para>
                /// </description></item>
                /// <item><description><para>localSSD: Local SSD.</para>
                /// </description></item>
                /// <item><description><para>bigData: Large-capacity storage.</para>
                /// </description></item>
                /// <item><description><para>ramEnhanced: Memory-enhanced instance family.</para>
                /// </description></item>
                /// <item><description><para>networkEnhanced: Network-enhanced.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("SpecType")]
                [Validation(Required=false)]
                public string SpecType { get; set; }

                /// <summary>
                /// <para>The tag information.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<DescribeBackupsResponseBodyDataInstanceSnapshotTags> Tags { get; set; }
                public class DescribeBackupsResponseBodyDataInstanceSnapshotTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bk-time</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1747708000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The cluster version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.3</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2ze0cez8106f2n85c2d7i</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The cloud disk size in GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The backup job status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of backup subtasks.</para>
            /// </summary>
            [NameInMap("SubTasks")]
            [Validation(Required=false)]
            public List<DescribeBackupsResponseBodyDataSubTasks> SubTasks { get; set; }
            public class DescribeBackupsResponseBodyDataSubTasks : TeaModel {
                /// <summary>
                /// <para>The database name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test1</para>
                /// </summary>
                [NameInMap("DataBase")]
                [Validation(Required=false)]
                public string DataBase { get; set; }

                /// <summary>
                /// <para>The snapshot ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <para>The task end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1747718190</para>
                /// </summary>
                [NameInMap("FinishedTime")]
                [Validation(Required=false)]
                public long? FinishedTime { get; set; }

                /// <summary>
                /// <para>The data size in GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <para>The snapshot name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-02-10_backup</para>
                /// </summary>
                [NameInMap("SnapshotName")]
                [Validation(Required=false)]
                public string SnapshotName { get; set; }

                /// <summary>
                /// <para>The task start date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1747708190</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The backup job status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The data table name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cdc_ods_t2030_lcpf_api_topic_msg</para>
                /// </summary>
                [NameInMap("Table")]
                [Validation(Required=false)]
                public string Table { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid params: [instance not exists].</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP request status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32A44F0D-BFF6-5664-999A-218BBDE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
