// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateListenerRequest : TeaModel {
        /// <summary>
        /// <para>The list of CA certificates configured for the listener. You can add only one CA certificate.</para>
        /// </summary>
        [NameInMap("CaCertificates")]
        [Validation(Required=false)]
        public List<CreateListenerRequestCaCertificates> CaCertificates { get; set; }
        public class CreateListenerRequestCaCertificates : TeaModel {
            /// <summary>
            /// <para>The ID of the CA certificate.</para>
            /// <remarks>
            /// <para>This parameter is required when the <b>CaEnabled</b> parameter is set to <b>true</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>123157*******</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable mutual authentication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes.</description></item>
        /// <item><description><b>false</b> (default): no.</description></item>
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
        public List<CreateListenerRequestCertificates> Certificates { get; set; }
        public class CreateListenerRequestCertificates : TeaModel {
            /// <summary>
            /// <para>The ID of the default certificate. You can add only one default server certificate.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is required when the <b>ListenerProtocol</b> parameter is set to <b>HTTPS</b> or <b>QUIC</b>.</description></item>
            /// <item><description>To add more server certificates, call the <a href="https://help.aliyun.com/document_detail/2254830.html">AssociateAdditionalCertificatesWithListener</a> operation to configure additional certificates after the listener is created.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>103705*******</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate the parameter value from your client to ensure that the value is unique across different requests. The ClientToken parameter supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of rule actions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DefaultActions")]
        [Validation(Required=false)]
        public List<CreateListenerRequestDefaultActions> DefaultActions { get; set; }
        public class CreateListenerRequestDefaultActions : TeaModel {
            /// <summary>
            /// <para>The configuration for the forward action. You can add up to 20 forward action configurations.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ForwardGroupConfig")]
            [Validation(Required=false)]
            public CreateListenerRequestDefaultActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class CreateListenerRequestDefaultActionsForwardGroupConfig : TeaModel {
                /// <summary>
                /// <para>The destination server group tuples for forwarding.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("ServerGroupTuples")]
                [Validation(Required=false)]
                public List<CreateListenerRequestDefaultActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                public class CreateListenerRequestDefaultActionsForwardGroupConfigServerGroupTuples : TeaModel {
                    /// <summary>
                    /// <para>The ID of the destination server group to which requests are forwarded.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sgp-8ilqs4axp6******</para>
                    /// </summary>
                    [NameInMap("ServerGroupId")]
                    [Validation(Required=false)]
                    public string ServerGroupId { get; set; }

                }

            }

            /// <summary>
            /// <para>The action type. You can add only one action type. Valid values: <b>ForwardGroup</b>: forwards requests to multiple server groups.</para>
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
        /// <item><description><para><b>true</b>: performs a dry run and does not create the listener. The system checks whether the required parameters are specified, the request format is valid, and the service limits are met. If the request fails the dry run, the system returns an error. If the request passes the dry run, the system returns the <c>DryRunOperation</c> error code.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): performs a dry run and sends the request. If the request passes the dry run, the system returns an HTTP 2xx status code and creates the listener.</para>
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
        /// <para>Specifies whether to enable <c>Gzip</c> compression to compress specific file types. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): yes.</description></item>
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
        /// <para>Specifies whether to enable <c>HTTP/2</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): yes.</description></item>
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
        /// <para>The idle connection timeout period. Unit: seconds.</para>
        /// <para>Valid values: <b>1</b> to <b>600</b>.</para>
        /// <para>Default value: <b>15</b>.</para>
        /// <para>If there is no access request within the timeout period, load balancing temporarily breaks the current connection and establishes a new connection when the next request arrives.</para>
        /// <remarks>
        /// <para>You can apply to increase the quota to extend the maximum idle connection timeout period to 3,600 seconds.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The custom name of the listener.</para>
        /// <para>The name must be 2 to 256 characters in length, and can contain letters, digits, Chinese characters, hyphens (-), forward slashes (/), periods (.), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP_80</para>
        /// </summary>
        [NameInMap("ListenerDescription")]
        [Validation(Required=false)]
        public string ListenerDescription { get; set; }

        /// <summary>
        /// <para>The frontend port used by the load balancing instance.</para>
        /// <para>Valid values: <b>1</b> to <b>65535</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The listener protocol.</para>
        /// <para>Valid values: <b>HTTP</b>, <b>HTTPS</b>, and <b>QUIC</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// <para>The instance ID of the application load balancing instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-n5qw04uq8vavfe****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The configuration of the associated QUIC listener.</para>
        /// </summary>
        [NameInMap("QuicConfig")]
        [Validation(Required=false)]
        public CreateListenerRequestQuicConfig QuicConfig { get; set; }
        public class CreateListenerRequestQuicConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the QUIC listener to be associated. This parameter is valid for HTTPS listeners and is required when <b>QuicUpgradeEnabled</b> is set to <b>true</b>.</para>
            /// <remarks>
            /// <para>The original listener and the associated QUIC listener must belong to the same ALB instance, and the QUIC listener must not have been associated before.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>lsn-o4u54y73wq7b******</para>
            /// </summary>
            [NameInMap("QuicListenerId")]
            [Validation(Required=false)]
            public string QuicListenerId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable QUIC upgrade. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b> (default): no.</description></item>
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
        /// <para>The request timeout period. Unit: seconds.</para>
        /// <para>Valid values: <b>1</b> to <b>600</b>.</para>
        /// <para>Default value: <b>60</b>.</para>
        /// <para>If there is no response from the backend server within the timeout period, load balancing stops waiting and returns an <c>HTTP 504</c> error code to the client.</para>
        /// <remarks>
        /// <para>You can apply to increase the quota to extend the maximum request timeout period to 3,600 seconds.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// <para>The ID of the security policy. System security policies and custom security policies are supported.</para>
        /// <para>Default value: <b>tls_cipher_policy_1_0</b> (system security policy).</para>
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
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateListenerRequestTag> Tag { get; set; }
        public class CreateListenerRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The key can be up to 128 characters in length. It cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The value can be up to 128 characters in length. It cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The X-Forwarded-For configuration.</para>
        /// </summary>
        [NameInMap("XForwardedForConfig")]
        [Validation(Required=false)]
        public CreateListenerRequestXForwardedForConfig XForwardedForConfig { get; set; }
        public class CreateListenerRequestXForwardedForConfig : TeaModel {
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
            /// <para>Specifies whether to use the <c>X-Forwarded-Clientcert-clientverify</c> header to obtain the verification result of the client certificate that is used to access the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b> (default): no.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported only by HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
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
            /// <para>Specifies whether to use the <c>X-Forwarded-Clientcert-fingerprint</c> header to obtain the fingerprint of the client certificate that is used to access the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b> (default): no.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported only by HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
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
            /// <para>Specifies whether to use the <c>X-Forwarded-Clientcert-issuerdn</c> header to obtain the issuer information of the client certificate that is used to access the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b> (default): no.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported only by HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
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
            /// <para>Specifies whether to use the <c>X-Forwarded-Clientcert-subjectdn</c> header to obtain the subject information of the client certificate that is used to access the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b> (default): no.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported only by HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertSubjectDNEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertSubjectDNEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow ALB to obtain the real IP address of the client from the X-Forwarded-For header. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b> (default): no.</description></item>
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
            /// <para>Application Load Balancing (ALB) traverses the <c>X-Forwarded-For</c> header from back to front and selects the first IP address that is not in the trusted IP address list as the real IP address of the client. This IP address is used for source IP address-based throttling.</para>
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
            /// <item><description><b>false</b> (default): no.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported by HTTP and HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
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
            /// <item><description>If you set this parameter to <b>true</b>, the default value of <b>XForwardedForProcessingMode</b> is <b>append</b>. You can change the value to <b>remove</b>.</description></item>
            /// <item><description>If you set this parameter to <b>false</b>, ALB retains the <c>X-Forwarded-For</c> header before forwarding the request to the backend server and does not perform additional processing.</description></item>
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
            /// <item><description>If you set this parameter to <b>append</b>, ALB adds the IP address of the last hop to the <c>X-Forwarded-For</c> header before forwarding the request to the backend server.</description></item>
            /// <item><description>If you set this parameter to <b>remove</b>, ALB removes the <c>X-Forwarded-For</c> header before forwarding the request to the backend server, regardless of whether the request contains the <c>X-Forwarded-For</c> header.</description></item>
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
            /// <item><description><b>false</b> (default): no.</description></item>
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
            /// <item><description><b>false</b> (default): no.</description></item>
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
            /// <item><description><b>false</b> (default): no.</description></item>
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
