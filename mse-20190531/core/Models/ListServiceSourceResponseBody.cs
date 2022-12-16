// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListServiceSourceResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// - `true`: The request is successful. 
        /// - `false`: The request fails.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data structure.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListServiceSourceResponseBodyData> Data { get; set; }
        public class ListServiceSourceResponseBodyData : TeaModel {
            /// <summary>
            /// The type of the service source.
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// The ID of the gateway.
            /// </summary>
            [NameInMap("BindingWithGateway")]
            [Validation(Required=false)]
            public int? BindingWithGateway { get; set; }

            /// <summary>
            /// The time when the service source was added.
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public long? GatewayId { get; set; }

            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            /// <summary>
            /// The time when the service source was last modified.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The unique ID of the service source.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("GroupList")]
            [Validation(Required=false)]
            public List<string> GroupList { get; set; }

            /// <summary>
            /// The name of the service source.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// Programming language
            /// </summary>
            [NameInMap("IngressOptions")]
            [Validation(Required=false)]
            public ListServiceSourceResponseBodyDataIngressOptions IngressOptions { get; set; }
            public class ListServiceSourceResponseBodyDataIngressOptions : TeaModel {
                /// <summary>
                /// Alibaba Cloud provides SDKs for multiple programming languages to help you integrate Alibaba Cloud products and services by using APIs. We recommend that you use an SDK to call API operations. This frees you from manual signature verification.
                /// </summary>
                [NameInMap("EnableIngress")]
                [Validation(Required=false)]
                public bool? EnableIngress { get; set; }

                [NameInMap("EnableStatus")]
                [Validation(Required=false)]
                public bool? EnableStatus { get; set; }

                /// <summary>
                /// ingress class
                /// </summary>
                [NameInMap("IngressClass")]
                [Validation(Required=false)]
                public string IngressClass { get; set; }

                /// <summary>
                /// Alibaba Cloud CLI allows you to search for API operations, call and debug API operations online, and dynamically generate executable sample code for SDKs.
                /// </summary>
                [NameInMap("WatchNamespace")]
                [Validation(Required=false)]
                public string WatchNamespace { get; set; }

            }

            /// <summary>
            /// The ID of the Container Service for Kubernetes (ACK) cluster, or the endpoint of the Microservices Engine (MSE) Nacos registry.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PathList")]
            [Validation(Required=false)]
            public List<string> PathList { get; set; }

            /// <summary>
            /// Indicates whether the service source is associated with the gateway.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// Query service sources
            /// </summary>
            [NameInMap("SourceUniqueId")]
            [Validation(Required=false)]
            public string SourceUniqueId { get; set; }

            /// <summary>
            /// The source of the service source.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The error message returned if the request fails.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned results.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
