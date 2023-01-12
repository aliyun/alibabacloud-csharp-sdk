// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCustomRoutingEndpointTrafficPoliciesResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The list of traffic policies.
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<ListCustomRoutingEndpointTrafficPoliciesResponseBodyPolicies> Policies { get; set; }
        public class ListCustomRoutingEndpointTrafficPoliciesResponseBodyPolicies : TeaModel {
            /// <summary>
            /// The ID of the GA instance to which the endpoint belongs.
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// The IP address of the traffic policy.
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// The ID of the endpoint group to which the endpoint belongs.
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// The ID of the endpoint to which the traffic policy belongs.
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// The ID of the custom routing listener to which the endpoint belongs.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The ID of the traffic policy.
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// The port range of the traffic policy.
            /// </summary>
            [NameInMap("PortRanges")]
            [Validation(Required=false)]
            public List<ListCustomRoutingEndpointTrafficPoliciesResponseBodyPoliciesPortRanges> PortRanges { get; set; }
            public class ListCustomRoutingEndpointTrafficPoliciesResponseBodyPoliciesPortRanges : TeaModel {
                /// <summary>
                /// The first port of the port range.
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                /// <summary>
                /// The last port of the port range.
                /// </summary>
                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public int? ToPort { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
