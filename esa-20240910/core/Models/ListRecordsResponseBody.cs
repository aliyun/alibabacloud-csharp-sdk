// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number, same as the PageNumber request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records displayed per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>DNS information of the records. For details, refer to &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/document_detail/2708761.html">Documentation</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/doc-detail/2708761.html">Documentation</a>.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<ListRecordsResponseBodyRecords> Records { get; set; }
        public class ListRecordsResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>The origin authentication information of the CNAME record.</para>
            /// </summary>
            [NameInMap("AuthConf")]
            [Validation(Required=false)]
            public ListRecordsResponseBodyRecordsAuthConf AuthConf { get; set; }
            public class ListRecordsResponseBodyRecordsAuthConf : TeaModel {
                /// <summary>
                /// <para>The AccessKey of the account to which the origin belongs. This parameter is available when the origin type is OSS with private cross-account read authentication, or when the origin type is S3 with private read authentication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>u0Nkg5gBK***QF5wvKMM504JUHt</para>
                /// </summary>
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// <para>The origin authentication type. Different origin types support different authentication types. The origin type refers to the SourceType parameter in this API. When the origin type is OSS or S3, the origin authentication type must be specified. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>public</b>: Public read. Use this value when the origin type is OSS or S3 and the origin has public read access.</description></item>
                /// <item><description><b>private</b>: Private read. Use this value when the origin type is S3 and the origin has private read access.</description></item>
                /// <item><description><b>private_same_account</b>: Private same-account read. Use this value when the origin type is OSS, the origin is under the same Alibaba Cloud account, and the origin has private read access.</description></item>
                /// <item><description><b>private_cross_account</b>: Private cross-account read. Use this value when the origin type is OSS, the origin is not under the same Alibaba Cloud account, and the origin has private read access.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>private</para>
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// <para>The region where the origin is located. This parameter is available when the origin type is S3. The region of the origin can be obtained from the official S3 website.</para>
                /// 
                /// <b>Example:</b>
                /// <para>us-east-1</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The SecretKey of the account to which the origin belongs. This parameter is available when the origin type is OSS with private cross-account read authentication, or when the origin type is S3 with private read authentication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VIxuvJSA2S03f***kp208dy5w7</para>
                /// </summary>
                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                /// <summary>
                /// <para>The signature algorithm version. This parameter is available when the origin type is S3 and the origin authentication type is private read. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>v2</b></description></item>
                /// <item><description><b>v4</b></description></item>
                /// </list>
                /// <para>Default value: v4.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v4</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The business scenario for record acceleration. Valid values:</para>
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
            /// <para>The comment of the record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>this is a remark.</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The creation time of the record. The date format follows the ISO 8601 standard and uses UTC time in the format of yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-24T02:01:11Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CustomPort")]
            [Validation(Required=false)]
            public string CustomPort { get; set; }

            /// <summary>
            /// <para>The specific DNS information of the record. Different record types contain different information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;value&quot;:&quot;1.1.1.1&quot;}</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public ListRecordsResponseBodyRecordsData Data { get; set; }
            public class ListRecordsResponseBodyRecordsData : TeaModel {
                /// <summary>
                /// <para>The encryption algorithm used by the record. Valid values: <b>0 to 255</b>. Exclusive to CERT and SSHFP records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Algorithm")]
                [Validation(Required=false)]
                public int? Algorithm { get; set; }

                /// <summary>
                /// <para>The public key certificate information of the record. Exclusive to CERT, SMIMEA, and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dGVzdGFkYWxrcw==</para>
                /// </summary>
                [NameInMap("Certificate")]
                [Validation(Required=false)]
                public string Certificate { get; set; }

                /// <summary>
                /// <para>The public key fingerprint value of the record. Exclusive to SSHFP records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcdef1234567890</para>
                /// </summary>
                [NameInMap("Fingerprint")]
                [Validation(Required=false)]
                public string Fingerprint { get; set; }

                /// <summary>
                /// <para>The flag of the record. The Flag of a CAA record indicates its priority and processing method. Valid values: <b>0 to 255</b>. Exclusive to CAA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>128</para>
                /// </summary>
                [NameInMap("Flag")]
                [Validation(Required=false)]
                public int? Flag { get; set; }

                /// <summary>
                /// <para>The public key identifier of the record. Valid values: <b>0 to 65535</b>. Exclusive to CERT records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("KeyTag")]
                [Validation(Required=false)]
                public int? KeyTag { get; set; }

                /// <summary>
                /// <para>The algorithm strategy used by the record for matching or verifying certificates. Valid values: <b>0 to 255</b>. Exclusive to SMIMEA and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MatchingType")]
                [Validation(Required=false)]
                public int? MatchingType { get; set; }

                /// <summary>
                /// <para>The port of the record. Valid values: <b>0 to 65535</b>. Exclusive to SRV records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The priority of the record. Valid values: <b>0 to 65535</b>. A smaller value indicates a higher priority. Exclusive to MX, SRV, and URI records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The type of certificate or public key used by the record. Valid values: <b>0 to 255</b>. Exclusive to SMIMEA and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Selector")]
                [Validation(Required=false)]
                public int? Selector { get; set; }

                /// <summary>
                /// <para>The tag of the record. The Tag of a CAA record indicates its specific type and purpose. Exclusive to CAA records.</para>
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
                /// <para>{\&quot;Name\&quot;:\&quot;PARAMETER\&quot;}</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public Dictionary<string, object> Tags { get; set; }

                /// <summary>
                /// <para>The certificate type of the record (in CERT records), or the public key type (in SSHFP records).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <para>The usage identifier of the record. Valid values: <b>0 to 255</b>. Exclusive to SMIMEA and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public int? Usage { get; set; }

                /// <summary>
                /// <para>The record value or partial content. This parameter is included in A/AAAA, CNAME, NS, MX, TXT, CAA, SRV, and URI records. It has different meanings for different record types:</para>
                /// <list type="bullet">
                /// <item><description><b>A/AAAA</b>: The IP address pointed to. When there are multiple IPs, they are separated by commas (,). At least one IPv4 address is required.</description></item>
                /// <item><description><b>CNAME</b>: The target domain name pointed to.</description></item>
                /// <item><description><b>NS</b>: The name server for the specified domain.</description></item>
                /// <item><description><b>MX</b>: A valid target mail server domain name.</description></item>
                /// <item><description><b>TXT</b>: A valid text string.</description></item>
                /// <item><description><b>CAA</b>: A valid certificate authority domain name.</description></item>
                /// <item><description><b>SRV</b>: A valid target host domain name.</description></item>
                /// <item><description><b>URI</b>: A valid URI string.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CNAME</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The weight of the record. Valid values: <b>0 to 65535</b>. Exclusive to SRV and URI records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The origin host policy. This takes effect when the record type is CNAME. It sets the policy for the host header used during origin requests. Two modes are available:</para>
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
            /// <para>Indicates whether proxy acceleration is enabled for the record. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Proxy enabled.</description></item>
            /// <item><description><b>false</b>: Proxy acceleration disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Proxied")]
            [Validation(Required=false)]
            public bool? Proxied { get; set; }

            /// <summary>
            /// <para>The CNAME of the record. This is the CNAME value that needs to be configured for the record when the site access method is CNAME access.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a.example.com.cnamezone.com</para>
            /// </summary>
            [NameInMap("RecordCname")]
            [Validation(Required=false)]
            public string RecordCname { get; set; }

            /// <summary>
            /// <para>The record ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890123</para>
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            /// <summary>
            /// <para>The record name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a.example.com</para>
            /// </summary>
            [NameInMap("RecordName")]
            [Validation(Required=false)]
            public string RecordName { get; set; }

            /// <summary>
            /// <para>The origin type of the CNAME record. This parameter is required when adding a CNAME record. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>OSS</b>: OSS origin.</description></item>
            /// <item><description><b>S3</b>: S3 origin.</description></item>
            /// <item><description><b>LB</b>: Load balancer origin.</description></item>
            /// <item><description><b>OP</b>: Origin pool.</description></item>
            /// <item><description><b>Domain</b>: Standard domain origin.</description></item>
            /// </list>
            /// <para>If this parameter is not specified or left empty, the default value is Domain, which indicates a standard domain origin type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("RecordSourceType")]
            [Validation(Required=false)]
            public string RecordSourceType { get; set; }

            /// <summary>
            /// <para>The DNS type of the record, such as <b>A/AAAA, CNAME, TXT</b>, etc.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A/AAAA</para>
            /// </summary>
            [NameInMap("RecordType")]
            [Validation(Required=false)]
            public string RecordType { get; set; }

            /// <summary>
            /// <para>The ID of the site to which the record belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890123</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            /// <summary>
            /// <para>The name of the site to which the record belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("SiteName")]
            [Validation(Required=false)]
            public string SiteName { get; set; }

            /// <summary>
            /// <para>The TTL (Time to Live) of the record, in seconds. When the value is 1, it indicates that the TTL is set to automatic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public long? Ttl { get; set; }

            /// <summary>
            /// <para>The update time of the record. The date format follows the ISO 8601 standard and uses UTC time in the format of yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-07T10:02:59Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
