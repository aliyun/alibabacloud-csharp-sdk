// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the queried record.</para>
        /// </summary>
        [NameInMap("RecordModel")]
        [Validation(Required=false)]
        public GetRecordResponseBodyRecordModel RecordModel { get; set; }
        public class GetRecordResponseBodyRecordModel : TeaModel {
            /// <summary>
            /// <para>The origin server authentication information of the CNAME record.</para>
            /// </summary>
            [NameInMap("AuthConf")]
            [Validation(Required=false)]
            public GetRecordResponseBodyRecordModelAuthConf AuthConf { get; set; }
            public class GetRecordResponseBodyRecordModelAuthConf : TeaModel {
                /// <summary>
                /// <para>The AccessKey of the account to which the origin server belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VIxuvJSA2S03f******kp208dy5w7</para>
                /// </summary>
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// <para>The origin server authentication type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>public</b>: Public read. Select this value when the origin server type is OSS or S3 and the origin server allows public read access.</description></item>
                /// <item><description><b>private</b>: Private read. Select this value when the origin server type is S3 and the origin server allows private read access.</description></item>
                /// <item><description><b>private_same_account</b>: Private read within the same account. Select this value when the origin server type is OSS, the origin server belongs to the same Alibaba Cloud account, and the origin server allows private read access.</description></item>
                /// <item><description><b>private_cross_account</b>: Private read across accounts. Select this value when the origin server type is OSS, the origin server belongs to a different Alibaba Cloud account, and the origin server allows private read access.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// <para>The region to which the origin server belongs. You can obtain the region information from the official website of S3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>us-east-1</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The AccessKey of the account to which the origin server belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>u0Nkg5gBK*******QF5wvKMM504JUHt</para>
                /// </summary>
                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                /// <summary>
                /// <para>The version of the signature algorithm. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>v2</b></description></item>
                /// <item><description><b>v4</b></description></item>
                /// </list>
                /// <para>If this parameter is not specified, the default value is <b>v4</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v2</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The business scenario for record acceleration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>image_video</b>: Images and videos.</description></item>
            /// <item><description><b>api</b>: API operations.</description></item>
            /// <item><description><b>web</b>: Web pages.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>image_video</para>
            /// </summary>
            [NameInMap("BizName")]
            [Validation(Required=false)]
            public string BizName { get; set; }

            /// <summary>
            /// <para>The description of the record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Remarks</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The time when the record was created. The time is displayed in UTC and follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-10T13:30:39Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether a custom port is enabled for the record. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: Enabled.</description></item>
            /// <item><description><b>off</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("CustomPort")]
            [Validation(Required=false)]
            public string CustomPort { get; set; }

            /// <summary>
            /// <para>The DNS information of the record. The content returned by this field varies based on the record type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;value&quot;:&quot;1.1.1.1&quot;}</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public GetRecordResponseBodyRecordModelData Data { get; set; }
            public class GetRecordResponseBodyRecordModelData : TeaModel {
                /// <summary>
                /// <para>The encryption algorithm used by the record. Valid values: <b>0</b> to <b>255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Algorithm")]
                [Validation(Required=false)]
                public int? Algorithm { get; set; }

                /// <summary>
                /// <para>The public key certificate information of the record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dGVzdGFkYWxrcw==</para>
                /// </summary>
                [NameInMap("Certificate")]
                [Validation(Required=false)]
                public string Certificate { get; set; }

                /// <summary>
                /// <para>The public key fingerprint of the record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcdef1234567890</para>
                /// </summary>
                [NameInMap("Fingerprint")]
                [Validation(Required=false)]
                public string Fingerprint { get; set; }

                /// <summary>
                /// <para>The flag of the record. For a CAA record, the flag indicates its priority and processing method. Valid values: <b>0</b> to <b>255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>128</para>
                /// </summary>
                [NameInMap("Flag")]
                [Validation(Required=false)]
                public int? Flag { get; set; }

                /// <summary>
                /// <para>The public key tag of the record. Valid values: <b>0</b> to <b>65535</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("KeyTag")]
                [Validation(Required=false)]
                public int? KeyTag { get; set; }

                /// <summary>
                /// <para>The algorithm policy used by the record to match or verify the certificate. Valid values: <b>0</b> to <b>255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MatchingType")]
                [Validation(Required=false)]
                public int? MatchingType { get; set; }

                /// <summary>
                /// <para>The port of the record. Valid values: <b>0</b> to <b>65535</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8707</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The priority of the record. Valid values: <b>0</b> to <b>65535</b>. A smaller value indicates a higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The type of the certificate or public key used by the record. Valid values: <b>0</b> to <b>255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Selector")]
                [Validation(Required=false)]
                public int? Selector { get; set; }

                /// <summary>
                /// <para>The tag of the record. For a CAA record, the tag indicates its specific type and usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>issue</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The tags of the record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;test\&quot;: \&quot;test val1\&quot;}</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public Dictionary<string, object> Tags { get; set; }

                /// <summary>
                /// <para>The certificate type for a CERT record, or the public key type for an SSHFP record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <para>The usage identifier of the record. Valid values: <b>0</b> to <b>255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public int? Usage { get; set; }

                /// <summary>
                /// <para>The record value or partial content. This field indicates different meanings for different record types:</para>
                /// <list type="bullet">
                /// <item><description><b>A/AAAA</b>: The destination IP address. If multiple IP addresses are specified, separate them with commas (,). At least one IPv4 address is required.</description></item>
                /// <item><description><b>CNAME</b>: The destination domain name.</description></item>
                /// <item><description><b>NS</b>: The name server of the domain name.</description></item>
                /// <item><description><b>MX</b>: The domain name of the destination mail server.</description></item>
                /// <item><description><b>TXT</b>: The text string.</description></item>
                /// <item><description><b>CAA</b>: The domain name of the certification authority (CA).</description></item>
                /// <item><description><b>SRV</b>: The domain name of the destination host.</description></item>
                /// <item><description><b>URI</b>: The URI string.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The weight of the record. Valid values: <b>0</b> to <b>65535</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The back-to-origin host policy. This parameter takes effect only when the record type is CNAME. It specifies the host policy for back-to-origin requests. Valid values:</para>
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
            /// <para>80,8080,8880,2052,2082,2086,2095</para>
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
            /// <para>Indicates whether proxy acceleration is enabled for the record. Only CNAME, A, and AAAA records support proxy acceleration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Proxy acceleration is enabled.</description></item>
            /// <item><description><b>false</b>: Proxy acceleration is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Proxied")]
            [Validation(Required=false)]
            public bool? Proxied { get; set; }

            /// <summary>
            /// <para>The CNAME of the record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a.example.com.cnamezone.com</para>
            /// </summary>
            [NameInMap("RecordCname")]
            [Validation(Required=false)]
            public string RecordCname { get; set; }

            /// <summary>
            /// <para>The ID of the record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890123</para>
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            /// <summary>
            /// <para>The name of the record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a.example.com</para>
            /// </summary>
            [NameInMap("RecordName")]
            [Validation(Required=false)]
            public string RecordName { get; set; }

            /// <summary>
            /// <para>The origin server type of the CNAME record. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>OSS</b>: An OSS origin server.</description></item>
            /// <item><description><b>S3</b>: An S3 origin server.</description></item>
            /// <item><description><b>LB</b>: A load balancing origin server.</description></item>
            /// <item><description><b>OP</b>: An IPAM pool origin server.</description></item>
            /// <item><description><b>Domain</b>: A common domain name origin server.</description></item>
            /// </list>
            /// <para>If this parameter is not specified or is left empty, the default value is <b>Domain</b>, which indicates a common domain name origin server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("RecordSourceType")]
            [Validation(Required=false)]
            public string RecordSourceType { get; set; }

            /// <summary>
            /// <para>The DNS record type, such as <b>A</b>, <b>AAAA</b>, <b>CNAME</b>, or <b>TXT</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A/AAAA</para>
            /// </summary>
            [NameInMap("RecordType")]
            [Validation(Required=false)]
            public string RecordType { get; set; }

            /// <summary>
            /// <para>The ID of the site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890123</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            /// <summary>
            /// <para>The name of the site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("SiteName")]
            [Validation(Required=false)]
            public string SiteName { get; set; }

            /// <summary>
            /// <para>The time-to-live (TTL) of the record, in seconds. A value of 1 indicates that the TTL is automatic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            /// <summary>
            /// <para>The time when the record was updated. The time is displayed in UTC and follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-27T02:26:22Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F32C57AA-7BF8-49AE-A2CC-9F42390F5A19</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
