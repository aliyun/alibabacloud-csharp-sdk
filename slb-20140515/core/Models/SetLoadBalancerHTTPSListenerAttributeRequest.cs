// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class SetLoadBalancerHTTPSListenerAttributeRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        [NameInMap("BackendProtocol")]
        [Validation(Required=false)]
        public string BackendProtocol { get; set; }

        [NameInMap("XForwardedFor")]
        [Validation(Required=false)]
        public string XForwardedFor { get; set; }

        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        [NameInMap("StickySession")]
        [Validation(Required=false)]
        public string StickySession { get; set; }

        [NameInMap("StickySessionType")]
        [Validation(Required=false)]
        public string StickySessionType { get; set; }

        [NameInMap("CookieTimeout")]
        [Validation(Required=false)]
        public int? CookieTimeout { get; set; }

        [NameInMap("Cookie")]
        [Validation(Required=false)]
        public string Cookie { get; set; }

        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

        [NameInMap("HealthCheckType")]
        [Validation(Required=false)]
        public string HealthCheckType { get; set; }

        [NameInMap("HealthCheckMethod")]
        [Validation(Required=false)]
        public string HealthCheckMethod { get; set; }

        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        [NameInMap("MaxConnection")]
        [Validation(Required=false)]
        public int? MaxConnection { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("access_key_id")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        [NameInMap("ServerCertificateId")]
        [Validation(Required=false)]
        public string ServerCertificateId { get; set; }

        [NameInMap("CACertificateId")]
        [Validation(Required=false)]
        public string CACertificateId { get; set; }

        [NameInMap("VServerGroup")]
        [Validation(Required=false)]
        public string VServerGroup { get; set; }

        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        [NameInMap("XForwardedFor_SLBIP")]
        [Validation(Required=false)]
        public string XForwardedFor_SLBIP { get; set; }

        [NameInMap("XForwardedFor_SLBID")]
        [Validation(Required=false)]
        public string XForwardedFor_SLBID { get; set; }

        [NameInMap("XForwardedFor_proto")]
        [Validation(Required=false)]
        public string XForwardedFor_proto { get; set; }

        [NameInMap("Gzip")]
        [Validation(Required=false)]
        public string Gzip { get; set; }

        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        [NameInMap("AclStatus")]
        [Validation(Required=false)]
        public string AclStatus { get; set; }

        [NameInMap("VpcIds")]
        [Validation(Required=false)]
        public string VpcIds { get; set; }

        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        [NameInMap("EnableHttp2")]
        [Validation(Required=false)]
        public string EnableHttp2 { get; set; }

        [NameInMap("TLSCipherPolicy")]
        [Validation(Required=false)]
        public string TLSCipherPolicy { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("XForwardedFor_SLBPORT")]
        [Validation(Required=false)]
        public string XForwardedFor_SLBPORT { get; set; }

        [NameInMap("XForwardedFor_ClientSrcPort")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientSrcPort { get; set; }

        [NameInMap("XForwardedFor_ClientCertSubjectDN")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientCertSubjectDN { get; set; }

        [NameInMap("XForwardedFor_ClientCertIssuerDN")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientCertIssuerDN { get; set; }

        [NameInMap("XForwardedFor_ClientCertFingerprint")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientCertFingerprint { get; set; }

        [NameInMap("XForwardedFor_ClientCertClientVerify")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientCertClientVerify { get; set; }

        [NameInMap("XForwardedFor_ClientCertSubjectDNAlias")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientCertSubjectDNAlias { get; set; }

        [NameInMap("XForwardedFor_ClientCertIssuerDNAlias")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientCertIssuerDNAlias { get; set; }

        [NameInMap("XForwardedFor_ClientCertFingerprintAlias")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientCertFingerprintAlias { get; set; }

        [NameInMap("XForwardedFor_ClientCertClientVerifyAlias")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientCertClientVerifyAlias { get; set; }

        [NameInMap("ServerCertificate")]
        [Validation(Required=false)]
        public List<SetLoadBalancerHTTPSListenerAttributeRequestServerCertificate> ServerCertificate { get; set; }
        public class SetLoadBalancerHTTPSListenerAttributeRequestServerCertificate : TeaModel {
        }

    }

}
