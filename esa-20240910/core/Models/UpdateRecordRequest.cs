// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateRecordRequest : TeaModel {
        /// <summary>
        /// <para>The origin authentication information of the CNAME record.</para>
        /// </summary>
        [NameInMap("AuthConf")]
        [Validation(Required=false)]
        public UpdateRecordRequestAuthConf AuthConf { get; set; }
        public class UpdateRecordRequestAuthConf : TeaModel {
            /// <summary>
            /// <para>The AccessKey of the account to which the origin server belongs. This parameter is required when the origin server type is OSS and the origin authentication type is private cross-account read, or when the origin server type is S3 and the origin authentication type is private read.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VIxuvJSA2S03f******kp208dy5w7</para>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>The origin authentication type. Different origin server types support different authentication types. The origin server type refers to the SourceType parameter in this operation. When the origin server type is OSS or S3, you must specify the origin authentication type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>public</b>: public read. Select this value when the origin server type is OSS or S3 and the origin server allows public read access.</description></item>
            /// <item><description><b>private</b>: private read. Select this value when the origin server type is S3 and the origin server allows only private read access.</description></item>
            /// <item><description><b>private_same_account</b>: private same-account read. Select this value when the origin server type is OSS, the origin server is under the same Alibaba Cloud account, and the origin server allows only private read access.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>The signature algorithm version. This parameter is required when the origin server type is S3 and the origin authentication type is private read. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>v2</b></para>
            /// </description></item>
            /// <item><description><para><b>v4</b></para>
            /// </description></item>
            /// </list>
            /// <para>Default value: v4.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The SecretKey of the account to which the origin server belongs. This parameter is required when the origin server type is OSS and the origin authentication type is private cross-account read, or when the origin server type is S3 and the origin authentication type is private read.</para>
            /// 
            /// <b>Example:</b>
            /// <para>u0Nkg5gBK*******QF5wvKMM504JUHt</para>
            /// </summary>
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            /// <summary>
            /// <para>The region to which the origin server belongs. This parameter is required when the origin server type is S3. Obtain the region from the official S3 website.</para>
            /// 
            /// <b>Example:</b>
            /// <para>us-east-1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The business scenario for record acceleration. This parameter is not required for records without acceleration enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>video_image</b>: video and image.</description></item>
        /// <item><description><b>api</b>: API.</description></item>
        /// <item><description><b>web</b>: web page.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>web</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>The comment for the record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a remark.</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The DNS information of the record. The content varies depending on the record type. For more information, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/document_detail/2708761.html">documentation</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/doc-detail/2708761.html">documentation</a>.</para>
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
            /// <para>The encryption algorithm used by the record. Valid values: <b>0 to 255</b>. This parameter is required when you add CERT or SSHFP records.</para>
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
            /// <para>The public key fingerprint value of the record. This parameter is required when you add SSHFP records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abcdef1234567890</para>
            /// </summary>
            [NameInMap("Fingerprint")]
            [Validation(Required=false)]
            public string Fingerprint { get; set; }

            /// <summary>
            /// <para>The flag of the record. The Flag of a CAA record indicates its priority and processing method. Valid values: <b>0 to 255</b>. This parameter is required when you add CAA records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public int? Flag { get; set; }

            /// <summary>
            /// <para>The public key identifier of the record. Valid values: <b>0 to 65535</b>. This parameter is required when you add CERT records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("KeyTag")]
            [Validation(Required=false)]
            public int? KeyTag { get; set; }

            /// <summary>
            /// <para>The algorithm policy used by the record for matching or verifying certificates. Valid values: <b>0 to 255</b>. This parameter is required when you add SMIMEA or TLSA records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MatchingType")]
            [Validation(Required=false)]
            public int? MatchingType { get; set; }

            /// <summary>
            /// <para>The port of the record. Valid values: <b>0 to 65535</b>. This parameter is required when you add SRV records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The priority of the record. Valid values: <b>0 to 65535</b>. A smaller value indicates a higher priority. This parameter is required when you add MX, SRV, or URI records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The type of certificate or public key used by the record. Valid values: <b>0 to 255</b>. This parameter is required when you add SMIMEA or TLSA records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Selector")]
            [Validation(Required=false)]
            public int? Selector { get; set; }

            /// <summary>
            /// <para>The tag of the record. The Tag of a CAA record indicates its specific type and purpose. This parameter is required when you add CAA records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>issue</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The certificate type of the record (for CERT records) or the public key type (for SSHFP records). This parameter is required when you add CERT or SSHFP records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>The usage identifier of the record. Valid values: <b>0 to 255</b>. This parameter is required when you add SMIMEA or TLSA records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public int? Usage { get; set; }

            /// <summary>
            /// <para>The record value or partial content. This parameter is required when you add A/AAAA, CNAME, NS, MX, TXT, CAA, SRV, or URI records. The meaning varies depending on the record type:</para>
            /// <list type="bullet">
            /// <item><description><b>A/AAAA</b>: The IP address to which the record points. Separate multiple IP addresses with commas (,). At least one IPv4 address is required.</description></item>
            /// <item><description><b>CNAME</b>: The target domain name to which the record points.</description></item>
            /// <item><description><b>NS</b>: The name server for the specified domain name.</description></item>
            /// <item><description><b>MX</b>: A valid target mail server domain name.</description></item>
            /// <item><description><b>TXT</b>: A valid text string.</description></item>
            /// <item><description><b>CAA</b>: A valid certification authority domain name.</description></item>
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
            /// <para>The weight of the record. Valid values: <b>0 to 65535</b>. This parameter is required when you add SRV or URI records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The back-to-origin HOST policy. This parameter takes effect when the record type is CNAME. Settings the HOST policy for back-to-origin requests. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>follow_hostname</b>: follows the host record.</description></item>
        /// <item><description><b>follow_origin_domain</b>: follows the Origin Domain Name.</description></item>
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
        /// <para>Specifies whether to enable proxy acceleration for the record. Only CNAME records and A/AAAA records support proxy acceleration. Valid values:</para>
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
        /// <para>The ID of the record. You can call <a href="https://help.aliyun.com/document_detail/2850265.html">ListRecords</a> to obtain the record ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public long? RecordId { get; set; }

        /// <summary>
        /// <para>The origin server type of the CNAME record. This parameter is required when you add a CNAME record. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OSS</b>: OSS origin server.</description></item>
        /// <item><description><b>S3</b>: S3 origin server.</description></item>
        /// <item><description><b>LB</b>: load balancing origin server.</description></item>
        /// <item><description><b>OP</b>: IPAM pool origin server.</description></item>
        /// <item><description><b>Domain</b>: standard domain name origin server.</description></item>
        /// </list>
        /// <para>If this parameter is not specified or is left empty, the default value is Domain, which indicates a standard domain name origin server type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The time-to-live (TTL) of the record, in seconds. Valid values: <b>30 to 86400</b>, or 1. A value of 1 indicates that the TTL of the record is automatically determined.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>The DNS type of the record, such as A/AAAA, CNAME, or TXT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A/AAAA</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
