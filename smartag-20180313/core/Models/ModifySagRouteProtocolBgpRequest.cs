// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ModifySagRouteProtocolBgpRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

        [NameInMap("SmartAGSn")]
        [Validation(Required=false)]
        public string SmartAGSn { get; set; }

        [NameInMap("RouterId")]
        [Validation(Required=false)]
        public string RouterId { get; set; }

        [NameInMap("LocalAs")]
        [Validation(Required=false)]
        public int? LocalAs { get; set; }

        [NameInMap("HoldTime")]
        [Validation(Required=false)]
        public int? HoldTime { get; set; }

        [NameInMap("KeepAlive")]
        [Validation(Required=false)]
        public int? KeepAlive { get; set; }

    }

}
