// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class ExpandCacheDiskRequest : TeaModel {
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        [NameInMap("LocalFilePath")]
        [Validation(Required=false)]
        public string LocalFilePath { get; set; }

        [NameInMap("NewSizeInGB")]
        [Validation(Required=false)]
        public int? NewSizeInGB { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
