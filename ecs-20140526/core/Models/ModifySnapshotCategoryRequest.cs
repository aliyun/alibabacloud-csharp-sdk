// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifySnapshotCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The snapshot type.</para>
        /// <list type="bullet">
        /// <item><description>Archive: Archive snapshot</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Archive</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The retention period of the snapshot in days. The retention period starts from the time when the snapshot is created, which is specified by CreationTime. A standard snapshot must be retained for at least 14 days after it is created before it can be archived.</para>
        /// <para>Archive snapshots have a retention period limit and must be retained as archive snapshots for at least 60 days. When you calculate the retention period of an archive snapshot, the period during which the snapshot was retained as a standard snapshot is deducted. If you delete an archive snapshot before it is retained for 60 days, you are charged for 60 days of archive storage. For more information, see <a href="https://help.aliyun.com/document_detail/56159.html">Snapshot billing</a>.</para>
        /// <para>Valid values: 74 to 65536.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the snapshot is permanently retained.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// <para>The snapshot ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-123**sd</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

    }

}
