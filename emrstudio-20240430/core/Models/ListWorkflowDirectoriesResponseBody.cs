// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20240430.Models
{
    public class ListWorkflowDirectoriesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListWorkflowDirectoriesResponseBodyData> Data { get; set; }
        public class ListWorkflowDirectoriesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>wd-y98v7non5dx****</para>
            /// </summary>
            [NameInMap("directoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>目录名称。</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>wd-y98v7non5dx****</para>
            /// </summary>
            [NameInMap("parentDirectoryId")]
            [Validation(Required=false)]
            public string ParentDirectoryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>p-v7n28j0m4ol****</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>w-lxyy60mpgpg****</para>
            /// </summary>
            [NameInMap("workflowId")]
            [Validation(Required=false)]
            public string WorkflowId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
