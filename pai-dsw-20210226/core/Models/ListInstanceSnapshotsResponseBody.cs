// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class ListInstanceSnapshotsResponseBody : TeaModel {
        /// <summary>
        /// 镜像快照列表
        /// </summary>
        [NameInMap("InstanceSnapshots")]
        [Validation(Required=false)]
        public List<InstanceSnapshot> InstanceSnapshots { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
