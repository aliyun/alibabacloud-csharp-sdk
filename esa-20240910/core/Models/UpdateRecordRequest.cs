// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateRecordRequest : TeaModel {
        /// <summary>
        /// <para>The origin authentication information of the CNAME record.</para>
        /// </summary>
        [NameInMap("AuthConf")]
        [Validation(Required=false)]
        public UpdateRecordRequestAuthConf AuthConf { get; set; }
        public class UpdateRecordRequestAuthConf : TeaModel {
            /// <summary>
            /// <para>The access key of the account to which the origin server belongs. This parameter is required when the SourceType is OSS, and AuthType is private_same_account, or when the SourceType is S3 and AuthType is private.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VIxuvJSA2S03f******kp208dy5w7</para>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>The authentication type of the origin server. Different origins support different authentication types. The type of origin refers to the SourceType parameter in this operation. If the type of origin is OSS or S3, you must specify the authentication type of the origin. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>public</b>: public read. Select this value when the origin type is OSS or S3 and the origin access is public read.</description></item>
            /// <item><description><b>private</b>: private read. Select this value when the origin type is S3 and the origin access is private read.</description></item>
            /// <item><description><b>private_same_account</b>: private read under the same account. Select this value when the origin type is OSS, the origins belong to the same Alibaba Cloud account, and the origins have private read access.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>The version of the signature algorithm. This parameter is required when the origin type is S3 and AuthType is private. The following two types are supported:</para>
            /// <list type="bullet">
            /// <item><description><b>v2</b></description></item>
            /// <item><description><b>v4</b></description></item>
            /// </list>
            /// <para>If you leave this parameter empty, the default value v4 is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The secret access key of the account to which the origin server belongs. This parameter is required when the SourceType is OSS, and AuthType is private_same_account, or when the SourceType is S3 and AuthType is private.</para>
            /// 
            /// <b>Example:</b>
            /// <para>u0Nkg5gBK*******QF5wvKMM504JUHt</para>
            /// </summary>
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            /// <summary>
            /// <para>The region of the origin. If the origin type is S3, you must specify this value. You can get the region information from the official website of S3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>us-east-1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The business scenario of the record for acceleration. Leave the parameter empty if your record is not proxied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>video_image</b>: video and image.</description></item>
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
        /// <para>This is a remark.</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The DNS record information. The format of this field varies based on the record type. For more information, see <a href="https://www.alibabacloud.com/help/doc-detail/2708761.html">Add DNS records</a>.</para>
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
            /// <para>The encryption algorithm used for the record, specified within the range from 0 to 255. This parameter is required when you add CERT or SSHFP records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
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
            /// <para>The public key identification for the record, specified within the range of 0 to 65,535. This parameter is required when you add a CAA record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("KeyTag")]
            [Validation(Required=false)]
            public int? KeyTag { get; set; }

            /// <summary>
            /// <para>The algorithm policy used to match or validate the certificate, specified within the range 0 to 255. This parameter is required when you add SMIMEA or TLSA records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MatchingType")]
            [Validation(Required=false)]
            public int? MatchingType { get; set; }

            /// <summary>
            /// <para>The port of the record, specified within the range of 0 to 65,535. This parameter is required when you add an SRV record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The priority of the record, specified within the range of 0 to 65,535. A smaller value indicates a higher priority. This parameter is required when you add MX, SRV, and URI records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The type of certificate or public key, specified within the range of 0 to 255. This parameter is required when you add SMIMEA or TLSA records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Selector")]
            [Validation(Required=false)]
            public int? Selector { get; set; }

            /// <summary>
            /// <para>The label of the record. The Tag of a CAA record indicate its specific type and usage. This parameter is required when you add a CAA record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>issue</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The certificate type of the record (in CERT records), or the public key type (in SSHFP records). This parameter is required when you add CERT or SSHFP records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
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
            /// <para>The record value or part of the record content. This parameter is required when you add A/AAAA, CNAME, NS, MX, TXT, CAA, SRV, and URI records. It has different meanings based on different types of records:</para>
            /// <list type="bullet">
            /// <item><description><b>A/AAAA</b>: the IP address(es). Separate multiple IPs with commas (,). You must have at least one IPv4 address.</description></item>
            /// <item><description><b>CNAME</b>: the target domain name.</description></item>
            /// <item><description><b>NS</b>: the name servers for the domain name.</description></item>
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
            /// <para>The weight of the record, specified within the range of 0 to 65,535. This parameter is required when you add SRV or URI records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The origin host policy. This policy takes effect when the record type is CNAME. You can set the policy in two modes:</para>
        /// <list type="bullet">
        /// <item><description><b>follow_hostname</b>: match the requested domain name.</description></item>
        /// <item><description><b>follow_origin_domain</b>: match the origin\&quot;s domain name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>follow_origin_domain</para>
        /// </summary>
        [NameInMap("HostPolicy")]
        [Validation(Required=false)]
        public string HostPolicy { get; set; }

        /// <summary>
        /// <para>Specifies whether to proxy the record. Only CNAME and A/AAAA records can be proxied. Valid values:</para>
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
        /// <para>The record ID, which can be obtained by calling <a href="https://help.aliyun.com/document_detail/2850265.html">ListRecords</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public long? RecordId { get; set; }

        /// <summary>
        /// <para>The type of the origin for the CNAME record. This parameter is required when you add a CNAME record. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OSS</b> : OSS origin.</description></item>
        /// <item><description><b>S3</b> : S3 origin.</description></item>
        /// <item><description><b>LB</b>: Load Balancer origin.</description></item>
        /// <item><description><b>OP</b>: origin in an origin pool.</description></item>
        /// <item><description><b>Domain</b>: common domain name.</description></item>
        /// </list>
        /// <para>If you leave the parameter empty or set its value as null, the default is Domain, which is common domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The TTL of the record. Unit: seconds. The range is 30 to 86,400, or 1. If the value is 1, the TTL of the record is determined by the system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
