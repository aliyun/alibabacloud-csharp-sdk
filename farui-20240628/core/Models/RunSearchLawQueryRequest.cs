// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class RunSearchLawQueryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>farui</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("filterCondition")]
        [Validation(Required=false)]
        public RunSearchLawQueryRequestFilterCondition FilterCondition { get; set; }
        public class RunSearchLawQueryRequestFilterCondition : TeaModel {
            [NameInMap("lawName")]
            [Validation(Required=false)]
            public string LawName { get; set; }

        }

        [NameInMap("pageParam")]
        [Validation(Required=false)]
        public RunSearchLawQueryRequestPageParam PageParam { get; set; }
        public class RunSearchLawQueryRequestPageParam : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("queryKeywords")]
        [Validation(Required=false)]
        public List<string> QueryKeywords { get; set; }

        [NameInMap("thread")]
        [Validation(Required=false)]
        public RunSearchLawQueryRequestThread Thread { get; set; }
        public class RunSearchLawQueryRequestThread : TeaModel {
            [NameInMap("messages")]
            [Validation(Required=false)]
            public List<RunSearchLawQueryRequestThreadMessages> Messages { get; set; }
            public class RunSearchLawQueryRequestThreadMessages : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

        }

    }

}
