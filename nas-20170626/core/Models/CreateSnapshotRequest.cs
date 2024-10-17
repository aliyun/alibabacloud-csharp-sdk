// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateSnapshotRequest : TeaModel {
        /// <summary>
        /// <para>The description of the snapshot.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The description must be 2 to 256 characters in length.</description></item>
        /// <item><description>The description cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>This parameter is empty by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FinanceDepet</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the advanced Extreme NAS file system. The value must start with <c>extreme-</c>, for example, <c>extreme-01dd****</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>extreme-01dd****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The retention period of the snapshot.</para>
        /// <para>Unit: days.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>\-1 (default). Auto snapshots are permanently retained. After the number of auto snapshots exceeds the upper limit, the earliest auto snapshot is automatically deleted.</description></item>
        /// <item><description>1 to 65536: Auto snapshots are retained for the specified days. After the retention period of auto snapshots expires, the auto snapshots are automatically deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// <para>The snapshot name.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).</description></item>
        /// <item><description>The name cannot start with auto because snapshots whose names start with auto are recognized as auto snapshots.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FinanceJoshua</para>
        /// </summary>
        [NameInMap("SnapshotName")]
        [Validation(Required=false)]
        public string SnapshotName { get; set; }

    }

}
