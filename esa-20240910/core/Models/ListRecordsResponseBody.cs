// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The DNS record information. The format of this field varies based on the record type. For more information, see Add DNS records.</para>
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
                /// <para>The access key of the account to which the origin server belongs. This value is returned when the SourceType is OSS, and AuthType is private_cross_account, or when the SourceType is S3 and AuthType is private.</para>
                /// 
                /// <b>Example:</b>
                /// <para>u0Nkg5gBK***QF5wvKMM504JUHt</para>
                /// </summary>
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// <para>The authentication type of the origin server. Different origins support different authentication types. The type of origin refers to the SourceType parameter in this operation. If the type of origin is OSS or S3, the authentication type of the origin must be specified. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>public</b>: public read. This value is returned when the origin is a public OSS or S3 bucket.</description></item>
                /// <item><description><b>private</b>: private read. This value is returned when the origin is a private S3 bucket.</description></item>
                /// <item><description><b>private_same_account</b>: private read under the same account. This value is returned when the origin is a private OSS bucket in your Alibaba Cloud account.</description></item>
                /// <item><description><b>private_cross_account</b>: private read across accounts. This value is returned when the origin is a private OSS bucket in a different Alibaba Cloud account.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>private</para>
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// <para>The region of the origin. This parameter is returned if the origin type is S3. You can get the region information from the official website of Amazon S3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>us-east-1</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The secret access key of the account to which the origin server belongs. This value is returned when the SourceType is OSS, and AuthType is private_same_account, or when the SourceType is S3 and AuthType is private.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VIxuvJSA2S03f***kp208dy5w7</para>
                /// </summary>
                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                /// <summary>
                /// <para>The version of the signature algorithm. This value is returned when the origin type is S3 and AuthType is private. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>v2</b></description></item>
                /// <item><description><b>v4</b></description></item>
                /// </list>
                /// <para>If this parameter is left empty, the default value v4 is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v4</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The business scenario of the record for acceleration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>image_video</b>: video and image.</description></item>
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
            /// <para>The comments of the record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>this is a remark.</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The time when the record was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-24T02:01:11Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The DNS record information. Different types of records contain different information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;value&quot;:&quot;1.1.1.1&quot;}</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public ListRecordsResponseBodyRecordsData Data { get; set; }
            public class ListRecordsResponseBodyRecordsData : TeaModel {
                /// <summary>
                /// <para>The encryption algorithm used for the record. Valid values: 0 to 255. Exclusive to CERT and SSHFP records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Algorithm")]
                [Validation(Required=false)]
                public int? Algorithm { get; set; }

                /// <summary>
                /// <para>The public key of the certificate. Exclusive to CERT, SMIMEA, and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dGVzdGFkYWxrcw==</para>
                /// </summary>
                [NameInMap("Certificate")]
                [Validation(Required=false)]
                public string Certificate { get; set; }

                /// <summary>
                /// <para>The public key fingerprint of the record. Exclusive to SSHFP records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcdef1234567890</para>
                /// </summary>
                [NameInMap("Fingerprint")]
                [Validation(Required=false)]
                public string Fingerprint { get; set; }

                /// <summary>
                /// <para>The flag bit of the record. The Flag for a CAA record indicates its priority and how it is processed. Valid values: 0 to 255. Exclusive to CAA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>128</para>
                /// </summary>
                [NameInMap("Flag")]
                [Validation(Required=false)]
                public int? Flag { get; set; }

                /// <summary>
                /// <para>The public key identification for the record. Valid values: 0 to 65535. Exclusive to CERT records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("KeyTag")]
                [Validation(Required=false)]
                public int? KeyTag { get; set; }

                /// <summary>
                /// <para>The algorithm policy used to match or validate the certificate. Valid values: 0 to 255. Exclusive to SMIMEA and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MatchingType")]
                [Validation(Required=false)]
                public int? MatchingType { get; set; }

                /// <summary>
                /// <para>The port of the record. Valid values: 0 to 65535. Exclusive to SRV records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The priority of the record. Valid values: 0 to 65535. A smaller value indicates a higher priority. Exclusive to MX, SRV, and URI records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The type of certificate or public key. Valid values: 0 to 255. Exclusive to SMIMEA, and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Selector")]
                [Validation(Required=false)]
                public int? Selector { get; set; }

                /// <summary>
                /// <para>The tag of the record. The Tag of a CAA record indicate its specific type and usage. Exclusive to CAA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>issue</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

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
                /// <para>The usage identifier of the record. Valid values: 0 to 255. Exclusive to SMIMEA, and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public int? Usage { get; set; }

                /// <summary>
                /// <para>Record value or part of the record content. This value is returned when the record is A/AAAA, CNAME, NS, MX, TXT, CAA, SRV, or URI. It has different meanings based on types of records:</para>
                /// <list type="bullet">
                /// <item><description><b>A/AAAA</b>: the IP addresses. IP addresses are separated by commas (,). There is at least one IPv4 address.</description></item>
                /// <item><description><b>CNAME</b>: the pointed/mapped domain name.</description></item>
                /// <item><description><b>NS</b>: the nameservers for the domain name.</description></item>
                /// <item><description><b>MX</b>: a valid domain name of the mail server.</description></item>
                /// <item><description><b>TXT</b>: a valid text string.</description></item>
                /// <item><description><b>CAA</b>: a valid domain name of the certificate authority.</description></item>
                /// <item><description><b>SRV</b>: a valid domain name of the target host.</description></item>
                /// <item><description><b>URI</b>: a valid URI string.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CNAME</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The weight of the record. Valid values: 0 to 65535. Exclusive to SRV and URI records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The origin host policy. This policy takes effect when the record type is CNAME. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>follow_hostname: matches the requested domain name.</description></item>
            /// <item><description>follow_origin_domain: matches the origin\&quot;s domain name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>follow_origin_domain</para>
            /// </summary>
            [NameInMap("HostPolicy")]
            [Validation(Required=false)]
            public string HostPolicy { get; set; }

            /// <summary>
            /// <para>Indicates whether the record is proxied. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Proxied")]
            [Validation(Required=false)]
            public bool? Proxied { get; set; }

            /// <summary>
            /// <para>The CNAME. If you use CNAME setup when you add your website to ESA, the value is the CNAME that you configured then.</para>
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
            /// <para>The origin type for the CNAME record. This parameter is returned when you add a CNAME record. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>OSS</b>: OSS bucket.</description></item>
            /// <item><description><b>S3</b>: S3 bucket.</description></item>
            /// <item><description><b>LB</b>: load balancer.</description></item>
            /// <item><description><b>OP</b>: origin pool.</description></item>
            /// <item><description><b>Domain</b>: domain name.</description></item>
            /// </list>
            /// <para>If you do not pass this parameter or if you leave its value empty, Domain is returned by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("RecordSourceType")]
            [Validation(Required=false)]
            public string RecordSourceType { get; set; }

            /// <summary>
            /// <para>The DNS type of the record, such as <b>A/AAAA, CNAME, and TXT</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A/AAAA</para>
            /// </summary>
            [NameInMap("RecordType")]
            [Validation(Required=false)]
            public string RecordType { get; set; }

            /// <summary>
            /// <para>The website ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890123</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            /// <summary>
            /// <para>The website name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("SiteName")]
            [Validation(Required=false)]
            public string SiteName { get; set; }

            /// <summary>
            /// <para>The TTL of the record. Unit: seconds. If the value is 1, the TTL of the record is determined by the system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public long? Ttl { get; set; }

            /// <summary>
            /// <para>The time when the record was updated. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
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
        /// <para>The total number of records returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
