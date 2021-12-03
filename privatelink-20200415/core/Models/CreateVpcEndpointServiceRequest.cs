// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class CreateVpcEndpointServiceRequest : TeaModel {
        [NameInMap("AutoAcceptEnabled")]
        [Validation(Required=false)]
        public bool? AutoAcceptEnabled { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("Payer")]
        [Validation(Required=false)]
        public string Payer { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Resource")]
        [Validation(Required=false)]
        public List<CreateVpcEndpointServiceRequestResource> Resource { get; set; }
        public class CreateVpcEndpointServiceRequestResource : TeaModel {
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        [NameInMap("ServiceDescription")]
        [Validation(Required=false)]
        public string ServiceDescription { get; set; }

        [NameInMap("ServiceResourceType")]
        [Validation(Required=false)]
        public string ServiceResourceType { get; set; }

        [NameInMap("ZoneAffinityEnabled")]
        [Validation(Required=false)]
        public bool? ZoneAffinityEnabled { get; set; }

    }

}
