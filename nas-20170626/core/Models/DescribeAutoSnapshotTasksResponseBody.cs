// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAutoSnapshotTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried automatic snapshot tasks.</para>
        /// </summary>
        [NameInMap("AutoSnapshotTasks")]
        [Validation(Required=false)]
        public DescribeAutoSnapshotTasksResponseBodyAutoSnapshotTasks AutoSnapshotTasks { get; set; }
        public class DescribeAutoSnapshotTasksResponseBodyAutoSnapshotTasks : TeaModel {
            [NameInMap("AutoSnapshotTask")]
            [Validation(Required=false)]
            public List<DescribeAutoSnapshotTasksResponseBodyAutoSnapshotTasksAutoSnapshotTask> AutoSnapshotTask { get; set; }
            public class DescribeAutoSnapshotTasksResponseBodyAutoSnapshotTasksAutoSnapshotTask : TeaModel {
                /// <summary>
                /// <para>The ID of the automatic snapshot policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sp-extreme-233e6****</para>
                /// </summary>
                [NameInMap("AutoSnapshotPolicyId")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyId { get; set; }

                /// <summary>
                /// <para>The ID of the file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>extreme-233e6****</para>
                /// </summary>
                [NameInMap("SourceFileSystemId")]
                [Validation(Required=false)]
                public string SourceFileSystemId { get; set; }

            }

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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of automatic snapshot tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
