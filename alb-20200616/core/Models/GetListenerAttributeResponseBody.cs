// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class GetListenerAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations of the access control lists (ACLs).</para>
        /// </summary>
        [NameInMap("AclConfig")]
        [Validation(Required=false)]
        public GetListenerAttributeResponseBodyAclConfig AclConfig { get; set; }
        public class GetListenerAttributeResponseBodyAclConfig : TeaModel {
            /// <summary>
            /// <para>The IDs of the ACLs that are associated with the listener.</para>
            /// </summary>
            [NameInMap("AclRelations")]
            [Validation(Required=false)]
            public List<GetListenerAttributeResponseBodyAclConfigAclRelations> AclRelations { get; set; }
            public class GetListenerAttributeResponseBodyAclConfigAclRelations : TeaModel {
                /// <summary>
                /// <para>The ID of the ACL that is associated with the listener.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acl-doc****</para>
                /// </summary>
                [NameInMap("AclId")]
                [Validation(Required=false)]
                public string AclId { get; set; }

                /// <summary>
                /// <para>Indicates whether the ACL is associated with the listener. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Associating</b></description></item>
                /// <item><description><b>Associated</b></description></item>
                /// <item><description><b>Dissociating</b></description></item>
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
            /// <para>The type of the ACL. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>White</b>: a whitelist. Only requests from the IP addresses or CIDR blocks in the network ACL are forwarded. Whitelists are applicable to scenarios in which you want to allow only specific IP addresses to access an application. Your service may be adversely affected if the whitelist is not properly configured. If a whitelist is configured for a listener, only requests from IP addresses that are on the whitelist are forwarded by the listener.</para>
            /// <para>If you enable a whitelist but do not add an IP address to the whitelist, the listener forwards all requests.</para>
            /// </description></item>
            /// <item><description><para><b>Black</b>: a blacklist. Requests from the IP addresses or CIDR blocks in the network ACL are denied. Blacklists are suitable for scenarios in which you want to deny access from specific IP addresses or CIDR blocks to an application.</para>
            /// <para>If a blacklist is configured for a listener but no IP addresses are added to the blacklist, the listener forwards all requests.</para>
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
        /// <para>A list of default CA certificates.</para>
        /// </summary>
        [NameInMap("CaCertificates")]
        [Validation(Required=false)]
        public List<GetListenerAttributeResponseBodyCaCertificates> CaCertificates { get; set; }
        public class GetListenerAttributeResponseBodyCaCertificates : TeaModel {
            /// <summary>
            /// <para>The ID of the default CA certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139a00604bd-cn-east-hangzho****</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

            /// <summary>
            /// <para>Indicates whether the certificate is a default certificate: Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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
        /// <para>Indicates whether mutual authentication is enabled. Valid values:</para>
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
        /// <para>A list of certificates.</para>
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<GetListenerAttributeResponseBodyCertificates> Certificates { get; set; }
        public class GetListenerAttributeResponseBodyCertificates : TeaModel {
            /// <summary>
            /// <para>The ID of the certificate. Only server certificates are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12315790212_166f8204689_1714763408_70998****</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

        }

        /// <summary>
        /// <para>The actions of the default forwarding rule.</para>
        /// </summary>
        [NameInMap("DefaultActions")]
        [Validation(Required=false)]
        public List<GetListenerAttributeResponseBodyDefaultActions> DefaultActions { get; set; }
        public class GetListenerAttributeResponseBodyDefaultActions : TeaModel {
            /// <summary>
            /// <para>The configuration of the ForwardGroup action. This parameter is returned and takes effect when Type is set to <b>ForwardGroup</b>.</para>
            /// </summary>
            [NameInMap("ForwardGroupConfig")]
            [Validation(Required=false)]
            public GetListenerAttributeResponseBodyDefaultActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class GetListenerAttributeResponseBodyDefaultActionsForwardGroupConfig : TeaModel {
                /// <summary>
                /// <para>The server group to which requests are forwarded.</para>
                /// </summary>
                [NameInMap("ServerGroupTuples")]
                [Validation(Required=false)]
                public List<GetListenerAttributeResponseBodyDefaultActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                public class GetListenerAttributeResponseBodyDefaultActionsForwardGroupConfigServerGroupTuples : TeaModel {
                    /// <summary>
                    /// <para>The ID of the server group to which requests are forwarded.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rsp-cige6j****</para>
                    /// </summary>
                    [NameInMap("ServerGroupId")]
                    [Validation(Required=false)]
                    public string ServerGroupId { get; set; }

                }

            }

            /// <summary>
            /// <para>The type of the action.</para>
            /// <para>If <b>ForwardGroup</b> is returned, requests are forwarded to multiple vServer groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ForwardGroup</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether GZIP compression is enabled to compress specific types of files. Valid values:</para>
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
        /// <para>Indicates whether HTTP/2 is enabled. Valid values:</para>
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
        /// <para>The timeout period of an idle connection. Unit: seconds.</para>
        /// <para>If no requests are received within the specified timeout period, Application Load Balancer (ALB) closes the current connection. When a request is received, ALB establishes a new connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The name of the listener.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ListenerDescription")]
        [Validation(Required=false)]
        public string ListenerDescription { get; set; }

        /// <summary>
        /// <para>The ID of the listener.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsr-bp1bpn0kn908w4nbw****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The frontend port that is used by the ALB instance.</para>
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
        /// <item><description><b>Provisioning</b></description></item>
        /// <item><description><b>Running</b></description></item>
        /// <item><description><b>Configuring</b></description></item>
        /// <item><description><b>Stopped</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("ListenerStatus")]
        [Validation(Required=false)]
        public string ListenerStatus { get; set; }

        /// <summary>
        /// <para>The ALB instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1o94dp5i6ea****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The logging configuration.</para>
        /// </summary>
        [NameInMap("LogConfig")]
        [Validation(Required=false)]
        public GetListenerAttributeResponseBodyLogConfig LogConfig { get; set; }
        public class GetListenerAttributeResponseBodyLogConfig : TeaModel {
            /// <summary>
            /// <para>Indicates whether custom headers are recorded in the access log. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AccessLogRecordCustomizedHeadersEnabled")]
            [Validation(Required=false)]
            public bool? AccessLogRecordCustomizedHeadersEnabled { get; set; }

            /// <summary>
            /// <para>The configuration of Xtrace. Xtrace is used to record requests sent to ALB.</para>
            /// </summary>
            [NameInMap("AccessLogTracingConfig")]
            [Validation(Required=false)]
            public GetListenerAttributeResponseBodyLogConfigAccessLogTracingConfig AccessLogTracingConfig { get; set; }
            public class GetListenerAttributeResponseBodyLogConfigAccessLogTracingConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether Xtrace is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para>You can set this parameter to <b>true</b> only if the AccessLogEnabled parameter is set to true.</para>
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
                /// <para>If <b>TracingEnabled</b> is set to <b>true</b>, this parameter is valid.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TracingSample")]
                [Validation(Required=false)]
                public int? TracingSample { get; set; }

                /// <summary>
                /// <para>The Xtrace type. Supported Xtrace type: <b>Zipkin</b>.</para>
                /// <remarks>
                /// <para>If <b>TracingEnabled</b> is set to <b>true</b>, this parameter is valid.</para>
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
        /// <para>The configuration information when the listener is associated with a QUIC listener.</para>
        /// </summary>
        [NameInMap("QuicConfig")]
        [Validation(Required=false)]
        public GetListenerAttributeResponseBodyQuicConfig QuicConfig { get; set; }
        public class GetListenerAttributeResponseBodyQuicConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the QUIC listener. This parameter is returned when <b>QuicUpgradeEnabled</b> is set to <b>true</b>. Only HTTPS listeners support this parameter.</para>
            /// <remarks>
            /// <para>You must associate the HTTPS listener and the QUIC listener with the same ALB instance. In addition, make sure that the QUIC listener has never been associated with another listener.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>lsn-333</para>
            /// </summary>
            [NameInMap("QuicListenerId")]
            [Validation(Required=false)]
            public string QuicListenerId { get; set; }

            /// <summary>
            /// <para>Indicates whether QUIC upgrade is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>Only HTTPS listeners support this parameter.</para>
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
        /// <para>365F4154-92F6-4AE4-92F8-7FF34B540710</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The timeout period of a request. Unit: seconds.</para>
        /// <para>If no responses are received from the backend server within the specified timeout period, ALB returns an <c>HTTP 504</c> error code to the client.</para>
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
        /// <para>This parameter is available only when you create an HTTPS listener.</para>
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
            /// <para>The tag key. The tag key can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The configuration of the XForward headers.</para>
        /// </summary>
        [NameInMap("XForwardedForConfig")]
        [Validation(Required=false)]
        public GetListenerAttributeResponseBodyXForwardedForConfig XForwardedForConfig { get; set; }
        public class GetListenerAttributeResponseBodyXForwardedForConfig : TeaModel {
            /// <summary>
            /// <para>The name of the custom header. This parameter takes effect only when <b>XForwardedForClientCertClientVerifyEnabled</b> is set to <b>true</b>.</para>
            /// <para>The name is 1 to 40 characters in length, and can contain lowercase letters, hyphens (-), underscores (_), and digits.</para>
            /// <remarks>
            /// <para>This parameter is available only when you create an HTTPS listener.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_client-verify-alias_123456</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertClientVerifyAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertClientVerifyAlias { get; set; }

            /// <summary>
            /// <para>Indicates whether the <c>X-Forwarded-Clientcert-clientverify</c> header is used to retrieve the verification result of the client certificate. Valid values:</para>
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
            [NameInMap("XForwardedForClientCertClientVerifyEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertClientVerifyEnabled { get; set; }

            /// <summary>
            /// <para>The name of the custom header. This parameter takes effect only when <b>XForwardedForClientCertFingerprintEnabled</b> is set to <b>true</b>.</para>
            /// <para>The name is 1 to 40 characters in length, and can contain lowercase letters, hyphens (-), underscores (_), and digits.</para>
            /// <remarks>
            /// <para>This parameter is available only when you create an HTTPS listener.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_finger-print-alias_123456</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertFingerprintAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertFingerprintAlias { get; set; }

            /// <summary>
            /// <para>Indicates whether the <c>X-Forwarded-Clientcert-fingerprint</c> header is used to retrieve the fingerprint of the client certificate. Valid values:</para>
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
            [NameInMap("XForwardedForClientCertFingerprintEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertFingerprintEnabled { get; set; }

            /// <summary>
            /// <para>The name of the custom header. This parameter takes effect only when <b>XForwardedForClientCertIssuerDNEnabled</b> is set to <b>true</b>.</para>
            /// <para>The name is 1 to 40 characters in length, and can contain lowercase letters, hyphens (-), underscores (_), and digits.</para>
            /// <remarks>
            /// <para>This parameter is available only when you create an HTTPS listener.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_issue-dn-alias_123456</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertIssuerDNAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertIssuerDNAlias { get; set; }

            /// <summary>
            /// <para>Indicates whether the <c>X-Forwarded-Clientcert-issuerdn</c> header is used to retrieve information about the authority that issues the client certificate. Valid values:</para>
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
            [NameInMap("XForwardedForClientCertIssuerDNEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertIssuerDNEnabled { get; set; }

            /// <summary>
            /// <para>The name of the custom header. This parameter takes effect only when <b>XForwardedForClientCertSubjectDNEnabled</b> is set to <b>true</b>.</para>
            /// <para>The name is 1 to 40 characters in length, and can contain lowercase letters, hyphens (-), underscores (_), and digits.</para>
            /// <remarks>
            /// <para>This parameter is available only when you create an HTTPS listener.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_subject-dn-alias_123456</para>
            /// </summary>
            [NameInMap("XForwardedForClientCertSubjectDNAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertSubjectDNAlias { get; set; }

            /// <summary>
            /// <para>Indicates whether the <c>X-Forwarded-Clientcert-subjectdn</c> header is used to retrieve information about the owner of the client certificate. Valid values:</para>
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
            [NameInMap("XForwardedForClientCertSubjectDNEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertSubjectDNEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether the <c>X-Forwarded-Client-Ip</c> header is used to retrieve the source port of the ALB instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only when you create an HTTP, HTTPS, or QUIC listener.</para>
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
            /// <para>ALB traverses <c>X-Forwarded-For</c> backward and selects the first IP address that is not on the trusted IP address list as the real IP address of the client. The IP address is used in source IP address throttling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.1.1.0/24</para>
            /// </summary>
            [NameInMap("XForwardedForClientSourceIpsTrusted")]
            [Validation(Required=false)]
            public string XForwardedForClientSourceIpsTrusted { get; set; }

            /// <summary>
            /// <para>Indicates whether the <c>X-Forwarded-Client-Port</c> header is used to retrieve the client port. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only when you create an HTTP or HTTPS listener.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XForwardedForClientSrcPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientSrcPortEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether the <c>X-Forwarded-For</c> header is used to retrieve the client IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only when you create an HTTP or HTTPS listener.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XForwardedForEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether the <c>X-Forwarded-Proto</c> header is used to retrieve the listening protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only when you create an HTTP, HTTPS, or QUIC listener.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XForwardedForProtoEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForProtoEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether the <c>SLB-ID</c> header is used to retrieve the ID of the CLB instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only when you create an HTTP, HTTPS, or QUIC listener.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XForwardedForSLBIdEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForSLBIdEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether the <c>X-Forwarded-Port</c> header is used to retrieve the listening port of the ALB instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only when you create an HTTP, HTTPS, or QUIC listener.</para>
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
