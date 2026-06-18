// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the record.</para>
        /// </summary>
        [NameInMap("RecordModel")]
        [Validation(Required=false)]
        public GetRecordResponseBodyRecordModel RecordModel { get; set; }
        public class GetRecordResponseBodyRecordModel : TeaModel {
            /// <summary>
            /// <para>The origin authentication settings for the CNAME record.</para>
            /// </summary>
            [NameInMap("AuthConf")]
            [Validation(Required=false)]
            public GetRecordResponseBodyRecordModelAuthConf AuthConf { get; set; }
            public class GetRecordResponseBodyRecordModelAuthConf : TeaModel {
                /// <summary>
                /// <para>The AccessKey ID of the account that owns the origin.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VIxuvJSA2S03f******kp208dy5w7</para>
                /// </summary>
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// <para>The origin authentication type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>public</b>: Public read. Select this value when the origin is an OSS or S3 origin with public read access.</para>
                /// </description></item>
                /// <item><description><para><b>private</b>: Private read. Select this value when the origin is an S3 origin with private read access.</para>
                /// </description></item>
                /// <item><description><para><b>private_same_account</b>: Private read within the same account. Select this value when the origin is an OSS origin with private read access under the same Alibaba Cloud account.</para>
                /// </description></item>
                /// <item><description><para><b>private_cross_account</b>: Private read across accounts. Select this value when the origin is an OSS origin with private read access under a different Alibaba Cloud account.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// <para>The origin\&quot;s region. For S3 origins, you can find region codes on the official S3 website.</para>
                /// 
                /// <b>Example:</b>
                /// <para>us-east-1</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The AccessKey secret of the account that owns the origin.</para>
                /// 
                /// <b>Example:</b>
                /// <para>u0Nkg5gBK*******QF5wvKMM504JUHt</para>
                /// </summary>
                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                /// <summary>
                /// <para>The version of the signature algorithm. Supported versions:</para>
                /// <list type="bullet">
                /// <item><description><para><b>v2</b></para>
                /// </description></item>
                /// <item><description><para><b>v4</b></para>
                /// </description></item>
                /// </list>
                /// <para>If unspecified, the default is <c>v4</c>.</para>
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
            /// <item><description><para><b>image_video</b>: Images and videos.</para>
            /// </description></item>
            /// <item><description><para><b>api</b>: APIs.</para>
            /// </description></item>
            /// <item><description><para><b>web</b>: Web pages.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>image_video</para>
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
            /// <para>The time when the record was created. The time is in UTC and follows the ISO 8601 standard. Format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-10T13:30:39Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CustomPort")]
            [Validation(Required=false)]
            public string CustomPort { get; set; }

            /// <summary>
            /// <para>DNS information for the record. The content varies based on the record type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;value&quot;:&quot;1.1.1.1&quot;}</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public GetRecordResponseBodyRecordModelData Data { get; set; }
            public class GetRecordResponseBodyRecordModelData : TeaModel {
                /// <summary>
                /// <para>The encryption algorithm of the record, from <b>0</b> to <b>255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Algorithm")]
                [Validation(Required=false)]
                public int? Algorithm { get; set; }

                /// <summary>
                /// <para>The record\&quot;s public key certificate.</para>
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
                /// <para>The flag of the record. For CAA records, this flag indicates the priority and processing method. The value must be from <b>0</b> to <b>255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>128</para>
                /// </summary>
                [NameInMap("Flag")]
                [Validation(Required=false)]
                public int? Flag { get; set; }

                /// <summary>
                /// <para>The public key identifier of the record, from <b>0</b> to <b>65535</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("KeyTag")]
                [Validation(Required=false)]
                public int? KeyTag { get; set; }

                /// <summary>
                /// <para>The algorithm policy for matching or verifying the certificate, from <b>0</b> to <b>255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MatchingType")]
                [Validation(Required=false)]
                public int? MatchingType { get; set; }

                /// <summary>
                /// <para>The port of the record, from <b>0</b> to <b>65535</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8707</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The priority of the record, from <b>0</b> to <b>65535</b>. A lower value indicates a higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The record\&quot;s certificate or public key type, from <b>0</b> to <b>255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Selector")]
                [Validation(Required=false)]
                public int? Selector { get; set; }

                /// <summary>
                /// <para>The tag of the record. For CAA records, the tag indicates the specific type and purpose.</para>
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
                /// <para>RSA</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <para>The usage identifier of the record, from <b>0</b> to <b>255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public int? Usage { get; set; }

                /// <summary>
                /// <para>The record value. The meaning of this parameter varies by the record type:</para>
                /// <list type="bullet">
                /// <item><description><para><b>A/AAAA</b>: The target IP address. Separate multiple IP addresses with a comma (<c>,</c>). Requires at least one IPv4 address.</para>
                /// </description></item>
                /// <item><description><para><b>CNAME</b>: The target domain name.</para>
                /// </description></item>
                /// <item><description><para><b>NS</b>: The name server for the specified domain.</para>
                /// </description></item>
                /// <item><description><para><b>MX</b>: A valid target mail server domain name.</para>
                /// </description></item>
                /// <item><description><para><b>TXT</b>: A valid text string.</para>
                /// </description></item>
                /// <item><description><para><b>CAA</b>: A valid Certificate Authority domain name.</para>
                /// </description></item>
                /// <item><description><para><b>SRV</b>: A valid target host domain name.</para>
                /// </description></item>
                /// <item><description><para><b>URI</b>: A valid URI string.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The weight of the record, from <b>0</b> to <b>65535</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>Specifies the policy for the <c>Host</c> header during origin-pull. This parameter applies only to CNAME records. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>follow_hostname</b>: Follows the host record.</para>
            /// </description></item>
            /// <item><description><para><b>follow_origin_domain</b>: Follows the origin domain.</para>
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
            /// <para>Indicates whether the proxy is enabled for the record. This feature is supported only for A, AAAA, and CNAME records. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The proxy is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The proxy is disabled.</para>
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
            /// <para>The CNAME of the record.</para>
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
            /// <para>The origin type for CNAME records. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>OSS</b>: OSS origin.</para>
            /// </description></item>
            /// <item><description><para><b>S3</b>: S3 origin.</para>
            /// </description></item>
            /// <item><description><para><b>LB</b>: A load balancer.</para>
            /// </description></item>
            /// <item><description><para><b>OP</b>: An origin pool.</para>
            /// </description></item>
            /// <item><description><para><b>Domain</b>: A standard domain.</para>
            /// </description></item>
            /// </list>
            /// <para>If unspecified, the default is <c>Domain</c>.</para>
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
            /// <para>The site ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890123</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            /// <summary>
            /// <para>The site name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("SiteName")]
            [Validation(Required=false)]
            public string SiteName { get; set; }

            /// <summary>
            /// <para>The record\&quot;s Time to Live (TTL) in seconds. A value of 1 indicates an automatic TTL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            /// <summary>
            /// <para>The time when the record was last updated. The time is in UTC and follows the ISO 8601 standard. Format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
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
