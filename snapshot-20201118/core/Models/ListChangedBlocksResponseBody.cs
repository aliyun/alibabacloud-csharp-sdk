// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Snapshot20201118.Models
{
    public class ListChangedBlocksResponseBody : TeaModel {
        /// <summary>
        /// TotalCount本次请求条件下的数据总量，此参数为可选参数，默认可不返回
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 下一页结果的 token，为空时代表无新增页
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public byte[] NextToken { get; set; }

        /// <summary>
        /// MaxResults本次请求所返回的最大记录条数
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

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
            /// 数据块的 Token，用于后续的数据读取
            /// </summary>
            [NameInMap("BlockToken")]
            [Validation(Required=false)]
            public byte[] BlockToken { get; set; }

        }

        /// <summary>
        /// 差异数据块 token 过期时间戳
        /// </summary>
        [NameInMap("ExpiryTime")]
        [Validation(Required=false)]
        public long? ExpiryTime { get; set; }

        /// <summary>
        /// 快照大小，单位 GB，最小 1GB
        /// </summary>
        [NameInMap("VolumeSize")]
        [Validation(Required=false)]
        public int? VolumeSize { get; set; }

        /// <summary>
        /// 数据块大小，单位 Byte
        /// </summary>
        [NameInMap("BlockSize")]
        [Validation(Required=false)]
        public int? BlockSize { get; set; }

    }

}
