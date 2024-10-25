// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeFileSystemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the file systems.</para>
        /// </summary>
        [NameInMap("FileSystems")]
        [Validation(Required=false)]
        public List<DescribeFileSystemsResponseBodyFileSystems> FileSystems { get; set; }
        public class DescribeFileSystemsResponseBodyFileSystems : TeaModel {
            /// <summary>
            /// <para>The capacity of the file system. Unit: MiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

            /// <summary>
            /// <para>The time when the file system was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-31 12:00:00</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-cmcc</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The ID of the file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c50f8*****</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>The name of the file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FileSystem1</para>
            /// </summary>
            [NameInMap("FileSystemName")]
            [Validation(Required=false)]
            public string FileSystemName { get; set; }

            /// <summary>
            /// <para>The storage usage of the file system. The value of this parameter is the maximum storage usage of the file system over the last hour. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102400</para>
            /// </summary>
            [NameInMap("MeteredSize")]
            [Validation(Required=false)]
            public long? MeteredSize { get; set; }

            /// <summary>
            /// <para>The information about mount targets.</para>
            /// </summary>
            [NameInMap("MountTargets")]
            [Validation(Required=false)]
            public List<DescribeFileSystemsResponseBodyFileSystemsMountTargets> MountTargets { get; set; }
            public class DescribeFileSystemsResponseBodyFileSystemsMountTargets : TeaModel {
                /// <summary>
                /// <para>The path of the mount target.</para>
                /// 
                /// <b>Example:</b>
                /// <para><em>.</em>.<em>.</em>:/${FileSystemName}/{MountTargetName}</para>
                /// </summary>
                [NameInMap("MountTargetDomain")]
                [Validation(Required=false)]
                public string MountTargetDomain { get; set; }

                /// <summary>
                /// <para>The name of the mount target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>target1</para>
                /// </summary>
                [NameInMap("MountTargetName")]
                [Validation(Required=false)]
                public string MountTargetName { get; set; }

                /// <summary>
                /// <para>The ID of the network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n-****</para>
                /// </summary>
                [NameInMap("NetWorkId")]
                [Validation(Required=false)]
                public string NetWorkId { get; set; }

                /// <summary>
                /// <para>The status of the mount target. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>active: The mount target is available.</description></item>
                /// <item><description>inactive: The mount target is unavailable.</description></item>
                /// <item><description>pending: The task is running.</description></item>
                /// <item><description>deleting: The mount target is being deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The billing method. PostPaid is returned. PostPaid indicates the pay-as-you-go billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The protocol type of the file system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NFS: Network File System (NFS)</description></item>
            /// <item><description>SMB: Server Message Block (SMB)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NFS</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>The status of the file system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>pending: The file system is being created or modified.</description></item>
            /// <item><description>running: The file system is available. Before you create a mount target for the file system, make sure that the file system is in the running state.</description></item>
            /// <item><description>stopped: The file system is unavailable.</description></item>
            /// <item><description>extending: The file system is being scaled out.</description></item>
            /// <item><description>stopping: The file system is being disabled.</description></item>
            /// <item><description>deleting: The file system is being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The storage type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>capacity: Capacity NAS file systems</description></item>
            /// <item><description>performance: Performance NAS file systems</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>capacity</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>762DD527-358B-1E48-8005-CCE3ED4EB9E0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
