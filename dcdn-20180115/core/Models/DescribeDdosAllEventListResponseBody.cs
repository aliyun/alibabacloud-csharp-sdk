// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDdosAllEventListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of events.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeDdosAllEventListResponseBodyDataList> DataList { get; set; }
        public class DescribeDdosAllEventListResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The peak attack traffic of volumetric attacks. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>800</para>
            /// </summary>
            [NameInMap("Bps")]
            [Validation(Required=false)]
            public long? Bps { get; set; }

            /// <summary>
            /// <para>The peak of connection flood attacks. Unit: connections per seconds (CPS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Cps")]
            [Validation(Required=false)]
            public long? Cps { get; set; }

            /// <summary>
            /// <para>The end of the time range during which data was queried. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-26T15:59:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The event ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>28069</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The type of the DDoS attack event that was queried. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>web-cc</b>: web resource exhaustion attacks</description></item>
            /// <item><description><b>cc</b>: connection flood attacks</description></item>
            /// <item><description><b>traffic</b>: volumetric attacks</description></item>
            /// <item><description>If you do not configure this parameter, DDoS attack events of all types are queried.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>web-cc</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The peak attack traffic of volumetric attacks. Unit: packets per second (PPS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>12000</para>
            /// </summary>
            [NameInMap("Pps")]
            [Validation(Required=false)]
            public long? Pps { get; set; }

            /// <summary>
            /// <para>The peak of web resource exhaustion attacks. Unit: queries per second (QPS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>7692</para>
            /// </summary>
            [NameInMap("Qps")]
            [Validation(Required=false)]
            public long? Qps { get; set; }

            /// <summary>
            /// <para>The beginning of the time range during which data was queried. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-09T10:03:31Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The attack target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

        }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page. Default value: <b>10</b>. Valid values: 5, 10, and 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D73A4243-CFBD-5110-876F-09237E77ECBD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
