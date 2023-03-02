// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListServiceSourceResponseBody : TeaModel {
        /// <summary>
        /// The response code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListServiceSourceResponseBodyData> Data { get; set; }
        public class ListServiceSourceResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the Container Service for Kubernetes (ACK) cluster or the endpoint of the Microservices Engine (MSE) registry.
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// Indicates whether the service source is associated with the gateway. The value 1 indicates that the service source is associated with the gateway.
            /// </summary>
            [NameInMap("BindingWithGateway")]
            [Validation(Required=false)]
            public int? BindingWithGateway { get; set; }

            /// <summary>
            /// The ID of the gateway.
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public long? GatewayId { get; set; }

            /// <summary>
            /// The unique ID of the gateway.
            /// </summary>
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            /// <summary>
            /// The creation time.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The update time.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The array of service groups.
            /// </summary>
            [NameInMap("GroupList")]
            [Validation(Required=false)]
            public List<string> GroupList { get; set; }

            /// <summary>
            /// The ID.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// Indicates whether Ingress is supported for applications.
            /// </summary>
            [NameInMap("IngressOptions")]
            [Validation(Required=false)]
            public ListServiceSourceResponseBodyDataIngressOptions IngressOptions { get; set; }
            public class ListServiceSourceResponseBodyDataIngressOptions : TeaModel {
                /// <summary>
                /// Indicates whether Ingress is enabled.
                /// </summary>
                [NameInMap("EnableIngress")]
                [Validation(Required=false)]
                public bool? EnableIngress { get; set; }

                /// <summary>
                /// Indicates whether the Ingress status is updated.
                /// </summary>
                [NameInMap("EnableStatus")]
                [Validation(Required=false)]
                public bool? EnableStatus { get; set; }

                /// <summary>
                /// The Ingress class.
                /// </summary>
                [NameInMap("IngressClass")]
                [Validation(Required=false)]
                public string IngressClass { get; set; }

                /// <summary>
                /// The namespace that you want to monitor.
                /// </summary>
                [NameInMap("WatchNamespace")]
                [Validation(Required=false)]
                public string WatchNamespace { get; set; }

            }

            /// <summary>
            /// The name.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The array of root paths of service lists.
            /// </summary>
            [NameInMap("PathList")]
            [Validation(Required=false)]
            public List<string> PathList { get; set; }

            /// <summary>
            /// The type of the service source.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The unique ID of the service source.
            /// </summary>
            [NameInMap("SourceUniqueId")]
            [Validation(Required=false)]
            public string SourceUniqueId { get; set; }

            /// <summary>
            /// The type.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
