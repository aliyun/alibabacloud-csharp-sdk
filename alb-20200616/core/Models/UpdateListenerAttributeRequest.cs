// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateListenerAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The CA certificate. You can specify only one CA certificate.</para>
        /// </summary>
        [NameInMap("CaCertificates")]
        [Validation(Required=false)]
        public List<UpdateListenerAttributeRequestCaCertificates> CaCertificates { get; set; }
        public class UpdateListenerAttributeRequestCaCertificates : TeaModel {
            /// <summary>
            /// <para>The ID of the CA certificate.</para>
            /// <remarks>
            /// <para> This parameter is required if <b>CaEnabled</b> is set to <b>true</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>123359******</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable mutual authentication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CaEnabled")]
        [Validation(Required=false)]
        public bool? CaEnabled { get; set; }

        /// <summary>
        /// <para>The certificates. You can add at most 20 certificates.</para>
        /// <remarks>
        /// <para> Only server certificates are supported.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<UpdateListenerAttributeRequestCertificates> Certificates { get; set; }
        public class UpdateListenerAttributeRequestCertificates : TeaModel {
            /// <summary>
            /// <para>The certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12315790212_166f8204689_1714763408_70998****</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The actions of the default forwarding rule.</para>
        /// </summary>
        [NameInMap("DefaultActions")]
        [Validation(Required=false)]
        public List<UpdateListenerAttributeRequestDefaultActions> DefaultActions { get; set; }
        public class UpdateListenerAttributeRequestDefaultActions : TeaModel {
            /// <summary>
            /// <para>The forwarding action. This parameter takes effect only when you set <b>Type</b> to <b>ForwardGroup</b>. You can specify at most 20 actions.</para>
            /// </summary>
            [NameInMap("ForwardGroupConfig")]
            [Validation(Required=false)]
            public UpdateListenerAttributeRequestDefaultActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class UpdateListenerAttributeRequestDefaultActionsForwardGroupConfig : TeaModel {
                /// <summary>
                /// <para>The server groups to which requests are forwarded.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("ServerGroupTuples")]
                [Validation(Required=false)]
                public List<UpdateListenerAttributeRequestDefaultActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                public class UpdateListenerAttributeRequestDefaultActionsForwardGroupConfigServerGroupTuples : TeaModel {
                    /// <summary>
                    /// <para>The ID of the server group to which requests are forwarded.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rsp-cige6j5e7p****</para>
                    /// </summary>
                    [NameInMap("ServerGroupId")]
                    [Validation(Required=false)]
                    public string ServerGroupId { get; set; }

                }

            }

            /// <summary>
            /// <para>The action type. You can specify only one type.</para>
            /// <para>Set the value to <b>ForwardGroup</b>, which specifies that requests are forwarded to multiple server groups.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ForwardGroup</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, a <c>2xx HTTP</c> status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable GZIP compression for specific types of files. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("GzipEnabled")]
        [Validation(Required=false)]
        public bool? GzipEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable HTTP/2. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only when you create an HTTPS listener.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Http2Enabled")]
        [Validation(Required=false)]
        public bool? Http2Enabled { get; set; }

        /// <summary>
        /// <para>The timeout period of an idle connection. Unit: seconds. Valid values: <b>1 to 60</b>.</para>
        /// <para>If no request is received within the specified timeout period, ALB closes the current connection. When another request is received, ALB establishes a new connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The name of the listener.</para>
        /// <para>The name must be 2 to 256 characters in length, and can contain letters, digits, commas (,), periods (.), semicolons (;), forward slashes (/), at signs (@), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP_80</para>
        /// </summary>
        [NameInMap("ListenerDescription")]
        [Validation(Required=false)]
        public string ListenerDescription { get; set; }

        /// <summary>
        /// <para>The ID of the Application Load Balancer (ALB) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsr-bp1bpn0kn908w4nbw****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The configuration information when the listener is associated with a QUIC listener.</para>
        /// </summary>
        [NameInMap("QuicConfig")]
        [Validation(Required=false)]
        public UpdateListenerAttributeRequestQuicConfig QuicConfig { get; set; }
        public class UpdateListenerAttributeRequestQuicConfig : TeaModel {
            /// <summary>
            /// <para>The QUIC listener ID. This parameter is required if <b>QuicUpgradeEnabled</b> is set to <b>true</b>. Only HTTPS listeners support this parameter.</para>
            /// <remarks>
            /// <para>You must add the HTTPS listener and the QUIC listener to the same ALB instance. In addition, make sure that the QUIC listener has never been associated with another listener.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>lsn-333</para>
            /// </summary>
            [NameInMap("QuicListenerId")]
            [Validation(Required=false)]
            public string QuicListenerId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable QUIC upgrade. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("QuicUpgradeEnabled")]
            [Validation(Required=false)]
            public bool? QuicUpgradeEnabled { get; set; }

        }

        /// <summary>
        /// <para>The timeout period of a request. Unit: seconds. Valid values: <b>1 to 180</b>.</para>
        /// <para>If no response is received from the backend server within the specified timeout period, ALB returns an <c>HTTP 504</c> error code to the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// <para>The security policy ID. System security policies and custom security policies are supported.</para>
        /// <remarks>
        /// <para>This parameter is available only when you create an HTTPS listener.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tls_cipher_policy_1_0</para>
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// <para>The configurations of the X-Forwarded-For header.</para>
        /// </summary>
        [NameInMap("XForwardedForConfig")]
        [Validation(Required=false)]
        public UpdateListenerAttributeRequestXForwardedForConfig XForwardedForConfig { get; set; }
        public class UpdateListenerAttributeRequestXForwardedForConfig : TeaModel {
            /// <summary>
            /// <para>The name of the custom header. The header takes effect only when you set <b>XForwardedForClientCertClientVerifyEnabled</b> to <b>true</b>.</para>
            /// <para>The name must be 1 to 40 characters in length. The name can contain lowercase letters, digits, hyphens (-), and underscores (-).</para>
            /// <remarks>
            /// <para> Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_client-verify-alias_123456</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertClientVerifyAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertClientVerifyAlias { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Clientcert-clientverify</c> header to retrieve the verification result of the client certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertClientVerifyEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertClientVerifyEnabled { get; set; }

            /// <summary>
            /// <para>The name of the custom header. The header takes effect only when you set <b>XForwardedForClientCertFingerprintEnabled</b> to <b>true</b>.</para>
            /// <para>The name must be 1 to 40 characters in length. The name can contain lowercase letters, digits, hyphens (-), and underscores (-).</para>
            /// <remarks>
            /// <para> Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_finger-print-alias_123456</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertFingerprintAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertFingerprintAlias { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Clientcert-fingerprint</c> header to retrieve the fingerprint of the client certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertFingerprintEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertFingerprintEnabled { get; set; }

            /// <summary>
            /// <para>The name of the custom header. The header takes effect only when you set <b>XForwardedForClientCertIssuerDNEnabled</b> to <b>true</b>.</para>
            /// <para>The name must be 1 to 40 characters in length. The name can contain lowercase letters, digits, hyphens (-), and underscores (-).</para>
            /// <remarks>
            /// <para> Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_issue-dn-alias_123456</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertIssuerDNAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertIssuerDNAlias { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Clientcert-issuerdn</c> header to retrieve information about the authority that issues the client certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertIssuerDNEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertIssuerDNEnabled { get; set; }

            /// <summary>
            /// <para>The name of the custom header. This parameter is valid only if the <b>XForwardedForClientCertSubjectDNEnabled</b> parameter is set to true.****</para>
            /// <para>The name must be 1 to 40 characters in length, The name can contain lowercase letters, digits, hyphens (-), and underscores (-).</para>
            /// <remarks>
            /// <para> Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_subject-dn-alias_123456</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertSubjectDNAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertSubjectDNAlias { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Clientcert-subjectdn</c> header to retrieve information about the owner of the client certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertSubjectDNEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertSubjectDNEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the X-Forwarded-For header to preserve client IP addresses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> HTTP and HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForClientSourceIpsEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientSourceIpsEnabled { get; set; }

            /// <summary>
            /// <para>The trusted proxy IP address.</para>
            /// <para>ALB instances traverse the IP addresses in the <c>X-Forwarded-For</c> header from the rightmost IP address to the leftmost IP address. The first IP address that is not on the trusted IP address list is considered the client IP address. Requests from the client IP address are throttled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.1.1.0/24</para>
            /// </summary>
            [NameInMap("XForwardedForClientSourceIpsTrusted")]
            [Validation(Required=false)]
            public string XForwardedForClientSourceIpsTrusted { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>XForwardedFor_ClientSrcPort</c> header to retrieve the client port. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> HTTP and HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForClientSrcPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientSrcPortEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-For</c> header to retrieve client IP addresses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> HTTP and HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XForwardedForEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Proto</c> header to retrieve the listener protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> HTTP, HTTPS, and QUIC listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForProtoEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForProtoEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>SLB-ID</c> header to retrieve the ID of the ALB instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> HTTP, HTTPS, and QUIC listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForSLBIdEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForSLBIdEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Port</c> header to retrieve the listener port of the ALB instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> HTTP, HTTPS, and QUIC listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForSLBPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForSLBPortEnabled { get; set; }

        }

    }

}
