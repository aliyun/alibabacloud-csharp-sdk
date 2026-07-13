// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeRecursionRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the record was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-23T13:09Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates when the record was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The priority of the Mail Exchange (MX) record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The record ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1903634198947606528</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public string RecordId { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6856BCF6-11D6-4D7E-AC53-FD579933522B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The host record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Rr")]
        [Validation(Required=false)]
        public string Rr { get; set; }

        /// <summary>
        /// <para>The Time to Live (TTL).</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>The type of the DNS record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The time when the record was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-29T13:20Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates when the record was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

        /// <summary>
        /// <para>The value of the DNS record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.XX.XX</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>The weight.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172635074000011</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
