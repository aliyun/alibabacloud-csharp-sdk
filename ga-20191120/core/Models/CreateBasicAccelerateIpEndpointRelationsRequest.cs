// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateBasicAccelerateIpEndpointRelationsRequest : TeaModel {
        [NameInMap("AccelerateIpEndpointRelations")]
        [Validation(Required=false)]
        public List<CreateBasicAccelerateIpEndpointRelationsRequestAccelerateIpEndpointRelations> AccelerateIpEndpointRelations { get; set; }
        public class CreateBasicAccelerateIpEndpointRelationsRequestAccelerateIpEndpointRelations : TeaModel {
            [NameInMap("AccelerateIpId")]
            [Validation(Required=false)]
            public string AccelerateIpId { get; set; }

            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

        }

        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
