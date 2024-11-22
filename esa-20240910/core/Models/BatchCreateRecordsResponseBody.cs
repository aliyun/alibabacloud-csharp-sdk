// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchCreateRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The records that have been created and failed to be created.</para>
        /// </summary>
        [NameInMap("RecordResultList")]
        [Validation(Required=false)]
        public BatchCreateRecordsResponseBodyRecordResultList RecordResultList { get; set; }
        public class BatchCreateRecordsResponseBodyRecordResultList : TeaModel {
            /// <summary>
            /// <para>The records that failed to be created.</para>
            /// </summary>
            [NameInMap("Failed")]
            [Validation(Required=false)]
            public List<BatchCreateRecordsResponseBodyRecordResultListFailed> Failed { get; set; }
            public class BatchCreateRecordsResponseBodyRecordResultListFailed : TeaModel {
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
                /// <para>The DNS information about the record, which contains various types of record values and their related attributes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;value&quot;:&quot;2.2.2.2&quot;}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public BatchCreateRecordsResponseBodyRecordResultListFailedData Data { get; set; }
                public class BatchCreateRecordsResponseBodyRecordResultListFailedData : TeaModel {
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
                    /// <para>The flag bit of the record. Indicates its priority and handling method, used in CAA records.</para>
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
                    /// <para>The algorithm policy used to match or validate the certificate. Valid values: 0 to 255. Applicable to SMIMEA and TLSA records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RSA</para>
                    /// </summary>
                    [NameInMap("MatchingType")]
                    [Validation(Required=false)]
                    public int? MatchingType { get; set; }

                    /// <summary>
                    /// <para>The port number of the record, associated with the SRV record. Exclusive to SRV records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The priority of the record. Valid values: 0 to 65535. A smaller value indicates a higher priority. Applicable to MX, SRV, and URI records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
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
                    /// <para>Indicates its priority and handling method, used in CAA records.</para>
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
                    /// <para>The record value or part of the record content. This value is returned when the record is A/AAAA, CNAME, NS, MX, TXT, CAA, SRV, or URI. It has different meanings based on types of records:</para>
                    /// <list type="bullet">
                    /// <item><description><b>A/AAAA</b>: the IP addresses. IP addresses are separated by commas (,). There is at least one IPv4 address.</description></item>
                    /// <item><description><b>CNAME</b>: the mapped domain name.</description></item>
                    /// <item><description><b>NS</b>: the nameservers for the domain name.</description></item>
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
                    /// <para>The weight of the record. Applicable to SRV and URI records.</para>
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
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the record is proxied. Only CNAME and A/AAAA records can be proxied. Valid values:</para>
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
                /// <para>The DNS type of the record, such as <b>A/AAAA, CNAME, and TXT</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A/AAAA</para>
                /// </summary>
                [NameInMap("RecordType")]
                [Validation(Required=false)]
                public string RecordType { get; set; }

                /// <summary>
                /// <para>The origin type of the CNAME record. This field is left empty for other types of records. The type of the origin server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>OSS</b>: OSS bucket.</description></item>
                /// <item><description><b>S3</b>: S3 bucket.</description></item>
                /// <item><description><b>LB</b>: load balancer.</description></item>
                /// <item><description><b>OP</b>: origin pool.</description></item>
                /// <item><description><b>Domain</b>: domain name.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The TTL of the record. Unit: seconds. If the value is 1, the TTL of the record is determined by the system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

            }

            /// <summary>
            /// <para>The records that have been created.</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public List<BatchCreateRecordsResponseBodyRecordResultListSuccess> Success { get; set; }
            public class BatchCreateRecordsResponseBodyRecordResultListSuccess : TeaModel {
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
                /// <para>The DNS record information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;value&quot;:&quot;1.1.1.1&quot;}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public BatchCreateRecordsResponseBodyRecordResultListSuccessData Data { get; set; }
                public class BatchCreateRecordsResponseBodyRecordResultListSuccessData : TeaModel {
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
                    /// <para>The flag bit of the record. Indicates its priority and handling method, used in CAA records.</para>
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
                    /// <para>The algorithm policy used to match or validate the certificate. Valid values: 0 to 255. Applicable to SMIMEA and TLSA records.</para>
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
                    /// <para>The priority of the record. Valid values: 0 to 65535. A smaller value indicates a higher priority. Applicable to MX, SRV, and URI records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
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
                    /// <para>The label of a CAA record, which indicates its specific type and purpose, such as issue, issuewild, and iodef.</para>
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
                    /// <para>The record value or part of the record content. This value is returned when the record is A/AAAA, CNAME, NS, MX, TXT, CAA, SRV, or URI. It has different meanings based on types of records:</para>
                    /// <list type="bullet">
                    /// <item><description><b>A/AAAA</b>: the IP addresses. Multiple IPs are separated by commas (,). There is at least one IPv4 address.</description></item>
                    /// <item><description><b>CNAME</b>: the mapped domain name.</description></item>
                    /// <item><description><b>NS</b>: the nameservers for the domain name.</description></item>
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
                    /// <para>The weight of the record. Valid values: 0 to 65535. Applicable to SRV and URI records.</para>
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

                /// <summary>
                /// <para>Indicates whether the record is proxied. Only CNAME and A/AAAA records can be proxied. Valid values:</para>
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
                /// <para>The DNS type of the record, such as <b>A/AAAA, CNAME, and TXT</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A/AAAA</para>
                /// </summary>
                [NameInMap("RecordType")]
                [Validation(Required=false)]
                public string RecordType { get; set; }

                /// <summary>
                /// <para>The origin type of the CNAME record. This field is left empty for other types of records. The type of the origin server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>OSS</b>: OSS bucket.</description></item>
                /// <item><description><b>S3</b>: S3 bucket.</description></item>
                /// <item><description><b>LB</b>: load balancer.</description></item>
                /// <item><description><b>OP</b>: origin pool.</description></item>
                /// <item><description><b>Domain</b>: domain name.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The TTL of the record. Unit: seconds. If the value is 1, the TTL of the record is determined by the system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

            }

            /// <summary>
            /// <para>The total number of returned records.</para>
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
