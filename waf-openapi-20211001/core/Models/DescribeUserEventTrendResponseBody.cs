// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeUserEventTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F51E6DD6-B2D2-57C9-90F1-FAFD0A19DE00</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The trends of attacks.</para>
        /// </summary>
        [NameInMap("Trend")]
        [Validation(Required=false)]
        public List<DescribeUserEventTrendResponseBodyTrend> Trend { get; set; }
        public class DescribeUserEventTrendResponseBodyTrend : TeaModel {
            /// <summary>
            /// <para>The number of high-risk events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("EventHigh")]
            [Validation(Required=false)]
            public long? EventHigh { get; set; }

            /// <summary>
            /// <para>The number of low-risk events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("EventLow")]
            [Validation(Required=false)]
            public long? EventLow { get; set; }

            /// <summary>
            /// <para>The number of medium-risk events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17</para>
            /// </summary>
            [NameInMap("EventMedium")]
            [Validation(Required=false)]
            public long? EventMedium { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The time at which the API was called. The value is a UNIX timestamp displayed in UTC. Unit: seconds.</para>
            /// <remarks>
            /// <para>Notice: The parameter has been deprecated, it is recommended to use the Timestamp parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1723435200</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            [Obsolete]
            public long? TimeStamp { get; set; }

            /// <summary>
            /// <para>The time at which the API was called. The value is a UNIX timestamp displayed in UTC. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1723435200</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

    }

}
