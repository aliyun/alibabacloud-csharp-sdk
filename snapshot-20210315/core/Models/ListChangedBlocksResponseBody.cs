// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Snapshot20210315.Models
{
    public class ListChangedBlocksResponseBody : TeaModel {
        /// <summary>
        /// 下一个待比较的数据块 BlockToken，为空时代表无其他待比较数据块，最大长度 256 字节
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 两个快照差异的数据块列表
        /// </summary>
        [NameInMap("ChangedBlocks")]
        [Validation(Required=false)]
        public List<ListChangedBlocksResponseBodyChangedBlocks> ChangedBlocks { get; set; }
        public class ListChangedBlocksResponseBodyChangedBlocks : TeaModel {
            /// <summary>
            /// 数据块的索引值，从零开始
            /// </summary>
            [NameInMap("BlockIndex")]
            [Validation(Required=false)]
            public long? BlockIndex { get; set; }

            /// <summary>
            /// FirstSnapshotId 中数据块的 Token，用于后续的数据读取，第一个快照未变化时可省略。最大长度 256 字节
            /// </summary>
            [NameInMap("FirstBlockToken")]
            [Validation(Required=false)]
            public string FirstBlockToken { get; set; }

            /// <summary>
            /// SecondBlockToken指定的快照中相对于 FirstBlockIndex 变化的数据块 Token，用于后续读取数据。最大长度 256 字节
            /// </summary>
            [NameInMap("SecondBlockToken")]
            [Validation(Required=false)]
            public string SecondBlockToken { get; set; }

        }

        /// <summary>
        /// 差异数据块 token 过期 UTC 时间戳， 单位微秒
        /// </summary>
        [NameInMap("ExpiryTime")]
        [Validation(Required=false)]
        public long? ExpiryTime { get; set; }

        /// <summary>
        /// 第二个快照大小，单位 GB，最小 1GB
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
        /// 本次查询中变化数据块数量
        /// </summary>
        [NameInMap("BlockCount")]
        [Validation(Required=false)]
        public long? BlockCount { get; set; }

        /// <summary>
        /// 第二个快照相对于第一个快照差异数据快总数
        /// </summary>
        [NameInMap("TotalBlockCount")]
        [Validation(Required=false)]
        public long? TotalBlockCount { get; set; }

    }

}
