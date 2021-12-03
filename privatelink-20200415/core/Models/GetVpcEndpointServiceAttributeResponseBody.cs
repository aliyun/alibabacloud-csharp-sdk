// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class GetVpcEndpointServiceAttributeResponseBody : TeaModel {
        [NameInMap("AutoAcceptEnabled")]
        [Validation(Required=false)]
        public bool? AutoAcceptEnabled { get; set; }

        [NameInMap("ConnectBandwidth")]
        [Validation(Required=false)]
        public int? ConnectBandwidth { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("MaxBandwidth")]
        [Validation(Required=false)]
        public int? MaxBandwidth { get; set; }

        [NameInMap("MinBandwidth")]
        [Validation(Required=false)]
        public int? MinBandwidth { get; set; }

        [NameInMap("Payer")]
        [Validation(Required=false)]
        public string Payer { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceBusinessStatus")]
        [Validation(Required=false)]
        public string ServiceBusinessStatus { get; set; }

        [NameInMap("ServiceDescription")]
        [Validation(Required=false)]
        public string ServiceDescription { get; set; }

        [NameInMap("ServiceDomain")]
        [Validation(Required=false)]
        public string ServiceDomain { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("ServiceResourceType")]
        [Validation(Required=false)]
        public string ServiceResourceType { get; set; }

        [NameInMap("ServiceStatus")]
        [Validation(Required=false)]
        public string ServiceStatus { get; set; }

        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("ZoneAffinityEnabled")]
        [Validation(Required=false)]
        public bool? ZoneAffinityEnabled { get; set; }

        [NameInMap("Zones")]
        [Validation(Required=false)]
        public List<string> Zones { get; set; }

    }

}
