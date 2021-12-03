// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointServicesByEndUserResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<ListVpcEndpointServicesByEndUserResponseBodyServices> Services { get; set; }
        public class ListVpcEndpointServicesByEndUserResponseBodyServices : TeaModel {
            [NameInMap("Payer")]
            [Validation(Required=false)]
            public string Payer { get; set; }

            [NameInMap("ServiceDomain")]
            [Validation(Required=false)]
            public string ServiceDomain { get; set; }

            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<string> Zones { get; set; }

        }

    }

}
