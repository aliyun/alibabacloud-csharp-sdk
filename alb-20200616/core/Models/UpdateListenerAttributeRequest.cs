// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateListenerAttributeRequest : TeaModel {
        [NameInMap("CaCertificates")]
        [Validation(Required=false)]
        public List<UpdateListenerAttributeRequestCaCertificates> CaCertificates { get; set; }
        public class UpdateListenerAttributeRequestCaCertificates : TeaModel {
        }

        [NameInMap("CaEnabled")]
        [Validation(Required=false)]
        public bool? CaEnabled { get; set; }

        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<UpdateListenerAttributeRequestCertificates> Certificates { get; set; }
        public class UpdateListenerAttributeRequestCertificates : TeaModel {
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

        }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DefaultActions")]
        [Validation(Required=false)]
        public List<UpdateListenerAttributeRequestDefaultActions> DefaultActions { get; set; }
        public class UpdateListenerAttributeRequestDefaultActions : TeaModel {
            [NameInMap("ForwardGroupConfig")]
            [Validation(Required=false)]
            public UpdateListenerAttributeRequestDefaultActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class UpdateListenerAttributeRequestDefaultActionsForwardGroupConfig : TeaModel {
                [NameInMap("ServerGroupTuples")]
                [Validation(Required=false)]
                public List<UpdateListenerAttributeRequestDefaultActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                public class UpdateListenerAttributeRequestDefaultActionsForwardGroupConfigServerGroupTuples : TeaModel {
                    public string ServerGroupId { get; set; }
                }
            };

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

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

        [NameInMap("QuicConfig")]
        [Validation(Required=false)]
        public UpdateListenerAttributeRequestQuicConfig QuicConfig { get; set; }
        public class UpdateListenerAttributeRequestQuicConfig : TeaModel {
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
        public UpdateListenerAttributeRequestXForwardedForConfig XForwardedForConfig { get; set; }
        public class UpdateListenerAttributeRequestXForwardedForConfig : TeaModel {
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

}
