// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class QueryContext : TeaModel {
        /// <summary>
        /// <para>The initial query condition.</para>
        /// </summary>
        [NameInMap("originalQuery")]
        [Validation(Required=false)]
        public QueryContextOriginalQuery OriginalQuery { get; set; }
        public class QueryContextOriginalQuery : TeaModel {
            /// <summary>
            /// <para>The industry classification of the original request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>medical</para>
            /// </summary>
            [NameInMap("industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

            /// <summary>
            /// <para>The page number of the original request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page")]
            [Validation(Required=false)]
            public string Page { get; set; }

            /// <summary>
            /// <para>The query content of the original request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Apsara Conference</para>
            /// </summary>
            [NameInMap("query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <para>The time range of the original request. Valid values: OneDay, OneWeek, OneMonth, OneYear, and NoLimit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NoLimit</para>
            /// </summary>
            [NameInMap("timeRange")]
            [Validation(Required=false)]
            public string TimeRange { get; set; }

        }

        /// <summary>
        /// <para>The query rewrite information.</para>
        /// </summary>
        [NameInMap("rewrite")]
        [Validation(Required=false)]
        public QueryContextRewrite Rewrite { get; set; }
        public class QueryContextRewrite : TeaModel {
            /// <summary>
            /// <para>Specifies whether query rewrite is enabled.</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The rewritten time range. An empty value indicates that no rewrite is performed or the rewrite result is the same as the original result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OneYear</para>
            /// </summary>
            [NameInMap("timeRange")]
            [Validation(Required=false)]
            public string TimeRange { get; set; }

        }

    }

}
