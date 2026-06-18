// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateRecordRequest : TeaModel {
        /// <summary>
        /// <para>The origin authentication settings for the CNAME record.</para>
        /// </summary>
        [NameInMap("AuthConf")]
        [Validation(Required=false)]
        public UpdateRecordRequestAuthConf AuthConf { get; set; }
        public class UpdateRecordRequestAuthConf : TeaModel {
            /// <summary>
            /// <para>The access key for the account that owns the origin. This is required for private, cross-account access to OSS origins, and for S3 origins where the authentication type is <b>private</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VIxuvJSA2S03f******kp208dy5w7</para>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>The origin authentication type. This parameter is required when the <b>SourceType</b> is <b>OSS</b> or <b>S3</b>. Supported authentication types vary depending on the origin type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>public</b>: Public read. Use for publicly readable OSS or S3 origins.</para>
            /// </description></item>
            /// <item><description><para><b>private</b>: Private read. Use for private S3 origins.</para>
            /// </description></item>
            /// <item><description><para><b>private_same_account</b>: Private read within the same account. Use for private OSS origins accessed from the same Alibaba Cloud account.</para>
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
            /// <para>The region where the origin is located. This parameter is required when the origin type is S3. You can find the region ID on the official S3 website.</para>
            /// <list type="bullet">
            /// <item><description><para><b>v2</b></para>
            /// </description></item>
            /// <item><description><para><b>v4</b></para>
            /// </description></item>
            /// </list>
            /// <para>If you do not specify a value, it defaults to v4.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The secret key for the account that owns the origin. This is required for private, cross-account access to OSS origins, and for S3 origins where the authentication type is <b>private</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>u0Nkg5gBK*******QF5wvKMM504JUHt</para>
            /// </summary>
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            /// <summary>
            /// <para>The signing algorithm version. This parameter is required when the origin type is S3 and the authentication type is <b>private</b>. Supported versions: v2 and v4. If this parameter is not specified, the default value is v4.</para>
            /// 
            /// <b>Example:</b>
            /// <para>us-east-1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The use case for proxy acceleration. Omit this parameter if proxy acceleration is disabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>video_image</b>: Video and images.</para>
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
        /// <para>A comment for the record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a remark.</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The DNS data for the record. The required content varies based on the record type. For more information, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/document_detail/2708761.html">Documentation</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/doc-detail/2708761.html">Documentation</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;value&quot;:&quot;2.2.2.2&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateRecordRequestData Data { get; set; }
        public class UpdateRecordRequestData : TeaModel {
            /// <summary>
            /// <para>The encryption algorithm specified in the record. The value must be an integer from <b>0 to 255</b>. This parameter is required for CERT and SSHFP records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public int? Algorithm { get; set; }

            /// <summary>
            /// <para>The public key certificate data for the record. This parameter is required for CERT, SMIMEA, and TLSA records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dGVzdGFkYWxrcw==</para>
            /// </summary>
            [NameInMap("Certificate")]
            [Validation(Required=false)]
            public string Certificate { get; set; }

            /// <summary>
            /// <para>The public key fingerprint for the record. This parameter is required for SSHFP records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abcdef1234567890</para>
            /// </summary>
            [NameInMap("Fingerprint")]
            [Validation(Required=false)]
            public string Fingerprint { get; set; }

            /// <summary>
            /// <para>The flag for the record. For a CAA record, this flag indicates its priority and handling behavior. The value must be an integer from <b>0 to 255</b>. This parameter is required for CAA records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public int? Flag { get; set; }

            /// <summary>
            /// <para>The public key identifier for the record. The value must be an integer from <b>0 to 65535</b>. This parameter is required for CERT records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("KeyTag")]
            [Validation(Required=false)]
            public int? KeyTag { get; set; }

            /// <summary>
            /// <para>The algorithm policy used to match or validate the certificate. The value must be an integer from <b>0 to 255</b>. This parameter is required for SMIMEA and TLSA records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MatchingType")]
            [Validation(Required=false)]
            public int? MatchingType { get; set; }

            /// <summary>
            /// <para>The port number for the record. The value must be an integer from <b>0 to 65535</b>. This parameter is required for SRV records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The record\&quot;s priority. The value must be an integer from <b>0 to 65535</b>, where a lower value indicates higher priority. This parameter is required for MX, SRV, and URI records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The type of certificate or public key specified in the record. The value must be an integer from <b>0 to 255</b>. This parameter is required for SMIMEA and TLSA records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Selector")]
            [Validation(Required=false)]
            public int? Selector { get; set; }

            /// <summary>
            /// <para>The tag for the record. For a CAA record, the tag specifies the record\&quot;s type and purpose. This parameter is required for CAA records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>issue</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The certificate type for a CERT record, or the public key type for an SSHFP record. This parameter is required for CERT and SSHFP records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>The usage identifier for the record. The value must be an integer from <b>0 to 255</b>. This parameter is required for SMIMEA and TLSA records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public int? Usage { get; set; }

            /// <summary>
            /// <para>The value of the record or part of its content. This parameter is required for A/AAAA, CNAME, NS, MX, TXT, CAA, SRV, and URI records. The meaning of this parameter varies by record type:</para>
            /// <list type="bullet">
            /// <item><description><para><b>A/AAAA</b>: The target IP address. To specify multiple IP addresses, separate them with a comma (,). At least one IPv4 address is required.</para>
            /// </description></item>
            /// <item><description><para><b>CNAME</b>: The target domain name.</para>
            /// </description></item>
            /// <item><description><para><b>NS</b>: The name server for the domain.</para>
            /// </description></item>
            /// <item><description><para><b>MX</b>: A valid domain name for the target mail server.</para>
            /// </description></item>
            /// <item><description><para><b>TXT</b>: A valid text string.</para>
            /// </description></item>
            /// <item><description><para><b>CAA</b>: A valid domain name for the certificate authority.</para>
            /// </description></item>
            /// <item><description><para><b>SRV</b>: A valid domain name for the target host.</para>
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
            /// <para>The weight of the record. The value must be an integer from <b>0 to 65535</b>. This parameter is required for SRV and URI records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The origin HOST policy. This policy, which applies only to CNAME records, determines the value of the <c>HOST</c> header in requests sent to the origin. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>follow_hostname</b>: Follows the host record.</para>
        /// </description></item>
        /// <item><description><para><b>follow_origin_domain</b>: Follows the origin domain name.</para>
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
        /// <para>Indicates whether to enable proxy acceleration for the record. Only CNAME and A/AAAA records support proxy acceleration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables proxy acceleration.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disables proxy acceleration.</para>
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
        /// <para>The record ID. Call the <a href="https://help.aliyun.com/document_detail/2850265.html">ListRecords</a> operation to get this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public long? RecordId { get; set; }

        /// <summary>
        /// <para>The origin type for the CNAME record. This parameter is required for CNAME records. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>OSS</b>: An OSS origin.</para>
        /// </description></item>
        /// <item><description><para><b>S3</b>: An S3 origin.</para>
        /// </description></item>
        /// <item><description><para><b>LB</b>: A load balancer origin.</para>
        /// </description></item>
        /// <item><description><para><b>OP</b>: An origin address pool origin.</para>
        /// </description></item>
        /// <item><description><para><b>Domain</b>: A standard domain name origin.</para>
        /// </description></item>
        /// </list>
        /// <para>If this parameter is omitted or left empty, the default value is <c>Domain</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The record\&quot;s time to live (TTL) in seconds. The value must be an integer from <b>30 to 86400</b> or 1. A value of 1 sets the TTL to automatic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
