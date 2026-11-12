// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListSnapshotsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the snapshot list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query.</para>
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
        /// <para>The snapshot information.</para>
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
            /// <para>The instance ID of the simple application server.</para>
            /// <para>Note: This field has a value for system cloud disk snapshots and is empty for data cloud disk snapshots.</para>
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
            /// <para>The time of the most recent rollback. The time is in the UTC (Z) time zone in the YYYY-MM-DDThh:mm:ssZ format.</para>
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
            /// <para>The snapshot name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-SnapshotName</para>
            /// </summary>
            [NameInMap("SnapshotName")]
            [Validation(Required=false)]
            public string SnapshotName { get; set; }

            /// <summary>
            /// <para>The ID of the source disk. This value is retained even if the source disk of the snapshot has been released.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-bp14wq0149cpp2xy****</para>
            /// </summary>
            [NameInMap("SourceDiskId")]
            [Validation(Required=false)]
            public string SourceDiskId { get; set; }

            /// <summary>
            /// <para>The type of the source disk for the snapshot. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>System: system cloud disk.</description></item>
            /// <item><description>Data: data cloud disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>System</para>
            /// </summary>
            [NameInMap("SourceDiskType")]
            [Validation(Required=false)]
            public string SourceDiskType { get; set; }

            /// <summary>
            /// <para>The snapshot status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>progressing: The snapshot is being created.</description></item>
            /// <item><description>accomplished: The snapshot is created.</description></item>
            /// <item><description>failed: The snapshot failed to be created.</description></item>
            /// <item><description>disabled: Rollback is not supported.</description></item>
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
        /// <para>The total number of snapshots.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
