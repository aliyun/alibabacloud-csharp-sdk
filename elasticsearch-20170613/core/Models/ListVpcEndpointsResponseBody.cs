// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListVpcEndpointsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListVpcEndpointsResponseBodyResult> Result { get; set; }
        public class ListVpcEndpointsResponseBodyResult : TeaModel {
            [NameInMap("endpointBusinessStatus")]
            [Validation(Required=false)]
            public string EndpointBusinessStatus { get; set; }

            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            [NameInMap("endpointName")]
            [Validation(Required=false)]
            public string EndpointName { get; set; }

            [NameInMap("endpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("connectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            [NameInMap("endpointDomain")]
            [Validation(Required=false)]
            public string EndpointDomain { get; set; }

            [NameInMap("endpointStatus")]
            [Validation(Required=false)]
            public string EndpointStatus { get; set; }

        }

    }

}
