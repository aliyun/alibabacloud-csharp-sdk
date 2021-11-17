// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class InstanceSnapshot : TeaModel {
        /// <summary>
        /// 实例快照保存时间（GMT）
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// 实例快照修改时间（GMT）
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 实例快照描述
        /// </summary>
        [NameInMap("InstanceSnapshotDescription")]
        [Validation(Required=false)]
        public string InstanceSnapshotDescription { get; set; }

        /// <summary>
        /// 实例快照ID
        /// </summary>
        [NameInMap("InstanceSnapshotId")]
        [Validation(Required=false)]
        public string InstanceSnapshotId { get; set; }

        /// <summary>
        /// 实例快照名称
        /// </summary>
        [NameInMap("InstanceSnapshotName")]
        [Validation(Required=false)]
        public string InstanceSnapshotName { get; set; }

        /// <summary>
        /// 实例快照存储地址
        /// </summary>
        [NameInMap("InstanceSnapshotRepoUrl")]
        [Validation(Required=false)]
        public string InstanceSnapshotRepoUrl { get; set; }

        /// <summary>
        /// 实例快照状态
        /// </summary>
        [NameInMap("InstanceSnapshotStatus")]
        [Validation(Required=false)]
        public string InstanceSnapshotStatus { get; set; }

        /// <summary>
        /// 实例快照标签
        /// </summary>
        [NameInMap("InstanceSnapshotTag")]
        [Validation(Required=false)]
        public string InstanceSnapshotTag { get; set; }

    }

}
