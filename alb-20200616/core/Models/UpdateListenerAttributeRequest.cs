// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateListenerAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The CA certificate list. Only one CA certificate is supported.</para>
        /// </summary>
        [NameInMap("CaCertificates")]
        [Validation(Required=false)]
        public List<UpdateListenerAttributeRequestCaCertificates> CaCertificates { get; set; }
        public class UpdateListenerAttributeRequestCaCertificates : TeaModel {
            /// <summary>
            /// <para>The CA certificate ID.</para>
            /// <remarks>
            /// <para>This parameter is required when <b>CaEnabled</b> is set to <b>true</b>.</para>
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
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CaEnabled")]
        [Validation(Required=false)]
        public bool? CaEnabled { get; set; }

        /// <summary>
        /// <para>The certificate list.</para>
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<UpdateListenerAttributeRequestCertificates> Certificates { get; set; }
        public class UpdateListenerAttributeRequestCertificates : TeaModel {
            /// <summary>
            /// <para>The default certificate ID. Only one default server certificate is supported.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is required when the listener protocol type is <b>HTTPS</b> or <b>QUIC</b>.</description></item>
            /// <item><description>To add more server certificates, invoke <a href="https://help.aliyun.com/document_detail/2254830.html">AssociateAdditionalCertificatesWithListener</a> to configure extension certificates after the listener is created.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>123157******</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of default rule actions.</para>
        /// </summary>
        [NameInMap("DefaultActions")]
        [Validation(Required=false)]
        public List<UpdateListenerAttributeRequestDefaultActions> DefaultActions { get; set; }
        public class UpdateListenerAttributeRequestDefaultActions : TeaModel {
            /// <summary>
            /// <para>The forwarding configuration for the action. This parameter is required and valid only when <b>Type</b> is set to <b>ForwardGroup</b>. You can add up to 20 forwarding action configurations.</para>
            /// </summary>
            [NameInMap("ForwardGroupConfig")]
            [Validation(Required=false)]
            public UpdateListenerAttributeRequestDefaultActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class UpdateListenerAttributeRequestDefaultActionsForwardGroupConfig : TeaModel {
                /// <summary>
                /// <para>The list of forwarding destination server group tuples.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("ServerGroupTuples")]
                [Validation(Required=false)]
                public List<UpdateListenerAttributeRequestDefaultActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                public class UpdateListenerAttributeRequestDefaultActionsForwardGroupConfigServerGroupTuples : TeaModel {
                    /// <summary>
                    /// <para>The ID of the destination server group to which requests are forwarded.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sgp-i5qt20******</para>
                    /// </summary>
                    [NameInMap("ServerGroupId")]
                    [Validation(Required=false)]
                    public string ServerGroupId { get; set; }

                }

            }

            /// <summary>
            /// <para>The action type. You can add up to one action type.</para>
            /// <para>Valid values: <b>ForwardGroup</b>, which indicates that requests are forwarded to multiple server groups.</para>
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
        /// <item><description><para><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, an <c>HTTP 2xx</c> status code is returned and the operation is performed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Gzip compression to compress specific types of files. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b>: disabled.</description></item>
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
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b>: disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Only HTTPS listeners support this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Http2Enabled")]
        [Validation(Required=false)]
        public bool? Http2Enabled { get; set; }

        /// <summary>
        /// <para>The idle connection timeout period. Unit: seconds. Valid values: <b>1 to 600</b>.</para>
        /// <para>If no access request is received within the timeout period, load balancing temporarily breaks the current connection and restores the connection when the next request arrives.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The custom listener name.</para>
        /// <para>The name must be 2 to 256 characters in length, and can contain letters, digits, Chinese characters, commas (,), periods (.), semicolons (;), forward slashes (/), at signs (@), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP_80</para>
        /// </summary>
        [NameInMap("ListenerDescription")]
        [Validation(Required=false)]
        public string ListenerDescription { get; set; }

        /// <summary>
        /// <para>The listener ID of the Application Load Balancing (ALB) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsn-o4u54y73wq7b******</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The configuration information when an associated QUIC listener is enabled.</para>
        /// </summary>
        [NameInMap("QuicConfig")]
        [Validation(Required=false)]
        public UpdateListenerAttributeRequestQuicConfig QuicConfig { get; set; }
        public class UpdateListenerAttributeRequestQuicConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the QUIC listener to be associated. This parameter is required when <b>QuicUpgradeEnabled</b> is set to <b>true</b>. This parameter is valid only for HTTPS listeners.</para>
            /// <remarks>
            /// <para>The original listener and the associated QUIC listener must belong to the same ALB instance, and the QUIC listener must not have been previously associated.</para>
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
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is valid only for HTTPS listeners.</para>
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
        /// <para>The request timeout period. Unit: seconds. Valid values: <b>1 to 600</b>.</para>
        /// <para>If no response is received from the backend server within the timeout period, load balancing returns an <c>HTTP 504</c> error code to the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// <para>The security policy. System security policies and custom security policies are supported.</para>
        /// <remarks>
        /// <para>Only HTTPS listeners support this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tls_cipher_policy_1_0</para>
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// <para>The configuration of the XForwardedFor feature.</para>
        /// </summary>
        [NameInMap("XForwardedForConfig")]
        [Validation(Required=false)]
        public UpdateListenerAttributeRequestXForwardedForConfig XForwardedForConfig { get; set; }
        public class UpdateListenerAttributeRequestXForwardedForConfig : TeaModel {
            /// <summary>
            /// <para>The custom header field name. This parameter takes effect only when <b>XForwardedForClientCertClientVerifyEnabled</b> is set to <b>true</b>.</para>
            /// <para>The name must be 1 to 40 characters in length, and can contain lowercase letters a to z, hyphens (-), underscores (_), and digits.</para>
            /// <remarks>
            /// <para>Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_client-verify-alias_123456</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertClientVerifyAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertClientVerifyAlias { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Clientcert-clientverify</c> header field to retrieve the verification result of the client certificate that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertClientVerifyEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertClientVerifyEnabled { get; set; }

            /// <summary>
            /// <para>The custom header field name. This parameter takes effect only when <b>XForwardedForClientCertFingerprintEnabled</b> is set to <b>true</b>.</para>
            /// <para>The name must be 1 to 40 characters in length, and can contain lowercase letters a to z, hyphens (-), underscores (_), and digits.</para>
            /// <remarks>
            /// <para>Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_finger-print-alias_123456</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertFingerprintAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertFingerprintAlias { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Clientcert-fingerprint</c> header field to retrieve the fingerprint of the client certificate that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertFingerprintEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertFingerprintEnabled { get; set; }

            /// <summary>
            /// <para>The custom header field name. This parameter takes effect only when <b>XForwardedForClientCertIssuerDNEnabled</b> is set to <b>true</b>.</para>
            /// <para>The name must be 1 to 40 characters in length, and can contain lowercase letters a to z, hyphens (-), underscores (_), and digits.</para>
            /// <remarks>
            /// <para>Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_issue-dn-alias_123456</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertIssuerDNAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertIssuerDNAlias { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Clientcert-issuerdn</c> header field to retrieve the issuer information of the client certificate that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertIssuerDNEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertIssuerDNEnabled { get; set; }

            /// <summary>
            /// <para>The custom header field name. This parameter takes effect only when <b>XForwardedForClientCertSubjectDNEnabled</b> is set to <b>true</b>.</para>
            /// <para>The name must be 1 to 40 characters in length, and can contain lowercase letters a to z, hyphens (-), underscores (_), and digits.</para>
            /// <remarks>
            /// <para>Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_subject-dn-alias_123456</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertSubjectDNAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertSubjectDNAlias { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Clientcert-subjectdn</c> header field to retrieve the owner information of the client certificate that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertSubjectDNEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertSubjectDNEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow ALB to retrieve the real client IP address from the X-Forwarded-For header field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled.</description></item>
            /// </list>
            /// <remarks>
            /// <para>HTTP and HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForClientSourceIpsEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientSourceIpsEnabled { get; set; }

            /// <summary>
            /// <para>The trusted proxy IP addresses.</para>
            /// <para>Application Load Balancing (ALB) traverses the <c>X-Forwarded-For</c> header field from right to left and selects the first IP address that is not in the trusted IP list as the real client IP address. This IP address is used for source IP-based rate limiting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.1.1.0/24</para>
            /// </summary>
            [NameInMap("XForwardedForClientSourceIpsTrusted")]
            [Validation(Required=false)]
            public string XForwardedForClientSourceIpsTrusted { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Client-srcport</c> header field to retrieve the port of the client that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled.</description></item>
            /// </list>
            /// <remarks>
            /// <para>HTTP and HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForClientSrcPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientSrcPortEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-For</c> header field to retrieve the real IP address of the client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b> (default): enabled.</description></item>
            /// <item><description><b>false</b>: disabled.</description></item>
            /// </list>
            /// <remarks>
            /// <ol>
            /// <item><description>If you set this parameter to <b>true</b>, <b>XForwardedForProcessingMode</b> defaults to <b>append</b> and can be changed to <b>remove</b>.</description></item>
            /// <item><description>If you set this parameter to <b>false</b>, the <c>X-Forwarded-For</c> header field is retained without additional processing before the request is sent to the backend server.</description></item>
            /// <item><description>HTTP and HTTPS listeners support this parameter.</description></item>
            /// </ol>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XForwardedForEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Host</c> header field to retrieve the domain name of the client that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b> (default): disabled.</description></item>
            /// </list>
            /// <remarks>
            /// <para>HTTP, HTTPS, and QUIC listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForHostEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForHostEnabled { get; set; }

            /// <summary>
            /// <para>The processing mode for the <c>X-Forwarded-For</c> header field. This parameter takes effect only when <b>XForwardedForEnabled</b> is set to <b>true</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>append</b> (default): append.</description></item>
            /// <item><description><b>remove</b>: remove.</description></item>
            /// </list>
            /// <remarks>
            /// <ol>
            /// <item><description>If you set this parameter to <b>append</b>, the last-hop IP address is appended to the <c>X-Forwarded-For</c> header field before the request is sent to the backend server.</description></item>
            /// <item><description>If you set this parameter to <b>remove</b>, the <c>X-Forwarded-For</c> header is removed before the request is sent to the backend server, regardless of whether the request contains the <c>X-Forwarded-For</c> header field.</description></item>
            /// <item><description>HTTP and HTTPS listeners support this parameter.</description></item>
            /// </ol>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>append</para>
            /// </summary>
            [NameInMap("XForwardedForProcessingMode")]
            [Validation(Required=false)]
            public string XForwardedForProcessingMode { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Proto</c> header field to retrieve the listener protocol of the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled.</description></item>
            /// </list>
            /// <remarks>
            /// <para>HTTP, HTTPS, and QUIC listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForProtoEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForProtoEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>SLB-ID</c> header field to retrieve the load balancing instance ID. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled.</description></item>
            /// </list>
            /// <remarks>
            /// <para>HTTP, HTTPS, and QUIC listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForSLBIdEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForSLBIdEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Port</c> header field to retrieve the listener port of the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled.</description></item>
            /// </list>
            /// <remarks>
            /// <para>HTTP, HTTPS, and QUIC listeners support this parameter.</para>
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
