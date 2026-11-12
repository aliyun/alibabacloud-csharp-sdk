// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeFileSystemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of file system information.</para>
        /// </summary>
        [NameInMap("FileSystems")]
        [Validation(Required=false)]
        public List<DescribeFileSystemsResponseBodyFileSystems> FileSystems { get; set; }
        public class DescribeFileSystemsResponseBodyFileSystems : TeaModel {
            /// <summary>
            /// <para>The capacity. Unit: MiB.</para>
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
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-cmcc</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The file system ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c50f8*****</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>The file system name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FileSystem1</para>
            /// </summary>
            [NameInMap("FileSystemName")]
            [Validation(Required=false)]
            public string FileSystemName { get; set; }

            /// <summary>
            /// <para>The file system usage.
            /// Non-real-time usage. It indicates the maximum usage in the previous hour. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102400</para>
            /// </summary>
            [NameInMap("MeteredSize")]
            [Validation(Required=false)]
            public long? MeteredSize { get; set; }

            /// <summary>
            /// <para>The collection of mount target information.</para>
            /// </summary>
            [NameInMap("MountTargets")]
            [Validation(Required=false)]
            public List<DescribeFileSystemsResponseBodyFileSystemsMountTargets> MountTargets { get; set; }
            public class DescribeFileSystemsResponseBodyFileSystemsMountTargets : TeaModel {
                /// <summary>
                /// <para>The mount target path.</para>
                /// 
                /// <b>Example:</b>
                /// <para><em>.</em>.<em>.</em>:/${FileSystemName}/{MountTargetName}</para>
                /// </summary>
                [NameInMap("MountTargetDomain")]
                [Validation(Required=false)]
                public string MountTargetDomain { get; set; }

                /// <summary>
                /// <para>The mount target name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>target1</para>
                /// </summary>
                [NameInMap("MountTargetName")]
                [Validation(Required=false)]
                public string MountTargetName { get; set; }

                /// <summary>
                /// <para>The network ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n-****</para>
                /// </summary>
                [NameInMap("NetWorkId")]
                [Validation(Required=false)]
                public string NetWorkId { get; set; }

                /// <summary>
                /// <para>The mount target status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>active: Available.</description></item>
                /// <item><description>inactive: Unavailable.</description></item>
                /// <item><description>pending: Processing a task.</description></item>
                /// <item><description>deleting: Being deleted.</description></item>
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
            /// <para>The billing method. Valid values: PostPaid (pay-as-you-go).</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The file system protocol type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NFS: NFS protocol.</description></item>
            /// <item><description>SMB: SMB protocol.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NFS</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>The file system status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>pending: The file system is processing a node.</description></item>
            /// <item><description>running: The file system is active. You can perform What to do next, such as creating a mount target, only when the status is running.</description></item>
            /// <item><description>stopped: The file system is unavailable.</description></item>
            /// <item><description>extending: The file system is being expanded.</description></item>
            /// <item><description>stopping: The file system is being stopped.</description></item>
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
            /// <item><description>capacity: Storage-optimized.</description></item>
            /// <item><description>performance: Extreme.</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>762DD527-358B-1E48-8005-CCE3ED4EB9E0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
