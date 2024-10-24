// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainQPSListResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the statistics on the QPS of the website.</para>
        /// </summary>
        [NameInMap("DomainQPSList")]
        [Validation(Required=false)]
        public List<DescribeDomainQPSListResponseBodyDomainQPSList> DomainQPSList { get; set; }
        public class DescribeDomainQPSListResponseBodyDomainQPSList : TeaModel {
            /// <summary>
            /// <para>The attack QPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AttackQps")]
            [Validation(Required=false)]
            public long? AttackQps { get; set; }

            /// <summary>
            /// <para>The number of cache hits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CacheHits")]
            [Validation(Required=false)]
            public long? CacheHits { get; set; }

            /// <summary>
            /// <para>The index number of the returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// <para>The peak attack QPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>37</para>
            /// </summary>
            [NameInMap("MaxAttackQps")]
            [Validation(Required=false)]
            public long? MaxAttackQps { get; set; }

            /// <summary>
            /// <para>The peak of normal QPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>93</para>
            /// </summary>
            [NameInMap("MaxNormalQps")]
            [Validation(Required=false)]
            public long? MaxNormalQps { get; set; }

            /// <summary>
            /// <para>The peak of total QPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>130</para>
            /// </summary>
            [NameInMap("MaxQps")]
            [Validation(Required=false)]
            public long? MaxQps { get; set; }

            /// <summary>
            /// <para>The time when the data was collected. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582992000</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            /// <summary>
            /// <para>The total number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20008</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// <para>The total QPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalQps")]
            [Validation(Required=false)]
            public long? TotalQps { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>327F2ABB-104D-437A-AAB5-D633E29A8C51</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
