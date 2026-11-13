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
            /// <para>The page number of the returned page.</para>
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
            /// <para>The list of deployment pipelines.</para>
            /// </summary>
            [NameInMap("PipelineRuns")]
            [Validation(Required=false)]
            public List<ListPipelineRunsResponseBodyPagingInfoPipelineRuns> PipelineRuns { get; set; }
            public class ListPipelineRunsResponseBodyPagingInfoPipelineRuns : TeaModel {
                /// <summary>
                /// <para>The timestamp when the deployment package was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1702736654000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The creator of the deployment pipeline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110755000425XXXX</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The description of the deployment pipeline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Deployment pipeline description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the deployment pipeline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>097c73fe-ed6e-4fb1-b109-a5d59e46cd58</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The error message returned when an error occurs during a deployment stage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Error message</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The time when the deployment pipeline was updated.</para>
                /// <para>The value is a 13-digit timestamp, such as <c>1702736654000</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1702736654000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The ID of the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70199</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The list of deployment stages.</para>
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
                    /// <para>The description of the deployment stage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Check before going online to development</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The additional supplementary information about the deployment stage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;checkerList&quot;: [{&quot;code&quot;: &quot;BuildPackageChecker&quot;, &quot;name&quot;: &quot;package check&quot;}, {&quot;code&quot;: &quot;NodeParentDependency&quot;, &quot;name&quot;: &quot;downstream dependency check&quot;}, {&quot;code&quot;: &quot;NodeInProcess&quot;, &quot;name&quot;: &quot;offline process check&quot;}]}</para>
                    /// </summary>
                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Detail { get; set; }

                    /// <summary>
                    /// <para>The error message returned when an error occurs during a deployment stage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Error message</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The name of the deployment stage.</para>
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
                    /// <item><description>Init: Initialized.</description></item>
                    /// <item><description>Running: Running.</description></item>
                    /// <item><description>Success: Succeeded.</description></item>
                    /// <item><description>Fail: Failed.</description></item>
                    /// <item><description>Termination: Terminated.</description></item>
                    /// <item><description>Cancel: Canceled.</description></item>
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
                    /// <para>The type of the deployment stage. This parameter categorizes the operation type of the deployment stage.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Deploy: Deployment operation.</description></item>
                    /// <item><description>Check: Check operation.</description></item>
                    /// <item><description>Offline: Undeployment operation.</description></item>
                    /// <item><description>Build: Build operation.</description></item>
                    /// <item><description>Delete: Delete operation.</description></item>
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
                /// <para>The status of the deployment pipeline.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Init: Initialized.</description></item>
                /// <item><description>Running: Running.</description></item>
                /// <item><description>Success: Succeeded.</description></item>
                /// <item><description>Fail: Failed.</description></item>
                /// <item><description>Termination: Terminated.</description></item>
                /// <item><description>Cancel: Canceled.</description></item>
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
            /// <para>The total number of entries that meet the filter conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2524</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C352CB7-CD88-50CF-9D0D-E81BDF02XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
