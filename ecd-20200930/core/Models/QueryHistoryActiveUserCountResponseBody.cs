// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class QueryHistoryActiveUserCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The active user statistics.</para>
        /// </summary>
        [NameInMap("ActiveUserCount")]
        [Validation(Required=false)]
        public QueryHistoryActiveUserCountResponseBodyActiveUserCount ActiveUserCount { get; set; }
        public class QueryHistoryActiveUserCountResponseBodyActiveUserCount : TeaModel {
            /// <summary>
            /// <para>The number of daily active users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("DailyActiveUserCount")]
            [Validation(Required=false)]
            public int? DailyActiveUserCount { get; set; }

            /// <summary>
            /// <para>The number of monthly active users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("MonthlyActiveUserCount")]
            [Validation(Required=false)]
            public int? MonthlyActiveUserCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890abcdefg</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
