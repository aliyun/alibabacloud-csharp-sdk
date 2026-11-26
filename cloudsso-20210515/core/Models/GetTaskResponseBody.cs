// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>923CA5E8-57BF-5E15-8BA6-E75A966B7E3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task information.</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public GetTaskResponseBodyTask Task { get; set; }
        public class GetTaskResponseBodyTask : TeaModel {
            /// <summary>
            /// <para>The ID of the access configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ac-00jhtfl8thteu6uj****</para>
            /// </summary>
            [NameInMap("AccessConfigurationId")]
            [Validation(Required=false)]
            public string AccessConfigurationId { get; set; }

            /// <summary>
            /// <para>The name of the access configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS-Admin</para>
            /// </summary>
            [NameInMap("AccessConfigurationName")]
            [Validation(Required=false)]
            public string AccessConfigurationName { get; set; }

            /// <summary>
            /// <para>The end time of the task. The time is in UTC and follows the RFC 3339 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-05T02:58:08Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The reason why the task failed.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <c>Status</c> is <c>Failed</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>No Permission.</para>
            /// </summary>
            [NameInMap("FailureReason")]
            [Validation(Required=false)]
            public string FailureReason { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the target belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17xxxxxxxxxxxx73</para>
            /// </summary>
            [NameInMap("OriginTargetId")]
            [Validation(Required=false)]
            public string OriginTargetId { get; set; }

            /// <summary>
            /// <para>The ID of the CloudSSO identity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>u-00q8wbq42wiltcrk****</para>
            /// </summary>
            [NameInMap("PrincipalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            /// <summary>
            /// <para>The name of the CloudSSO identity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alice</para>
            /// </summary>
            [NameInMap("PrincipalName")]
            [Validation(Required=false)]
            public string PrincipalName { get; set; }

            /// <summary>
            /// <para>The CloudSSO identity type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>User: user.</description></item>
            /// <item><description>Group: user group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("PrincipalType")]
            [Validation(Required=false)]
            public string PrincipalType { get; set; }

            /// <summary>
            /// <para>The start time of the task. The time is in UTC and follows the RFC 3339 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-05T02:58:07Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>InProgress: The task is in progress.</description></item>
            /// <item><description>Success: The task succeeded.</description></item>
            /// <item><description>Failed: The task failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the task target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>114240524784****</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The name of the task target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev-test</para>
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// <para>The path ID of the task target in the resource directory.</para>
            /// </summary>
            [NameInMap("TargetPath")]
            [Validation(Required=false)]
            public string TargetPath { get; set; }

            /// <summary>
            /// <para>The path name of the task target in the resource directory.</para>
            /// </summary>
            [NameInMap("TargetPathName")]
            [Validation(Required=false)]
            public string TargetPathName { get; set; }

            /// <summary>
            /// <para>The task target type. Valid values: RD-Account, which indicates that the task target is an account in a resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RD-Account</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-shfqw1u1edszvxw5****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ProvisionAccessConfiguration: Deploys the access configuration.</description></item>
            /// <item><description>DeprovisionAccessConfiguration: Removes the access configuration deployment.</description></item>
            /// <item><description>CreateAccessAssignment: Grants authorization to an account in a resource directory.</description></item>
            /// <item><description>DeleteAccessAssignment: Revokes authorization from an account in a resource directory.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DeleteAccessAssignment</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

    }

}
