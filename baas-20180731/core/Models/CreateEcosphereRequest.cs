// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class CreateEcosphereRequest : TeaModel {
        [NameInMap("ChannelPolicy")]
        [Validation(Required=false)]
        public string ChannelPolicy { get; set; }

        [NameInMap("ConsortiumName")]
        [Validation(Required=false)]
        public string ConsortiumName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("MajorVersion")]
        [Validation(Required=false)]
        public string MajorVersion { get; set; }

        [NameInMap("OrdererDomain")]
        [Validation(Required=false)]
        public string OrdererDomain { get; set; }

        [NameInMap("OrdererType")]
        [Validation(Required=false)]
        public string OrdererType { get; set; }

        [NameInMap("OrderersCount")]
        [Validation(Required=false)]
        public int? OrderersCount { get; set; }

        [NameInMap("Organization")]
        [Validation(Required=false)]
        public List<CreateEcosphereRequestOrganization> Organization { get; set; }
        public class CreateEcosphereRequestOrganization : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("PeersCount")]
        [Validation(Required=false)]
        public int? PeersCount { get; set; }

        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        [NameInMap("SpecName")]
        [Validation(Required=false)]
        public string SpecName { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
