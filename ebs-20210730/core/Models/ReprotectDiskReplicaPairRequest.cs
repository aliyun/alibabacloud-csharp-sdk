// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class ReprotectDiskReplicaPairRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ReplicaPairId")]
        [Validation(Required=false)]
        public string ReplicaPairId { get; set; }

        /// <summary>
        /// 反向复制开关：false代表恢复原方向，true代表反向复制。默认值是true。
        /// </summary>
        [NameInMap("ReverseReplicate")]
        [Validation(Required=false)]
        public bool? ReverseReplicate { get; set; }

    }

}
