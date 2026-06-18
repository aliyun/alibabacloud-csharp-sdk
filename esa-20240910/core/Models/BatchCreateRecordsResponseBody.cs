// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchCreateRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The results of the batch record creation, with details for both successful and failed records.</para>
        /// </summary>
        [NameInMap("RecordResultList")]
        [Validation(Required=false)]
        public BatchCreateRecordsResponseBodyRecordResultList RecordResultList { get; set; }
        public class BatchCreateRecordsResponseBodyRecordResultList : TeaModel {
            /// <summary>
            /// <para>A list of records that failed to be created.</para>
            /// </summary>
            [NameInMap("Failed")]
            [Validation(Required=false)]
            public List<BatchCreateRecordsResponseBodyRecordResultListFailed> Failed { get; set; }
            public class BatchCreateRecordsResponseBodyRecordResultListFailed : TeaModel {
                /// <summary>
                /// <para>The acceleration use case for the record. Valid values:</para>
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
                /// <para>The DNS information for the record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;value&quot;:&quot;2.2.2.2&quot;}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public BatchCreateRecordsResponseBodyRecordResultListFailedData Data { get; set; }
                public class BatchCreateRecordsResponseBodyRecordResultListFailedData : TeaModel {
                    /// <summary>
                    /// <para>The encryption algorithm used by the record. The value ranges from <b>0</b> to <b>255</b>. This parameter applies to CERT and SSHFP records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Algorithm")]
                    [Validation(Required=false)]
                    public int? Algorithm { get; set; }

                    /// <summary>
                    /// <para>The public key certificate for the record. This parameter applies to CERT, SMIMEA, and TLSA records.</para>
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
                    /// <para>The flag for the record, which indicates its priority and processing method. This parameter applies to CAA records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>128</para>
                    /// </summary>
                    [NameInMap("Flag")]
                    [Validation(Required=false)]
                    public int? Flag { get; set; }

                    /// <summary>
                    /// <para>The public key identifier for the record. The value ranges from <b>0</b> to <b>65535</b>. This parameter applies to CERT records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("KeyTag")]
                    [Validation(Required=false)]
                    public int? KeyTag { get; set; }

                    /// <summary>
                    /// <para>The algorithm policy used by the record to match or validate certificates. The value ranges from <b>0</b> to <b>255</b>. This parameter applies to SMIMEA and TLSA records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RSA</para>
                    /// </summary>
                    [NameInMap("MatchingType")]
                    [Validation(Required=false)]
                    public int? MatchingType { get; set; }

                    /// <summary>
                    /// <para>The port for the record. The value ranges from 0 to 65535. This parameter applies only to SRV records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The priority of the record. The value ranges from <b>0</b> to <b>65535</b>. A smaller value indicates a higher priority. This parameter applies to MX, SRV, and URI records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public int? Priority { get; set; }

                    /// <summary>
                    /// <para>The type of certificate or public key used by the record. The value ranges from <b>0</b> to <b>255</b>. This parameter applies to SMIMEA and TLSA records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Selector")]
                    [Validation(Required=false)]
                    public int? Selector { get; set; }

                    /// <summary>
                    /// <para>The tag for a CAA record, which specifies its type and purpose, such as <c>issue</c>, <c>issuewild</c>, or <c>iodef</c>.</para>
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
                    /// <para>The usage identifier for the record. The value ranges from <b>0</b> to <b>255</b>. This parameter applies to SMIMEA and TLSA records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Usage")]
                    [Validation(Required=false)]
                    public int? Usage { get; set; }

                    /// <summary>
                    /// <para>The record value. This parameter applies to A/AAAA, CNAME, NS, MX, TXT, CAA, SRV, and URI records. The meaning of this parameter varies based on the record type:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>A/AAAA</b>: The IP address. To specify multiple addresses, separate them with a comma (,). At least one IPv4 address is required.</para>
                    /// </description></item>
                    /// <item><description><para><b>CNAME</b>: The target domain name.</para>
                    /// </description></item>
                    /// <item><description><para><b>NS</b>: The name server for the domain.</para>
                    /// </description></item>
                    /// <item><description><para><b>MX</b>: The domain name of a valid target mail server.</para>
                    /// </description></item>
                    /// <item><description><para><b>TXT</b>: A valid text string.</para>
                    /// </description></item>
                    /// <item><description><para><b>CAA</b>: The domain name of a valid certificate authority.</para>
                    /// </description></item>
                    /// <item><description><para><b>SRV</b>: The domain name of a valid target host.</para>
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
                    /// <para>The weight of the record. The value ranges from 0 to 65535. This parameter applies to SRV and URI records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                }

                /// <summary>
                /// <para>The result description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>记录的名称非法</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("HttpPorts")]
                [Validation(Required=false)]
                public string HttpPorts { get; set; }

                [NameInMap("HttpsPorts")]
                [Validation(Required=false)]
                public string HttpsPorts { get; set; }

                /// <summary>
                /// <para>Specifies whether proxy acceleration is enabled for the record. This option is available only for CNAME, A, and AAAA records. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Proxy acceleration is enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Proxy acceleration is disabled.</para>
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
                /// <para>The DNS type of the record, such as <b>A/AAAA</b>, <b>CNAME</b>, or <b>TXT</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A/AAAA</para>
                /// </summary>
                [NameInMap("RecordType")]
                [Validation(Required=false)]
                public string RecordType { get; set; }

                /// <summary>
                /// <para>The type of origin for a CNAME record. This parameter is empty for other record types. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>OSS</b>: An OSS origin.</para>
                /// </description></item>
                /// <item><description><para><b>S3</b>: An S3 origin.</para>
                /// </description></item>
                /// <item><description><para><b>LB</b>: A load balancer origin.</para>
                /// </description></item>
                /// <item><description><para><b>OP</b>: An origin pool.</para>
                /// </description></item>
                /// <item><description><para><b>Domain</b>: A domain name origin.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The TTL of the record in seconds. A value of 1 sets the TTL to Automatic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

            }

            /// <summary>
            /// <para>A list of successfully created records.</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public List<BatchCreateRecordsResponseBodyRecordResultListSuccess> Success { get; set; }
            public class BatchCreateRecordsResponseBodyRecordResultListSuccess : TeaModel {
                /// <summary>
                /// <para>The acceleration use case for the record. Valid values:</para>
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
                /// <para>The DNS information for the record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;value&quot;:&quot;1.1.1.1&quot;}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public BatchCreateRecordsResponseBodyRecordResultListSuccessData Data { get; set; }
                public class BatchCreateRecordsResponseBodyRecordResultListSuccessData : TeaModel {
                    /// <summary>
                    /// <para>The encryption algorithm used by the record. The value ranges from <b>0</b> to <b>255</b>. This parameter applies to CERT and SSHFP records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Algorithm")]
                    [Validation(Required=false)]
                    public int? Algorithm { get; set; }

                    /// <summary>
                    /// <para>The public key certificate for the record. This parameter applies to CERT, SMIMEA, and TLSA records.</para>
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
                    /// <para>The flag for the record, which indicates its priority and processing method. This parameter applies to CAA records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>128</para>
                    /// </summary>
                    [NameInMap("Flag")]
                    [Validation(Required=false)]
                    public int? Flag { get; set; }

                    /// <summary>
                    /// <para>The public key identifier for the record. The value ranges from <b>0</b> to <b>65535</b>. This parameter applies to CERT records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("KeyTag")]
                    [Validation(Required=false)]
                    public int? KeyTag { get; set; }

                    /// <summary>
                    /// <para>The algorithm policy used by the record to match or validate certificates. The value ranges from <b>0</b> to <b>255</b>. This parameter applies to SMIMEA and TLSA records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MatchingType")]
                    [Validation(Required=false)]
                    public int? MatchingType { get; set; }

                    /// <summary>
                    /// <para>The port for the record. The value ranges from <b>0</b> to <b>65535</b>. This parameter applies only to SRV records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The priority of the record. The value ranges from <b>0</b> to <b>65535</b>. A smaller value indicates a higher priority. This parameter applies to MX, SRV, and URI records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public int? Priority { get; set; }

                    /// <summary>
                    /// <para>The type of certificate or public key used by the record. The value ranges from <b>0</b> to <b>255</b>. This parameter applies to SMIMEA and TLSA records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Selector")]
                    [Validation(Required=false)]
                    public int? Selector { get; set; }

                    /// <summary>
                    /// <para>The tag for a CAA record, which specifies its type and purpose, such as <c>issue</c>, <c>issuewild</c>, or <c>iodef</c>.</para>
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
                    /// <para>The usage identifier for the record. The value ranges from <b>0</b> to <b>255</b>. This parameter applies to SMIMEA and TLSA records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Usage")]
                    [Validation(Required=false)]
                    public int? Usage { get; set; }

                    /// <summary>
                    /// <para>The record value. This parameter applies to A/AAAA, CNAME, NS, MX, TXT, CAA, SRV, and URI records. The meaning of this parameter varies based on the record type:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>A/AAAA</b>: The IP address. To specify multiple addresses, separate them with a comma (,). At least one IPv4 address is required.</para>
                    /// </description></item>
                    /// <item><description><para><b>CNAME</b>: The target domain name.</para>
                    /// </description></item>
                    /// <item><description><para><b>NS</b>: The name server for the domain.</para>
                    /// </description></item>
                    /// <item><description><para><b>MX</b>: The domain name of a valid target mail server.</para>
                    /// </description></item>
                    /// <item><description><para><b>TXT</b>: A valid text string.</para>
                    /// </description></item>
                    /// <item><description><para><b>CAA</b>: The domain name of a valid certificate authority.</para>
                    /// </description></item>
                    /// <item><description><para><b>SRV</b>: The domain name of a valid target host.</para>
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
                    /// <para>The weight of the record. The value ranges from <b>0</b> to <b>65535</b>. This parameter applies to SRV and URI records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                }

                /// <summary>
                /// <para>The result description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("HttpPorts")]
                [Validation(Required=false)]
                public string HttpPorts { get; set; }

                [NameInMap("HttpsPorts")]
                [Validation(Required=false)]
                public string HttpsPorts { get; set; }

                /// <summary>
                /// <para>Specifies whether proxy acceleration is enabled for the record. This option is available only for CNAME, A, and AAAA records. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Proxy acceleration is enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Proxy acceleration is disabled.</para>
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
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("RecordName")]
                [Validation(Required=false)]
                public string RecordName { get; set; }

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
                /// <para>The type of origin for a CNAME record. This parameter is empty for other record types. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>OSS</b>: An OSS origin.</para>
                /// </description></item>
                /// <item><description><para><b>S3</b>: An S3 origin.</para>
                /// </description></item>
                /// <item><description><para><b>LB</b>: A load balancer origin.</para>
                /// </description></item>
                /// <item><description><para><b>OP</b>: An origin pool.</para>
                /// </description></item>
                /// <item><description><para><b>Domain</b>: A domain name origin.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The TTL of the record in seconds. A value of 1 sets the TTL to Automatic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

            }

            /// <summary>
            /// <para>The total number of records in the creation operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2430E05E-1340-5773-B5E1-B743929F46F2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
