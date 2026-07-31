// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetAutoOpsTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>81500666-d7f5-4143-8329-0223cc738105</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the O&amp;M task.</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public GetAutoOpsTaskResponseBodyTask Task { get; set; }
        public class GetAutoOpsTaskResponseBodyTask : TeaModel {
            /// <summary>
            /// <para>The time when the approval of the O&amp;M task was completed. This value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1669965908</para>
            /// </summary>
            [NameInMap("AllowedOverTime")]
            [Validation(Required=false)]
            public long? AllowedOverTime { get; set; }

            /// <summary>
            /// <para>The remarks of the O&amp;M task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The name of the O&amp;M task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>taskname</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The execution plan of the O&amp;M task.</para>
            /// <list type="bullet">
            /// <item><description><para><b>ExecAt</b>: If the value of ScheduleType is Manual, this parameter is not meaningful. If the value of ScheduleType is FixTime, this parameter indicates the scheduled execution time in seconds as a UNIX timestamp. If the value of ScheduleType is CycleInterval, this parameter indicates the first execution time in seconds as a UNIX timestamp.</para>
            /// </description></item>
            /// <item><description><para><b>PeriodNum</b>: If the value of ScheduleType is Manual or FixTime, this parameter is not meaningful. If the value of ScheduleType is CycleInterval, this parameter indicates the interval for periodic execution.</para>
            /// </description></item>
            /// <item><description><para><b>PeriodUnit</b>: If the value of ScheduleType is Manual or FixTime, this parameter is not meaningful. If the value of ScheduleType is CycleInterval, this parameter indicates the unit of the periodic execution interval. Valid values: hour and day.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ExecAt&quot;:0,&quot;PeriodNum&quot;:0,&quot;PeriodUnit&quot;:&quot;&quot;}</para>
            /// </summary>
            [NameInMap("ScheduleTimeInfo")]
            [Validation(Required=false)]
            public string ScheduleTimeInfo { get; set; }

            /// <summary>
            /// <para>The scheduling type of the task.</para>
            /// <list type="bullet">
            /// <item><description><b>FixTime</b>: scheduled execution.</description></item>
            /// <item><description><b>CycleInterval</b>: periodic execution.</description></item>
            /// <item><description><b>Manual</b>: manual execution triggered by the user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FixTime</para>
            /// </summary>
            [NameInMap("ScheduleType")]
            [Validation(Required=false)]
            public string ScheduleType { get; set; }

            /// <summary>
            /// <para>The content of the script to be executed by the O&amp;M task. The value is Base64-encoded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bHM=</para>
            /// </summary>
            [NameInMap("Script")]
            [Validation(Required=false)]
            public string Script { get; set; }

            /// <summary>
            /// <para>The ID of the script associated with the O&amp;M task. This parameter is returned only when ScriptType is set to SpecificScript.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public long? ScriptId { get; set; }

            /// <summary>
            /// <para>The name of the script associated with the O&amp;M task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <para>The script type of the O&amp;M task.</para>
            /// <list type="bullet">
            /// <item><description><para><b>HandInput</b>: manually entered script.</para>
            /// </description></item>
            /// <item><description><para><b>SpecificScript</b>: associated existing script.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HandInput</para>
            /// </summary>
            [NameInMap("ScriptType")]
            [Validation(Required=false)]
            public string ScriptType { get; set; }

            /// <summary>
            /// <para>The ID of the O&amp;M task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The status of the O&amp;M task.</para>
            /// <list type="bullet">
            /// <item><description><b>PendingApproval</b>: pending approval.</description></item>
            /// <item><description><b>Rejected</b>: rejected.</description></item>
            /// <item><description><b>Cancelled</b>: cancelled.</description></item>
            /// <item><description><b>PendingExecution</b>: approved and waiting for execution.</description></item>
            /// <item><description><b>PrepareRun</b>: preparing to execute.</description></item>
            /// <item><description><b>Running</b>: executing.</description></item>
            /// <item><description><b>Completed</b>: execution completed.</description></item>
            /// <item><description><b>Failed</b>: execution failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PendingApproval</para>
            /// </summary>
            [NameInMap("TaskState")]
            [Validation(Required=false)]
            public string TaskState { get; set; }

        }

    }

}
