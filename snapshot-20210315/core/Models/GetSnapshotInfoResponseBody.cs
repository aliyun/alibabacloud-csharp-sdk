// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Snapshot20210315.Models
{
    public class GetSnapshotInfoResponseBody : TeaModel {
        /// <summary>
        /// 快照大小，单位 GB，最小 1GB
        /// </summary>
        [NameInMap("VolumeSize")]
        [Validation(Required=false)]
        public long? VolumeSize { get; set; }

        /// <summary>
        /// 快照数据快大小，单位 Bytes
        /// </summary>
        [NameInMap("BlockSize")]
        [Validation(Required=false)]
        public long? BlockSize { get; set; }

        /// <summary>
        /// 快照数据块总数量，包含空数据块
        /// </summary>
        [NameInMap("BlockCount")]
        [Validation(Required=false)]
        public long? BlockCount { get; set; }

        /// <summary>
        /// 快照中非空数据块总数量，仅在 ShowDetail 为 True 时返回
        /// </summary>
        [NameInMap("ValidBlockCount")]
        [Validation(Required=false)]
        public long? ValidBlockCount { get; set; }

        /// <summary>
        /// 快照状态。    "SNAPSHOT_INVALID",     "SNAPSHOT_PENDING",     "SNAPSHOT_COMMITTED",     "SNAPSHOT_DELETED"
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 快照创建时间戳
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 快照是否为加密快照
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

    }

}
