// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class RunSearchCaseFullTextRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>farui</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("filterCondition")]
        [Validation(Required=false)]
        public RunSearchCaseFullTextRequestFilterCondition FilterCondition { get; set; }
        public class RunSearchCaseFullTextRequestFilterCondition : TeaModel {
            [NameInMap("caseNo")]
            [Validation(Required=false)]
            public string CaseNo { get; set; }

            [NameInMap("caseTitle")]
            [Validation(Required=false)]
            public string CaseTitle { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("pageParam")]
        [Validation(Required=false)]
        public RunSearchCaseFullTextRequestPageParam PageParam { get; set; }
        public class RunSearchCaseFullTextRequestPageParam : TeaModel {
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

        [NameInMap("referLevel")]
        [Validation(Required=false)]
        public string ReferLevel { get; set; }

        [NameInMap("sortKeyAndDirection")]
        [Validation(Required=false)]
        public Dictionary<string, string> SortKeyAndDirection { get; set; }

        [NameInMap("thread")]
        [Validation(Required=false)]
        public RunSearchCaseFullTextRequestThread Thread { get; set; }
        public class RunSearchCaseFullTextRequestThread : TeaModel {
            [NameInMap("messages")]
            [Validation(Required=false)]
            public List<RunSearchCaseFullTextRequestThreadMessages> Messages { get; set; }
            public class RunSearchCaseFullTextRequestThreadMessages : TeaModel {
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
