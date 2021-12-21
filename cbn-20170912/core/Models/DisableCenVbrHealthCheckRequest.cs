// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DisableCenVbrHealthCheckRequest : TeaModel {
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

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

        [NameInMap("VbrInstanceId")]
        [Validation(Required=false)]
        public string VbrInstanceId { get; set; }

        [NameInMap("VbrInstanceOwnerId")]
        [Validation(Required=false)]
        public long? VbrInstanceOwnerId { get; set; }

        [NameInMap("VbrInstanceRegionId")]
        [Validation(Required=false)]
        public string VbrInstanceRegionId { get; set; }

    }

}
