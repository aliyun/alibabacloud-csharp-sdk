// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskReplicaPairProgressResponseBody : TeaModel {
        /// <summary>
        /// 同步进度
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// 最近一次恢复点的时间戳。有条件返回，复制对start后，才会返回该字段。
        /// </summary>
        [NameInMap("RecoverPoint")]
        [Validation(Required=false)]
        public long? RecoverPoint { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
