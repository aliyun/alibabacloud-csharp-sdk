// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListSemanticJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The paginated result of task definitions. Use the Name field of a list item to run, delete, query run records, or download results. Use the ProjectId field to query run details, view logs, or stop a run.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSemanticJobsResponseBodyData Data { get; set; }
        public class ListSemanticJobsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page, starting from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of task definitions per page in the current response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of task definitions.</para>
            /// </summary>
            [NameInMap("SemanticJobs")]
            [Validation(Required=false)]
            public List<ListSemanticJobsResponseBodyDataSemanticJobs> SemanticJobs { get; set; }
            public class ListSemanticJobsResponseBodyDataSemanticJobs : TeaModel {
                /// <summary>
                /// <para>The user ID of the semantic task creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user-demo</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The creation time, expressed as a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1700000000000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The last modification time, expressed as a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1700000000000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>The internal unique ID of the task definition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The task name. Used for RunSemanticJob, DeleteSemanticJob, ListSemanticJobRuns, and DownloadSemanticResults.</para>
                /// 
                /// <b>Example:</b>
                /// <para>semantic-job-demo</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The workspace ID to which the task belongs. Used for GetSemanticJobDetail, GetSemanticJobLog, and KillSemanticJob.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The list of uploaded file IDs associated with the task.</para>
                /// </summary>
                [NameInMap("ReferenceFileIds")]
                [Validation(Required=false)]
                public List<string> ReferenceFileIds { get; set; }

                /// <summary>
                /// <para>The list of external reference file URIs associated with the task.</para>
                /// </summary>
                [NameInMap("ReferenceFileUris")]
                [Validation(Required=false)]
                public List<string> ReferenceFileUris { get; set; }

                /// <summary>
                /// <para>The ID of the resource group used to run this task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-demo</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The input datasource config saved in the node. This configuration determines the analysis scope at runtime.</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public Dictionary<string, object> Source { get; set; }

                /// <summary>
                /// <para>The Source.type data source type saved in the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>maxcompute</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The user ID of the semantic task creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user-demo</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The total number of task definitions that meet the conditions within the current tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Used for locating logs and troubleshooting issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>676271D6-53B4-57BE-89FA-72F7AE1418DF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
