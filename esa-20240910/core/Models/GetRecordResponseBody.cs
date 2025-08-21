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
            /// <para>The origin authentication information of the CNAME record.</para>
            /// </summary>
            [NameInMap("AuthConf")]
            [Validation(Required=false)]
            public GetRecordResponseBodyRecordModelAuthConf AuthConf { get; set; }
            public class GetRecordResponseBodyRecordModelAuthConf : TeaModel {
                /// <summary>
                /// <para>The access key ID of the account to which the origin server belongs. This parameter is returned if the origin type is OSS and AuthType is set to private_cross_account, or the origin type is S3 and AuthType is set to private.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VIxuvJSA2S03f******kp208dy5w7</para>
                /// </summary>
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// <para>The authentication type of the origin server. Different origins support different authentication types. The origin type refers to the SourceType parameter in this operation. This parameter is returned if the origin type is OSS or S3Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>public</b>: public read. This value is returned when the origin is a public OSS or S3 bucket.</description></item>
                /// <item><description><b>private</b>: private read. This value is returned when the origin is a private S3 bucket.</description></item>
                /// <item><description><b>private_same_account</b>: private read in the same account. This value is returned when the origin is a private OSS bucket in your account.</description></item>
                /// <item><description><b>private_cross_account</b>: private read across accounts. This value is returned when the origin is a private OSS bucket in a different Alibaba Cloud account.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// <para>The region of the origin. If the origin type is S3, you must specify this value. You can obtain the region information from the official website of S3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>us-east-1</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The secret access key of the account to which the origin server belongs. This parameter is returned if the origin type is OSS and AuthType is set to private_cross_account, or the origin type is S3 and AuthType is set to private.SecretKey</para>
                /// 
                /// <b>Example:</b>
                /// <para>u0Nkg5gBK*******QF5wvKMM504JUHt</para>
                /// </summary>
                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                /// <summary>
                /// <para>The version of the signature algorithm. This parameter is returned when the origin type is S3 and AuthType is private. The following two types are supported:</para>
                /// <list type="bullet">
                /// <item><description><b>v2</b></description></item>
                /// <item><description><b>v4</b></description></item>
                /// </list>
                /// <para>If this parameter is left empty, the default value v4 is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v2</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The business scenario of the record for acceleration. Leave this parameter empty if your record is not proxied. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>image_video</b></description></item>
            /// <item><description><b>api</b></description></item>
            /// <item><description><b>web</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>image_video</para>
            /// </summary>
            [NameInMap("BizName")]
            [Validation(Required=false)]
            public string BizName { get; set; }

            /// <summary>
            /// <para>The comments of the record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a comment.</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The time when the record was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-10T13:30:39Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The DNS record information. The content returned by this parameter varies based on the record type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;value&quot;:&quot;1.1.1.1&quot;}</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public GetRecordResponseBodyRecordModelData Data { get; set; }
            public class GetRecordResponseBodyRecordModelData : TeaModel {
                /// <summary>
                /// <para>The encryption algorithm used for the record, specified within the range from 0 to 255. This parameter is required when you add CERT or SSHFP records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Algorithm")]
                [Validation(Required=false)]
                public int? Algorithm { get; set; }

                /// <summary>
                /// <para>The public key of the certificate. This parameter is required when you add CERT, SMIMEA, or TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dGVzdGFkYWxrcw==</para>
                /// </summary>
                [NameInMap("Certificate")]
                [Validation(Required=false)]
                public string Certificate { get; set; }

                /// <summary>
                /// <para>The public key fingerprint of the record. This parameter is required when you add a SSHFP record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcdef1234567890</para>
                /// </summary>
                [NameInMap("Fingerprint")]
                [Validation(Required=false)]
                public string Fingerprint { get; set; }

                /// <summary>
                /// <para>The flag bit of the record. The Flag for a CAA record indicates its priority and how it is processed, specified within the range of 0 to 255. This parameter is required when you add a CAA record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>128</para>
                /// </summary>
                [NameInMap("Flag")]
                [Validation(Required=false)]
                public int? Flag { get; set; }

                /// <summary>
                /// <para>The public key identification for the record. Valid values: 0 to 65535. This parameter is required when you add a CAA record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("KeyTag")]
                [Validation(Required=false)]
                public int? KeyTag { get; set; }

                /// <summary>
                /// <para>The algorithm policy used to match or validate the certificate, specified within the range 0 to 255. This parameter is required when you add SMIMEA or TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MatchingType")]
                [Validation(Required=false)]
                public int? MatchingType { get; set; }

                /// <summary>
                /// <para>The port of the record. Valid values: 0 to 65535. This parameter is required when you add an SRV record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8707</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The priority of the record. Valid values: 0 to 65535. A smaller value indicates a higher priority. This parameter is required when you add MX, SRV, and URI records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The type of the certificate or public key, specified within the range of 0 to 255. This parameter is required when you add SMIMEA or TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Selector")]
                [Validation(Required=false)]
                public int? Selector { get; set; }

                /// <summary>
                /// <para>The tag of the record. The Tag of a CAA record indicate its specific type and usage.</para>
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
                /// <para>The certificate type of the record (in CERT records), or the public key type (in SSHFP records). This parameter is required when you add CERT or SSHFP records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RSA</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <para>The usage identifier of the record, specified within the range of 0 to 255. This parameter is required when you add SMIMEA or TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public int? Usage { get; set; }

                /// <summary>
                /// <para>The record value or part of the record content. This parameter is returned when you add A/AAAA, CNAME, NS, MX, TXT, CAA, SRV, and URI records. It has different meanings based on types of records.</para>
                /// <list type="bullet">
                /// <item><description><b>A/AAAA</b>: the IP address. Multiple IP addresses are separated with commas (,). There is at least one IPv4 address.</description></item>
                /// <item><description><b>CNAME</b>: the target domain name.</description></item>
                /// <item><description><b>NS</b>: the nameserver for the domain name.</description></item>
                /// <item><description><b>MX</b>: a valid domain name of the target mail server.</description></item>
                /// <item><description><b>TXT</b>: a valid text string.</description></item>
                /// <item><description><b>CAA</b>: a valid domain name of the certificate authority.</description></item>
                /// <item><description><b>SRV</b>: a valid domain name of the target host.</description></item>
                /// <item><description><b>URI</b>: a valid URI string.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The weight of the record, specified within the range of 0 to 65535. This parameter is required when you add SRV or URI records.</para>
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
            /// <para>Indicates whether the record is proxied. Only CNAME and A/AAAA records can be proxied. Valid values:</para>
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
            /// <para>The origin type for the CNAME record. This parameter is required when you add a CNAME record. Valid values:</para>
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
            /// <para>The type of the DNS record, such as <b>A/AAAA, CNAME, and TXT</b>.</para>
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
            /// <para>20</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            /// <summary>
            /// <para>The time when the record was updated. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
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
