// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ModifySagLanRequest : TeaModel {
        [NameInMap("EndIp")]
        [Validation(Required=false)]
        public string EndIp { get; set; }

        [NameInMap("IP")]
        [Validation(Required=false)]
        public string IP { get; set; }

        [NameInMap("IPType")]
        [Validation(Required=false)]
        public string IPType { get; set; }

        [NameInMap("Lease")]
        [Validation(Required=false)]
        public string Lease { get; set; }

        [NameInMap("Mask")]
        [Validation(Required=false)]
        public string Mask { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PortName")]
        [Validation(Required=false)]
        public string PortName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

        [NameInMap("SmartAGSn")]
        [Validation(Required=false)]
        public string SmartAGSn { get; set; }

        [NameInMap("StartIp")]
        [Validation(Required=false)]
        public string StartIp { get; set; }

    }

}
