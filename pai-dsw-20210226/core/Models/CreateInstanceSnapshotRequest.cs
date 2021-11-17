// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class CreateInstanceSnapshotRequest : TeaModel {
        /// <summary>
        /// 实例快照描述
        /// </summary>
        [NameInMap("InstanceSnapshotDescription")]
        [Validation(Required=false)]
        public string InstanceSnapshotDescription { get; set; }

        /// <summary>
        /// 实例快照名称
        /// </summary>
        [NameInMap("InstanceSnapshotName")]
        [Validation(Required=false)]
        public string InstanceSnapshotName { get; set; }

        /// <summary>
        /// 实例快照存储地址（可选）
        /// </summary>
        [NameInMap("InstanceSnapshotRepoUrl")]
        [Validation(Required=false)]
        public string InstanceSnapshotRepoUrl { get; set; }

    }

}
