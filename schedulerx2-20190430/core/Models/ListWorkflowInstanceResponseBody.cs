// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ListWorkflowInstanceResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public ListWorkflowInstanceResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class ListWorkflowInstanceResponseBodyAccessDeniedDetail : TeaModel {
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about workflow instances.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListWorkflowInstanceResponseBodyData Data { get; set; }
        public class ListWorkflowInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The workflow instances.</para>
            /// </summary>
            [NameInMap("WfInstanceInfos")]
            [Validation(Required=false)]
            public List<ListWorkflowInstanceResponseBodyDataWfInstanceInfos> WfInstanceInfos { get; set; }
            public class ListWorkflowInstanceResponseBodyDataWfInstanceInfos : TeaModel {
                /// <summary>
                /// <para>The data timestamp of the workflow instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-03 18:00:00</para>
                /// </summary>
                [NameInMap("DataTime")]
                [Validation(Required=false)]
                public string DataTime { get; set; }

                /// <summary>
                /// <para>The time when the workflow instance stopped running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-03 18:00:21</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The time when the workflow instance was scheduled to run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-03 18:00:00</para>
                /// </summary>
                [NameInMap("ScheduleTime")]
                [Validation(Required=false)]
                public string ScheduleTime { get; set; }

                /// <summary>
                /// <para>The time when the workflow instance started to run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-03 18:00:01</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The state of the workflow instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: pending</description></item>
                /// <item><description>2: preparing</description></item>
                /// <item><description>3: running</description></item>
                /// <item><description>4: successful</description></item>
                /// <item><description>5: failed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The workflow instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("WfInstanceId")]
                [Validation(Required=false)]
                public long? WfInstanceId { get; set; }

                /// <summary>
                /// <para>The workflow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("WorkflowId")]
                [Validation(Required=false)]
                public long? WorkflowId { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workflowId=xxx is not existed</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39090022-1F3B-4797-8518-6B61095F1AF0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
