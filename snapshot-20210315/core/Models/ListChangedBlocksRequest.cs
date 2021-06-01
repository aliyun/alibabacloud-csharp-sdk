// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Snapshot20210315.Models
{
    public class ListChangedBlocksRequest : TeaModel {
        /// <summary>
        /// 标记开始比较差异的位置，为空时代表从 StartingBlockIndex 指定数据块开始比较， 最大长度 256 字节
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 本次读取的最大数据记录数量，最小 100，最大 10000
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
        /// 待比较的第一个快照名称，最大 256 字节
        /// </summary>
        [NameInMap("FirstSnapshotId")]
        [Validation(Required=false)]
        public string FirstSnapshotId { get; set; }

        /// <summary>
        /// 待比较的第二个快照名称，最大 256 字节
        /// </summary>
        [NameInMap("SecondSnapshotId")]
        [Validation(Required=false)]
        public string SecondSnapshotId { get; set; }

        /// <summary>
        /// 两个快照比较的起始数据块 index，从零开始，最大值为第二快照的数据块总数量减一。当 NextToken 不为空时忽略该参数
        /// </summary>
        [NameInMap("StartingBlockIndex")]
        [Validation(Required=false)]
        public long? StartingBlockIndex { get; set; }

    }

}
