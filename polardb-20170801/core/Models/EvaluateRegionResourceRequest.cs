// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class EvaluateRegionResourceRequest : TeaModel {
        [NameInMap("DBInstanceConnType")]
        [Validation(Required=false)]
        public string DBInstanceConnType { get; set; }

        [NameInMap("DBNodeClass")]
        [Validation(Required=false)]
        public string DBNodeClass { get; set; }

        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        [NameInMap("DispenseMode")]
        [Validation(Required=false)]
        public string DispenseMode { get; set; }

        [NameInMap("NeedMaxScaleLink")]
        [Validation(Required=false)]
        public string NeedMaxScaleLink { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public string SubDomain { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
