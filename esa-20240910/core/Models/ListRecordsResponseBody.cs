// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number. The value is the same as the PageNumber request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The DNS information of the records. For more information, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/document_detail/2708761.html">Documentation</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/doc-detail/2708761.html">Documentation</a>.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<ListRecordsResponseBodyRecords> Records { get; set; }
        public class ListRecordsResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>The origin server authentication information of the CNAME record.</para>
            /// </summary>
            [NameInMap("AuthConf")]
            [Validation(Required=false)]
            public ListRecordsResponseBodyRecordsAuthConf AuthConf { get; set; }
            public class ListRecordsResponseBodyRecordsAuthConf : TeaModel {
                /// <summary>
                /// <para>The AccessKey ID of the account to which the origin server belongs. This parameter is returned when the origin server type is OSS and the origin server authentication type is private read across accounts, or when the origin server type is S3 and the origin server authentication type is private read.</para>
                /// 
                /// <b>Example:</b>
                /// <para>u0Nkg5gBK***QF5wvKMM504JUHt</para>
                /// </summary>
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// <para>The origin server authentication type. Different origin server types support different authentication types. The origin server type refers to the SourceType parameter in this operation. When the origin server type is OSS or S3, you must specify the origin server authentication type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>public</b>: Public read. This value is used when the origin server type is OSS or S3 and the origin server allows public read access.</description></item>
                /// <item><description><b>private</b>: Private read. This value is used when the origin server type is S3 and the origin server allows private read access.</description></item>
                /// <item><description><b>private_same_account</b>: Private read within the same account. This value is used when the origin server type is OSS, the origin server and the current service are within the same Alibaba Cloud account, and the origin server allows private read access.</description></item>
                /// <item><description><b>private_cross_account</b>: Private read across accounts. This value is used when the origin server type is OSS, the origin server and the current service are within different Alibaba Cloud accounts, and the origin server allows private read access.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>private</para>
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// <para>The region to which the origin server belongs. This parameter is returned when the origin server type is S3. You can obtain the region information from the official website of S3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>us-east-1</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The AccessKey secret of the account to which the origin server belongs. This parameter is returned when the origin server type is OSS and the origin server authentication type is private read across accounts, or when the origin server type is S3 and the origin server authentication type is private read.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VIxuvJSA2S03f***kp208dy5w7</para>
                /// </summary>
                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                /// <summary>
                /// <para>The signature algorithm version. This parameter is returned when the origin server type is S3 and the origin server authentication type is private read. Valid values:</para>
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
            /// <para>The business scenario for record acceleration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>image_video</b>: images and videos</description></item>
            /// <item><description><b>api</b>: APIs</description></item>
            /// <item><description><b>web</b>: web pages</description></item>
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
            /// <para>this is a remark.</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The creation time of the record. The time is displayed in UTC and follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-24T02:01:11Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Specifies whether a custom port is enabled for the record. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled</description></item>
            /// <item><description>off: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("CustomPort")]
            [Validation(Required=false)]
            public string CustomPort { get; set; }

            /// <summary>
            /// <para>The specific DNS information of the record. Different types of records contain different information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;value&quot;:&quot;1.1.1.1&quot;}</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public ListRecordsResponseBodyRecordsData Data { get; set; }
            public class ListRecordsResponseBodyRecordsData : TeaModel {
                /// <summary>
                /// <para>The encryption algorithm used by the record. Valid values: <b>0</b> to <b>255</b>. This parameter is exclusive to CERT and SSHFP records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Algorithm")]
                [Validation(Required=false)]
                public int? Algorithm { get; set; }

                /// <summary>
                /// <para>The public key certificate information of the record. This parameter is exclusive to CERT, SMIMEA, and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dGVzdGFkYWxrcw==</para>
                /// </summary>
                [NameInMap("Certificate")]
                [Validation(Required=false)]
                public string Certificate { get; set; }

                /// <summary>
                /// <para>The public key fingerprint value of the record. This parameter is exclusive to SSHFP records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcdef1234567890</para>
                /// </summary>
                [NameInMap("Fingerprint")]
                [Validation(Required=false)]
                public string Fingerprint { get; set; }

                /// <summary>
                /// <para>The flag of the record. For CAA records, the flag indicates the priority and processing method. Valid values: <b>0</b> to <b>255</b>. This parameter is exclusive to CAA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>128</para>
                /// </summary>
                [NameInMap("Flag")]
                [Validation(Required=false)]
                public int? Flag { get; set; }

                /// <summary>
                /// <para>The public key tag of the record. Valid values: <b>0</b> to <b>65535</b>. This parameter is exclusive to CERT records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("KeyTag")]
                [Validation(Required=false)]
                public int? KeyTag { get; set; }

                /// <summary>
                /// <para>The algorithm policy used by the record to match or verify the certificate. Valid values: <b>0</b> to <b>255</b>. This parameter is exclusive to SMIMEA and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MatchingType")]
                [Validation(Required=false)]
                public int? MatchingType { get; set; }

                /// <summary>
                /// <para>The port of the record. Valid values: <b>0</b> to <b>65535</b>. This parameter is exclusive to SRV records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The priority of the record. Valid values: <b>0</b> to <b>65535</b>. A smaller value indicates a higher priority. This parameter is exclusive to MX, SRV, and URI records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The type of the certificate or public key used by the record. Valid values: <b>0</b> to <b>255</b>. This parameter is exclusive to SMIMEA and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Selector")]
                [Validation(Required=false)]
                public int? Selector { get; set; }

                /// <summary>
                /// <para>The tag of the record. For CAA records, the tag indicates the specific type and usage. This parameter is exclusive to CAA records.</para>
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
                /// <para>The certificate type of the record in CERT records, or the public key type in SSHFP records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <para>The usage identifier of the record. Valid values: <b>0</b> to <b>255</b>. This parameter is exclusive to SMIMEA and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public int? Usage { get; set; }

                /// <summary>
                /// <para>The record value or partial content. This parameter is included in A, AAAA, CNAME, NS, MX, TXT, CAA, SRV, and URI records. It indicates different meanings in different types of records:</para>
                /// <list type="bullet">
                /// <item><description><b>A/AAAA</b>: The destination IP address. If multiple IP addresses are specified, separate them with commas (,). At least one IPv4 address is required.</description></item>
                /// <item><description><b>CNAME</b>: The destination domain name.</description></item>
                /// <item><description><b>NS</b>: The name server of the specified domain name.</description></item>
                /// <item><description><b>MX</b>: The valid destination mail server domain name.</description></item>
                /// <item><description><b>TXT</b>: The valid text string.</description></item>
                /// <item><description><b>CAA</b>: The valid certification authority domain name.</description></item>
                /// <item><description><b>SRV</b>: The valid destination host domain name.</description></item>
                /// <item><description><b>URI</b>: The valid URI string.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CNAME</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The weight of the record. Valid values: <b>0</b> to <b>65535</b>. This parameter is exclusive to SRV and URI records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The back-to-origin host policy. This policy takes effect when the record type is CNAME. Settings for the host policy in back-to-origin requests include two patterns:</para>
            /// <list type="bullet">
            /// <item><description><b>follow_hostname</b>: follow the request host</description></item>
            /// <item><description><b>follow_origin_domain</b>: follow the Origin Domain Name</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>follow_origin_domain</para>
            /// </summary>
            [NameInMap("HostPolicy")]
            [Validation(Required=false)]
            public string HostPolicy { get; set; }

            /// <summary>
            /// <para>The HTTP port. Port 80 is supported by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80,8080,8880,2052,2082,2086,2095</para>
            /// </summary>
            [NameInMap("HttpPorts")]
            [Validation(Required=false)]
            public string HttpPorts { get; set; }

            /// <summary>
            /// <para>The HTTPS port. Port 443 is supported by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443,2053,2083,2087,2096,8443</para>
            /// </summary>
            [NameInMap("HttpsPorts")]
            [Validation(Required=false)]
            public string HttpsPorts { get; set; }

            /// <summary>
            /// <para>Specifies whether proxy acceleration is enabled for the record. Valid values:</para>
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
            /// <para>The CNAME of the record. If the site is onboarded by using CNAME access, you must configure this CNAME value for the record.</para>
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
            /// <para>The origin server type of the CNAME record. This parameter is required when you add a CNAME record. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>OSS</b>: OSS origin server</description></item>
            /// <item><description><b>S3</b>: S3 origin server</description></item>
            /// <item><description><b>LB</b>: load balancing origin server</description></item>
            /// <item><description><b>OP</b>: IPAM pool origin server</description></item>
            /// <item><description><b>Domain</b>: regular domain name origin server</description></item>
            /// </list>
            /// <para>If this parameter is not specified or is left empty, the default value is Domain, which indicates a regular domain name origin server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("RecordSourceType")]
            [Validation(Required=false)]
            public string RecordSourceType { get; set; }

            /// <summary>
            /// <para>The DNS type of the record, such as <b>A/AAAA</b>, <b>CNAME</b>, or <b>TXT</b>.</para>
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
            /// <para>The time-to-live (TTL) of the record, in seconds. A value of 1 indicates that the TTL is automatic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public long? Ttl { get; set; }

            /// <summary>
            /// <para>The update time of the record. The time is displayed in UTC and follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
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
