// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListInstanceEndpointResponseBody : TeaModel {
        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The endpoints of the instance.
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<ListInstanceEndpointResponseBodyEndpoints> Endpoints { get; set; }
        public class ListInstanceEndpointResponseBodyEndpoints : TeaModel {
            /// <summary>
            /// Indicates whether the access control list (ACL) feature is enabled.
            /// </summary>
            [NameInMap("AclEnable")]
            [Validation(Required=false)]
            public bool? AclEnable { get; set; }

            /// <summary>
            /// The ACL configured for the instance.
            /// </summary>
            [NameInMap("AclEntries")]
            [Validation(Required=false)]
            public List<ListInstanceEndpointResponseBodyEndpointsAclEntries> AclEntries { get; set; }
            public class ListInstanceEndpointResponseBodyEndpointsAclEntries : TeaModel {
                /// <summary>
                /// Details about the ACL.
                /// </summary>
                [NameInMap("Entry")]
                [Validation(Required=false)]
                public string Entry { get; set; }

            }

            /// <summary>
            /// Domain names.
            /// </summary>
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<ListInstanceEndpointResponseBodyEndpointsDomains> Domains { get; set; }
            public class ListInstanceEndpointResponseBodyEndpointsDomains : TeaModel {
                /// <summary>
                /// The domain name.
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// Type
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// Indicates whether the ACL feature is enabled.
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// The type of the endpoint.
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// The virtual private clouds (VPCs) that are associated with the instance.
            /// </summary>
            [NameInMap("LinkedVpcs")]
            [Validation(Required=false)]
            public List<ListInstanceEndpointResponseBodyEndpointsLinkedVpcs> LinkedVpcs { get; set; }
            public class ListInstanceEndpointResponseBodyEndpointsLinkedVpcs : TeaModel {
                /// <summary>
                /// VPC ID
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// The status of the instance.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
