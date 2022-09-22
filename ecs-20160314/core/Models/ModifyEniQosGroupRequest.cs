// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class ModifyEniQosGroupRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("QosGroupName")]
        [Validation(Required=false)]
        public string QosGroupName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Rx")]
        [Validation(Required=false)]
        public int? Rx { get; set; }

        [NameInMap("RxPps")]
        [Validation(Required=false)]
        public int? RxPps { get; set; }

        [NameInMap("Tx")]
        [Validation(Required=false)]
        public int? Tx { get; set; }

        [NameInMap("TxPps")]
        [Validation(Required=false)]
        public int? TxPps { get; set; }

    }

}
