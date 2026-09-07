// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class QueryHistoryActiveUserStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5CC5E450-FC43-4F5B-B540-9964BD313427</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of daily active user statistics.</para>
        /// </summary>
        [NameInMap("UserStatisticList")]
        [Validation(Required=false)]
        public List<QueryHistoryActiveUserStatisticResponseBodyUserStatisticList> UserStatisticList { get; set; }
        public class QueryHistoryActiveUserStatisticResponseBodyUserStatisticList : TeaModel {
            /// <summary>
            /// <para>The number of deduplicated active users on the day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>150</para>
            /// </summary>
            [NameInMap("ActiveUserCount")]
            [Validation(Required=false)]
            public int? ActiveUserCount { get; set; }

            /// <summary>
            /// <para>The date in the standard yyyy-MM-dd format, in the UTC+8 time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-01</para>
            /// </summary>
            [NameInMap("FormatDate")]
            [Validation(Required=false)]
            public string FormatDate { get; set; }

            /// <summary>
            /// <para>The timestamp of the date, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735689600000</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public long? TimeStamp { get; set; }

        }

    }

}
