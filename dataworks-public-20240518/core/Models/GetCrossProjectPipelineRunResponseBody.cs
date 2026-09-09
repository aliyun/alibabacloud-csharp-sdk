// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetCrossProjectPipelineRunResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;RequestId&quot;:&quot;735894D1-D5E5-50B8-8A6D-041C90A98B23&quot;,&quot;PipelineRunId&quot;:&quot;fcfd4160-e2ff-4603-9719-09128fe733df&quot;,&quot;DeploymentEnvironmentId&quot;:101,&quot;ObjectId&quot;:&quot;1&quot;,&quot;ObjectType&quot;:&quot;ODPS_SQL&quot;,&quot;ObjectName&quot;:&quot;object-1&quot;,&quot;ObjectVersion&quot;:&quot;7&quot;,&quot;ChangeType&quot;:&quot;ADD&quot;,&quot;Status&quot;:&quot;Ready&quot;,&quot;Description&quot;:&quot;将源项目已发布的对象发布到目标项目&quot;,&quot;Creator&quot;:&quot;creator&quot;,&quot;CreateTime&quot;:1788739200000}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCrossProjectPipelineRunResponseBodyData Data { get; set; }
        public class GetCrossProjectPipelineRunResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1788739260000</para>
            /// </summary>
            [NameInMap("AbolishTime")]
            [Validation(Required=false)]
            public long? AbolishTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>operator</para>
            /// </summary>
            [NameInMap("Abolisher")]
            [Validation(Required=false)]
            public string Abolisher { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ADD</para>
            /// </summary>
            [NameInMap("ChangeType")]
            [Validation(Required=false)]
            public string ChangeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1788739200000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>creator</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("DeploymentEnvironmentId")]
            [Validation(Required=false)]
            public long? DeploymentEnvironmentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>将源项目已发布的对象发布到目标项目</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DeploymentFailed</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Deployment failed</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1788739260000</para>
            /// </summary>
            [NameInMap("ExecuteTime")]
            [Validation(Required=false)]
            public long? ExecuteTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>executor</para>
            /// </summary>
            [NameInMap("Executor")]
            [Validation(Required=false)]
            public string Executor { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1788739320000</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ObjectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>object-1</para>
            /// </summary>
            [NameInMap("ObjectName")]
            [Validation(Required=false)]
            public string ObjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ODPS_SQL</para>
            /// </summary>
            [NameInMap("ObjectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("ObjectVersion")]
            [Validation(Required=false)]
            public string ObjectVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fcfd4160-e2ff-4603-9719-09128fe733df</para>
            /// </summary>
            [NameInMap("PipelineRunId")]
            [Validation(Required=false)]
            public string PipelineRunId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>735894D1-D5E5-50B8-8A6D-041C90A98B23</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Ready</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>735894D1-D5E5-50B8-8A6D-041C90A98B23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
