// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class GetListenerAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ACL configuration structure.</para>
        /// </summary>
        [NameInMap("AclConfig")]
        [Validation(Required=false)]
        public GetListenerAttributeResponseBodyAclConfig AclConfig { get; set; }
        public class GetListenerAttributeResponseBodyAclConfig : TeaModel {
            /// <summary>
            /// <para>The IDs of the access control policies associated with the listener.</para>
            /// </summary>
            [NameInMap("AclRelations")]
            [Validation(Required=false)]
            public List<GetListenerAttributeResponseBodyAclConfigAclRelations> AclRelations { get; set; }
            public class GetListenerAttributeResponseBodyAclConfigAclRelations : TeaModel {
                /// <summary>
                /// <para>The ID of the access control policy associated with the listener.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acl-doc****</para>
                /// </summary>
                [NameInMap("AclId")]
                [Validation(Required=false)]
                public string AclId { get; set; }

                /// <summary>
                /// <para>The association status between the ACL and the listener. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Associating</b>: The ACL is being associated.</para>
                /// </description></item>
                /// <item><description><para><b>Associated</b>: The ACL is associated.</para>
                /// </description></item>
                /// <item><description><para><b>Dissociating</b>: The ACL is being dissociated.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Associating</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The access control type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>White</b>: Only requests from the IP addresses or CIDR blocks configured in the selected ACL are forwarded. A whitelist is applicable to scenarios where an application allows access only from specific IP addresses. Configuring a whitelist poses business risks. After a whitelist is configured, only requests from the IP addresses in the whitelist can access the load balancing listener. If you enable whitelist access but do not add any IP addresses to the ACL, the load balancing listener forwards all requests.</para>
            /// </description></item>
            /// <item><description><para><b>Black</b>: No requests from the IP addresses or CIDR blocks configured in the selected ACL are forwarded. A blacklist is applicable to scenarios where an application blocks access from specific IP addresses. If you enable blacklist access but do not add any IP addresses to the ACL, the load balancing listener forwards all requests.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>White</para>
            /// </summary>
            [NameInMap("AclType")]
            [Validation(Required=false)]
            public string AclType { get; set; }

        }

        /// <summary>
        /// <para>The list of CA certificates.</para>
        /// </summary>
        [NameInMap("CaCertificates")]
        [Validation(Required=false)]
        public List<GetListenerAttributeResponseBodyCaCertificates> CaCertificates { get; set; }
        public class GetListenerAttributeResponseBodyCaCertificates : TeaModel {
            /// <summary>
            /// <para>The ID of the CA certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139a00*****</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

            /// <summary>
            /// <para>Specifies whether the certificate is the default certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: No.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The status of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Associated</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether mutual authentication is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
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
        public List<GetListenerAttributeResponseBodyCertificates> Certificates { get; set; }
        public class GetListenerAttributeResponseBodyCertificates : TeaModel {
            /// <summary>
            /// <para>The ID of the certificate. Only server certificates are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123157*******</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

        }

        /// <summary>
        /// <para>The list of default rule actions.</para>
        /// </summary>
        [NameInMap("DefaultActions")]
        [Validation(Required=false)]
        public List<GetListenerAttributeResponseBodyDefaultActions> DefaultActions { get; set; }
        public class GetListenerAttributeResponseBodyDefaultActions : TeaModel {
            /// <summary>
            /// <para>The configuration of the forwarding action. This parameter takes effect only when the action type is <b>ForwardGroup</b>.</para>
            /// </summary>
            [NameInMap("ForwardGroupConfig")]
            [Validation(Required=false)]
            public GetListenerAttributeResponseBodyDefaultActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class GetListenerAttributeResponseBodyDefaultActionsForwardGroupConfig : TeaModel {
                /// <summary>
                /// <para>The destination server groups for forwarding.</para>
                /// </summary>
                [NameInMap("ServerGroupTuples")]
                [Validation(Required=false)]
                public List<GetListenerAttributeResponseBodyDefaultActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                public class GetListenerAttributeResponseBodyDefaultActionsForwardGroupConfigServerGroupTuples : TeaModel {
                    /// <summary>
                    /// <para>The ID of the destination server group.</para>
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
            /// <para>The action type. Valid value: <b>ForwardGroup</b>, which indicates that requests are forwarded to multiple server groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ForwardGroup</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether Gzip compression is enabled to compress specific file types. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("GzipEnabled")]
        [Validation(Required=false)]
        public bool? GzipEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether HTTP/2 is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
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
        /// <para>Specifies the idle connection timeout period. Unit: seconds.</para>
        /// <para>If no request is received within the timeout period, the load balancer temporarily closes the current connection and establishes a new connection when the next request arrives.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The custom name of the listener.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP_80</para>
        /// </summary>
        [NameInMap("ListenerDescription")]
        [Validation(Required=false)]
        public string ListenerDescription { get; set; }

        /// <summary>
        /// <para>The listener ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsn-o4u54y73wq7b******</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The frontend port used by the load balancer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The listener protocol. Valid values: <b>HTTP</b>, <b>HTTPS</b>, and <b>QUIC</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// <para>The current status of the listener. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Provisioning</b>: The listener is being created.</para>
        /// </description></item>
        /// <item><description><para><b>Running</b>: The listener is running.</para>
        /// </description></item>
        /// <item><description><para><b>Configuring</b>: The listener is being configured.</para>
        /// </description></item>
        /// <item><description><para><b>Stopped</b>: The listener is stopped.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("ListenerStatus")]
        [Validation(Required=false)]
        public string ListenerStatus { get; set; }

        /// <summary>
        /// <para>The ID of the ALB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-bd6oylbckp6k9x****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The log configuration information.</para>
        /// </summary>
        [NameInMap("LogConfig")]
        [Validation(Required=false)]
        public GetListenerAttributeResponseBodyLogConfig LogConfig { get; set; }
        public class GetListenerAttributeResponseBodyLogConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether custom header fields are included in access logs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AccessLogRecordCustomizedHeadersEnabled")]
            [Validation(Required=false)]
            public bool? AccessLogRecordCustomizedHeadersEnabled { get; set; }

            /// <summary>
            /// <para>The Xtrace configuration information for access logs.</para>
            /// </summary>
            [NameInMap("AccessLogTracingConfig")]
            [Validation(Required=false)]
            public GetListenerAttributeResponseBodyLogConfigAccessLogTracingConfig AccessLogTracingConfig { get; set; }
            public class GetListenerAttributeResponseBodyLogConfigAccessLogTracingConfig : TeaModel {
                /// <summary>
                /// <para>The status of the Xtrace feature. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Yes.</description></item>
                /// <item><description><b>false</b>: No.</description></item>
                /// </list>
                /// <remarks>
                /// <para>You can set this parameter to <b>true</b> only when the access log feature (AccessLogEnabled) is enabled for the instance.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("TracingEnabled")]
                [Validation(Required=false)]
                public bool? TracingEnabled { get; set; }

                /// <summary>
                /// <para>The sampling rate for Xtrace. Valid values: 1 to 10000.</para>
                /// <remarks>
                /// <para>This parameter takes effect only when <b>TracingEnabled</b> is set to <b>true</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TracingSample")]
                [Validation(Required=false)]
                public int? TracingSample { get; set; }

                /// <summary>
                /// <para>The Xtrace type. Valid value: <b>Zipkin</b>.</para>
                /// <remarks>
                /// <para>This parameter takes effect only when <b>TracingEnabled</b> is set to <b>true</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Zipkin</para>
                /// </summary>
                [NameInMap("TracingType")]
                [Validation(Required=false)]
                public string TracingType { get; set; }

            }

        }

        /// <summary>
        /// <para>The configuration information for associating a QUIC listener.</para>
        /// </summary>
        [NameInMap("QuicConfig")]
        [Validation(Required=false)]
        public GetListenerAttributeResponseBodyQuicConfig QuicConfig { get; set; }
        public class GetListenerAttributeResponseBodyQuicConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the QUIC listener to be associated. This parameter is required when <b>QuicUpgradeEnabled</b> is set to <b>true</b>. This parameter takes effect only for HTTPS listeners.</para>
            /// <remarks>
            /// <para>The original listener and the associated QUIC listener must belong to the same ALB instance, and the QUIC listener must not have been associated before.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>lsn-ek6ad66t****</para>
            /// </summary>
            [NameInMap("QuicListenerId")]
            [Validation(Required=false)]
            public string QuicListenerId { get; set; }

            /// <summary>
            /// <para>Specifies whether QUIC upgrade is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter takes effect only for HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("QuicUpgradeEnabled")]
            [Validation(Required=false)]
            public bool? QuicUpgradeEnabled { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365F4154-92F6-4AE4-92F8-7FF******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Specifies the request timeout period. Unit: seconds.</para>
        /// <para>If a backend server does not send a response within the timeout period, the load balancer stops waiting and returns an <c>HTTP 504</c> error code to the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34</para>
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// <para>The security policy.</para>
        /// <remarks>
        /// <para>This parameter is supported only by HTTPS listeners.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tls_cipher_policy_1_1</para>
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetListenerAttributeResponseBodyTags> Tags { get; set; }
        public class GetListenerAttributeResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key. It can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. It can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The X-Forwarded-For field configuration.</para>
        /// </summary>
        [NameInMap("XForwardedForConfig")]
        [Validation(Required=false)]
        public GetListenerAttributeResponseBodyXForwardedForConfig XForwardedForConfig { get; set; }
        public class GetListenerAttributeResponseBodyXForwardedForConfig : TeaModel {
            /// <summary>
            /// <para>The custom header name. This parameter takes effect only when <b>XForwardedForClientCertClientVerifyEnabled</b> is set to <b>true</b>. The name must be 1 to 40 characters in length and can contain lowercase letters, hyphens (-), underscores (_), and digits.</para>
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
            /// <para>Specifies whether to use the <c>X-Forwarded-Clientcert-clientverify</c> header field to retrieve the verification result of the client certificate that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
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
            /// <para>The custom header name. This parameter takes effect only when <b>XForwardedForClientCertFingerprintEnabled</b> is set to <b>true</b>. The name must be 1 to 40 characters in length and can contain lowercase letters, hyphens (-), underscores (_), and digits.</para>
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
            /// <para>Specifies whether to use the <c>X-Forwarded-Clientcert-fingerprint</c> header field to retrieve the fingerprint of the client certificate that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
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
            /// <para>The custom header name. This parameter takes effect only when <b>XForwardedForClientCertIssuerDNEnabled</b> is set to <b>true</b>. The name must be 1 to 40 characters in length and can contain lowercase letters, hyphens (-), underscores (_), and digits.</para>
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
            /// <para>Specifies whether to use the <c>X-Forwarded-Clientcert-issuerdn</c> header field to retrieve the issuer information of the client certificate that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
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
            /// <para>The custom header name. This parameter takes effect only when <b>XForwardedForClientCertSubjectDNEnabled</b> is set to <b>true</b>. The name must be 1 to 40 characters in length and can contain lowercase letters, hyphens (-), underscores (_), and digits.</para>
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
            /// <para>Specifies whether to use the <c>X-Forwarded-Clientcert-subjectdn</c> header field to retrieve the subject information of the client certificate that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
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
            /// <para>Specifies whether to allow Application Load Balancer (ALB) to retrieve the actual client IP address from the <c>X-Forwarded-For</c> header field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
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
            /// <para>Application Load Balancing (ALB) traverses the <c>X-Forwarded-For</c> header field from back to front and selects the first IP address that is not in the trusted IP address list as the actual client IP address. This IP address is used for source IP address-based rate limiting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.1.1.0/24</para>
            /// </summary>
            [NameInMap("XForwardedForClientSourceIpsTrusted")]
            [Validation(Required=false)]
            public string XForwardedForClientSourceIpsTrusted { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Client-Port</c> header field to retrieve the port of the client that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
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
            /// <para>Specifies whether to use the <c>X-Forwarded-For</c> header field to retrieve the actual IP address of the client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b> (default): Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// <remarks>
            /// <ol>
            /// <item><description>If you set this parameter to <b>true</b>, the default value of <b>XForwardedForProcessingMode</b> is <b>append</b>, and you can change it to <b>remove</b>.</description></item>
            /// <item><description>If you set this parameter to <b>false</b>, the <c>X-Forwarded-For</c> header field is retained without additional processing before the request is forwarded to the backend server.</description></item>
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
            /// <para>Specifies whether to use the <c>X-Forwarded-Host</c> header field to retrieve the domain name of the client that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b> (default): No.</description></item>
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
            /// <para>The processing mode for the <c>X-Forwarded-For</c> header field. This parameter takes effect only when <b>XForwardedForEnabled</b> is set to <b>true</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>append</b> (default): Appends the IP address of the last hop to the <c>X-Forwarded-For</c> header field before the request is forwarded to the backend server.</description></item>
            /// <item><description><b>remove</b>: Deletes the <c>X-Forwarded-For</c> header field before the request is forwarded to the backend server, regardless of whether the request contains the <c>X-Forwarded-For</c> header field.</description></item>
            /// </list>
            /// <remarks>
            /// <ol>
            /// <item><description>If you set this parameter to <b>append</b>, the IP address of the last hop is added to the <c>X-Forwarded-For</c> header field before the request is forwarded to the backend server.</description></item>
            /// <item><description>If you set this parameter to <b>remove</b>, the <c>X-Forwarded-For</c> header field is deleted before the request is forwarded to the backend server, regardless of whether the request contains the <c>X-Forwarded-For</c> header field.</description></item>
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
            /// <para>Specifies whether to use the <c>X-Forwarded-Proto</c> header field to retrieve the listener protocol of the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported by HTTP, HTTPS, and QUIC listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XForwardedForProtoEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForProtoEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>SLB-ID</c> header field to retrieve the load balancing instance ID. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported by HTTP, HTTPS, and QUIC listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XForwardedForSLBIdEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForSLBIdEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Port</c> header field to retrieve the listener port of the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported by HTTP, HTTPS, and QUIC listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XForwardedForSLBPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForSLBPortEnabled { get; set; }

        }

    }

}
