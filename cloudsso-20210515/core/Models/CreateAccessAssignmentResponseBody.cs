// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class CreateAccessAssignmentResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4726AA56-E138-5C99-85E4-F493536D042F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task information.</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public CreateAccessAssignmentResponseBodyTask Task { get; set; }
        public class CreateAccessAssignmentResponseBodyTask : TeaModel {
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
            /// <para>The Alibaba Cloud account ID of the authorization target.</para>
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
            /// <item><description>User: A user.</description></item>
            /// <item><description>Group: A group.</description></item>
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
            /// <para>The target type of the task. Valid values: RD-Account: The task target is an account in a resource directory.</para>
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
            /// <para>t-sh6tceylhvgejpip****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task type. Valid values: CreateAccessAssignment: The task is an authorization task for an account in a resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreateAccessAssignment</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

    }

}
