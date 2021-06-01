// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Snapshot20210315.Models
{
    public class ListSnapshotBlocksRequest : TeaModel {
        /// <summary>
        /// 标记当前开始读取的位置，置空表示从 StartingBlockIndex 指定 Block 开始，最大长度 256 字节
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 本次读取的最大数据记录数量，最小 100， 最大 10000， 默认为 100
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// 幂等参数
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 待列出数据块的快照名称，最大 256 字节
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// 列出快照中数据块起始索引值，从零开始，最大值为快照数据块总数减一。NextToken 不为空时忽略此参数
        /// </summary>
        [NameInMap("StartingBlockIndex")]
        [Validation(Required=false)]
        public long? StartingBlockIndex { get; set; }

    }

}
