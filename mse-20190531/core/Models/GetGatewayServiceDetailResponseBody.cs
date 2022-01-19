// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayServiceDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGatewayServiceDetailResponseBodyData Data { get; set; }
        public class GetGatewayServiceDetailResponseBodyData : TeaModel {
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public long? GatewayId { get; set; }
            [NameInMap("GatewayTrafficPolicy")]
            [Validation(Required=false)]
            public TrafficPolicy GatewayTrafficPolicy { get; set; }
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("Ips")]
            [Validation(Required=false)]
            public List<string> Ips { get; set; }
            [NameInMap("LabelDetails")]
            [Validation(Required=false)]
            public List<GetGatewayServiceDetailResponseBodyDataLabelDetails> LabelDetails { get; set; }
            public class GetGatewayServiceDetailResponseBodyDataLabelDetails : TeaModel {
                public string Key { get; set; }
                public List<string> Values { get; set; }
            }
            [NameInMap("MetaInfo")]
            [Validation(Required=false)]
            public string MetaInfo { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }
            [NameInMap("ServiceNameInRegistry")]
            [Validation(Required=false)]
            public string ServiceNameInRegistry { get; set; }
            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public long? SourceId { get; set; }
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }
            [NameInMap("VersionDetails")]
            [Validation(Required=false)]
            public List<GetGatewayServiceDetailResponseBodyDataVersionDetails> VersionDetails { get; set; }
            public class GetGatewayServiceDetailResponseBodyDataVersionDetails : TeaModel {
                public int? EndpointNum { get; set; }
                public string EndpointNumPercent { get; set; }
                public GetGatewayServiceDetailResponseBodyDataVersionDetailsServiceVersion ServiceVersion { get; set; }
                public class GetGatewayServiceDetailResponseBodyDataVersionDetailsServiceVersion : TeaModel {
                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public List<GetGatewayServiceDetailResponseBodyDataVersionDetailsServiceVersionLabels> Labels { get; set; }
                    public class GetGatewayServiceDetailResponseBodyDataVersionDetailsServiceVersionLabels : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }
            }
            [NameInMap("Versions")]
            [Validation(Required=false)]
            public List<GetGatewayServiceDetailResponseBodyDataVersions> Versions { get; set; }
            public class GetGatewayServiceDetailResponseBodyDataVersions : TeaModel {
                public string Label { get; set; }
                public string Type { get; set; }
                public string Value { get; set; }
            }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
