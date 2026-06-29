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
            /// <para>The back-to-origin authentication information of the CNAME record.</para>
            /// </summary>
            [NameInMap("AuthConf")]
            [Validation(Required=false)]
            public GetRecordResponseBodyRecordModelAuthConf AuthConf { get; set; }
            public class GetRecordResponseBodyRecordModelAuthConf : TeaModel {
                /// <summary>
                /// <para>The AccessKey of the account to which the origin belongs.</para>
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
                /// <item><description><b>public</b>: public read. Select this value when the origin type is OSS or S3 and the origin has public read access.</description></item>
                /// <item><description><b>private</b>: private read. Select this value when the origin type is S3 and the origin has private read access.</description></item>
                /// <item><description><b>private_same_account</b>: private read within the same account. Select this value when the origin type is OSS, the origin is under the same Alibaba Cloud account, and the origin has private read access.</description></item>
                /// <item><description><b>private_cross_account</b>: private read across accounts. Select this value when the origin type is OSS, the origin is under a different Alibaba Cloud account, and the origin has private read access.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// <para>The region of the origin. Obtain the region from the official S3 website.</para>
                /// 
                /// <b>Example:</b>
                /// <para>us-east-1</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The AccessKey of the account to which the origin belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>u0Nkg5gBK*******QF5wvKMM504JUHt</para>
                /// </summary>
                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                /// <summary>
                /// <para>The signature algorithm version. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>v2</b></description></item>
                /// <item><description><b>v4</b></description></item>
                /// </list>
                /// <para>Default value: v4.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v2</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The business scenario when the record is accelerated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>image_video</b>: video and image.</description></item>
            /// <item><description><b>api</b>: API.</description></item>
            /// <item><description><b>web</b>: web page.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>image_video</para>
            /// </summary>
            [NameInMap("BizName")]
            [Validation(Required=false)]
            public string BizName { get; set; }

            /// <summary>
            /// <para>The comment of the record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Remarks</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The creation time of the record. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
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
            /// <para>The DNS information of the record. The content returned in this field varies by record type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;value&quot;:&quot;1.1.1.1&quot;}</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public GetRecordResponseBodyRecordModelData Data { get; set; }
            public class GetRecordResponseBodyRecordModelData : TeaModel {
                /// <summary>
                /// <para>The encryption algorithm used by the record. Valid values: <b>0 to 255</b>.</para>
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
                /// <para>The public key fingerprint value of the record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcdef1234567890</para>
                /// </summary>
                [NameInMap("Fingerprint")]
                [Validation(Required=false)]
                public string Fingerprint { get; set; }

                /// <summary>
                /// <para>The flag of the record. The Flag of a CAA record indicates its priority and processing method. Valid values: <b>0 to 255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>128</para>
                /// </summary>
                [NameInMap("Flag")]
                [Validation(Required=false)]
                public int? Flag { get; set; }

                /// <summary>
                /// <para>The public key identifier of the record. Valid values: <b>0 to 65535</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("KeyTag")]
                [Validation(Required=false)]
                public int? KeyTag { get; set; }

                /// <summary>
                /// <para>The algorithm policy used by the record for matching or verifying certificates. Valid values: <b>0 to 255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MatchingType")]
                [Validation(Required=false)]
                public int? MatchingType { get; set; }

                /// <summary>
                /// <para>The port of the record. Valid values: <b>0 to 65535</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8707</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The priority of the record. Valid values: <b>0 to 65535</b>. A smaller value indicates a higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The type of certificate or public key used by the record. Valid values: <b>0 to 255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Selector")]
                [Validation(Required=false)]
                public int? Selector { get; set; }

                /// <summary>
                /// <para>The tag of the record. The Tag of a CAA record indicates its specific type and purpose.</para>
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
                /// <para>The certificate type of the record (in CERT records) or the public key type (in SSHFP records).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <para>The usage identifier of the record. Valid values: <b>0 to 255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public int? Usage { get; set; }

                /// <summary>
                /// <para>The record value or partial content. The meaning varies by record type:</para>
                /// <list type="bullet">
                /// <item><description><b>A/AAAA</b>: the IP address that the record points to. Separate multiple IP addresses with commas (,). At least one IPv4 address is required.</description></item>
                /// <item><description><b>CNAME</b>: the target domain name that the record points to.</description></item>
                /// <item><description><b>NS</b>: the name server for the specified domain name.</description></item>
                /// <item><description><b>MX</b>: the valid target mail server domain name.</description></item>
                /// <item><description><b>TXT</b>: a valid text string.</description></item>
                /// <item><description><b>CAA</b>: a valid certification authority domain name.</description></item>
                /// <item><description><b>SRV</b>: a valid target host domain name.</description></item>
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
                /// <para>The weight of the record. Valid values: <b>0 to 65535</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The back-to-origin HOST policy. This parameter takes effect when the record type is CNAME. It specifies the HOST header policy for back-to-origin requests. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>follow_hostname</b>: follows the host record.</description></item>
            /// <item><description><b>follow_origin_domain</b>: follows the origin domain name.</description></item>
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
            /// <para>Indicates whether proxy acceleration is enabled for the record. Only CNAME and A/AAAA records support proxy acceleration. Valid values:</para>
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
            /// <para>The origin type of the CNAME record. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>OSS</b>: OSS origin.</description></item>
            /// <item><description><b>S3</b>: S3 origin.</description></item>
            /// <item><description><b>LB</b>: load balancing origin.</description></item>
            /// <item><description><b>OP</b>: IPAM pool origin.</description></item>
            /// <item><description><b>Domain</b>: standard domain name origin.</description></item>
            /// </list>
            /// <para>If this parameter is not specified or is left empty, the default value is Domain, which indicates a standard domain name origin type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("RecordSourceType")]
            [Validation(Required=false)]
            public string RecordSourceType { get; set; }

            /// <summary>
            /// <para>The DNS type of the record, such as <b>A/AAAA, CNAME, or TXT</b>.</para>
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
            /// <para>The Time-to-Live (TTL) of the record, in seconds. A value of 1 indicates that the TTL is set to automatic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            /// <summary>
            /// <para>The update time of the record. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
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
