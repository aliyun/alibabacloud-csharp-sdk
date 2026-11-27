// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateListenerAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The list of CA certificates. You can add only one CA certificate.</para>
        /// </summary>
        [NameInMap("CaCertificates")]
        [Validation(Required=false)]
        public List<UpdateListenerAttributeRequestCaCertificates> CaCertificates { get; set; }
        public class UpdateListenerAttributeRequestCaCertificates : TeaModel {
            /// <summary>
            /// <para>The ID of the CA certificate.</para>
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
        /// <item><description><b>true</b>: yes.</description></item>
        /// <item><description><b>false</b>: no.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CaEnabled")]
        [Validation(Required=false)]
        public bool? CaEnabled { get; set; }

        /// <summary>
        /// <para>The list of certificates.</para>
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<UpdateListenerAttributeRequestCertificates> Certificates { get; set; }
        public class UpdateListenerAttributeRequestCertificates : TeaModel {
            /// <summary>
            /// <para>The ID of the default certificate. You can add only one default server certificate.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is required when the listener Protocol Type is <b>HTTPS</b> or <b>QUIC</b>.</description></item>
            /// <item><description>To add more server certificates, invoke the <a href="https://help.aliyun.com/document_detail/2254830.html">AssociateAdditionalCertificatesWithListener</a> operation to configure extension certificates after you create the listener.</description></item>
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
        /// <para>You can generate a parameter value on your client to ensure that the value is unique across different requests. The client token supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
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
            /// <para>The configuration for the forwarding action. This parameter is required and takes effect only when <b>Type</b> is set to <b>ForwardGroup</b>. You can specify up to 20 forwarding action configurations.</para>
            /// </summary>
            [NameInMap("ForwardGroupConfig")]
            [Validation(Required=false)]
            public UpdateListenerAttributeRequestDefaultActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class UpdateListenerAttributeRequestDefaultActionsForwardGroupConfig : TeaModel {
                /// <summary>
                /// <para>The list of destination server group tuples for forwarding.</para>
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
            /// <para>The action type. You can specify only one action type. Valid values: <b>ForwardGroup</b>: forwards requests to multiple server groups.</para>
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
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run without updating the listener configurations. The system checks whether required parameters are specified, the request format is valid, and service limits are met. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): performs a dry run and sends the request. If the request passes the dry run, an <c>HTTP 2xx</c> status code is returned and the operation is performed.</para>
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
        /// <para>Specifies whether to enable Gzip compression to compress specific file types. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes.</description></item>
        /// <item><description><b>false</b>: no.</description></item>
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
        /// <item><description><b>true</b>: yes.</description></item>
        /// <item><description><b>false</b>: no.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only by HTTPS listeners.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Http2Enabled")]
        [Validation(Required=false)]
        public bool? Http2Enabled { get; set; }

        /// <summary>
        /// <para>Specifies the idle connection timeout period. Unit: seconds. Valid values: <b>1</b> to <b>600</b>.</para>
        /// <para>If no access request is received within the timeout period, load balancing temporarily breaks the current connection and establishes a new connection when the next request arrives.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The custom name of the listener.</para>
        /// <para>The name must be 2 to 256 characters in length, and can contain letters, digits, Chinese characters, commas (,), periods (.), semicolons (;), forward slashes (/), at signs (@), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP_80</para>
        /// </summary>
        [NameInMap("ListenerDescription")]
        [Validation(Required=false)]
        public string ListenerDescription { get; set; }

        /// <summary>
        /// <para>The ID of the listener on the application load balancing instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsn-o4u54y73wq7b******</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The configurations for associating a QUIC listener.</para>
        /// </summary>
        [NameInMap("QuicConfig")]
        [Validation(Required=false)]
        public UpdateListenerAttributeRequestQuicConfig QuicConfig { get; set; }
        public class UpdateListenerAttributeRequestQuicConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the QUIC listener to be associated. This parameter is required when <b>QuicUpgradeEnabled</b> is set to <b>true</b>. This parameter is supported only by HTTPS listeners.</para>
            /// <remarks>
            /// <para>The original listener and the associated QUIC listener must belong to the same ALB instance, and the QUIC listener must not have been associated before.</para>
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
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b>: no.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported only by HTTPS listeners.</para>
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
        /// <para>Specifies the request timeout period. Unit: seconds. Valid values: <b>1</b> to <b>600</b>.</para>
        /// <para>If no response is received from the backend server within the timeout period, load balancing stops waiting and returns an HTTP 504 error code to the client.</para>
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
        /// <para>This parameter is supported only by HTTPS listeners.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tls_cipher_policy_1_0</para>
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// <para>The configurations of X-Forwarded-For attributes.</para>
        /// </summary>
        [NameInMap("XForwardedForConfig")]
        [Validation(Required=false)]
        public UpdateListenerAttributeRequestXForwardedForConfig XForwardedForConfig { get; set; }
        public class UpdateListenerAttributeRequestXForwardedForConfig : TeaModel {
            /// <summary>
            /// <para>The custom header name. This parameter takes effect only when <b>XForwardedForClientCertClientVerifyEnabled</b> is set to <b>true</b>.</para>
            /// <para>The name must be 1 to 40 characters in length, and can contain lowercase letters, hyphens (-), underscores (_), and digits.</para>
            /// <remarks>
            /// <para>This parameter is supported only by HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_client-verify-alias_123456</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertClientVerifyAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertClientVerifyAlias { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Clientcert-clientverify</c> header to obtain the verification result of the client certificate that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b>: no.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported only by HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertClientVerifyEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertClientVerifyEnabled { get; set; }

            /// <summary>
            /// <para>The custom header name. This parameter takes effect only when <b>XForwardedForClientCertFingerprintEnabled</b> is set to <b>true</b>.</para>
            /// <para>The name must be 1 to 40 characters in length, and can contain lowercase letters, hyphens (-), underscores (_), and digits.</para>
            /// <remarks>
            /// <para>This parameter is supported only by HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_finger-print-alias_123456</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertFingerprintAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertFingerprintAlias { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Clientcert-fingerprint</c> header to obtain the fingerprint of the client certificate that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b>: no.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported only by HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertFingerprintEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertFingerprintEnabled { get; set; }

            /// <summary>
            /// <para>The custom header name. This parameter takes effect only when <b>XForwardedForClientCertIssuerDNEnabled</b> is set to <b>true</b>.</para>
            /// <para>The name must be 1 to 40 characters in length, and can contain lowercase letters, hyphens (-), underscores (_), and digits.</para>
            /// <remarks>
            /// <para>This parameter is supported only by HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_issue-dn-alias_123456</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertIssuerDNAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertIssuerDNAlias { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Clientcert-issuerdn</c> header to obtain the issuer information of the client certificate that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b>: no.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported only by HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertIssuerDNEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertIssuerDNEnabled { get; set; }

            /// <summary>
            /// <para>The custom header name. This parameter takes effect only when <b>XForwardedForClientCertSubjectDNEnabled</b> is set to <b>true</b>.</para>
            /// <para>The name must be 1 to 40 characters in length, and can contain lowercase letters, hyphens (-), underscores (_), and digits.</para>
            /// <remarks>
            /// <para>This parameter is supported only by HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_subject-dn-alias_123456</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertSubjectDNAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertSubjectDNAlias { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Clientcert-subjectdn</c> header to obtain the subject information of the client certificate that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b>: no.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported only by HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertSubjectDNEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertSubjectDNEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow ALB to obtain the real IP address of the client from the X-Forwarded-For header. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b>: no.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported by HTTP and HTTPS listeners.</para>
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
            /// <para>Load balancing traverses the <c>X-Forwarded-For</c> header from back to front and selects the first IP address that is not in the trusted IP address list as the real IP address of the client. This IP address is used for source IP address-based rate limiting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.1.1.0/24</para>
            /// </summary>
            [NameInMap("XForwardedForClientSourceIpsTrusted")]
            [Validation(Required=false)]
            public string XForwardedForClientSourceIpsTrusted { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Client-srcport</c> header to obtain the port of the client that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b>: no.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported by HTTP and HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForClientSrcPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientSrcPortEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-For</c> header to obtain the real IP address of the client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b> (default): yes.</description></item>
            /// <item><description><b>false</b>: no.</description></item>
            /// </list>
            /// <remarks>
            /// <ol>
            /// <item><description>If you set this parameter to <b>true</b>, the default value of <b>XForwardedForProcessingMode</b> is <b>append</b>, and you can change it to <b>remove</b>.</description></item>
            /// <item><description>If you set this parameter to <b>false</b>, the <c>X-Forwarded-For</c> header is retained without additional processing before the request is forwarded to backend servers.</description></item>
            /// <item><description>This parameter is supported by HTTP and HTTPS listeners.</description></item>
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
            /// <para>Specifies whether to use the <c>X-Forwarded-Host</c> header to obtain the domain name of the client that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b> (default): no.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported by HTTP, HTTPS, and QUIC listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForHostEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForHostEnabled { get; set; }

            /// <summary>
            /// <para>The processing mode of the <c>X-Forwarded-For</c> header. This parameter takes effect only when <b>XForwardedForEnabled</b> is set to <b>true</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>append</b> (default): appends the IP address.</description></item>
            /// <item><description><b>remove</b>: removes the header.</description></item>
            /// </list>
            /// <remarks>
            /// <ol>
            /// <item><description>If you set this parameter to <b>append</b>, the IP address of the last hop is added to the <c>X-Forwarded-For</c> header before the request is forwarded to backend servers.</description></item>
            /// <item><description>If you set this parameter to <b>remove</b>, the <c>X-Forwarded-For</c> header is removed before the request is forwarded to backend servers, regardless of whether the request contains the <c>X-Forwarded-For</c> header.</description></item>
            /// <item><description>This parameter is supported by HTTP and HTTPS listeners.</description></item>
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
            /// <para>Specifies whether to use the <c>X-Forwarded-Proto</c> header to obtain the listener protocol of the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b>: no.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported by HTTP, HTTPS, and QUIC listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForProtoEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForProtoEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>SLB-ID</c> header to obtain the instance ID of the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b>: no.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported by HTTP, HTTPS, and QUIC listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForSLBIdEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForSLBIdEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Port</c> header to obtain the listener port of the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b>: no.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported by HTTP, HTTPS, and QUIC listeners.</para>
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
