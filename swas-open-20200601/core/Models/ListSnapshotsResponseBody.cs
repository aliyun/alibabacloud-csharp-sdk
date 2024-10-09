// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListSnapshotsResponseBody : TeaModel {
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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20758A-585D-4A41-A9B2-28DA8F4F534F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details about the snapshots.</para>
        /// </summary>
        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public List<ListSnapshotsResponseBodySnapshots> Snapshots { get; set; }
        public class ListSnapshotsResponseBodySnapshots : TeaModel {
            /// <summary>
            /// <para>The time when the snapshot was created. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-09T07:12:49Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the simple application server.</para>
            /// <para>Note: This parameter has a value returned for only system disk snapshots.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2ad1ae67295445f598017499dc****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The progress of snapshot creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100%</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

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
            /// <para>The remarks of the snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-Remark</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the snapshot belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2bti7cf7****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The time when the last disk rollback was performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-09T07:12:49Z</para>
            /// </summary>
            [NameInMap("RollbackTime")]
            [Validation(Required=false)]
            public string RollbackTime { get; set; }

            /// <summary>
            /// <para>The snapshot ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-bp16oazlsold4dks****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// <para>The name of the snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-SnapshotName</para>
            /// </summary>
            [NameInMap("SnapshotName")]
            [Validation(Required=false)]
            public string SnapshotName { get; set; }

            /// <summary>
            /// <para>The ID of the source disk. This parameter has a value even after the source disk is released.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-bp14wq0149cpp2xy****</para>
            /// </summary>
            [NameInMap("SourceDiskId")]
            [Validation(Required=false)]
            public string SourceDiskId { get; set; }

            /// <summary>
            /// <para>The type of the source disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>system: system disk.</description></item>
            /// <item><description>data: data disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>System</para>
            /// </summary>
            [NameInMap("SourceDiskType")]
            [Validation(Required=false)]
            public string SourceDiskType { get; set; }

            /// <summary>
            /// <para>The status of the snapshot. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Progressing: The snapshot is being created.</description></item>
            /// <item><description>Accomplished: The snapshot is created.</description></item>
            /// <item><description>Failed: The snapshot failed to be created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Accomplished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags of the snapshot.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListSnapshotsResponseBodySnapshotsTags> Tags { get; set; }
            public class ListSnapshotsResponseBodySnapshotsTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

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
