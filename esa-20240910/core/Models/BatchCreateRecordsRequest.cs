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
            /// <summary>
            /// <para>The origin server authentication information for the CNAME record.</para>
            /// </summary>
            [NameInMap("AuthConf")]
            [Validation(Required=false)]
            public BatchCreateRecordsRequestRecordListAuthConf AuthConf { get; set; }
            public class BatchCreateRecordsRequestRecordListAuthConf : TeaModel {
                /// <summary>
                /// <para>The AccessKey of the account to which the origin server belongs. This parameter is required when the origin server type is OSS and the origin server authentication type is private cross-account read, or when the origin server type is S3 and the origin server authentication type is private read.</para>
                /// 
                /// <b>Example:</b>
                /// <para>u0Nkg5gBK*******QF5wvKMM504JUHt</para>
                /// </summary>
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// <para>The origin server authentication type. Different origin server types support different authentication types. The origin server type refers to the SourceType parameter in this operation. When the origin server type is OSS or S3, this parameter is required. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>public</b>: public read. Select this value when the origin server type is OSS or S3 and the origin server is publicly readable.</description></item>
                /// <item><description><b>private</b>: private read. Select this value when the origin server type is S3 and the origin server is privately readable.</description></item>
                /// <item><description><b>private_same_account</b>: private same-account read. Select this value when the origin server type is OSS, the origin server is under the same Alibaba Cloud account, and the origin server is privately readable.</description></item>
                /// <item><description><b>private_cross_account</b>: private cross-account read. Select this value when the origin server type is OSS, the origin server is under a different Alibaba Cloud account, and the origin server is privately readable.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>private</para>
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// <para>The region to which the origin server belongs. This parameter is required when the origin server type is S3. You can obtain the region of the origin server from the official website of S3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>us-east-1</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The SecretKey of the account to which the origin server belongs. This parameter is required when the origin server type is OSS and the origin server authentication type is private cross-account read, or when the origin server type is S3 and the origin server authentication type is private read.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VIxuvJSA2S03f******kp208dy5w7</para>
                /// </summary>
                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                /// <summary>
                /// <para>The signature algorithm version. This parameter is available when the origin server type is S3 and the origin server authentication type is private read. Valid values:</para>
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
            /// <item><description><b>image_video</b>: images and videos.</description></item>
            /// <item><description><b>api</b>: API operations.</description></item>
            /// <item><description><b>web</b>: web pages.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>web</para>
            /// </summary>
            [NameInMap("BizName")]
            [Validation(Required=false)]
            public string BizName { get; set; }

            /// <summary>
            /// <para>The DNS information of the record. Specify different fields based on the record type.</para>
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
                /// <para>The encryption algorithm used by the record. Valid values: <b>0</b> to <b>255</b>. This parameter applies to CERT and SSHFP records.</para>
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
                /// <para>The flag of the CAA record, which indicates its priority and processing method. Valid values: <b>0</b> to <b>255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>128</para>
                /// </summary>
                [NameInMap("Flag")]
                [Validation(Required=false)]
                public int? Flag { get; set; }

                /// <summary>
                /// <para>The public key identifier of the record. Valid values: <b>0</b> to <b>65535</b>. This parameter applies to CERT records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("KeyTag")]
                [Validation(Required=false)]
                public int? KeyTag { get; set; }

                /// <summary>
                /// <para>The algorithm policy used by the record to match or verify the certificate. Valid values: <b>0</b> to <b>255</b>. This parameter applies to SMIMEA and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MatchingType")]
                [Validation(Required=false)]
                public int? MatchingType { get; set; }

                /// <summary>
                /// <para>The port of the record. Valid values: <b>0</b> to <b>65535</b>. This parameter applies only to SRV records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The priority of the record. Valid values: <b>0</b> to <b>65535</b>. A smaller value indicates a higher priority. This parameter is required when you add MX, SRV, or URI records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The type of the certificate or public key used by the record. Valid values: <b>0</b> to <b>255</b>. This parameter applies to SMIMEA and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Selector")]
                [Validation(Required=false)]
                public int? Selector { get; set; }

                /// <summary>
                /// <para>The tag of the CAA record, which indicates its specific type and usage, such as issue, issuewild, and iodef.</para>
                /// 
                /// <b>Example:</b>
                /// <para>issue</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The certificate type for CERT records or the public key type for SSHFP records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <para>The usage identifier of the record. Valid values: <b>0</b> to <b>255</b>. This parameter applies to SMIMEA and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public int? Usage { get; set; }

                /// <summary>
                /// <para>The record value or partial content.</para>
                /// <list type="bullet">
                /// <item><description><b>A/AAAA</b>: the IP address.</description></item>
                /// <item><description><b>CNAME</b>: the target domain name.</description></item>
                /// <item><description><b>MX</b>: the valid target mail server domain name.</description></item>
                /// <item><description><b>TXT</b>: the valid character string.</description></item>
                /// <item><description><b>CAA</b>: the valid domain name of the certification authority to issue certificates.</description></item>
                /// <item><description><b>SRV</b>: the valid target host domain name.</description></item>
                /// <item><description><b>URI</b>: the valid URI string.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The weight of the record. Valid values: <b>0</b> to <b>65535</b>. This parameter applies to SRV and URI records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The HTTP port. By default, port 80 is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80,2052,2082,2086,2095,8080,8880</para>
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
            /// <para>Specifies whether to enable proxy acceleration for the record. Only CNAME and A/AAAA records can enable proxy acceleration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enables proxy acceleration.</description></item>
            /// <item><description><b>false</b>: disables proxy acceleration.</description></item>
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
            /// <para>The origin server type for the CNAME record. This parameter is required when you add a CNAME record. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>OSS</b>: an OSS origin server.</description></item>
            /// <item><description><b>S3</b>: an S3 origin server.</description></item>
            /// <item><description><b>LB</b>: a load balancing origin server.</description></item>
            /// <item><description><b>OP</b>: an IPAM pool origin server.</description></item>
            /// <item><description><b>Domain</b>: a common domain name origin server.</description></item>
            /// </list>
            /// <para>If this parameter is not specified or is left empty, the default value is Domain, which indicates a common domain name origin server type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The time-to-live (TTL) of the record, in seconds. A value of 1 indicates that the TTL is automatic.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            /// <summary>
            /// <para>The DNS record type.</para>
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
        /// <para>The site ID. You can obtain the site ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
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
