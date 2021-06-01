// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Snapshot20210315.Models
{
    public class GetSnapshotBlockRequest : TeaModel {
        /// <summary>
        /// 幂等参数
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 待读取的数据块索引，从零开始。从 ListChangedBlocks 或者 ListSnapshotBlocks 返回。最大为快照数据块数量减一
        /// </summary>
        [NameInMap("BlockIndex")]
        [Validation(Required=false)]
        public long? BlockIndex { get; set; }

        /// <summary>
        /// 待读取的数据块Token，从 ListChangedBlocks 或者 ListSnapshotBlocks 返回，最大长度 256 字节
        /// </summary>
        [NameInMap("BlockToken")]
        [Validation(Required=false)]
        public string BlockToken { get; set; }

        /// <summary>
        /// 待读取数据的快照名称，最大 256 字节
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

    }

}
