// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class ListEndpointsResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListEndpointsResponseBodyResult> Result { get; set; }
        public class ListEndpointsResponseBodyResult : TeaModel {
            [NameInMap("connectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("endpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            [NameInMap("endpointZones")]
            [Validation(Required=false)]
            public List<ListEndpointsResponseBodyResultEndpointZones> EndpointZones { get; set; }
            public class ListEndpointsResponseBodyResultEndpointZones : TeaModel {
                [NameInMap("vSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("securityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
