// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class GlobalQueryContext : TeaModel {
        /// <summary>
        /// <para>The initial query condition.</para>
        /// </summary>
        [NameInMap("originalQuery")]
        [Validation(Required=false)]
        public GlobalQueryContextOriginalQuery OriginalQuery { get; set; }
        public class GlobalQueryContextOriginalQuery : TeaModel {
            /// <summary>
            /// <para>页码</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page")]
            [Validation(Required=false)]
            public string Page { get; set; }

            /// <summary>
            /// <para>查询关键字</para>
            /// 
            /// <b>Example:</b>
            /// <para>特朗普关税最新消息</para>
            /// </summary>
            [NameInMap("query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <para>时间范围</para>
            /// 
            /// <b>Example:</b>
            /// <para>NoLimit</para>
            /// </summary>
            [NameInMap("timeRange")]
            [Validation(Required=false)]
            public string TimeRange { get; set; }

        }

    }

}
