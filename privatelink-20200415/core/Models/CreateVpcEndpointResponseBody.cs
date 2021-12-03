// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class CreateVpcEndpointResponseBody : TeaModel {
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        [NameInMap("ConnectionStatus")]
        [Validation(Required=false)]
        public string ConnectionStatus { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("EndpointBusinessStatus")]
        [Validation(Required=false)]
        public string EndpointBusinessStatus { get; set; }

        [NameInMap("EndpointDescription")]
        [Validation(Required=false)]
        public string EndpointDescription { get; set; }

        [NameInMap("EndpointDomain")]
        [Validation(Required=false)]
        public string EndpointDomain { get; set; }

        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        [NameInMap("EndpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        [NameInMap("EndpointStatus")]
        [Validation(Required=false)]
        public string EndpointStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
