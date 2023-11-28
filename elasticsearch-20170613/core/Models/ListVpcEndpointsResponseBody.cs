// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListVpcEndpointsResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the endpoints.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListVpcEndpointsResponseBodyResult> Result { get; set; }
        public class ListVpcEndpointsResponseBodyResult : TeaModel {
            /// <summary>
            /// The status of the endpoint connection. Valid values:
            /// 
            /// *   Pending
            /// *   Connecting
            /// *   Connected
            /// *   Disconnecting
            /// *   Disconnected
            /// *   Deleting
            /// *   ServiceDeleted
            /// </summary>
            [NameInMap("connectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            /// <summary>
            /// The time when the endpoint was created.
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The business status of the endpoint. Valid values:
            /// 
            /// *   Normal
            /// *   FinancialLocked
            /// </summary>
            [NameInMap("endpointBusinessStatus")]
            [Validation(Required=false)]
            public string EndpointBusinessStatus { get; set; }

            /// <summary>
            /// The domain name of the endpoint. The domain name is used for connection configuration.
            /// </summary>
            [NameInMap("endpointDomain")]
            [Validation(Required=false)]
            public string EndpointDomain { get; set; }

            /// <summary>
            /// The ID of the endpoint.
            /// </summary>
            [NameInMap("endpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// The name of the endpoint.
            /// </summary>
            [NameInMap("endpointName")]
            [Validation(Required=false)]
            public string EndpointName { get; set; }

            /// <summary>
            /// The status of the endpoint. Valid values:
            /// 
            /// *   Creating
            /// *   Active
            /// *   Pending
            /// *   Deleting
            /// </summary>
            [NameInMap("endpointStatus")]
            [Validation(Required=false)]
            public string EndpointStatus { get; set; }

            /// <summary>
            /// The ID of the endpoint service with which the endpoint is associated.
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// The name of the endpoint service with which the endpoint is associated.
            /// </summary>
            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

    }

}
