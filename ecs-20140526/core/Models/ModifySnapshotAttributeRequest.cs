// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifySnapshotAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The description of the snapshot. The description can be empty and can be up to 256 characters in length. It cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to shutdown the instant access feature for the snapshot. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: shutdown the instant access feature.</description></item>
        /// <item><description>false: do not shutdown the instant access feature.
        /// Default value: false.</description></item>
        /// </list>
        /// <remarks>
        /// <para><b>[Deprecated]</b> This parameter is deprecated. Standard snapshots of ESSD cloud disks have been upgraded to <a href="https://help.aliyun.com/document_detail/193667.html">instant access by default</a>. You do not need to perform additional configurations, and no additional fees are incurred.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableInstantAccess")]
        [Validation(Required=false)]
        public bool? DisableInstantAccess { get; set; }

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
        /// <para>The retention period of the snapshot in days. When you specify this parameter, the retention period is calculated from the <b>creation time</b> of the snapshot. The creation time is represented in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format and displayed in UTC. Valid values: 1 to 65536.</para>
        /// <remarks>
        /// <para>You can only extend the retention period of a snapshot. You cannot shorten the existing retention period.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// <para>The snapshot ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp199lyny9bb47pa****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The display name of the snapshot. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with http:// or https://. It can contain digits, colons (:), underscores (_), and hyphens (-). To prevent name conflicts with automatic snapshots, the name cannot start with auto.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testSnapshotName</para>
        /// </summary>
        [NameInMap("SnapshotName")]
        [Validation(Required=false)]
        public string SnapshotName { get; set; }

    }

}
