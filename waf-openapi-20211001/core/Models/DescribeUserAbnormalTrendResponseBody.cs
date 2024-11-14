// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeUserAbnormalTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The trends of risks.</para>
        /// </summary>
        [NameInMap("Trend")]
        [Validation(Required=false)]
        public List<DescribeUserAbnormalTrendResponseBodyTrend> Trend { get; set; }
        public class DescribeUserAbnormalTrendResponseBodyTrend : TeaModel {
            /// <summary>
            /// <para>The number of high risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("AbnormalHigh")]
            [Validation(Required=false)]
            public long? AbnormalHigh { get; set; }

            /// <summary>
            /// <para>The number of low risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("AbnormalLow")]
            [Validation(Required=false)]
            public long? AbnormalLow { get; set; }

            /// <summary>
            /// <para>The number of medium risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14</para>
            /// </summary>
            [NameInMap("AbnormalMedium")]
            [Validation(Required=false)]
            public long? AbnormalMedium { get; set; }

            /// <summary>
            /// <para>The time at which the API was called. The value is a UNIX timestamp displayed in UTC. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1722268800</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public long? TimeStamp { get; set; }

            /// <summary>
            /// <para>The time at which the API was called. The value is a UNIX timestamp displayed in UTC. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1722268800</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

    }

}
