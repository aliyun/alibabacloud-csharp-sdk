// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class GetListenerAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ACL configuration.</para>
        /// </summary>
        [NameInMap("AclConfig")]
        [Validation(Required=false)]
        public GetListenerAttributeResponseBodyAclConfig AclConfig { get; set; }
        public class GetListenerAttributeResponseBodyAclConfig : TeaModel {
            /// <summary>
            /// <para>The list of access control group IDs associated with the listener.</para>
            /// </summary>
            [NameInMap("AclRelations")]
            [Validation(Required=false)]
            public List<GetListenerAttributeResponseBodyAclConfigAclRelations> AclRelations { get; set; }
            public class GetListenerAttributeResponseBodyAclConfigAclRelations : TeaModel {
                /// <summary>
                /// <para>The ID of the access control group associated with the listener.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acl-doc****</para>
                /// </summary>
                [NameInMap("AclId")]
                [Validation(Required=false)]
                public string AclId { get; set; }

                /// <summary>
                /// <para>The status of the ACL-listener association. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Associating</b>: The ACL is being associated.</para>
                /// </description></item>
                /// <item><description><para><b>Associated</b>: The ACL is associated.</para>
                /// </description></item>
                /// <item><description><para><b>Dissociating</b>: The ACL is being disassociated.</para>
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
            /// <para>The type of access control. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>White</b>: Only requests from the IP addresses or CIDR blocks settings in the selected access control policy group are forwarded. Whitelists are applicable to scenarios in which you want to allow only specific IP addresses to access your application. Enabling a whitelist poses some risks. After a whitelist is enabled, only the IP addresses in the whitelist can access the load balancing listener.</para>
            /// <para> If a whitelist is enabled but no IP address is added to the access control policy group, the load balancing listener forwards all requests.</para>
            /// </description></item>
            /// <item><description><para><b>Black</b>: All requests from the IP addresses or CIDR blocks settings in the selected access control policy group are blocked. Blacklists are applicable to scenarios in which you want to block access from specific IP addresses.</para>
            /// <para>If a blacklist is enabled but no IP address is added to the access control policy group, the load balancing listener forwards all requests.</para>
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
            /// <para>The CA certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139a00*****</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

            /// <summary>
            /// <para>Indicates whether the certificate is the default certificate. Valid values:</para>
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
            /// <para>The certificate status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Associated</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether mutual authentication is enabled. Valid values:</para>
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
            /// <para>The certificate ID. Only server certificates are supported.</para>
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
            /// <para>The configuration of the forwarding action. This parameter is valid when the type is <b>ForwardGroup</b>.</para>
            /// </summary>
            [NameInMap("ForwardGroupConfig")]
            [Validation(Required=false)]
            public GetListenerAttributeResponseBodyDefaultActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class GetListenerAttributeResponseBodyDefaultActionsForwardGroupConfig : TeaModel {
                /// <summary>
                /// <para>The destination server groups to which requests are forwarded.</para>
                /// </summary>
                [NameInMap("ServerGroupTuples")]
                [Validation(Required=false)]
                public List<GetListenerAttributeResponseBodyDefaultActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                public class GetListenerAttributeResponseBodyDefaultActionsForwardGroupConfigServerGroupTuples : TeaModel {
                    /// <summary>
                    /// <para>The ID of the destination server group to which requests are forwarded.</para>
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
            /// <para>The action type.</para>
            /// <para>Valid values: <b>ForwardGroup</b>, which indicates that requests are forwarded to multiple server groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ForwardGroup</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether Gzip compression is enabled to compress specific types of files. Valid values:</para>
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
        /// <para>Indicates whether HTTP/2 is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
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
        /// <para>The idle connection timeout period. Unit: seconds.</para>
        /// <para>If no access request is received within the timeout period, the load balancing instance temporarily breaks the current connection and restores the connection when the next request arrives.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The custom listener name.</para>
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
        /// <para>The frontend port used by the load balancing instance.</para>
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
        /// <para>The status of the listener. Valid values:</para>
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
        /// <para>The load balancing instance ID.</para>
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
            /// <para>Indicates whether access logs contain custom header fields. Valid values:</para>
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
                /// <para>The Xtrace feature status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Yes.</description></item>
                /// <item><description><b>false</b>: No.</description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter can be set to <b>true</b> only when the instance access log switch (AccessLogEnabled) is turned on.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("TracingEnabled")]
                [Validation(Required=false)]
                public bool? TracingEnabled { get; set; }

                /// <summary>
                /// <para>The sampling rate of Xtrace. Valid values: 1 to 10000.</para>
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
                /// <para>The type of Xtrace. Valid values: <b>Zipkin</b>.</para>
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
        /// <para>The configuration information when the associated QUIC listener is enabled.</para>
        /// </summary>
        [NameInMap("QuicConfig")]
        [Validation(Required=false)]
        public GetListenerAttributeResponseBodyQuicConfig QuicConfig { get; set; }
        public class GetListenerAttributeResponseBodyQuicConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the QUIC listener to be associated. This parameter is required when <b>QuicUpgradeEnabled</b> is set to <b>true</b>. This parameter is valid only for HTTPS listeners.</para>
            /// <remarks>
            /// <para>The original listener and the associated QUIC listener must belong to the same ALB instance, and the QUIC listener must not have been previously associated.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>lsn-ek6ad66t****</para>
            /// </summary>
            [NameInMap("QuicListenerId")]
            [Validation(Required=false)]
            public string QuicListenerId { get; set; }

            /// <summary>
            /// <para>Indicates whether QUIC upgrade is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is valid only for HTTPS listeners.</para>
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
        /// <para>The request timeout period. Unit: seconds.</para>
        /// <para>If the backend server does not provide a response within the timeout period, the load balancing instance stops waiting and returns an <c>HTTP 504</c> error code to the client.</para>
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
        /// <para>Only HTTPS listeners support this parameter.</para>
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
            /// <para>The tag key. The tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The XForward field configuration.</para>
        /// </summary>
        [NameInMap("XForwardedForConfig")]
        [Validation(Required=false)]
        public GetListenerAttributeResponseBodyXForwardedForConfig XForwardedForConfig { get; set; }
        public class GetListenerAttributeResponseBodyXForwardedForConfig : TeaModel {
            /// <summary>
            /// <para>The custom header name. This value takes effect only when <b>XForwardedForClientCertClientVerifyEnabled</b> is set to <b>true</b>.</para>
            /// <para>The value must be 1 to 40 characters in length and can contain lowercase letters a to z, hyphens (-), underscores (_), and digits.</para>
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
            /// <para>Indicates whether the <c>X-Forwarded-Clientcert-clientverify</c> header field is used to obtain the verification result of the client certificate that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertClientVerifyEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertClientVerifyEnabled { get; set; }

            /// <summary>
            /// <para>The custom header name. This value takes effect only when <b>XForwardedForClientCertFingerprintEnabled</b> is set to <b>true</b>.</para>
            /// <para>The value must be 1 to 40 characters in length and can contain lowercase letters a to z, hyphens (-), underscores (_), and digits.</para>
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
            /// <para>Indicates whether the <c>X-Forwarded-Clientcert-fingerprint</c> header field is used to obtain the fingerprint of the client certificate that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertFingerprintEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertFingerprintEnabled { get; set; }

            /// <summary>
            /// <para>The custom header name. This value takes effect only when <b>XForwardedForClientCertIssuerDNEnabled</b> is set to <b>true</b>.</para>
            /// <para>The value must be 1 to 40 characters in length and can contain lowercase letters a to z, hyphens (-), underscores (_), and digits.</para>
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
            /// <para>Indicates whether the <c>X-Forwarded-Clientcert-issuerdn</c> header field is used to obtain the issuer information of the client certificate that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertIssuerDNEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertIssuerDNEnabled { get; set; }

            /// <summary>
            /// <para>The custom header name. This value takes effect only when <b>XForwardedForClientCertSubjectDNEnabled</b> is set to <b>true</b>.</para>
            /// <para>The value must be 1 to 40 characters in length and can contain lowercase letters a to z, hyphens (-), underscores (_), and digits.</para>
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
            /// <para>Indicates whether the <c>X-Forwarded-Clientcert-subjectdn</c> header field is used to obtain the owner information of the client certificate that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertSubjectDNEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertSubjectDNEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether ALB is allowed to look up the originating client IP address from the X-Forwarded-For header field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
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
            /// <para>Application Load Balancer (ALB) traverses the <c>X-Forwarded-For</c> header from right to left and selects the first IP address that is not in the trusted IP list as the originating client IP address. This IP address is used for source IP-based rate limiting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.1.1.0/24</para>
            /// </summary>
            [NameInMap("XForwardedForClientSourceIpsTrusted")]
            [Validation(Required=false)]
            public string XForwardedForClientSourceIpsTrusted { get; set; }

            /// <summary>
            /// <para>Indicates whether the <c>X-Forwarded-Client-Port</c> header field is used to obtain the port of the client that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// <remarks>
            /// <para>HTTP and HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XForwardedForClientSrcPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientSrcPortEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether the <c>X-Forwarded-For</c> header field is used to obtain the originating IP address of the client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b> (default): Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// <remarks>
            /// <ol>
            /// <item><description>If set to <b>true</b>, <b>XForwardedForProcessingMode</b> defaults to <b>append</b> and can be changed to <b>remove</b>.</description></item>
            /// <item><description>If set to <b>false</b>, the <c>X-Forwarded-For</c> header field is preserved without additional processing before the request is sent to the backend server.</description></item>
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
            /// <para>Indicates whether the <c>X-Forwarded-Host</c> header field is used to obtain the domain name of the client that accesses the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b> (default): No.</description></item>
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
            /// <para>The mode for processing the <c>X-Forwarded-For</c> header field. This value takes effect only when <b>XForwardedForEnabled</b> is set to <b>true</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>append</b> (default): Append.</description></item>
            /// <item><description><b>remove</b>: Remove.</description></item>
            /// </list>
            /// <remarks>
            /// <ol>
            /// <item><description>If set to <b>append</b>, the last-hop IP address is appended to the <c>X-Forwarded-For</c> header field before the request is sent to the backend server.</description></item>
            /// <item><description>If set to <b>remove</b>, the <c>X-Forwarded-For</c> header is removed before the request is sent to the backend server, regardless of whether the request contains the <c>X-Forwarded-For</c> header field.</description></item>
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
            /// <para>Indicates whether the <c>X-Forwarded-Proto</c> header field is used to obtain the listener protocol of the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// <remarks>
            /// <para>HTTP, HTTPS, and QUIC listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XForwardedForProtoEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForProtoEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether the <c>SLB-ID</c> header field is used to obtain the load balancing instance ID. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// <remarks>
            /// <para>HTTP, HTTPS, and QUIC listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XForwardedForSLBIdEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForSLBIdEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether the <c>X-Forwarded-Port</c> header field is used to obtain the listener port of the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// <remarks>
            /// <para>HTTP, HTTPS, and QUIC listeners support this parameter.</para>
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
