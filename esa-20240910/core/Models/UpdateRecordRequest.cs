// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateRecordRequest : TeaModel {
        /// <summary>
        /// <para>The origin server authentication information for a CNAME record.</para>
        /// </summary>
        [NameInMap("AuthConf")]
        [Validation(Required=false)]
        public UpdateRecordRequestAuthConf AuthConf { get; set; }
        public class UpdateRecordRequestAuthConf : TeaModel {
            /// <summary>
            /// <para>The AccessKey of the account to which the origin server belongs. This parameter is required when the origin server type is OSS and the authentication type is private cross-account read, or when the origin server type is S3 and the authentication type is private read.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VIxuvJSA2S03f******kp208dy5w7</para>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>The origin server authentication type. Supported authentication types vary based on the origin server type, which is specified by the SourceType parameter in this operation. This parameter is required when the origin server type is OSS or S3. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>public</b>: Public read. Select this value when the origin server type is OSS or S3 and the origin server allows public read access.</description></item>
            /// <item><description><b>private</b>: Private read. Select this value when the origin server type is S3 and the origin server allows private read access.</description></item>
            /// <item><description><b>private_same_account</b>: Private read within the same account. Select this value when the origin server type is OSS, the origin server and the current resource belong to the same Alibaba Cloud account, and the origin server allows private read access.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>The signature algorithm version. This parameter is required when the origin server type is S3 and the authentication type is private read. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>v2</b></para>
            /// </description></item>
            /// <item><description><para><b>v4</b></para>
            /// </description></item>
            /// </list>
            /// <para>If this parameter is not specified, the default value is <b>v4</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The secret key of the account to which the origin server belongs. This parameter is required when the origin server type is OSS and the authentication type is private cross-account read, or when the origin server type is S3 and the authentication type is private read.</para>
            /// 
            /// <b>Example:</b>
            /// <para>u0Nkg5gBK*******QF5wvKMM504JUHt</para>
            /// </summary>
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            /// <summary>
            /// <para>The region to which the origin server belongs. This parameter is required when the origin server type is S3. You can obtain the region of the origin server from the official website of S3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>us-east-1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The business scenario when record acceleration is enabled. This parameter is not required for records without acceleration enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>video_image</b>: Video and image.</description></item>
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
        /// <para>The description of the record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a remark.</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The DNS information of the record. The required content for this field varies based on the record type. For more information, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/document_detail/2708761.html">Documentation</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/doc-detail/2708761.html">Documentation</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;value&quot;:&quot;2.2.2.2&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateRecordRequestData Data { get; set; }
        public class UpdateRecordRequestData : TeaModel {
            /// <summary>
            /// <para>The encryption algorithm used by the record. Valid values: <b>0</b> to <b>255</b>. This parameter is required when you add CERT or SSHFP records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public int? Algorithm { get; set; }

            /// <summary>
            /// <para>The public key certificate information of the record. This parameter is required when you add CERT, SMIMEA, or TLSA records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dGVzdGFkYWxrcw==</para>
            /// </summary>
            [NameInMap("Certificate")]
            [Validation(Required=false)]
            public string Certificate { get; set; }

            /// <summary>
            /// <para>The public key fingerprint of the record. This parameter is required when you add an SSHFP record.</para>
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
            /// <para>The algorithm policy used to match or verify the certificate. Valid values: <b>0</b> to <b>255</b>. This parameter is required when you add SMIMEA or TLSA records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
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
            /// <para>The priority of the record. Valid values: <b>0</b> to <b>65535</b>. A smaller value indicates a higher priority. This parameter is required when you add MX, SRV, or URI records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The type of the certificate or public key used by the record. Valid values: <b>0</b> to <b>255</b>. This parameter is required when you add SMIMEA or TLSA records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Selector")]
            [Validation(Required=false)]
            public int? Selector { get; set; }

            /// <summary>
            /// <para>The tag of the record. For a CAA record, the tag indicates its specific type and purpose. This parameter is required when you add a CAA record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>issue</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The certificate type for a CERT record, or the public key type for an SSHFP record. This parameter is required when you add CERT or SSHFP records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>The usage identifier of the record. Valid values: <b>0</b> to <b>255</b>. This parameter is required when you add SMIMEA or TLSA records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public int? Usage { get; set; }

            /// <summary>
            /// <para>The record value or partial content. This parameter is required when you add A, AAAA, CNAME, NS, MX, TXT, CAA, SRV, or URI records. The meaning of this parameter varies based on the record type:</para>
            /// <list type="bullet">
            /// <item><description><b>A/AAAA</b>: The destination IP address. Separate multiple IP addresses with commas (,). At least one IPv4 address is required.</description></item>
            /// <item><description><b>CNAME</b>: The target domain name.</description></item>
            /// <item><description><b>NS</b>: The name server of the specified domain name.</description></item>
            /// <item><description><b>MX</b>: The valid domain name of the target mail server.</description></item>
            /// <item><description><b>TXT</b>: A valid text string.</description></item>
            /// <item><description><b>CAA</b>: The valid domain name of the certificate issuing authority.</description></item>
            /// <item><description><b>SRV</b>: The valid domain name of the target host.</description></item>
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
            /// <para>The weight of the record. Valid values: <b>0</b> to <b>65535</b>. This parameter is required when you add SRV or URI records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The back-to-origin host policy. This parameter takes effect when the record type is CNAME and specifies the host header policy for back-to-origin requests. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>follow_hostname</b>: Follows the host record.</description></item>
        /// <item><description><b>follow_origin_domain</b>: Follows the origin domain name.</description></item>
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
        /// <para>Specifies whether to enable proxy acceleration for the record. Only CNAME, A, and AAAA records support proxy acceleration. Valid values:</para>
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
        /// <para>The ID of the record. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/2850265.html">ListRecords</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public long? RecordId { get; set; }

        /// <summary>
        /// <para>The origin server type for a CNAME record. This parameter is required when you add a CNAME record. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OSS</b>: OSS origin server.</description></item>
        /// <item><description><b>S3</b>: S3 origin server.</description></item>
        /// <item><description><b>LB</b>: Load balancer origin server.</description></item>
        /// <item><description><b>OP</b>: Origin address pool origin server.</description></item>
        /// <item><description><b>Domain</b>: Common domain name origin server.</description></item>
        /// </list>
        /// <para>If this parameter is not specified or is left empty, the default value is <b>Domain</b>, which indicates a common domain name origin server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The time-to-live (TTL) of the record, in seconds. Valid values: <b>30</b> to <b>86400</b>, or <b>1</b>. A value of 1 indicates that the TTL is automatic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>The DNS record type. Examples include A, AAAA, CNAME, and TXT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A/AAAA</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
