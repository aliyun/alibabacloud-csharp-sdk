// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateRecordRequest : TeaModel {
        /// <summary>
        /// <para>The origin authentication information for the CNAME record.</para>
        /// </summary>
        [NameInMap("AuthConf")]
        [Validation(Required=false)]
        public CreateRecordRequestAuthConf AuthConf { get; set; }
        public class CreateRecordRequestAuthConf : TeaModel {
            /// <summary>
            /// <para>The AccessKey of the account that owns the origin. This value is required when the origin type is OSS and the authentication type is private cross-account read, or when the origin type is S3 and the authentication type is private read.</para>
            /// 
            /// <b>Example:</b>
            /// <para>u0Nkg5gBK*******QF5wvKMM504JUHt</para>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>The origin authentication type. Different origin types support different authentication types. The origin type refers to the SourceType parameter in this API. When the origin type is OSS or S3, you need to specify the origin authentication type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>public</b>: Public read. Select this value when the origin type is OSS or S3 and the origin has public read access.</description></item>
            /// <item><description><b>private</b>: Private read. Select this value when the origin type is S3 and the origin has private read access.</description></item>
            /// <item><description><b>private_same_account</b>: Private same-account read. Select this value when the origin type is OSS, the origin is under the same Alibaba Cloud account, and the origin has private read access.</description></item>
            /// <item><description><b>private_cross_account</b>: Private cross-account read. Select this value when the origin type is OSS, the origin is not under the same Alibaba Cloud account, and the origin has private read access.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>The region where the origin is located. This value is required when the origin type is S3. The region information can be obtained from the official S3 website.</para>
            /// 
            /// <b>Example:</b>
            /// <para>us-east-1</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The SecretKey of the account that owns the origin. This value is required when the origin type is OSS and the authentication type is private cross-account read, or when the origin type is S3 and the authentication type is private read.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VIxuvJSA2S03f******kp208dy5w7</para>
            /// </summary>
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            /// <summary>
            /// <para>The signature algorithm version. This is required when the origin type is S3 and the authentication type is private read. The following two versions are supported:</para>
            /// <list type="bullet">
            /// <item><description><b>v2</b></description></item>
            /// <item><description><b>v4</b></description></item>
            /// </list>
            /// <para>If not specified, the default value is v4.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v4</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>Used to tag the business scenario of the DNS record. This parameter is required when proxy acceleration is enabled for the DNS record (i.e., when the proxied parameter is set to true), and is not required when proxy acceleration is disabled (i.e., when the proxied parameter is set to false). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>image_video</b>: Image and video.</description></item>
        /// <item><description><b>api</b>: API.</description></item>
        /// <item><description><b>web</b>: Web page.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>web</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>The comment for the record, with a maximum length of 100 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a remark.</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The DNS information of the record. Different types of records require different content for this field. For more information, see
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
            /// <para>The encryption algorithm used by the record, ranging from <b>0 to 255</b>. This field is required when adding CERT or SSHFP records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public int? Algorithm { get; set; }

            /// <summary>
            /// <para>The public key certificate information of the record. This parameter is required when adding CERT, SMIMEA, or TLSA records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dGVzdGFkYWxrcw==</para>
            /// </summary>
            [NameInMap("Certificate")]
            [Validation(Required=false)]
            public string Certificate { get; set; }

            /// <summary>
            /// <para>The public key fingerprint value of the record. This parameter is required when adding an SSHFP record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abcdef1234567890</para>
            /// </summary>
            [NameInMap("Fingerprint")]
            [Validation(Required=false)]
            public string Fingerprint { get; set; }

            /// <summary>
            /// <para>The flag of the record. The Flag of a CAA record indicates its priority and processing method, with a value range of <b>0 to 255</b>. This parameter is required when adding a CAA record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public int? Flag { get; set; }

            /// <summary>
            /// <para>The public key identifier of the record, ranging from <b>0 to 65535</b>. This parameter is required when adding a CERT record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("KeyTag")]
            [Validation(Required=false)]
            public int? KeyTag { get; set; }

            /// <summary>
            /// <para>The algorithm policy used by the record to match or verify certificates, ranging from <b>0 to 255</b>. This parameter is required when adding SMIMEA or TLSA records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MatchingType")]
            [Validation(Required=false)]
            public int? MatchingType { get; set; }

            /// <summary>
            /// <para>The port of the record, ranging from <b>0 to 65535</b>. This parameter is required when adding an SRV record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The priority of the record, ranging from <b>0 to 65535</b>. A smaller value indicates a higher priority. This parameter is required when adding MX, SRV, or URI records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The type of certificate or public key used by the record, ranging from <b>0 to 255</b>. This parameter is required when adding SMIMEA or TLSA records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Selector")]
            [Validation(Required=false)]
            public int? Selector { get; set; }

            /// <summary>
            /// <para>The tag of the record. The Tag of a CAA record indicates its specific type and purpose. This parameter is required when adding a CAA record. Valid values for Tag:</para>
            /// <list type="bullet">
            /// <item><description><b>issue</b>: Authorizes a specific CA to issue certificates for the domain. It is usually followed by the CA\&quot;s domain name.</description></item>
            /// <item><description><b>issuewild</b>: Authorizes a specific CA to issue wildcard certificates for the domain (e.g., *.example.com).</description></item>
            /// <item><description><b>iodef</b>: Specifies a URI for receiving reports about violations of CAA records.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>issue</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The certificate type of the record (for CERT records) or the public key type (for SSHFP records). This parameter is required when adding CERT or SSHFP records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>The usage identifier of the record, ranging from <b>0 to 255</b>. This parameter is required when adding SMIMEA or TLSA records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public int? Usage { get; set; }

            /// <summary>
            /// <para>The record value or partial content. This parameter is required when the record type is A/AAAA, CNAME, NS, MX, TXT, CAA, SRV, or URI. It represents different meanings for different record types:</para>
            /// <list type="bullet">
            /// <item><description><b>A/AAAA</b>: The IP address to point to. Multiple IPs are separated by commas (,). At least one IPv4 address is required.</description></item>
            /// <item><description><b>CNAME</b>: The target domain name to point to.</description></item>
            /// <item><description><b>NS</b>: The name server for the specified domain.</description></item>
            /// <item><description><b>MX</b>: A valid target mail server domain name.</description></item>
            /// <item><description><b>TXT</b>: A valid text string.</description></item>
            /// <item><description><b>CAA</b>: A valid certificate authority domain name.</description></item>
            /// <item><description><b>SRV</b>: A valid target host domain name.</description></item>
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
            /// <para>The weight of the record, ranging from <b>0 to 65535</b>. This parameter is required when adding SRV or URI records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The origin host policy. This takes effect when the record type is CNAME. It specifies the host policy for back-to-origin requests. Two modes are available:</para>
        /// <list type="bullet">
        /// <item><description><b>follow_hostname</b>: Follow the request host.</description></item>
        /// <item><description><b>follow_origin_domain</b>: Follow the origin domain.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>follow_origin_domain</para>
        /// </summary>
        [NameInMap("HostPolicy")]
        [Validation(Required=false)]
        public string HostPolicy { get; set; }

        [NameInMap("HttpPorts")]
        [Validation(Required=false)]
        public string HttpPorts { get; set; }

        [NameInMap("HttpsPorts")]
        [Validation(Required=false)]
        public string HttpsPorts { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable proxy acceleration for the record. Only CNAME records or A/AAAA records (i.e., when the type parameter is set to A/AAAA or CNAME) can enable proxy acceleration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enable proxy acceleration.</description></item>
        /// <item><description><b>false</b>: Disable proxy acceleration.</description></item>
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
        /// <para>The site ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The origin type of the CNAME record. This parameter is required when adding a CNAME record (i.e., when the type parameter is set to CNAME). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OSS</b>: OSS origin.</description></item>
        /// <item><description><b>S3</b>: S3 origin.</description></item>
        /// <item><description><b>LB</b>: Load balancer origin.</description></item>
        /// <item><description><b>OP</b>: Origin pool origin.</description></item>
        /// <item><description><b>Domain</b>: Standard domain origin.</description></item>
        /// </list>
        /// <para>If this parameter is not specified or is left empty, it defaults to Domain, which is the standard domain origin type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The time-to-live (TTL) of the record, in seconds. When set to 1, the TTL is automatic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>The DNS type of the record, such as <b>A/AAAA</b>, <b>CNAME</b>, <b>TXT</b>, etc.</para>
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
