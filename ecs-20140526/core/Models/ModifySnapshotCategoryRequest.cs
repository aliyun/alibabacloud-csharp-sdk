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
        /// <item><description>Archive: archive snapshot.</description></item>
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
        /// <para>The number of days for which the snapshot is retained. The retention period starts from the snapshot creation time (CreationTime). A standard snapshot must have been retained for at least 14 days after creation before it can be archived.</para>
        /// <para>Archive snapshots must be retained for at least 60 days. When the retention period of an archive snapshot is calculated, the retention period of the standard snapshot is deducted. If an archive snapshot is deleted before 60 days, you are charged for 60 days of archive storage. For more information, see <a href="https://help.aliyun.com/document_detail/56159.html">Snapshot billing</a>.</para>
        /// <para>Valid values: [74, 65536].</para>
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
