// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class CreateInstanceSnapshotV2Request : TeaModel {
        /// <summary>
        /// 镜像地址
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 实例快照描述
        /// </summary>
        [NameInMap("SnapshotDescription")]
        [Validation(Required=false)]
        public string SnapshotDescription { get; set; }

        /// <summary>
        /// 实例快照名称
        /// </summary>
        [NameInMap("SnapshotName")]
        [Validation(Required=false)]
        public string SnapshotName { get; set; }

    }

}
