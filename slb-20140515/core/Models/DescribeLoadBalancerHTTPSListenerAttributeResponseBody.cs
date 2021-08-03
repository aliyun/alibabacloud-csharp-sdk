// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeLoadBalancerHTTPSListenerAttributeResponseBody : TeaModel {
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        [NameInMap("XForwardedFor_ClientCertClientVerify")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientCertClientVerify { get; set; }

        [NameInMap("CACertificateId")]
        [Validation(Required=false)]
        public string CACertificateId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        [NameInMap("BackendServerPort")]
        [Validation(Required=false)]
        public int? BackendServerPort { get; set; }

        [NameInMap("CookieTimeout")]
        [Validation(Required=false)]
        public int? CookieTimeout { get; set; }

        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        [NameInMap("XForwardedFor")]
        [Validation(Required=false)]
        public string XForwardedFor { get; set; }

        [NameInMap("XForwardedFor_ClientCertFingerprint")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientCertFingerprint { get; set; }

        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        [NameInMap("XForwardedFor_SLBPORT")]
        [Validation(Required=false)]
        public string XForwardedFor_SLBPORT { get; set; }

        [NameInMap("StickySessionType")]
        [Validation(Required=false)]
        public string StickySessionType { get; set; }

        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        [NameInMap("XForwardedFor_proto")]
        [Validation(Required=false)]
        public string XForwardedFor_proto { get; set; }

        [NameInMap("HealthCheckMethod")]
        [Validation(Required=false)]
        public string HealthCheckMethod { get; set; }

        [NameInMap("TLSCipherPolicy")]
        [Validation(Required=false)]
        public string TLSCipherPolicy { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

        [NameInMap("XForwardedFor_ClientSrcPort")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientSrcPort { get; set; }

        [NameInMap("Cookie")]
        [Validation(Required=false)]
        public string Cookie { get; set; }

        [NameInMap("Gzip")]
        [Validation(Required=false)]
        public string Gzip { get; set; }

        [NameInMap("EnableHttp2")]
        [Validation(Required=false)]
        public string EnableHttp2 { get; set; }

        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        [NameInMap("AclStatus")]
        [Validation(Required=false)]
        public string AclStatus { get; set; }

        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

        [NameInMap("XForwardedFor_SLBID")]
        [Validation(Required=false)]
        public string XForwardedFor_SLBID { get; set; }

        [NameInMap("XForwardedFor_ClientCertSubjectDN")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientCertSubjectDN { get; set; }

        [NameInMap("SecurityStatus")]
        [Validation(Required=false)]
        public string SecurityStatus { get; set; }

        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        [NameInMap("ServerCertificateId")]
        [Validation(Required=false)]
        public string ServerCertificateId { get; set; }

        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        [NameInMap("XForwardedFor_ClientCertIssuerDN")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientCertIssuerDN { get; set; }

        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        [NameInMap("XForwardedFor_SLBIP")]
        [Validation(Required=false)]
        public string XForwardedFor_SLBIP { get; set; }

        [NameInMap("StickySession")]
        [Validation(Required=false)]
        public string StickySession { get; set; }

        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public DescribeLoadBalancerHTTPSListenerAttributeResponseBodyRules Rules { get; set; }
        public class DescribeLoadBalancerHTTPSListenerAttributeResponseBodyRules : TeaModel {
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancerHTTPSListenerAttributeResponseBodyRulesRule> Rule { get; set; }
            public class DescribeLoadBalancerHTTPSListenerAttributeResponseBodyRulesRule : TeaModel {
                public string VServerGroupId { get; set; }
                public string Url { get; set; }
                public string Domain { get; set; }
                public string RuleName { get; set; }
                public string RuleId { get; set; }
            }
        };

        [NameInMap("DomainExtensions")]
        [Validation(Required=false)]
        public DescribeLoadBalancerHTTPSListenerAttributeResponseBodyDomainExtensions DomainExtensions { get; set; }
        public class DescribeLoadBalancerHTTPSListenerAttributeResponseBodyDomainExtensions : TeaModel {
            [NameInMap("DomainExtension")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancerHTTPSListenerAttributeResponseBodyDomainExtensionsDomainExtension> DomainExtension { get; set; }
            public class DescribeLoadBalancerHTTPSListenerAttributeResponseBodyDomainExtensionsDomainExtension : TeaModel {
                public string ServerCertificateId { get; set; }
                public string Domain { get; set; }
                public string DomainExtensionId { get; set; }
            }
        };

    }

}
