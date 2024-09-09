// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayServiceDetailResponseBody : TeaModel {
        /// <summary>
        /// The response code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGatewayServiceDetailResponseBodyData Data { get; set; }
        public class GetGatewayServiceDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the gateway.
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public long? GatewayId { get; set; }

            /// <summary>
            /// The traffic policy of the service.
            /// </summary>
            [NameInMap("GatewayTrafficPolicy")]
            [Validation(Required=false)]
            public TrafficPolicy GatewayTrafficPolicy { get; set; }

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
            /// The last modification time.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The name of the group.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// Indicates whether the health check is enabled.
            /// </summary>
            [NameInMap("HealthCheck")]
            [Validation(Required=false)]
            public string HealthCheck { get; set; }

            /// <summary>
            /// The status of the health check. Valid values:
            /// </summary>
            [NameInMap("HealthStatus")]
            [Validation(Required=false)]
            public string HealthStatus { get; set; }

            /// <summary>
            /// The ID of the service.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The IP address of the service.
            /// </summary>
            [NameInMap("Ips")]
            [Validation(Required=false)]
            public List<string> Ips { get; set; }

            /// <summary>
            /// The details of the tag.
            /// </summary>
            [NameInMap("LabelDetails")]
            [Validation(Required=false)]
            public List<GetGatewayServiceDetailResponseBodyDataLabelDetails> LabelDetails { get; set; }
            public class GetGatewayServiceDetailResponseBodyDataLabelDetails : TeaModel {
                /// <summary>
                /// The tag.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// The basic information about the service.
            /// </summary>
            [NameInMap("MetaInfo")]
            [Validation(Required=false)]
            public string MetaInfo { get; set; }

            /// <summary>
            /// The name of the service.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The namespace.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The traffic policy of service ports.
            /// </summary>
            [NameInMap("PortTrafficPolicyList")]
            [Validation(Required=false)]
            public List<GetGatewayServiceDetailResponseBodyDataPortTrafficPolicyList> PortTrafficPolicyList { get; set; }
            public class GetGatewayServiceDetailResponseBodyDataPortTrafficPolicyList : TeaModel {
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
                /// The modification time.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The port ID.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The service ID.
                /// </summary>
                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public long? ServiceId { get; set; }

                /// <summary>
                /// The service port number.
                /// </summary>
                [NameInMap("ServicePort")]
                [Validation(Required=false)]
                public int? ServicePort { get; set; }

                /// <summary>
                /// The traffic policy.
                /// </summary>
                [NameInMap("TrafficPolicy")]
                [Validation(Required=false)]
                public TrafficPolicy TrafficPolicy { get; set; }

            }

            /// <summary>
            /// The array of service ports.
            /// </summary>
            [NameInMap("Ports")]
            [Validation(Required=false)]
            public List<int?> Ports { get; set; }

            [NameInMap("ServiceFQDN")]
            [Validation(Required=false)]
            public string ServiceFQDN { get; set; }

            /// <summary>
            /// The name of the service registered with the service registry.
            /// </summary>
            [NameInMap("ServiceNameInRegistry")]
            [Validation(Required=false)]
            public string ServiceNameInRegistry { get; set; }

            [NameInMap("ServicePort")]
            [Validation(Required=false)]
            public int? ServicePort { get; set; }

            /// <summary>
            /// The protocol of the service.
            /// </summary>
            [NameInMap("ServiceProtocol")]
            [Validation(Required=false)]
            public string ServiceProtocol { get; set; }

            /// <summary>
            /// The ID of the service source.
            /// </summary>
            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public long? SourceId { get; set; }

            /// <summary>
            /// The source type of the service.
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// The details of versions.
            /// </summary>
            [NameInMap("VersionDetails")]
            [Validation(Required=false)]
            public List<GetGatewayServiceDetailResponseBodyDataVersionDetails> VersionDetails { get; set; }
            public class GetGatewayServiceDetailResponseBodyDataVersionDetails : TeaModel {
                /// <summary>
                /// The number of instances.
                /// </summary>
                [NameInMap("EndpointNum")]
                [Validation(Required=false)]
                public int? EndpointNum { get; set; }

                /// <summary>
                /// The percentage of instances.
                /// </summary>
                [NameInMap("EndpointNumPercent")]
                [Validation(Required=false)]
                public string EndpointNumPercent { get; set; }

                /// <summary>
                /// The service version.
                /// </summary>
                [NameInMap("ServiceVersion")]
                [Validation(Required=false)]
                public GetGatewayServiceDetailResponseBodyDataVersionDetailsServiceVersion ServiceVersion { get; set; }
                public class GetGatewayServiceDetailResponseBodyDataVersionDetailsServiceVersion : TeaModel {
                    /// <summary>
                    /// The tag.
                    /// </summary>
                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public List<GetGatewayServiceDetailResponseBodyDataVersionDetailsServiceVersionLabels> Labels { get; set; }
                    public class GetGatewayServiceDetailResponseBodyDataVersionDetailsServiceVersionLabels : TeaModel {
                        /// <summary>
                        /// The tag.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The version number.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// The service version. This parameter is deprecated.
            /// </summary>
            [NameInMap("Versions")]
            [Validation(Required=false)]
            public List<GetGatewayServiceDetailResponseBodyDataVersions> Versions { get; set; }
            public class GetGatewayServiceDetailResponseBodyDataVersions : TeaModel {
                /// <summary>
                /// The tag.
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// The type.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The message returned.
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
