// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class DeleteAccessAssignmentResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5C9D0CF4-5CE8-5CE6-932A-826EF4ADD007</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task information.</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public DeleteAccessAssignmentResponseBodyTask Task { get; set; }
        public class DeleteAccessAssignmentResponseBodyTask : TeaModel {
            /// <summary>
            /// <para>The access configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ac-00jhtfl8thteu6uj****</para>
            /// </summary>
            [NameInMap("AccessConfigurationId")]
            [Validation(Required=false)]
            public string AccessConfigurationId { get; set; }

            /// <summary>
            /// <para>The access configuration name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS-Admin</para>
            /// </summary>
            [NameInMap("AccessConfigurationName")]
            [Validation(Required=false)]
            public string AccessConfigurationName { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the authorization target belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>114240524784****</para>
            /// </summary>
            [NameInMap("OriginTargetId")]
            [Validation(Required=false)]
            public string OriginTargetId { get; set; }

            /// <summary>
            /// <para>The CloudSSO identity ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>u-00q8wbq42wiltcrk****</para>
            /// </summary>
            [NameInMap("PrincipalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            /// <summary>
            /// <para>The CloudSSO identity name.</para>
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
            /// <item><description>Group: group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("PrincipalType")]
            [Validation(Required=false)]
            public string PrincipalType { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>InProgress: The task is in progress.</description></item>
            /// <item><description>Success: The task is successful.</description></item>
            /// <item><description>Failed: The task failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InProgress</para>
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
            /// <para>The type of the task target. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RD-Account: an account in a resource directory.</description></item>
            /// </list>
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
            /// <item><description>DeleteAccessAssignment: the task of removing authorization from an account in a resource directory.</description></item>
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
