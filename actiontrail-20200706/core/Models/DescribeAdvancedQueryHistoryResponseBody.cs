// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DescribeAdvancedQueryHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of advanced query records.</para>
        /// </summary>
        [NameInMap("QueryHistoryList")]
        [Validation(Required=false)]
        public List<DescribeAdvancedQueryHistoryResponseBodyQueryHistoryList> QueryHistoryList { get; set; }
        public class DescribeAdvancedQueryHistoryResponseBodyQueryHistoryList : TeaModel {
            /// <summary>
            /// <para>The ID of the advanced query record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>query-uIkIvLiVSuCKqg0yoa****</para>
            /// </summary>
            [NameInMap("QueryId")]
            [Validation(Required=false)]
            public string QueryId { get; set; }

            /// <summary>
            /// <para>The conditional statement for the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>event.userIdentity.accessKeyId: *</para>
            /// </summary>
            [NameInMap("QuerySql")]
            [Validation(Required=false)]
            public string QuerySql { get; set; }

            /// <summary>
            /// <para>Indicates whether simple query mode is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SimpleQuery")]
            [Validation(Required=false)]
            public bool? SimpleQuery { get; set; }

            /// <summary>
            /// <para>The time when the advanced query record was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1753695874000</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19F032B7-5FD8-5AC9-97FD-ACF54371****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
