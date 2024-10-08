// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchCreateRecordsResponseBody : TeaModel {
        [NameInMap("RecordResultList")]
        [Validation(Required=false)]
        public BatchCreateRecordsResponseBodyRecordResultList RecordResultList { get; set; }
        public class BatchCreateRecordsResponseBodyRecordResultList : TeaModel {
            [NameInMap("Failed")]
            [Validation(Required=false)]
            public List<BatchCreateRecordsResponseBodyRecordResultListFailed> Failed { get; set; }
            public class BatchCreateRecordsResponseBodyRecordResultListFailed : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>web</para>
                /// </summary>
                [NameInMap("BizName")]
                [Validation(Required=false)]
                public string BizName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;value&quot;:&quot;2.2.2.2&quot;}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public BatchCreateRecordsResponseBodyRecordResultListFailedData Data { get; set; }
                public class BatchCreateRecordsResponseBodyRecordResultListFailedData : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Algorithm")]
                    [Validation(Required=false)]
                    public int? Algorithm { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dGVzdGFkYWxrcw==</para>
                    /// </summary>
                    [NameInMap("Certificate")]
                    [Validation(Required=false)]
                    public string Certificate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>abcdef1234567890</para>
                    /// </summary>
                    [NameInMap("Fingerprint")]
                    [Validation(Required=false)]
                    public string Fingerprint { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>128</para>
                    /// </summary>
                    [NameInMap("Flag")]
                    [Validation(Required=false)]
                    public int? Flag { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("KeyTag")]
                    [Validation(Required=false)]
                    public int? KeyTag { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>RSA</para>
                    /// </summary>
                    [NameInMap("MatchingType")]
                    [Validation(Required=false)]
                    public int? MatchingType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public int? Priority { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Selector")]
                    [Validation(Required=false)]
                    public int? Selector { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>issue</para>
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Usage")]
                    [Validation(Required=false)]
                    public int? Usage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>example.com</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Proxied")]
                [Validation(Required=false)]
                public bool? Proxied { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234567890123</para>
                /// </summary>
                [NameInMap("RecordId")]
                [Validation(Required=false)]
                public long? RecordId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>a.example.com</para>
                /// </summary>
                [NameInMap("RecordName")]
                [Validation(Required=false)]
                public string RecordName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>A/AAAA</para>
                /// </summary>
                [NameInMap("RecordType")]
                [Validation(Required=false)]
                public string RecordType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

            }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public List<BatchCreateRecordsResponseBodyRecordResultListSuccess> Success { get; set; }
            public class BatchCreateRecordsResponseBodyRecordResultListSuccess : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>web</para>
                /// </summary>
                [NameInMap("BizName")]
                [Validation(Required=false)]
                public string BizName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;value&quot;:&quot;1.1.1.1&quot;}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public BatchCreateRecordsResponseBodyRecordResultListSuccessData Data { get; set; }
                public class BatchCreateRecordsResponseBodyRecordResultListSuccessData : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Algorithm")]
                    [Validation(Required=false)]
                    public int? Algorithm { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dGVzdGFkYWxrcw==</para>
                    /// </summary>
                    [NameInMap("Certificate")]
                    [Validation(Required=false)]
                    public string Certificate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>abcdef1234567890</para>
                    /// </summary>
                    [NameInMap("Fingerprint")]
                    [Validation(Required=false)]
                    public string Fingerprint { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>128</para>
                    /// </summary>
                    [NameInMap("Flag")]
                    [Validation(Required=false)]
                    public int? Flag { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("KeyTag")]
                    [Validation(Required=false)]
                    public int? KeyTag { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MatchingType")]
                    [Validation(Required=false)]
                    public int? MatchingType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public int? Priority { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Selector")]
                    [Validation(Required=false)]
                    public int? Selector { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>issue</para>
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Usage")]
                    [Validation(Required=false)]
                    public int? Usage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>example.com</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Proxied")]
                [Validation(Required=false)]
                public bool? Proxied { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234567890123</para>
                /// </summary>
                [NameInMap("RecordId")]
                [Validation(Required=false)]
                public long? RecordId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("RecordName")]
                [Validation(Required=false)]
                public string RecordName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>A/AAAA</para>
                /// </summary>
                [NameInMap("RecordType")]
                [Validation(Required=false)]
                public string RecordType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2430E05E-1340-5773-B5E1-B743929F46F2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
