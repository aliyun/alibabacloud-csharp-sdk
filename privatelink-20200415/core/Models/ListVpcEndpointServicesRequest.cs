// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointServicesRequest : TeaModel {
        [NameInMap("AutoAcceptEnabled")]
        [Validation(Required=false)]
        public bool? AutoAcceptEnabled { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ServiceBusinessStatus")]
        [Validation(Required=false)]
        public string ServiceBusinessStatus { get; set; }

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

        [NameInMap("ZoneAffinityEnabled")]
        [Validation(Required=false)]
        public bool? ZoneAffinityEnabled { get; set; }

    }

}
