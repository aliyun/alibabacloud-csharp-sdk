// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>A list of DNS records. For details, see the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/document_detail/2708761.html">documentation</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/doc-detail/2708761.html">documentation</a>.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<ListRecordsResponseBodyRecords> Records { get; set; }
        public class ListRecordsResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>The origin authentication settings for the CNAME record.</para>
            /// </summary>
            [NameInMap("AuthConf")]
            [Validation(Required=false)]
            public ListRecordsResponseBodyRecordsAuthConf AuthConf { get; set; }
            public class ListRecordsResponseBodyRecordsAuthConf : TeaModel {
                /// <summary>
                /// <para>The AccessKey for the account that owns the origin server. This parameter is required if the origin type is OSS and the authentication type is <c>private_cross_account</c>, or if the origin type is S3 and the authentication type is <c>private</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>u0Nkg5gBK***QF5wvKMM504JUHt</para>
                /// </summary>
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// <para>The origin authentication type. The available authentication types depend on the origin type, which is specified by the <c>RecordSourceType</c> parameter. This parameter is required if the origin type is OSS or S3. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>public</b>: Public read. Use this value if the origin type is OSS or S3 and the origin server allows public read access.</para>
                /// </description></item>
                /// <item><description><para><b>private</b>: Private read. Use this value if the origin type is S3 and the origin server requires private read access.</para>
                /// </description></item>
                /// <item><description><para><b>private_same_account</b>: Private read within the same account. Use this value if the origin type is OSS, the origin server is in the same Alibaba Cloud account, and requires private read access.</para>
                /// </description></item>
                /// <item><description><para><b>private_cross_account</b>: Private read across different accounts. Use this value if the origin type is OSS, the origin server is in a different Alibaba Cloud account, and requires private read access.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>private</para>
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// <para>The region where the origin server is located. This parameter is required if the origin type is S3. For valid region names, refer to the official S3 documentation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>us-east-1</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The SecretKey for the account that owns the origin server. This parameter is required if the origin type is OSS and the authentication type is <c>private_cross_account</c>, or if the origin type is S3 and the authentication type is <c>private</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VIxuvJSA2S03f***kp208dy5w7</para>
                /// </summary>
                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                /// <summary>
                /// <para>The signature algorithm version. This parameter is required if the origin type is S3 and the authentication type is <c>private</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>v2</b></para>
                /// </description></item>
                /// <item><description><para><b>v4</b></para>
                /// </description></item>
                /// </list>
                /// <para>The default is <c>v4</c>.</para>
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
            /// <item><description><para><b>image_video</b>: Images and videos.</para>
            /// </description></item>
            /// <item><description><para><b>api</b>: API.</para>
            /// </description></item>
            /// <item><description><para><b>web</b>: Web page.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>web</para>
            /// </summary>
            [NameInMap("BizName")]
            [Validation(Required=false)]
            public string BizName { get; set; }

            /// <summary>
            /// <para>The record\&quot;s comment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>this is a remark.</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The UTC time when the record was created, in ISO 8601 format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
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
            /// <para>The DNS details of the record. The fields in this object vary based on the record type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;value&quot;:&quot;1.1.1.1&quot;}</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public ListRecordsResponseBodyRecordsData Data { get; set; }
            public class ListRecordsResponseBodyRecordsData : TeaModel {
                /// <summary>
                /// <para>The encryption algorithm for the record. The value ranges from <b>0 to 255</b>. This parameter is valid only for CERT and SSHFP records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Algorithm")]
                [Validation(Required=false)]
                public int? Algorithm { get; set; }

                /// <summary>
                /// <para>The public key certificate. This parameter is valid only for CERT, SMIMEA, and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dGVzdGFkYWxrcw==</para>
                /// </summary>
                [NameInMap("Certificate")]
                [Validation(Required=false)]
                public string Certificate { get; set; }

                /// <summary>
                /// <para>The public key fingerprint. This parameter is valid only for SSHFP records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcdef1234567890</para>
                /// </summary>
                [NameInMap("Fingerprint")]
                [Validation(Required=false)]
                public string Fingerprint { get; set; }

                /// <summary>
                /// <para>The record\&quot;s flag. For a CAA record, the flag determines how a certificate authority (CA) processes the record. The value ranges from <b>0 to 255</b>. This parameter applies only to CAA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>128</para>
                /// </summary>
                [NameInMap("Flag")]
                [Validation(Required=false)]
                public int? Flag { get; set; }

                /// <summary>
                /// <para>The public key identifier. The value ranges from <b>0 to 65535</b>. This parameter is valid only for CERT records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("KeyTag")]
                [Validation(Required=false)]
                public int? KeyTag { get; set; }

                /// <summary>
                /// <para>The algorithm policy for matching or validating certificates. The value ranges from <b>0 to 255</b>. This parameter is valid only for SMIMEA and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MatchingType")]
                [Validation(Required=false)]
                public int? MatchingType { get; set; }

                /// <summary>
                /// <para>The port number, which must be an integer from <b>0 to 65535</b>. This parameter applies only to SRV records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The priority of the record, which must be an integer from <b>0 to 65535</b>. A lower value indicates a higher priority. This parameter applies only to MX, SRV, and URI records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The type of certificate or public key for the record. The value ranges from <b>0 to 255</b>. This parameter is valid only for SMIMEA and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Selector")]
                [Validation(Required=false)]
                public int? Selector { get; set; }

                /// <summary>
                /// <para>The record\&quot;s tag. For a CAA record, the tag indicates its specific type and purpose. This parameter is valid only for CAA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>issue</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

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
                /// <para>The usage identifier. The value ranges from <b>0 to 255</b>. This parameter is valid only for SMIMEA and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public int? Usage { get; set; }

                /// <summary>
                /// <para>The value of the record. This parameter applies to A/AAAA, CNAME, NS, MX, TXT, CAA, SRV, and URI records. The meaning of this parameter varies based on the record type:</para>
                /// <list type="bullet">
                /// <item><description><para><b>A/AAAA</b>: The target IP address. Use an IPv4 address for an A record and an IPv6 address for an AAAA record.</para>
                /// </description></item>
                /// <item><description><para><b>CNAME</b>: The target domain name.</para>
                /// </description></item>
                /// <item><description><para><b>NS</b>: The name server for the specified domain.</para>
                /// </description></item>
                /// <item><description><para><b>MX</b>: The domain name of the target mail server.</para>
                /// </description></item>
                /// <item><description><para><b>TXT</b>: A text string.</para>
                /// </description></item>
                /// <item><description><para><b>CAA</b>: The domain name of the certificate authority.</para>
                /// </description></item>
                /// <item><description><para><b>SRV</b>: The domain name of the target host.</para>
                /// </description></item>
                /// <item><description><para><b>URI</b>: A URI string.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CNAME</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The weight of the record, which must be an integer from <b>0 to 65535</b>. This parameter applies only to SRV and URI records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The policy for the <c>HOST</c> header in back-to-origin requests. This parameter applies only to CNAME records. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>follow_hostname</b>: Uses the <c>HOST</c> header of the incoming request.</para>
            /// </description></item>
            /// <item><description><para><b>follow_origin_domain</b>: Uses the domain name of the origin server.</para>
            /// </description></item>
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
            /// <item><description><para><b>true</b>: Proxy acceleration is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Proxy acceleration is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Proxied")]
            [Validation(Required=false)]
            public bool? Proxied { get; set; }

            /// <summary>
            /// <para>The CNAME value assigned to this record. To enable the service, create a CNAME record in your DNS provider\&quot;s settings that points to this value.</para>
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
            /// <para>The type of origin for the CNAME record. This parameter is required when you add a CNAME record. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>OSS</b>: OSS origin.</para>
            /// </description></item>
            /// <item><description><para><b>S3</b>: S3 origin.</para>
            /// </description></item>
            /// <item><description><para><b>LB</b>: Load balancer origin.</para>
            /// </description></item>
            /// <item><description><para><b>OP</b>: Origin pool.</para>
            /// </description></item>
            /// <item><description><para><b>Domain</b>: Domain origin.</para>
            /// </description></item>
            /// </list>
            /// <para>If this parameter is not specified, the default value is <c>Domain</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("RecordSourceType")]
            [Validation(Required=false)]
            public string RecordSourceType { get; set; }

            /// <summary>
            /// <para>The DNS record type, such as <b>A/AAAA, CNAME, and TXT</b>.</para>
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
            /// <para>The Time to Live (TTL) for the record, in seconds. A value of 1 indicates that the TTL is automatic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public long? Ttl { get; set; }

            /// <summary>
            /// <para>The UTC time when the record was last updated, in ISO 8601 format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
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
