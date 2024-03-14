// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class CreateGatewayCacheDiskRequest : TeaModel {
        [NameInMap("CacheDiskCategory")]
        [Validation(Required=false)]
        public string CacheDiskCategory { get; set; }

        [NameInMap("CacheDiskSizeInGB")]
        [Validation(Required=false)]
        public long? CacheDiskSizeInGB { get; set; }

        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
