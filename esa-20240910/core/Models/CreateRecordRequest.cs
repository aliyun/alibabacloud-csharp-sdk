// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateRecordRequest : TeaModel {
        /// <summary>
        /// <para>The origin server authentication information for a CNAME record.</para>
        /// </summary>
        [NameInMap("AuthConf")]
        [Validation(Required=false)]
        public CreateRecordRequestAuthConf AuthConf { get; set; }
        public class CreateRecordRequestAuthConf : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID of the account to which the origin server belongs. This parameter is required when the origin server type is OSS and the authentication type is private read across accounts, or when the origin server type is S3 and the authentication type is private read.</para>
            /// 
            /// <b>Example:</b>
            /// <para>u0Nkg5gBK*******QF5wvKMM504JUHt</para>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>The origin server authentication type. Different origin server types support different authentication types. The origin server type is specified by the SourceType parameter. This parameter is required when the origin server type is OSS or S3. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>public</b>: Public read. Select this value when the origin server type is OSS or S3 and the origin server allows public read access.</description></item>
            /// <item><description><b>private</b>: Private read. Select this value when the origin server type is S3 and the origin server allows private read access.</description></item>
            /// <item><description><b>private_same_account</b>: Private read within the same account. Select this value when the origin server type is OSS, the origin server belongs to the same Alibaba Cloud account, and the origin server allows private read access.</description></item>
            /// <item><description><b>private_cross_account</b>: Private read across accounts. Select this value when the origin server type is OSS, the origin server belongs to a different Alibaba Cloud account, and the origin server allows private read access.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>The region to which the origin server belongs. This parameter is required when the origin server type is S3. You can obtain the region information from the official website of S3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>us-east-1</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The AccessKey secret of the account to which the origin server belongs. This parameter is required when the origin server type is OSS and the authentication type is private read across accounts, or when the origin server type is S3 and the authentication type is private read.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VIxuvJSA2S03f******kp208dy5w7</para>
            /// </summary>
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            /// <summary>
            /// <para>The signature algorithm version. This parameter is required when the origin server type is S3 and the authentication type is private read. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>v2</b></description></item>
            /// <item><description><b>v4</b></description></item>
            /// </list>
            /// <para>If this parameter is not specified, the default value is v4.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v4</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The business scenario used to tag the DNS record. This parameter is required when proxy acceleration is enabled for the DNS record. That is, the Proxied parameter is set to true. This parameter is not required when proxy acceleration is disabled. That is, the Proxied parameter is set to false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>image_video</b>: Images and videos.</description></item>
        /// <item><description><b>api</b>: API operations.</description></item>
        /// <item><description><b>web</b>: Web pages.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>web</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>The description of the record. The description can be up to 100 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a remark.</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The DNS information of the record. The required content for this field varies based on the record type. For more information, see
        /// &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/document_detail/2708761.html">Documentation</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/doc-detail/2708761.html">Documentation</a>
        /// .</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;value&quot;:&quot;2.2.2.2&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateRecordRequestData Data { get; set; }
        public class CreateRecordRequestData : TeaModel {
            /// <summary>
            /// <para>The encryption algorithm used by the record. Valid values: <b>0</b> to <b>255</b>. This parameter is required when you add a CERT or SSHFP record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public int? Algorithm { get; set; }

            /// <summary>
            /// <para>The public key certificate information of the record. This parameter is required when you add a CERT, SMIMEA, or TLSA record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dGVzdGFkYWxrcw==</para>
            /// </summary>
            [NameInMap("Certificate")]
            [Validation(Required=false)]
            public string Certificate { get; set; }

            /// <summary>
            /// <para>The public key fingerprint value of the record. This parameter is required when you add an SSHFP record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abcdef1234567890</para>
            /// </summary>
            [NameInMap("Fingerprint")]
            [Validation(Required=false)]
            public string Fingerprint { get; set; }

            /// <summary>
            /// <para>The flag of the record. For a CAA record, the flag indicates its priority and processing method. Valid values: <b>0</b> to <b>255</b>. This parameter is required when you add a CAA record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public int? Flag { get; set; }

            /// <summary>
            /// <para>The public key tag of the record. Valid values: <b>0</b> to <b>65535</b>. This parameter is required when you add a CERT record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("KeyTag")]
            [Validation(Required=false)]
            public int? KeyTag { get; set; }

            /// <summary>
            /// <para>The algorithm policy used by the record to match or verify the certificate. Valid values: <b>0</b> to <b>255</b>. This parameter is required when you add an SMIMEA or TLSA record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MatchingType")]
            [Validation(Required=false)]
            public int? MatchingType { get; set; }

            /// <summary>
            /// <para>The port of the record. Valid values: <b>0</b> to <b>65535</b>. This parameter is required when you add an SRV record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The priority of the record. Valid values: <b>0</b> to <b>65535</b>. A smaller value indicates a higher priority. This parameter is required when you add an MX, SRV, or URI record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The type of the certificate or public key used by the record. Valid values: <b>0</b> to <b>255</b>. This parameter is required when you add an SMIMEA or TLSA record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Selector")]
            [Validation(Required=false)]
            public int? Selector { get; set; }

            /// <summary>
            /// <para>The tag of the record. For a CAA record, the tag indicates its specific type and purpose. This parameter is required when you add a CAA record. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>issue</b>: Authorizes a specific CA to issue certificates for the domain name. This is typically followed by the domain name of the CA.</description></item>
            /// <item><description><b>issuewild</b>: Authorizes a specific CA to issue wildcard certificates for the domain name, such as *.example.com.</description></item>
            /// <item><description><b>iodef</b>: Specifies a URI to receive reports about CAA record violations.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>issue</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The certificate type for a CERT record, or the public key type for an SSHFP record. This parameter is required when you add a CERT or SSHFP record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>The usage identifier of the record. Valid values: <b>0</b> to <b>255</b>. This parameter is required when you add an SMIMEA or TLSA record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public int? Usage { get; set; }

            /// <summary>
            /// <para>The record value or partial content. This parameter is required when the record type is A/AAAA, CNAME, NS, MX, TXT, CAA, SRV, or URI. This parameter has different meanings for different record types:</para>
            /// <list type="bullet">
            /// <item><description><b>A/AAAA</b>: The destination IP address. Separate multiple IP addresses with commas (,). At least one IPv4 address is required.</description></item>
            /// <item><description><b>CNAME</b>: The destination domain name.</description></item>
            /// <item><description><b>NS</b>: The name server of the domain name.</description></item>
            /// <item><description><b>MX</b>: The domain name of the destination mail server.</description></item>
            /// <item><description><b>TXT</b>: A valid text string.</description></item>
            /// <item><description><b>CAA</b>: The domain name of the certification authority (CA).</description></item>
            /// <item><description><b>SRV</b>: The domain name of the destination host.</description></item>
            /// <item><description><b>URI</b>: A valid URI string.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// <para>The weight of the record. Valid values: <b>0</b> to <b>65535</b>. This parameter is required when you add an SRV or URI record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The back-to-origin host policy. This parameter takes effect when the record type is CNAME. Settings for the host policy in back-to-origin requests. Two patterns are available:</para>
        /// <list type="bullet">
        /// <item><description><b>follow_hostname</b>: Follows the request host.</description></item>
        /// <item><description><b>follow_origin_domain</b>: Follows the Origin Domain Name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>follow_origin_domain</para>
        /// </summary>
        [NameInMap("HostPolicy")]
        [Validation(Required=false)]
        public string HostPolicy { get; set; }

        /// <summary>
        /// <para>The HTTP port. By default, port 80 is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80,2052,2082,2086,2095,8080,8880</para>
        /// </summary>
        [NameInMap("HttpPorts")]
        [Validation(Required=false)]
        public string HttpPorts { get; set; }

        /// <summary>
        /// <para>The HTTPS port. By default, port 443 is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>443,2053,2083,2087,2096,8443</para>
        /// </summary>
        [NameInMap("HttpsPorts")]
        [Validation(Required=false)]
        public string HttpsPorts { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable proxy acceleration for the record. Proxy acceleration can be enabled only for CNAME, A, or AAAA records. That is, the Type parameter is set to CNAME, A, or AAAA. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enables proxy acceleration.</description></item>
        /// <item><description><b>false</b>: Disables proxy acceleration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Proxied")]
        [Validation(Required=false)]
        public bool? Proxied { get; set; }

        /// <summary>
        /// <para>The record name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("RecordName")]
        [Validation(Required=false)]
        public string RecordName { get; set; }

        /// <summary>
        /// <para>The site ID. You can obtain the site ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The origin server type for a CNAME record. This parameter is required when you add a CNAME record. That is, the Type parameter is set to CNAME. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OSS</b>: OSS origin server.</description></item>
        /// <item><description><b>S3</b>: S3 origin server.</description></item>
        /// <item><description><b>LB</b>: Load balancing origin server.</description></item>
        /// <item><description><b>OP</b>: IPAM pool origin server.</description></item>
        /// <item><description><b>Domain</b>: Common domain name origin server.</description></item>
        /// </list>
        /// <para>If this parameter is not specified or is left empty, the default value is Domain, which indicates a common domain name origin server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The time-to-live (TTL) of the record, in seconds. A value of 1 indicates that the TTL is automatically determined.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>The DNS record type, such as <b>A/AAAA</b>, <b>CNAME</b>, or <b>TXT</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A/AAAA</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
