// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class UpdateVpcEndpointServiceAttributeRequest : TeaModel {
        [NameInMap("AutoAcceptEnabled")]
        [Validation(Required=false)]
        public bool? AutoAcceptEnabled { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ConnectBandwidth")]
        [Validation(Required=false)]
        public int? ConnectBandwidth { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ServiceDescription")]
        [Validation(Required=false)]
        public string ServiceDescription { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        [NameInMap("ZoneAffinityEnabled")]
        [Validation(Required=false)]
        public bool? ZoneAffinityEnabled { get; set; }

    }

}
