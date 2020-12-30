// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ModifySagRouteProtocolOspfRequest : TeaModel {
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

        [NameInMap("AreaId")]
        [Validation(Required=false)]
        public int? AreaId { get; set; }

        [NameInMap("DeadTime")]
        [Validation(Required=false)]
        public int? DeadTime { get; set; }

        [NameInMap("HelloTime")]
        [Validation(Required=false)]
        public int? HelloTime { get; set; }

        [NameInMap("AuthenticationType")]
        [Validation(Required=false)]
        public string AuthenticationType { get; set; }

        [NameInMap("Md5KeyId")]
        [Validation(Required=false)]
        public int? Md5KeyId { get; set; }

        [NameInMap("Md5Key")]
        [Validation(Required=false)]
        public string Md5Key { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

    }

}
