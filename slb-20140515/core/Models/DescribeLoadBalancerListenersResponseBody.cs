// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeLoadBalancerListenersResponseBody : TeaModel {
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public List<DescribeLoadBalancerListenersResponseBodyListeners> Listeners { get; set; }
        public class DescribeLoadBalancerListenersResponseBodyListeners : TeaModel {
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }

            [NameInMap("AclStatus")]
            [Validation(Required=false)]
            public string AclStatus { get; set; }

            [NameInMap("AclType")]
            [Validation(Required=false)]
            public string AclType { get; set; }

            [NameInMap("BackendServerPort")]
            [Validation(Required=false)]
            public int? BackendServerPort { get; set; }

            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("HTTPListenerConfig")]
            [Validation(Required=false)]
            public DescribeLoadBalancerListenersResponseBodyListenersHTTPListenerConfig HTTPListenerConfig { get; set; }
            public class DescribeLoadBalancerListenersResponseBodyListenersHTTPListenerConfig : TeaModel {
                [NameInMap("Cookie")]
                [Validation(Required=false)]
                public string Cookie { get; set; }
                [NameInMap("CookieTimeout")]
                [Validation(Required=false)]
                public int? CookieTimeout { get; set; }
                [NameInMap("ForwardPort")]
                [Validation(Required=false)]
                public int? ForwardPort { get; set; }
                [NameInMap("Gzip")]
                [Validation(Required=false)]
                public string Gzip { get; set; }
                [NameInMap("HealthCheck")]
                [Validation(Required=false)]
                public string HealthCheck { get; set; }
                [NameInMap("HealthCheckConnectPort")]
                [Validation(Required=false)]
                public int? HealthCheckConnectPort { get; set; }
                [NameInMap("HealthCheckDomain")]
                [Validation(Required=false)]
                public string HealthCheckDomain { get; set; }
                [NameInMap("HealthCheckHttpCode")]
                [Validation(Required=false)]
                public string HealthCheckHttpCode { get; set; }
                [NameInMap("HealthCheckHttpVersion")]
                [Validation(Required=false)]
                public string HealthCheckHttpVersion { get; set; }
                [NameInMap("HealthCheckInterval")]
                [Validation(Required=false)]
                public int? HealthCheckInterval { get; set; }
                [NameInMap("HealthCheckMethod")]
                [Validation(Required=false)]
                public string HealthCheckMethod { get; set; }
                [NameInMap("HealthCheckTimeout")]
                [Validation(Required=false)]
                public int? HealthCheckTimeout { get; set; }
                [NameInMap("HealthCheckType")]
                [Validation(Required=false)]
                public string HealthCheckType { get; set; }
                [NameInMap("HealthCheckURI")]
                [Validation(Required=false)]
                public string HealthCheckURI { get; set; }
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }
                [NameInMap("IdleTimeout")]
                [Validation(Required=false)]
                public int? IdleTimeout { get; set; }
                [NameInMap("ListenerForward")]
                [Validation(Required=false)]
                public string ListenerForward { get; set; }
                [NameInMap("RequestTimeout")]
                [Validation(Required=false)]
                public int? RequestTimeout { get; set; }
                [NameInMap("StickySession")]
                [Validation(Required=false)]
                public string StickySession { get; set; }
                [NameInMap("StickySessionType")]
                [Validation(Required=false)]
                public string StickySessionType { get; set; }
                [NameInMap("UnhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }
                [NameInMap("XForwardedFor")]
                [Validation(Required=false)]
                public string XForwardedFor { get; set; }
                [NameInMap("XForwardedFor_ClientSrcPort")]
                [Validation(Required=false)]
                public string XForwardedFor_ClientSrcPort { get; set; }
                [NameInMap("XForwardedFor_SLBID")]
                [Validation(Required=false)]
                public string XForwardedFor_SLBID { get; set; }
                [NameInMap("XForwardedFor_SLBIP")]
                [Validation(Required=false)]
                public string XForwardedFor_SLBIP { get; set; }
                [NameInMap("XForwardedFor_SLBPORT")]
                [Validation(Required=false)]
                public string XForwardedFor_SLBPORT { get; set; }
                [NameInMap("XForwardedFor_proto")]
                [Validation(Required=false)]
                public string XForwardedFor_proto { get; set; }
            };

            [NameInMap("HTTPSListenerConfig")]
            [Validation(Required=false)]
            public DescribeLoadBalancerListenersResponseBodyListenersHTTPSListenerConfig HTTPSListenerConfig { get; set; }
            public class DescribeLoadBalancerListenersResponseBodyListenersHTTPSListenerConfig : TeaModel {
                [NameInMap("CACertificateId")]
                [Validation(Required=false)]
                public string CACertificateId { get; set; }
                [NameInMap("Cookie")]
                [Validation(Required=false)]
                public string Cookie { get; set; }
                [NameInMap("CookieTimeout")]
                [Validation(Required=false)]
                public int? CookieTimeout { get; set; }
                [NameInMap("EnableHttp2")]
                [Validation(Required=false)]
                public string EnableHttp2 { get; set; }
                [NameInMap("Gzip")]
                [Validation(Required=false)]
                public string Gzip { get; set; }
                [NameInMap("HealthCheck")]
                [Validation(Required=false)]
                public string HealthCheck { get; set; }
                [NameInMap("HealthCheckConnectPort")]
                [Validation(Required=false)]
                public int? HealthCheckConnectPort { get; set; }
                [NameInMap("HealthCheckDomain")]
                [Validation(Required=false)]
                public string HealthCheckDomain { get; set; }
                [NameInMap("HealthCheckHttpCode")]
                [Validation(Required=false)]
                public string HealthCheckHttpCode { get; set; }
                [NameInMap("HealthCheckHttpVersion")]
                [Validation(Required=false)]
                public string HealthCheckHttpVersion { get; set; }
                [NameInMap("HealthCheckInterval")]
                [Validation(Required=false)]
                public int? HealthCheckInterval { get; set; }
                [NameInMap("HealthCheckMethod")]
                [Validation(Required=false)]
                public string HealthCheckMethod { get; set; }
                [NameInMap("HealthCheckTimeout")]
                [Validation(Required=false)]
                public int? HealthCheckTimeout { get; set; }
                [NameInMap("HealthCheckType")]
                [Validation(Required=false)]
                public string HealthCheckType { get; set; }
                [NameInMap("HealthCheckURI")]
                [Validation(Required=false)]
                public string HealthCheckURI { get; set; }
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }
                [NameInMap("IdleTimeout")]
                [Validation(Required=false)]
                public int? IdleTimeout { get; set; }
                [NameInMap("RequestTimeout")]
                [Validation(Required=false)]
                public int? RequestTimeout { get; set; }
                [NameInMap("ServerCertificateId")]
                [Validation(Required=false)]
                public string ServerCertificateId { get; set; }
                [NameInMap("StickySession")]
                [Validation(Required=false)]
                public string StickySession { get; set; }
                [NameInMap("StickySessionType")]
                [Validation(Required=false)]
                public string StickySessionType { get; set; }
                [NameInMap("TLSCipherPolicy")]
                [Validation(Required=false)]
                public string TLSCipherPolicy { get; set; }
                [NameInMap("UnhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }
                [NameInMap("XForwardedFor")]
                [Validation(Required=false)]
                public string XForwardedFor { get; set; }
                [NameInMap("XForwardedFor_ClientCertClientVerify")]
                [Validation(Required=false)]
                public string XForwardedFor_ClientCertClientVerify { get; set; }
                [NameInMap("XForwardedFor_ClientCertFingerprint")]
                [Validation(Required=false)]
                public string XForwardedFor_ClientCertFingerprint { get; set; }
                [NameInMap("XForwardedFor_ClientCertIssuerDN")]
                [Validation(Required=false)]
                public string XForwardedFor_ClientCertIssuerDN { get; set; }
                [NameInMap("XForwardedFor_ClientCertSubjectDN")]
                [Validation(Required=false)]
                public string XForwardedFor_ClientCertSubjectDN { get; set; }
                [NameInMap("XForwardedFor_ClientSrcPort")]
                [Validation(Required=false)]
                public string XForwardedFor_ClientSrcPort { get; set; }
                [NameInMap("XForwardedFor_SLBID")]
                [Validation(Required=false)]
                public string XForwardedFor_SLBID { get; set; }
                [NameInMap("XForwardedFor_SLBIP")]
                [Validation(Required=false)]
                public string XForwardedFor_SLBIP { get; set; }
                [NameInMap("XForwardedFor_SLBPORT")]
                [Validation(Required=false)]
                public string XForwardedFor_SLBPORT { get; set; }
                [NameInMap("XForwardedFor_proto")]
                [Validation(Required=false)]
                public string XForwardedFor_proto { get; set; }
            };

            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            [NameInMap("ListenerProtocol")]
            [Validation(Required=false)]
            public string ListenerProtocol { get; set; }

            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public string Scheduler { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TCPListenerConfig")]
            [Validation(Required=false)]
            public DescribeLoadBalancerListenersResponseBodyListenersTCPListenerConfig TCPListenerConfig { get; set; }
            public class DescribeLoadBalancerListenersResponseBodyListenersTCPListenerConfig : TeaModel {
                [NameInMap("ConnectionDrain")]
                [Validation(Required=false)]
                public string ConnectionDrain { get; set; }
                [NameInMap("ConnectionDrainTimeout")]
                [Validation(Required=false)]
                public int? ConnectionDrainTimeout { get; set; }
                [NameInMap("EstablishedTimeout")]
                [Validation(Required=false)]
                public int? EstablishedTimeout { get; set; }
                [NameInMap("HealthCheck")]
                [Validation(Required=false)]
                public string HealthCheck { get; set; }
                [NameInMap("HealthCheckConnectPort")]
                [Validation(Required=false)]
                public int? HealthCheckConnectPort { get; set; }
                [NameInMap("HealthCheckConnectTimeout")]
                [Validation(Required=false)]
                public int? HealthCheckConnectTimeout { get; set; }
                [NameInMap("HealthCheckDomain")]
                [Validation(Required=false)]
                public string HealthCheckDomain { get; set; }
                [NameInMap("HealthCheckHttpCode")]
                [Validation(Required=false)]
                public string HealthCheckHttpCode { get; set; }
                [NameInMap("HealthCheckInterval")]
                [Validation(Required=false)]
                public int? HealthCheckInterval { get; set; }
                [NameInMap("HealthCheckMethod")]
                [Validation(Required=false)]
                public string HealthCheckMethod { get; set; }
                [NameInMap("HealthCheckType")]
                [Validation(Required=false)]
                public string HealthCheckType { get; set; }
                [NameInMap("HealthCheckURI")]
                [Validation(Required=false)]
                public string HealthCheckURI { get; set; }
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }
                [NameInMap("MasterSlaveServerGroupId")]
                [Validation(Required=false)]
                public string MasterSlaveServerGroupId { get; set; }
                [NameInMap("PersistenceTimeout")]
                [Validation(Required=false)]
                public int? PersistenceTimeout { get; set; }
                [NameInMap("UnhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }
            };

            [NameInMap("UDPListenerConfig")]
            [Validation(Required=false)]
            public DescribeLoadBalancerListenersResponseBodyListenersUDPListenerConfig UDPListenerConfig { get; set; }
            public class DescribeLoadBalancerListenersResponseBodyListenersUDPListenerConfig : TeaModel {
                [NameInMap("ConnectionDrain")]
                [Validation(Required=false)]
                public string ConnectionDrain { get; set; }
                [NameInMap("ConnectionDrainTimeout")]
                [Validation(Required=false)]
                public int? ConnectionDrainTimeout { get; set; }
                [NameInMap("HealthCheck")]
                [Validation(Required=false)]
                public string HealthCheck { get; set; }
                [NameInMap("HealthCheckConnectPort")]
                [Validation(Required=false)]
                public int? HealthCheckConnectPort { get; set; }
                [NameInMap("HealthCheckConnectTimeout")]
                [Validation(Required=false)]
                public int? HealthCheckConnectTimeout { get; set; }
                [NameInMap("HealthCheckExp")]
                [Validation(Required=false)]
                public string HealthCheckExp { get; set; }
                [NameInMap("HealthCheckInterval")]
                [Validation(Required=false)]
                public int? HealthCheckInterval { get; set; }
                [NameInMap("HealthCheckReq")]
                [Validation(Required=false)]
                public string HealthCheckReq { get; set; }
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }
                [NameInMap("MasterSlaveServerGroupId")]
                [Validation(Required=false)]
                public string MasterSlaveServerGroupId { get; set; }
                [NameInMap("UnhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }
            };

            [NameInMap("VServerGroupId")]
            [Validation(Required=false)]
            public string VServerGroupId { get; set; }

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
