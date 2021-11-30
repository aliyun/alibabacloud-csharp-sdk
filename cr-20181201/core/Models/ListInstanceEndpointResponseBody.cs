// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListInstanceEndpointResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<ListInstanceEndpointResponseBodyEndpoints> Endpoints { get; set; }
        public class ListInstanceEndpointResponseBodyEndpoints : TeaModel {
            [NameInMap("AclEnable")]
            [Validation(Required=false)]
            public bool? AclEnable { get; set; }

            [NameInMap("AclEntries")]
            [Validation(Required=false)]
            public List<ListInstanceEndpointResponseBodyEndpointsAclEntries> AclEntries { get; set; }
            public class ListInstanceEndpointResponseBodyEndpointsAclEntries : TeaModel {
                [NameInMap("Entry")]
                [Validation(Required=false)]
                public string Entry { get; set; }

            }

            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<ListInstanceEndpointResponseBodyEndpointsDomains> Domains { get; set; }
            public class ListInstanceEndpointResponseBodyEndpointsDomains : TeaModel {
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            [NameInMap("LinkedVpcs")]
            [Validation(Required=false)]
            public List<ListInstanceEndpointResponseBodyEndpointsLinkedVpcs> LinkedVpcs { get; set; }
            public class ListInstanceEndpointResponseBodyEndpointsLinkedVpcs : TeaModel {
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
