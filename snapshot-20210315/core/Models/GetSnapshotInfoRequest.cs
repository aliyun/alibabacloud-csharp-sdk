/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Snapshot20210315.Models
{
    public class GetSnapshotInfoRequest : TeaModel {
        /// <summary>
        /// 幂等参数
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 待读取数据的快照名称
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// 是否返回详细信息，详细信息需要更多查询时间，默认为 False
        /// </summary>
        [NameInMap("ShowDetail")]
        [Validation(Required=false)]
        public bool? ShowDetail { get; set; }

    }

}
