// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchCreateRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The list of DNS records to be created.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecordList")]
        [Validation(Required=false)]
        public List<BatchCreateRecordsRequestRecordList> RecordList { get; set; }
        public class BatchCreateRecordsRequestRecordList : TeaModel {
            [NameInMap("AuthConf")]
            [Validation(Required=false)]
            public BatchCreateRecordsRequestRecordListAuthConf AuthConf { get; set; }
            public class BatchCreateRecordsRequestRecordListAuthConf : TeaModel {
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The business scenario of the record for acceleration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>image_video</b></description></item>
            /// <item><description><b>api</b></description></item>
            /// <item><description><b>web</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>web</para>
            /// </summary>
            [NameInMap("BizName")]
            [Validation(Required=false)]
            public string BizName { get; set; }

            /// <summary>
            /// <para>The DNS information of the record. Enter fields based on the record type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;value&quot;:&quot;2.2.2.2&quot;
            /// }</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public BatchCreateRecordsRequestRecordListData Data { get; set; }
            public class BatchCreateRecordsRequestRecordListData : TeaModel {
                /// <summary>
                /// <para>The encryption algorithm used for the record. Valid values: 0 to 255. Applicable to CERT and SSHFP records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Algorithm")]
                [Validation(Required=false)]
                public int? Algorithm { get; set; }

                /// <summary>
                /// <para>The public key of the certificate. Applicable to CERT, SMIMEA, and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dGVzdGFkYWxrcw==</para>
                /// </summary>
                [NameInMap("Certificate")]
                [Validation(Required=false)]
                public string Certificate { get; set; }

                /// <summary>
                /// <para>The public key fingerprint of the record. Applicable to SSHFP records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcdef1234567890</para>
                /// </summary>
                [NameInMap("Fingerprint")]
                [Validation(Required=false)]
                public string Fingerprint { get; set; }

                /// <summary>
                /// <para>The Flag for a CAA record indicates its priority and how it is processed. Valid values: 0 to 255.</para>
                /// 
                /// <b>Example:</b>
                /// <para>128</para>
                /// </summary>
                [NameInMap("Flag")]
                [Validation(Required=false)]
                public int? Flag { get; set; }

                /// <summary>
                /// <para>The public key identification for the record. Valid values: 0 to 65535. Applicable to CERT records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("KeyTag")]
                [Validation(Required=false)]
                public int? KeyTag { get; set; }

                /// <summary>
                /// <para>The algorithm policy used to match or validate the certificate. Valid values: 0 to 255. Applicable to SMIMEA, and TLSA records.</para>
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
                /// <para>0</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The priority of the record. Valid values: 0 to 65535. A smaller value indicates a higher priority. This parameter is required when you add MX, SRV, and URI records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The type of certificate or public key. Valid values: 0 to 255. Applicable to SMIMEA and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Selector")]
                [Validation(Required=false)]
                public int? Selector { get; set; }

                /// <summary>
                /// <para>The tag of a CAA record, which indicates its specific type and purpose, such as issue, issuewild, and iodef.</para>
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
                /// <para>The usage identifier of the record. Valid values: 0 to 255. Applicable to SMIMEA and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public int? Usage { get; set; }

                /// <summary>
                /// <para>The record value or part of the record content. A/AAAA: the IP address being pointed to. CNAME: the target domain name being pointed to. MX: valid target mail server domain name. TXT: valid text string. CAA: valid certificate authority domain name. SRV: valid target host domain name. URI: valid URI string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The weight of the record. Valid values: 0 to 65,535. Applicable to SRV and URI records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to proxy the record. Only CNAME and A/AAAA records can be proxied. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Proxied")]
            [Validation(Required=false)]
            public bool? Proxied { get; set; }

            /// <summary>
            /// <para>The record name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
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
            /// <para>If you do not pass this parameter or if you leave its value empty, Domain is used by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The TTL of the record. Unit: seconds. If the value is 1, the TTL of the record is determined by the system.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            /// <summary>
            /// <para>The DNS type of the record.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A/AAAA</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The website ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
