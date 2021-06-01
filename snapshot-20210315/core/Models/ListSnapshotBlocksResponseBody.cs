// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Snapshot20210315.Models
{
    public class ListSnapshotBlocksResponseBody : TeaModel {
        /// <summary>
        /// 返回下一个有效数据块 token，为空时代表无其他有效数据块，最大  256 字节
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 快照有效数据块信息列表，不包含空数据块
        /// </summary>
        [NameInMap("Blocks")]
        [Validation(Required=false)]
        public List<ListSnapshotBlocksResponseBodyBlocks> Blocks { get; set; }
        public class ListSnapshotBlocksResponseBodyBlocks : TeaModel {
            /// <summary>
            /// 数据块的索引值，从零开始
            /// </summary>
            [NameInMap("BlockIndex")]
            [Validation(Required=false)]
            public long? BlockIndex { get; set; }

            /// <summary>
            /// 数据块的 Token，用于后续的数据读取。最大长度 256 字节
            /// </summary>
            [NameInMap("BlockToken")]
            [Validation(Required=false)]
            public string BlockToken { get; set; }

        }

        /// <summary>
        /// BlockToken 过期 UTC 时间戳, 单位微秒
        /// </summary>
        [NameInMap("ExpiryTime")]
        [Validation(Required=false)]
        public long? ExpiryTime { get; set; }

        /// <summary>
        /// 快照大小，单位 GB，最小 1GB
        /// </summary>
        [NameInMap("VolumeSize")]
        [Validation(Required=false)]
        public long? VolumeSize { get; set; }

        /// <summary>
        /// 数据块大小，单位 Byte
        /// </summary>
        [NameInMap("BlockSize")]
        [Validation(Required=false)]
        public long? BlockSize { get; set; }

        /// <summary>
        /// 本次查询中快照有效数据块数量
        /// </summary>
        [NameInMap("BlockCount")]
        [Validation(Required=false)]
        public long? BlockCount { get; set; }

        /// <summary>
        /// 快照有效数据块总数量
        /// </summary>
        [NameInMap("TotalBlockCount")]
        [Validation(Required=false)]
        public long? TotalBlockCount { get; set; }

    }

}
