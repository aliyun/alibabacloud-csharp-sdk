// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetSwimLaneGroupListResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the lane groups.
        /// </summary>
        [NameInMap("SwimLaneGroupList")]
        [Validation(Required=false)]
        public List<GetSwimLaneGroupListResponseBodySwimLaneGroupList> SwimLaneGroupList { get; set; }
        public class GetSwimLaneGroupListResponseBodySwimLaneGroupList : TeaModel {
            [NameInMap("FallbackTarget")]
            [Validation(Required=false)]
            public string FallbackTarget { get; set; }

            /// <summary>
            /// The name of a lane group.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The name of the ingress gateway.
            /// </summary>
            [NameInMap("IngressGatewayName")]
            [Validation(Required=false)]
            public string IngressGatewayName { get; set; }

            /// <summary>
            /// The ingress type. Traffic routing rules can be configured only in an ingress gateway.
            /// </summary>
            [NameInMap("IngressType")]
            [Validation(Required=false)]
            public string IngressType { get; set; }

            [NameInMap("IsPermissive")]
            [Validation(Required=false)]
            public bool? IsPermissive { get; set; }

            [NameInMap("RouteHeader")]
            [Validation(Required=false)]
            public string RouteHeader { get; set; }

            /// <summary>
            /// A list of services associated with the lane group.
            /// </summary>
            [NameInMap("ServiceList")]
            [Validation(Required=false)]
            public string ServiceList { get; set; }

            [NameInMap("SwimLaneLabels")]
            [Validation(Required=false)]
            public string SwimLaneLabels { get; set; }

            [NameInMap("TraceHeader")]
            [Validation(Required=false)]
            public string TraceHeader { get; set; }

        }

    }

}
