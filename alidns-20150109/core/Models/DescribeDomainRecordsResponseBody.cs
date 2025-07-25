// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned Domain Name System (DNS) records.</para>
        /// </summary>
        [NameInMap("DomainRecords")]
        [Validation(Required=false)]
        public DescribeDomainRecordsResponseBodyDomainRecords DomainRecords { get; set; }
        public class DescribeDomainRecordsResponseBodyDomainRecords : TeaModel {
            [NameInMap("Record")]
            [Validation(Required=false)]
            public List<DescribeDomainRecordsResponseBodyDomainRecordsRecord> Record { get; set; }
            public class DescribeDomainRecordsResponseBodyDomainRecordsRecord : TeaModel {
                /// <summary>
                /// <para>The time when the DNS record was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since 00:00:00 UTC on January 1, 1970.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1666501957000</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("LbaStatus")]
                [Validation(Required=false)]
                public bool? LbaStatus { get; set; }

                /// <summary>
                /// <para>The resolution line.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Line")]
                [Validation(Required=false)]
                public string Line { get; set; }

                /// <summary>
                /// <para>Indicates whether the DNS record is locked.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Locked")]
                [Validation(Required=false)]
                public bool? Locked { get; set; }

                /// <summary>
                /// <para>The priority of the mail exchanger (MX) record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public long? Priority { get; set; }

                /// <summary>
                /// <para>The hostname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>www</para>
                /// </summary>
                [NameInMap("RR")]
                [Validation(Required=false)]
                public string RR { get; set; }

                /// <summary>
                /// <para>The ID of the DNS record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9999985</para>
                /// </summary>
                [NameInMap("RecordId")]
                [Validation(Required=false)]
                public string RecordId { get; set; }

                /// <summary>
                /// <para>The description of the DNS record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The status of the DNS record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time-to-live (TTL) of the cached DNS record. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("TTL")]
                [Validation(Required=false)]
                public long? TTL { get; set; }

                /// <summary>
                /// <para>The type of the DNS record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MX</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The time when the DNS record was updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since 00:00:00 UTC on January 1, 1970.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1676872961000</para>
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

                /// <summary>
                /// <para>The record value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mail1.hichina.com</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The weight of the DNS record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
