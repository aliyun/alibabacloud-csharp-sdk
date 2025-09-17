// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class GetTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the task.</para>
        /// </summary>
        [NameInMap("task")]
        [Validation(Required=false)]
        public GetTaskResponseBodyTask Task { get; set; }
        public class GetTaskResponseBodyTask : TeaModel {
            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-09T00:46:03Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error returned for the task.</para>
            /// </summary>
            [NameInMap("error")]
            [Validation(Required=false)]
            public GetTaskResponseBodyTaskError Error { get; set; }
            public class GetTaskResponseBodyTaskError : TeaModel {
                /// <summary>
                /// <para>The error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OperationFailure.OperationFailed</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///      &quot;requestId&quot;: &quot;123****&quot;,
                ///      &quot;errorCode&quot;: &quot;InvalidRamUser.NoPermission&quot;,
                ///      &quot;errorMsg&quot;: &quot;Ram user is not authorized to perform the operation.&quot;
                /// }</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The code of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-8vbascjthm7kzhp3****</para>
            /// </summary>
            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The path of the resources. The relative resource ID. The resource path contains the complete resource location (parent resource/child resource).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Instance/i-8vbascjthm7kzhp3****
            /// Instance/r-8vbf5abe31c9c4d4/Account/cctest</para>
            /// </summary>
            [NameInMap("resourcePath")]
            [Validation(Required=false)]
            public string ResourcePath { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Instance</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The task state.</para>
            /// <para>Pending</para>
            /// <para>Running</para>
            /// <para>Succeeded</para>
            /// <para>Failed</para>
            /// <para>Cancelling</para>
            /// <para>Cancelled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Succeeded</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the task operation. Valid values: Create, Update, and Delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Create</para>
            /// </summary>
            [NameInMap("taskAction")]
            [Validation(Required=false)]
            public string TaskAction { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-433aead756057fff8189a7ce5****</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
