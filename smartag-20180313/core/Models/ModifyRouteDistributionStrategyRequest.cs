// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ModifyRouteDistributionStrategyRequest : TeaModel {
        [NameInMap("DestCidrBlock")]
        [Validation(Required=false)]
        public string DestCidrBlock { get; set; }

        [NameInMap("HcInstanceId")]
        [Validation(Required=false)]
        public string HcInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RouteDistribution")]
        [Validation(Required=false)]
        public string RouteDistribution { get; set; }

        [NameInMap("RouteSource")]
        [Validation(Required=false)]
        public string RouteSource { get; set; }

        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
