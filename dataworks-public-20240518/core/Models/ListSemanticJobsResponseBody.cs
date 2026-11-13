// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListSemanticJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The paged results of job definitions. Use the Name of a list item to run or delete a job, query its run records, or download its results. Use the ProjectId to query run details and logs, or stop a run.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSemanticJobsResponseBodyData Data { get; set; }
        public class ListSemanticJobsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page. Pages start from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of job definitions returned on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of job definitions.</para>
            /// </summary>
            [NameInMap("SemanticJobs")]
            [Validation(Required=false)]
            public List<ListSemanticJobsResponseBodyDataSemanticJobs> SemanticJobs { get; set; }
            public class ListSemanticJobsResponseBodyDataSemanticJobs : TeaModel {
                /// <summary>
                /// <para>The user identifier of the creator of the semantic job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user-demo</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1700000000000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The last modification time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1700000000000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>The internal unique ID of the job definition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The job name. This name is used in RunSemanticJob, DeleteSemanticJob, ListSemanticJobRuns, and DownloadSemanticResults.</para>
                /// 
                /// <b>Example:</b>
                /// <para>semantic-job-demo</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the workspace to which the job belongs. This ID is used in GetSemanticJobDetail, GetSemanticJobLog, and KillSemanticJob.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The list of IDs of the uploaded files associated with the job.</para>
                /// </summary>
                [NameInMap("ReferenceFileIds")]
                [Validation(Required=false)]
                public List<string> ReferenceFileIds { get; set; }

                /// <summary>
                /// <para>The list of URIs of the external reference files associated with the job.</para>
                /// </summary>
                [NameInMap("ReferenceFileUris")]
                [Validation(Required=false)]
                public List<string> ReferenceFileUris { get; set; }

                /// <summary>
                /// <para>The identifier of the resource group used to run the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-demo</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The input data source configuration saved for the job. The job uses this configuration to determine the analysis scope at runtime.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;type&quot;:&quot;maxcompute&quot;,&quot;domain&quot;:&quot;sales&quot;,&quot;pinnedScopeInfo&quot;:[{&quot;type&quot;:&quot;project&quot;,&quot;name&quot;:&quot;mc_project&quot;}]}</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public Dictionary<string, object> Source { get; set; }

                /// <summary>
                /// <para>The data source type saved in the Source.type field of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>maxcompute</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The user identifier of the creator of the semantic job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user-demo</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The total number of job definitions that meet the query conditions in the current tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to locate logs and troubleshoot issues.</para>
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
