// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListCrossProjectPipelineRunsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business response data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RequestId&quot;:&quot;735894D1-D5E5-50B8-8A6D-041C90A98B23&quot;,&quot;PageNumber&quot;:1,&quot;PageSize&quot;:10,&quot;TotalCount&quot;:1,&quot;PipelineRuns&quot;:[{&quot;RequestId&quot;:&quot;735894D1-D5E5-50B8-8A6D-041C90A98B23&quot;,&quot;PipelineRunId&quot;:&quot;fcfd4160-e2ff-4603-9719-09128fe733df&quot;,&quot;DeploymentEnvironmentId&quot;:101,&quot;ObjectId&quot;:&quot;1&quot;,&quot;ObjectType&quot;:&quot;ODPS_SQL&quot;,&quot;ObjectName&quot;:&quot;object-1&quot;,&quot;ObjectVersion&quot;:&quot;7&quot;,&quot;ChangeType&quot;:&quot;ADD&quot;,&quot;Status&quot;:&quot;Ready&quot;,&quot;Description&quot;:&quot;Publish objects that have been published in the source project to the target project&quot;,&quot;Creator&quot;:&quot;creator&quot;,&quot;CreateTime&quot;:1788739200000}]}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCrossProjectPipelineRunsResponseBodyData Data { get; set; }
        public class ListCrossProjectPipelineRunsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
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
            /// <para>The list of cross-workspace publish pipelines that match the query conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;RequestId&quot;:&quot;735894D1-D5E5-50B8-8A6D-041C90A98B23&quot;,&quot;PipelineRunId&quot;:&quot;fcfd4160-e2ff-4603-9719-09128fe733df&quot;,&quot;DeploymentEnvironmentId&quot;:101,&quot;ObjectId&quot;:&quot;1&quot;,&quot;ObjectType&quot;:&quot;ODPS_SQL&quot;,&quot;ObjectName&quot;:&quot;object-1&quot;,&quot;ObjectVersion&quot;:&quot;7&quot;,&quot;ChangeType&quot;:&quot;ADD&quot;,&quot;Status&quot;:&quot;Ready&quot;,&quot;Description&quot;:&quot;Publish objects that have been published in the source project to the target project&quot;,&quot;Creator&quot;:&quot;creator&quot;,&quot;CreateTime&quot;:1788739200000}]</para>
            /// </summary>
            [NameInMap("PipelineRuns")]
            [Validation(Required=false)]
            public List<ListCrossProjectPipelineRunsResponseBodyDataPipelineRuns> PipelineRuns { get; set; }
            public class ListCrossProjectPipelineRunsResponseBodyDataPipelineRuns : TeaModel {
                /// <summary>
                /// <para>The termination time. This value is a UNIX timestamp in milliseconds. This parameter is returned only after the pipeline is terminated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1788739260000</para>
                /// </summary>
                [NameInMap("AbolishTime")]
                [Validation(Required=false)]
                public long? AbolishTime { get; set; }

                /// <summary>
                /// <para>The user who terminated the pipeline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>operator</para>
                /// </summary>
                [NameInMap("Abolisher")]
                [Validation(Required=false)]
                public string Abolisher { get; set; }

                /// <summary>
                /// <para>The change type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ADD</para>
                /// </summary>
                [NameInMap("ChangeType")]
                [Validation(Required=false)]
                public string ChangeType { get; set; }

                /// <summary>
                /// <para>The creation time. This value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1788739200000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>creator</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The cross-workspace publish environment ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>101</para>
                /// </summary>
                [NameInMap("DeploymentEnvironmentId")]
                [Validation(Required=false)]
                public long? DeploymentEnvironmentId { get; set; }

                /// <summary>
                /// <para>The description of the publish operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Publish objects that have been published in the source project to the target project</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DeploymentFailed</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Deployment failed</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The execution time. This value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1788739260000</para>
                /// </summary>
                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public long? ExecuteTime { get; set; }

                /// <summary>
                /// <para>The executor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>executor</para>
                /// </summary>
                [NameInMap("Executor")]
                [Validation(Required=false)]
                public string Executor { get; set; }

                /// <summary>
                /// <para>The completion time. This value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1788739320000</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <para>The publish object ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ObjectId")]
                [Validation(Required=false)]
                public string ObjectId { get; set; }

                /// <summary>
                /// <para>The name of the published object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>object-1</para>
                /// </summary>
                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

                /// <summary>
                /// <para>The publish object type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ODPS_SQL</para>
                /// </summary>
                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// <para>The version of the published object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("ObjectVersion")]
                [Validation(Required=false)]
                public string ObjectVersion { get; set; }

                /// <summary>
                /// <para>The ID of the cross-workspace publish pipeline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fcfd4160-e2ff-4603-9719-09128fe733df</para>
                /// </summary>
                [NameInMap("PipelineRunId")]
                [Validation(Required=false)]
                public string PipelineRunId { get; set; }

                /// <summary>
                /// <para>The request ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>735894D1-D5E5-50B8-8A6D-041C90A98B23</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <para>The publish flow status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Building: Building.</description></item>
                /// <item><description>Ready: Ready and waiting for execution.</description></item>
                /// <item><description>Running: Running.</description></item>
                /// <item><description>Termination: Terminated.</description></item>
                /// <item><description>Success: Succeeded.</description></item>
                /// <item><description>Fail: Failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Ready</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>735894D1-D5E5-50B8-8A6D-041C90A98B23</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>735894D1-D5E5-50B8-8A6D-041C90A98B23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
