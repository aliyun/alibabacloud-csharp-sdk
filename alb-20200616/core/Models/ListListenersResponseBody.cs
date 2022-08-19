// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListListenersResponseBody : TeaModel {
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public List<ListListenersResponseBodyListeners> Listeners { get; set; }
        public class ListListenersResponseBodyListeners : TeaModel {
            [NameInMap("DefaultActions")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersDefaultActions> DefaultActions { get; set; }
            public class ListListenersResponseBodyListenersDefaultActions : TeaModel {
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public ListListenersResponseBodyListenersDefaultActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class ListListenersResponseBodyListenersDefaultActionsForwardGroupConfig : TeaModel {
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<ListListenersResponseBodyListenersDefaultActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class ListListenersResponseBodyListenersDefaultActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        public string ServerGroupId { get; set; }
                    }
                };

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("GzipEnabled")]
            [Validation(Required=false)]
            public bool? GzipEnabled { get; set; }

            [NameInMap("Http2Enabled")]
            [Validation(Required=false)]
            public bool? Http2Enabled { get; set; }

            [NameInMap("IdleTimeout")]
            [Validation(Required=false)]
            public int? IdleTimeout { get; set; }

            [NameInMap("ListenerDescription")]
            [Validation(Required=false)]
            public string ListenerDescription { get; set; }

            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            [NameInMap("ListenerProtocol")]
            [Validation(Required=false)]
            public string ListenerProtocol { get; set; }

            [NameInMap("ListenerStatus")]
            [Validation(Required=false)]
            public string ListenerStatus { get; set; }

            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            [NameInMap("LogConfig")]
            [Validation(Required=false)]
            public ListListenersResponseBodyListenersLogConfig LogConfig { get; set; }
            public class ListListenersResponseBodyListenersLogConfig : TeaModel {
                [NameInMap("AccessLogRecordCustomizedHeadersEnabled")]
                [Validation(Required=false)]
                public bool? AccessLogRecordCustomizedHeadersEnabled { get; set; }
                [NameInMap("AccessLogTracingConfig")]
                [Validation(Required=false)]
                public ListListenersResponseBodyListenersLogConfigAccessLogTracingConfig AccessLogTracingConfig { get; set; }
                public class ListListenersResponseBodyListenersLogConfigAccessLogTracingConfig : TeaModel {
                    [NameInMap("TracingEnabled")]
                    [Validation(Required=false)]
                    public bool? TracingEnabled { get; set; }

                    [NameInMap("TracingSample")]
                    [Validation(Required=false)]
                    public int? TracingSample { get; set; }

                    [NameInMap("TracingType")]
                    [Validation(Required=false)]
                    public string TracingType { get; set; }

                }
            };

            [NameInMap("QuicConfig")]
            [Validation(Required=false)]
            public ListListenersResponseBodyListenersQuicConfig QuicConfig { get; set; }
            public class ListListenersResponseBodyListenersQuicConfig : TeaModel {
                [NameInMap("QuicListenerId")]
                [Validation(Required=false)]
                public string QuicListenerId { get; set; }
                [NameInMap("QuicUpgradeEnabled")]
                [Validation(Required=false)]
                public bool? QuicUpgradeEnabled { get; set; }
            };

            [NameInMap("RequestTimeout")]
            [Validation(Required=false)]
            public int? RequestTimeout { get; set; }

            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

            [NameInMap("XForwardedForConfig")]
            [Validation(Required=false)]
            public ListListenersResponseBodyListenersXForwardedForConfig XForwardedForConfig { get; set; }
            public class ListListenersResponseBodyListenersXForwardedForConfig : TeaModel {
                [NameInMap("XForwardedForClientCertClientVerifyAlias")]
                [Validation(Required=false)]
                public string XForwardedForClientCertClientVerifyAlias { get; set; }
                [NameInMap("XForwardedForClientCertClientVerifyEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientCertClientVerifyEnabled { get; set; }
                [NameInMap("XForwardedForClientCertFingerprintAlias")]
                [Validation(Required=false)]
                public string XForwardedForClientCertFingerprintAlias { get; set; }
                [NameInMap("XForwardedForClientCertFingerprintEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientCertFingerprintEnabled { get; set; }
                [NameInMap("XForwardedForClientCertIssuerDNAlias")]
                [Validation(Required=false)]
                public string XForwardedForClientCertIssuerDNAlias { get; set; }
                [NameInMap("XForwardedForClientCertIssuerDNEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientCertIssuerDNEnabled { get; set; }
                [NameInMap("XForwardedForClientCertSubjectDNAlias")]
                [Validation(Required=false)]
                public string XForwardedForClientCertSubjectDNAlias { get; set; }
                [NameInMap("XForwardedForClientCertSubjectDNEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientCertSubjectDNEnabled { get; set; }
                [NameInMap("XForwardedForClientSourceIpsEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientSourceIpsEnabled { get; set; }
                [NameInMap("XForwardedForClientSourceIpsTrusted")]
                [Validation(Required=false)]
                public string XForwardedForClientSourceIpsTrusted { get; set; }
                [NameInMap("XForwardedForClientSrcPortEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientSrcPortEnabled { get; set; }
                [NameInMap("XForwardedForEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForEnabled { get; set; }
                [NameInMap("XForwardedForProtoEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForProtoEnabled { get; set; }
                [NameInMap("XForwardedForSLBIdEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForSLBIdEnabled { get; set; }
                [NameInMap("XForwardedForSLBPortEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForSLBPortEnabled { get; set; }
            };

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
