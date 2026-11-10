// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchCreateRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of record creation results, including the details of successful and failed records.</para>
        /// </summary>
        [NameInMap("RecordResultList")]
        [Validation(Required=false)]
        public BatchCreateRecordsResponseBodyRecordResultList RecordResultList { get; set; }
        public class BatchCreateRecordsResponseBodyRecordResultList : TeaModel {
            /// <summary>
            /// <para>The list of failed records.</para>
            /// </summary>
            [NameInMap("Failed")]
            [Validation(Required=false)]
            public List<BatchCreateRecordsResponseBodyRecordResultListFailed> Failed { get; set; }
            public class BatchCreateRecordsResponseBodyRecordResultListFailed : TeaModel {
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
                /// <para>The DNS information of the record, including the values and related attributes of various record types.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;value&quot;:&quot;2.2.2.2&quot;}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public BatchCreateRecordsResponseBodyRecordResultListFailedData Data { get; set; }
                public class BatchCreateRecordsResponseBodyRecordResultListFailedData : TeaModel {
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
                    /// <para>The flag of the record. Indicates the priority and processing method. This parameter applies to CAA records.</para>
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
                    /// <para>The port number of the record. This parameter is associated with SRV records and applies only to SRV records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The priority of the record. Valid values: <b>0</b> to <b>65535</b>. A smaller value indicates a higher priority. This parameter applies to MX, SRV, and URI records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
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
                    /// <para>The tag of the CAA record. Indicates the specific type and purpose, such as issue, issuewild, or iodef.</para>
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
                    /// <para>The record value or partial content. This parameter is included in A/AAAA, CNAME, NS, MX, TXT, CAA, SRV, and URI records. It indicates different meanings in different record types:</para>
                    /// <list type="bullet">
                    /// <item><description><b>A/AAAA</b>: The target IP address. Separate multiple IP addresses with half-width commas (,). At least one IPv4 address is required.</description></item>
                    /// <item><description><b>CNAME</b>: The target domain name.</description></item>
                    /// <item><description><b>NS</b>: The name server of the specified domain name.</description></item>
                    /// <item><description><b>MX</b>: The valid domain name of the target mail server.</description></item>
                    /// <item><description><b>TXT</b>: The valid text character string.</description></item>
                    /// <item><description><b>CAA</b>: The valid domain name of the certificate issuing authority.</description></item>
                    /// <item><description><b>SRV</b>: The valid domain name of the target host.</description></item>
                    /// <item><description><b>URI</b>: The valid URI string.</description></item>
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

                /// <summary>
                /// <para>The HTTP port. By default, port 80 is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80,8080</para>
                /// </summary>
                [NameInMap("HttpPorts")]
                [Validation(Required=false)]
                public string HttpPorts { get; set; }

                /// <summary>
                /// <para>The HTTPS port. Port 443 is supported by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>443,8443</para>
                /// </summary>
                [NameInMap("HttpsPorts")]
                [Validation(Required=false)]
                public string HttpsPorts { get; set; }

                /// <summary>
                /// <para>Specifies whether proxy acceleration is enabled for the record. Only CNAME and A/AAAA records support proxy acceleration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Proxied")]
                [Validation(Required=false)]
                public bool? Proxied { get; set; }

                /// <summary>
                /// <para>The ID of the created record.</para>
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
                /// <para>The DNS record type, such as <b>A/AAAA</b>, <b>CNAME</b>, or <b>TXT</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A/AAAA</para>
                /// </summary>
                [NameInMap("RecordType")]
                [Validation(Required=false)]
                public string RecordType { get; set; }

                /// <summary>
                /// <para>The origin server type for CNAME records. This field is empty for other record types. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>OSS</b>: OSS origin server.</description></item>
                /// <item><description><b>S3</b>: S3 origin server.</description></item>
                /// <item><description><b>LB</b>: Load balancing origin server.</description></item>
                /// <item><description><b>OP</b>: Source IPAM pool origin server.</description></item>
                /// <item><description><b>Domain</b>: Common domain name origin server.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The time-to-live (TTL) of the record, in seconds. A value of 1 indicates that the TTL is automatic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

            }

            /// <summary>
            /// <para>The list of successful records.</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public List<BatchCreateRecordsResponseBodyRecordResultListSuccess> Success { get; set; }
            public class BatchCreateRecordsResponseBodyRecordResultListSuccess : TeaModel {
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
                    /// <para>The flag of the record. Indicates the priority and processing method. This parameter applies to CAA records.</para>
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
                    /// <para>The priority of the record. Valid values: <b>0</b> to <b>65535</b>. A smaller value indicates a higher priority. This parameter applies to MX, SRV, and URI records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
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
                    /// <para>The tag of the CAA record. Indicates the specific type and purpose, such as issue, issuewild, or iodef.</para>
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
                    /// <para>The record value or partial content. This parameter is included in A/AAAA, CNAME, NS, MX, TXT, CAA, SRV, and URI records. It indicates different meanings in different record types:</para>
                    /// <list type="bullet">
                    /// <item><description><b>A/AAAA</b>: The IP address. Separate multiple IP addresses with commas (,). At least one IPv4 address is required.</description></item>
                    /// <item><description><b>CNAME</b>: The target domain name.</description></item>
                    /// <item><description><b>NS</b>: The name server of the specified domain name.</description></item>
                    /// <item><description><b>MX</b>: The valid domain name of the target mail server.</description></item>
                    /// <item><description><b>TXT</b>: The valid text character string.</description></item>
                    /// <item><description><b>CAA</b>: The valid domain name of the certificate issuing authority.</description></item>
                    /// <item><description><b>SRV</b>: The valid domain name of the target host.</description></item>
                    /// <item><description><b>URI</b>: The valid URI string.</description></item>
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
                /// <para>The description of the creation result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The HTTP port. By default, port 80 is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80,8080</para>
                /// </summary>
                [NameInMap("HttpPorts")]
                [Validation(Required=false)]
                public string HttpPorts { get; set; }

                /// <summary>
                /// <para>The HTTPS port. Port 443 is supported by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>443,8443</para>
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
                /// <para>The DNS record type, such as <b>A/AAAA</b>, <b>CNAME</b>, or <b>TXT</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A/AAAA</para>
                /// </summary>
                [NameInMap("RecordType")]
                [Validation(Required=false)]
                public string RecordType { get; set; }

                /// <summary>
                /// <para>The origin server type for CNAME records. This field is empty for other record types. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>OSS</b>: OSS origin server.</description></item>
                /// <item><description><b>S3</b>: S3 origin server.</description></item>
                /// <item><description><b>LB</b>: Load balancing origin server.</description></item>
                /// <item><description><b>OP</b>: Source IPAM pool origin server.</description></item>
                /// <item><description><b>Domain</b>: Common domain name origin server.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The time-to-live (TTL) of the record, in seconds. A value of 1 indicates that the TTL is automatic.</para>
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
