// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class CreateFabricConsortiumRequest : TeaModel {
        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("OrdererType")]
        [Validation(Required=false)]
        public string OrdererType { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        [NameInMap("ConsortiumName")]
        [Validation(Required=false)]
        public string ConsortiumName { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("ConsortiumDescription")]
        [Validation(Required=false)]
        public string ConsortiumDescription { get; set; }

        [NameInMap("ChannelPolicy")]
        [Validation(Required=false)]
        public string ChannelPolicy { get; set; }

        [NameInMap("SpecName")]
        [Validation(Required=false)]
        public string SpecName { get; set; }

        [NameInMap("OrderersCount")]
        [Validation(Required=false)]
        public int? OrderersCount { get; set; }

        [NameInMap("PeersCount")]
        [Validation(Required=false)]
        public int? PeersCount { get; set; }

        [NameInMap("PaymentDurationUnit")]
        [Validation(Required=false)]
        public string PaymentDurationUnit { get; set; }

        [NameInMap("PaymentDuration")]
        [Validation(Required=false)]
        public int? PaymentDuration { get; set; }

        [NameInMap("Organization")]
        [Validation(Required=false)]
        public List<CreateFabricConsortiumRequestOrganization> Organization { get; set; }
        public class CreateFabricConsortiumRequestOrganization : TeaModel {
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
