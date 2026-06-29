// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchCreateRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The list of DNS records to create.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecordList")]
        [Validation(Required=false)]
        public List<BatchCreateRecordsRequestRecordList> RecordList { get; set; }
        public class BatchCreateRecordsRequestRecordList : TeaModel {
            /// <summary>
            /// <para>The origin authentication information of the CNAME record.</para>
            /// </summary>
            [NameInMap("AuthConf")]
            [Validation(Required=false)]
            public BatchCreateRecordsRequestRecordListAuthConf AuthConf { get; set; }
            public class BatchCreateRecordsRequestRecordListAuthConf : TeaModel {
                /// <summary>
                /// <para>The AccessKey of the account to which the origin belongs. This parameter is required when the origin type is OSS and the authentication type is private cross-account read, or when the origin type is S3 and the authentication type is private read.</para>
                /// 
                /// <b>Example:</b>
                /// <para>u0Nkg5gBK*******QF5wvKMM504JUHt</para>
                /// </summary>
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// <para>The origin authentication type. Different origin types support different authentication types. The origin type refers to the SourceType parameter in this operation. When the origin type is OSS or S3, you must specify the authentication type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>public</b>: public read. Select this value when the origin type is OSS or S3 and the origin allows public read access.</description></item>
                /// <item><description><b>private</b>: private read. Select this value when the origin type is S3 and the origin allows only private read access.</description></item>
                /// <item><description><b>private_same_account</b>: private same-account read. Select this value when the origin type is OSS, the origin is under the same Alibaba Cloud account, and the origin allows only private read access.</description></item>
                /// <item><description><b>private_cross_account</b>: private cross-account read. Select this value when the origin type is OSS, the origin is under a different Alibaba Cloud account, and the origin allows only private read access.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>private</para>
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// <para>The region of the origin. This parameter is required when the origin type is S3. Obtain the region from the official S3 website.</para>
                /// 
                /// <b>Example:</b>
                /// <para>us-east-1</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The SecretKey of the account to which the origin belongs. This parameter is required when the origin type is OSS and the authentication type is private cross-account read, or when the origin type is S3 and the authentication type is private read.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VIxuvJSA2S03f******kp208dy5w7</para>
                /// </summary>
                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                /// <summary>
                /// <para>The signature algorithm version. This parameter is available when the origin type is S3 and the authentication type is private read. Valid values:</para>
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
            /// <para>The DNS information of the record. Different fields are required based on the record type.</para>
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
                /// <para>The encryption algorithm used by the record. Value range: <b>0 to 255</b>. This parameter applies to CERT and SSHFP records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Algorithm")]
                [Validation(Required=false)]
                public int? Algorithm { get; set; }

                /// <summary>
                /// <para>The public key certificate information of the record. This parameter applies to CERT, SMIMEA, and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dGVzdGFkYWxrcw==</para>
                /// </summary>
                [NameInMap("Certificate")]
                [Validation(Required=false)]
                public string Certificate { get; set; }

                /// <summary>
                /// <para>The public key fingerprint of the record. This parameter applies to SSHFP records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcdef1234567890</para>
                /// </summary>
                [NameInMap("Fingerprint")]
                [Validation(Required=false)]
                public string Fingerprint { get; set; }

                /// <summary>
                /// <para>The flag of the CAA record, which indicates its priority and processing method. Value range: <b>0 to 255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>128</para>
                /// </summary>
                [NameInMap("Flag")]
                [Validation(Required=false)]
                public int? Flag { get; set; }

                /// <summary>
                /// <para>The public key identifier of the record. Value range: <b>0 to 65535</b>. This parameter applies to CERT records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("KeyTag")]
                [Validation(Required=false)]
                public int? KeyTag { get; set; }

                /// <summary>
                /// <para>The algorithm policy used to match or verify certificates. Value range: <b>0 to 255</b>. This parameter applies to SMIMEA and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MatchingType")]
                [Validation(Required=false)]
                public int? MatchingType { get; set; }

                /// <summary>
                /// <para>The port of the record. Value range: <b>0 to 65535</b>. This parameter applies only to SRV records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The priority of the record. Value range: <b>0 to 65535</b>. A smaller value indicates a higher priority. This parameter is required when you add MX, SRV, or URI records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The type of certificate or public key used by the record. Value range: <b>0 to 255</b>. This parameter applies to SMIMEA and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Selector")]
                [Validation(Required=false)]
                public int? Selector { get; set; }

                /// <summary>
                /// <para>The tag of the CAA record, which indicates its specific type and purpose, such as issue, issuewild, or iodef.</para>
                /// 
                /// <b>Example:</b>
                /// <para>issue</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The certificate type (for CERT records) or public key type (for SSHFP records) of the record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <para>The usage identifier of the record. Value range: <b>0 to 255</b>. This parameter applies to SMIMEA and TLSA records.</para>
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
                /// <item><description><b>A/AAAA</b>: the IP address.</description></item>
                /// <item><description><b>CNAME</b>: the target domain name.</description></item>
                /// <item><description><b>MX</b>: a valid target mail server domain name.</description></item>
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
                /// <para>The weight of the record. Value range: <b>0 to 65535</b>. This parameter applies to SRV and URI records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            [NameInMap("HttpPorts")]
            [Validation(Required=false)]
            public string HttpPorts { get; set; }

            [NameInMap("HttpsPorts")]
            [Validation(Required=false)]
            public string HttpsPorts { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable proxied acceleration for the record. Only CNAME records and A/AAAA records support proxied acceleration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Proxied acceleration is enabled.</description></item>
            /// <item><description><b>false</b>: Proxied acceleration is disabled.</description></item>
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
            /// <para>The origin type of the CNAME record. This parameter is required when you add a CNAME record. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>OSS</b>: OSS origin.</description></item>
            /// <item><description><b>S3</b>: S3 origin.</description></item>
            /// <item><description><b>LB</b>: load balancing origin.</description></item>
            /// <item><description><b>OP</b>: IPAM pool origin.</description></item>
            /// <item><description><b>Domain</b>: common domain name origin.</description></item>
            /// </list>
            /// <para>If this parameter is left empty or not specified, the default value is Domain, which indicates a common domain name origin.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The time-to-live (TTL) of the record, in seconds. A value of 1 indicates that the TTL is set to automatic.</para>
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
        /// <para>The site ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
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
