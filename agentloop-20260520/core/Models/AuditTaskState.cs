// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class AuditTaskState : TeaModel {
        /// <summary>
        /// <para>The current expected sharing switch for the task.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The runtime error, which is returned only when runtimeStatus is error.</para>
        /// </summary>
        [NameInMap("runtimeError")]
        [Validation(Required=false)]
        public AuditTaskStateRuntimeError RuntimeError { get; set; }
        public class AuditTaskStateRuntimeError : TeaModel {
            /// <summary>
            /// <para>The error code, such as task_status_query_failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task_status_query_failed</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The error description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>error</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The ID of the status query request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GUID</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        /// <summary>
        /// <para>The runtime status, which appears only when includeRuntimeStatus=true is requested. Valid values: pending, starting, stopping, running, stopped, missing, drifted, and error. The list and get operations do not return deleting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("runtimeStatus")]
        [Validation(Required=false)]
        public string RuntimeStatus { get; set; }

        /// <summary>
        /// <para>The time when the remote status is checked. This field appears together with runtimeStatus.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("runtimeStatusCheckedAt")]
        [Validation(Required=false)]
        public string RuntimeStatusCheckedAt { get; set; }

        /// <summary>
        /// <para>The task details in JSON format.</para>
        /// </summary>
        [NameInMap("task")]
        [Validation(Required=false)]
        public Dictionary<string, object> Task { get; set; }

        /// <summary>
        /// <para>The stable ID of the task, which must be equal to task.taskId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom_host_intrusion_audit</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The current execution configuration version of the task. The minimum value is 1. Starting or stopping the task does not increment this version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public long? Version { get; set; }

    }

}
