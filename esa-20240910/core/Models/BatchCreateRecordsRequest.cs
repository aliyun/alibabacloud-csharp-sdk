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
            /// <para>The origin authentication information for the CNAME record.</para>
            /// </summary>
            [NameInMap("AuthConf")]
            [Validation(Required=false)]
            public BatchCreateRecordsRequestRecordListAuthConf AuthConf { get; set; }
            public class BatchCreateRecordsRequestRecordListAuthConf : TeaModel {
                /// <summary>
                /// <para>The access key ID of the account that owns the origin. This parameter is required when the origin type is <c>OSS</c> and the authentication type is <c>private_cross_account</c>, or when the origin type is <c>S3</c> and the authentication type is <c>private</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>u0Nkg5gBK*******QF5wvKMM504JUHt</para>
                /// </summary>
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// <para>The type of origin authentication. Supported authentication types depend on the origin type, which is specified by the <c>SourceType</c> parameter. This parameter is required when the origin type is <c>OSS</c> or <c>S3</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>public</b>: For OSS or S3 origins with public read access.</para>
                /// </description></item>
                /// <item><description><para><b>private</b>: For S3 origins with private read access.</para>
                /// </description></item>
                /// <item><description><para><b>private_same_account</b>: For OSS origins with private read access within the same Alibaba Cloud account.</para>
                /// </description></item>
                /// <item><description><para><b>private_cross_account</b>: For OSS origins with private read access from a different Alibaba Cloud account.</para>
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
                /// <para>The region where the S3 origin is located. This parameter is required when the origin type is <c>S3</c>. For a list of valid region IDs, refer to the official S3 documentation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>us-east-1</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The secret key associated with the specified AccessKey. This parameter is required when the origin type is <c>OSS</c> and the authentication type is <c>private_cross_account</c>, or when the origin type is <c>S3</c> and the authentication type is <c>private</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VIxuvJSA2S03f******kp208dy5w7</para>
                /// </summary>
                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                /// <summary>
                /// <para>The signature algorithm version. This parameter is applicable when the origin type is <c>S3</c> and the authentication type is <c>private</c>. Supported versions:</para>
                /// <list type="bullet">
                /// <item><description><para><b>v2</b></para>
                /// </description></item>
                /// <item><description><para><b>v4</b></para>
                /// </description></item>
                /// </list>
                /// <para>If omitted, the default version is <c>v4</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v4</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The use case for proxy acceleration. Valid values:</para>
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
            /// <para>web</para>
            /// </summary>
            [NameInMap("BizName")]
            [Validation(Required=false)]
            public string BizName { get; set; }

            /// <summary>
            /// <para>The content of the DNS record. The required fields depend on the record type.</para>
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
                /// <para>The algorithm identifier for the record. Valid values range from <b>0-255</b>. This parameter applies to CERT and SSHFP records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Algorithm")]
                [Validation(Required=false)]
                public int? Algorithm { get; set; }

                /// <summary>
                /// <para>The certificate or public key data for the record. This parameter applies to CERT, SMIMEA, and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dGVzdGFkYWxrcw==</para>
                /// </summary>
                [NameInMap("Certificate")]
                [Validation(Required=false)]
                public string Certificate { get; set; }

                /// <summary>
                /// <para>The public key fingerprint for the record. This parameter applies to SSHFP records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcdef1234567890</para>
                /// </summary>
                [NameInMap("Fingerprint")]
                [Validation(Required=false)]
                public string Fingerprint { get; set; }

                /// <summary>
                /// <para>The flag for the CAA record, which specifies how a Certificate Authority must handle the record. Valid values range from <b>0-255</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>128</para>
                /// </summary>
                [NameInMap("Flag")]
                [Validation(Required=false)]
                public int? Flag { get; set; }

                /// <summary>
                /// <para>The public key identifier for the record. Valid values range from <b>0-65535</b>. This parameter applies to CERT records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("KeyTag")]
                [Validation(Required=false)]
                public int? KeyTag { get; set; }

                /// <summary>
                /// <para>The algorithm policy used to match or validate a certificate. Valid values range from <b>0-255</b>. This parameter applies to SMIMEA and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MatchingType")]
                [Validation(Required=false)]
                public int? MatchingType { get; set; }

                /// <summary>
                /// <para>The port number for the record. Valid values range from <b>0-65535</b>. This parameter applies only to SRV records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The priority of the record. Valid values range from <b>0-65535</b>. A lower value indicates a higher priority. This parameter is required for MX, SRV, or URI records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The type of certificate or public key used by the record. Valid values range from <b>0-255</b>. This parameter applies to SMIMEA and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Selector")]
                [Validation(Required=false)]
                public int? Selector { get; set; }

                /// <summary>
                /// <para>The tag for the CAA record, which specifies its type and purpose, such as <c>issue</c>, <c>issuewild</c>, or <c>iodef</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>issue</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The certificate type for a CERT record or the public key type for an SSHFP record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <para>The usage identifier for the record. Valid values range from <b>0-255</b>. This parameter applies to SMIMEA and TLSA records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public int? Usage { get; set; }

                /// <summary>
                /// <para>The record value. The format depends on the record type.</para>
                /// <list type="bullet">
                /// <item><description><para><b>A/AAAA</b>: An IP address.</para>
                /// </description></item>
                /// <item><description><para><b>CNAME</b>: The target domain name.</para>
                /// </description></item>
                /// <item><description><para><b>MX</b>: The domain name of the target mail server.</para>
                /// </description></item>
                /// <item><description><para><b>TXT</b>: A text string.</para>
                /// </description></item>
                /// <item><description><para><b>CAA</b>: The domain name of a Certificate Authority.</para>
                /// </description></item>
                /// <item><description><para><b>SRV</b>: The domain name of the target host.</para>
                /// </description></item>
                /// <item><description><para><b>URI</b>: A URI string.</para>
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
                /// <para>The weight of the record. Valid values range from <b>0-65535</b>. This parameter applies to SRV and URI records.</para>
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
            /// <para>Specifies whether to enable proxy acceleration for the record. Only CNAME and A/AAAA records support proxy acceleration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enables proxy acceleration.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disables proxy acceleration.</para>
            /// </description></item>
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
            /// <para>The name of the record.</para>
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
            /// <item><description><para><b>OSS</b>: An OSS origin.</para>
            /// </description></item>
            /// <item><description><para><b>S3</b>: An S3 origin.</para>
            /// </description></item>
            /// <item><description><para><b>LB</b>: A load balancer origin.</para>
            /// </description></item>
            /// <item><description><para><b>OP</b>: An origin pool origin.</para>
            /// </description></item>
            /// <item><description><para><b>Domain</b>: A domain name origin.</para>
            /// </description></item>
            /// </list>
            /// <para>If omitted or left empty, this parameter defaults to <c>Domain</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The Time to Live (TTL) for the record, in seconds. A value of <c>1</c> indicates an automatic TTL.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            /// <summary>
            /// <para>The type of the DNS record.</para>
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
        /// <para>The ID of the site. You can get this ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
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
