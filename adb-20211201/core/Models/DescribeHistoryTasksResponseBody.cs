// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeHistoryTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>null</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeHistoryTasksResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeHistoryTasksResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>null</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>null</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>null</para>
            /// 
            /// <b>Example:</b>
            /// <para>141345906006****</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>null</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>null</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQFmy+hZZsvoWTQ2NTJFQUFBLUIyNjktMzk5NS05MEZCLUMxMzgwNDUwMDA2Ng==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>null</para>
            /// <list type="bullet">
            /// <item><description><b>null</b></description></item>
            /// <item><description><b>null</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>null</para>
            /// <list type="bullet">
            /// <item><description><b>null</b></description></item>
            /// <item><description><b>null</b></description></item>
            /// <item><description><b>null</b></description></item>
            /// <item><description><b>null</b></description></item>
            /// <item><description><b>null</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ControlPolicy</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The task list.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryTasksResponseBodyItems> Items { get; set; }
        public class DescribeHistoryTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Allowed operation information. When used specifically, matches operation Action based on currentStepName+status in this information. If no Action is matched, represents task current status does not support operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;steps\&quot;:[{\&quot;action_info\&quot;:{\&quot;Waiting\&quot;:[\&quot;modifySwitchTime\&quot;]},\&quot;step_name\&quot;:\&quot;exec_task\&quot;}]}</para>
            /// </summary>
            [NameInMap("ActionInfo")]
            [Validation(Required=false)]
            public string ActionInfo { get; set; }

            /// <summary>
            /// <para>null</para>
            /// 
            /// <b>Example:</b>
            /// <para>141345906006****</para>
            /// </summary>
            [NameInMap("CallerSource")]
            [Validation(Required=false)]
            public string CallerSource { get; set; }

            /// <summary>
            /// <para>null</para>
            /// <list type="bullet">
            /// <item><description><b>null</b></description></item>
            /// <item><description><b>null</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("CallerUid")]
            [Validation(Required=false)]
            public string CallerUid { get; set; }

            /// <summary>
            /// <para>Current executing step name. If empty, represents task has not started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exec_task</para>
            /// </summary>
            [NameInMap("CurrentStepName")]
            [Validation(Required=false)]
            public string CurrentStepName { get; set; }

            /// <summary>
            /// <para>The database engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>analyticdb</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>Task end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-03T12:06:17Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>Cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amv-********</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>Instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Instance</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ads</para>
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>Indicates the task progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>79.0</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public float? Progress { get; set; }

            /// <summary>
            /// <para>The reason why the current task was initiated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Estimated remaining execution time, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("RemainTime")]
            [Validation(Required=false)]
            public int? RemainTime { get; set; }

            /// <summary>
            /// <para>Task start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-03T11:31:03Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>Task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Scheduled</b></description></item>
            /// <item><description><b>Running</b></description></item>
            /// <item><description><b>Succeed</b></description></item>
            /// <item><description><b>Failed</b>: The task failed.</description></item>
            /// <item><description><b>Cancelling</b></description></item>
            /// <item><description><b>Canceled</b></description></item>
            /// <item><description><b>Waiting</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;callerUid\&quot;:\&quot;test\&quot;}</para>
            /// </summary>
            [NameInMap("TaskDetail")]
            [Validation(Required=false)]
            public string TaskDetail { get; set; }

            /// <summary>
            /// <para>Task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-83br18hloy3faf****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Task type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>autotest_dispatch_cases</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>null</para>
            /// 
            /// <b>Example:</b>
            /// <para>141345906006****</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// <para>The returned message. null</para>
        /// <list type="bullet">
        /// <item><description>null****</description></item>
        /// <item><description>null</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E51713A3-BB45-5616-AB15-170B704F8F01</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Total record count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
