/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Snapshot20201118.Models
{
    public class ListChangedBlocksRequest : TeaModel {
        /// <summary>
        /// 标记当前开始读取的位置，置空表示从头开始
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 本次读取的最大数据记录数量
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 幂等参数
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 待比较的第一个快照名称
        /// </summary>
        [NameInMap("FirstSnapshotId")]
        [Validation(Required=false)]
        public string FirstSnapshotId { get; set; }

        /// <summary>
        /// 待比较的第二个快照名称
        /// </summary>
        [NameInMap("SecondSnapshotId")]
        [Validation(Required=false)]
        public string SecondSnapshotId { get; set; }

        /// <summary>
        /// 两个快照比较的起始数据块 index，从零开始
        /// </summary>
        [NameInMap("StartingBlockIndex")]
        [Validation(Required=false)]
        public long? StartingBlockIndex { get; set; }

    }

}
