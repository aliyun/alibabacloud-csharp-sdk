// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DescribeAdvancedQueryHistoryResponseBody : TeaModel {
        [NameInMap("QueryHistoryList")]
        [Validation(Required=false)]
        public List<DescribeAdvancedQueryHistoryResponseBodyQueryHistoryList> QueryHistoryList { get; set; }
        public class DescribeAdvancedQueryHistoryResponseBodyQueryHistoryList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>query-uIkIvLiVSuCKqg0yoa****</para>
            /// </summary>
            [NameInMap("QueryId")]
            [Validation(Required=false)]
            public string QueryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>event.userIdentity.accessKeyId: *</para>
            /// </summary>
            [NameInMap("QuerySql")]
            [Validation(Required=false)]
            public string QuerySql { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SimpleQuery")]
            [Validation(Required=false)]
            public bool? SimpleQuery { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1753695874000</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>19F032B7-5FD8-5AC9-97FD-ACF54371****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
