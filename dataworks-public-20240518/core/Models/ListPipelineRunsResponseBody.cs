// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListPipelineRunsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListPipelineRunsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListPipelineRunsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The returned page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>A list of deployment pipeline runs.</para>
            /// </summary>
            [NameInMap("PipelineRuns")]
            [Validation(Required=false)]
            public List<ListPipelineRunsResponseBodyPagingInfoPipelineRuns> PipelineRuns { get; set; }
            public class ListPipelineRunsResponseBodyPagingInfoPipelineRuns : TeaModel {
                /// <summary>
                /// <para>The creation timestamp of the deployment pipeline run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1702736654000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The creator of the deployment pipeline run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110755000425XXXX</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The description of the deployment pipeline run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Release process description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the deployment pipeline run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>097c73fe-ed6e-4fb1-b109-a5d59e46cd58</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The error message returned if the deployment pipeline run fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Error message</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The last modification timestamp of the deployment pipeline run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1702736654000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70199</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>A list of deployment stages.</para>
                /// </summary>
                [NameInMap("Stages")]
                [Validation(Required=false)]
                public List<ListPipelineRunsResponseBodyPagingInfoPipelineRunsStages> Stages { get; set; }
                public class ListPipelineRunsResponseBodyPagingInfoPipelineRunsStages : TeaModel {
                    /// <summary>
                    /// <para>The code of the deployment stage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DEV_CHECK</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The stage description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Check before going online to development</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Additional information about the deployment stage.</para>
                    /// </summary>
                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Detail { get; set; }

                    /// <summary>
                    /// <para>The error message returned if the deployment stage fails.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Error message</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The stage name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Check before going online to development</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The status of the deployment stage.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Init</c>: Initializing</para>
                    /// </description></item>
                    /// <item><description><para><c>Running</c>: Running</para>
                    /// </description></item>
                    /// <item><description><para><c>Success</c>: Succeeded</para>
                    /// </description></item>
                    /// <item><description><para><c>Fail</c>: Failed</para>
                    /// </description></item>
                    /// <item><description><para><c>Termination</c>: Terminated</para>
                    /// </description></item>
                    /// <item><description><para><c>Cancel</c>: Canceled</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Running</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The step number of the deployment stage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public int? Step { get; set; }

                    /// <summary>
                    /// <para>The type of the deployment stage.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Deploy</c>: A deploy operation</para>
                    /// </description></item>
                    /// <item><description><para><c>Check</c>: A check operation</para>
                    /// </description></item>
                    /// <item><description><para><c>Offline</c>: An offline operation</para>
                    /// </description></item>
                    /// <item><description><para><c>Build</c>: A build operation</para>
                    /// </description></item>
                    /// <item><description><para><c>Delete</c>: A delete operation</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Check</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The status of the deployment pipeline run.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Init</c>: Initializing</para>
                /// </description></item>
                /// <item><description><para><c>Running</c>: Running</para>
                /// </description></item>
                /// <item><description><para><c>Success</c>: Succeeded</para>
                /// </description></item>
                /// <item><description><para><c>Fail</c>: Failed</para>
                /// </description></item>
                /// <item><description><para><c>Termination</c>: Terminated</para>
                /// </description></item>
                /// <item><description><para><c>Cancel</c>: Canceled</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries that meet the filter criteria.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2524</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Use this ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C352CB7-CD88-50CF-9D0D-E81BDF02XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
