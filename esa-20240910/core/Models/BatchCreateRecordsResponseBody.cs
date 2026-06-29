// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchCreateRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of record creation results, including details of successfully and unsuccessfully created records.</para>
        /// </summary>
        [NameInMap("RecordResultList")]
        [Validation(Required=false)]
        public BatchCreateRecordsResponseBodyRecordResultList RecordResultList { get; set; }
        public class BatchCreateRecordsResponseBodyRecordResultList : TeaModel {
            /// <summary>
            /// <para>The list of records that failed to be created.</para>
            /// </summary>
            [NameInMap("Failed")]
            [Validation(Required=false)]
            public List<BatchCreateRecordsResponseBodyRecordResultListFailed> Failed { get; set; }
            public class BatchCreateRecordsResponseBodyRecordResultListFailed : TeaModel {
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
                /// <para>The DNS information of the record, including record values and related properties for various record types.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;value&quot;:&quot;2.2.2.2&quot;}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public BatchCreateRecordsResponseBodyRecordResultListFailedData Data { get; set; }
                public class BatchCreateRecordsResponseBodyRecordResultListFailedData : TeaModel {
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
                    /// <para>The flag of the record, which indicates its priority and processing method. This parameter applies to CAA records.</para>
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
                    /// <para>The port number of the record. This parameter applies only to SRV records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The priority of the record. Value range: <b>0 to 65535</b>. A smaller value indicates a higher priority. This parameter applies to MX, SRV, and URI records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
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
                    /// <para>The record value or partial content. This parameter is included in A/AAAA, CNAME, NS, MX, TXT, CAA, SRV, and URI records. The meaning varies by record type:</para>
                    /// <list type="bullet">
                    /// <item><description><b>A/AAAA</b>: the IP address. Separate multiple IP addresses with commas (,). At least one IPv4 address is required.</description></item>
                    /// <item><description><b>CNAME</b>: the target domain name.</description></item>
                    /// <item><description><b>NS</b>: the name server of the specified domain name.</description></item>
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
                    /// <para>The weight of the record. This parameter applies to SRV and URI records.</para>
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
                /// <para>The record name is invalid.</para>
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
                /// <para>Indicates whether proxied acceleration is enabled for the record. Only CNAME records and A/AAAA records support proxied acceleration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Proxied acceleration is enabled.</description></item>
                /// <item><description><b>false</b>: Proxied acceleration is disabled.</description></item>
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
                /// <para>The DNS type of the record, such as <b>A/AAAA, CNAME, or TXT</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A/AAAA</para>
                /// </summary>
                [NameInMap("RecordType")]
                [Validation(Required=false)]
                public string RecordType { get; set; }

                /// <summary>
                /// <para>The origin type of the CNAME record. This field is empty for other record types. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>OSS</b>: OSS origin.</description></item>
                /// <item><description><b>S3</b>: S3 origin.</description></item>
                /// <item><description><b>LB</b>: load balancing origin.</description></item>
                /// <item><description><b>OP</b>: IPAM pool origin.</description></item>
                /// <item><description><b>Domain</b>: common domain name origin.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The time-to-live (TTL) of the record, in seconds. A value of 1 indicates that the TTL is set to automatic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

            }

            /// <summary>
            /// <para>The list of successfully created records.</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public List<BatchCreateRecordsResponseBodyRecordResultListSuccess> Success { get; set; }
            public class BatchCreateRecordsResponseBodyRecordResultListSuccess : TeaModel {
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
                /// <para>The DNS information of the record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;value&quot;:&quot;1.1.1.1&quot;}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public BatchCreateRecordsResponseBodyRecordResultListSuccessData Data { get; set; }
                public class BatchCreateRecordsResponseBodyRecordResultListSuccessData : TeaModel {
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
                    /// <para>The flag of the record, which indicates its priority and processing method. This parameter applies to CAA records.</para>
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
                    /// <para>The priority of the record. Value range: <b>0 to 65535</b>. A smaller value indicates a higher priority. This parameter applies to MX, SRV, and URI records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
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
                    /// <para>The record value or partial content. This parameter is included in A/AAAA, CNAME, NS, MX, TXT, CAA, SRV, and URI records. The meaning varies by record type:</para>
                    /// <list type="bullet">
                    /// <item><description><b>A/AAAA</b>: the IP address. Separate multiple IP addresses with commas (,). At least one IPv4 address is required.</description></item>
                    /// <item><description><b>CNAME</b>: the target domain name.</description></item>
                    /// <item><description><b>NS</b>: the name server of the specified domain name.</description></item>
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

                /// <summary>
                /// <para>The description of the creation result.</para>
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
                /// <para>Specifies whether to enable proxied acceleration for the record. Only CNAME records and A/AAAA records support proxied acceleration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Proxied acceleration is enabled.</description></item>
                /// <item><description><b>false</b>: Proxied acceleration is disabled.</description></item>
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
                /// <para>The DNS type of the record, such as <b>A/AAAA, CNAME, or TXT</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A/AAAA</para>
                /// </summary>
                [NameInMap("RecordType")]
                [Validation(Required=false)]
                public string RecordType { get; set; }

                /// <summary>
                /// <para>The origin type of the CNAME record. This field is empty for other record types. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>OSS</b>: OSS origin.</description></item>
                /// <item><description><b>S3</b>: S3 origin.</description></item>
                /// <item><description><b>LB</b>: load balancing origin.</description></item>
                /// <item><description><b>OP</b>: IPAM pool origin.</description></item>
                /// <item><description><b>Domain</b>: common domain name origin.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The time-to-live (TTL) of the record, in seconds. A value of 1 indicates that the TTL is set to automatic.</para>
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
