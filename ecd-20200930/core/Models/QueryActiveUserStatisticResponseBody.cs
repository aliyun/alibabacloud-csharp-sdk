// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class QueryActiveUserStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of data points.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of active user statistics.</para>
        /// </summary>
        [NameInMap("UserStatisticList")]
        [Validation(Required=false)]
        public List<QueryActiveUserStatisticResponseBodyUserStatisticList> UserStatisticList { get; set; }
        public class QueryActiveUserStatisticResponseBodyUserStatisticList : TeaModel {
            /// <summary>
            /// <para>The number of deduplicated active users within the statistical period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>56</para>
            /// </summary>
            [NameInMap("ActiveUserCount")]
            [Validation(Required=false)]
            public int? ActiveUserCount { get; set; }

            /// <summary>
            /// <para>The formatted date string in UTC+8, in the format of yyyy-MM-dd.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-30</para>
            /// </summary>
            [NameInMap("FormatDate")]
            [Validation(Required=false)]
            public string FormatDate { get; set; }

            /// <summary>
            /// <para>The epoch timestamp in milliseconds corresponding to the data point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1606723951000</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public long? TimeStamp { get; set; }

        }

    }

}
