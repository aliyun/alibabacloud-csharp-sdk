// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowsByPageResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6CB28697-BFE2-5739-9228-3971990E982C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The details of the returned task flows.</para>
        /// </summary>
        [NameInMap("TaskFlowList")]
        [Validation(Required=false)]
        public ListTaskFlowsByPageResponseBodyTaskFlowList TaskFlowList { get; set; }
        public class ListTaskFlowsByPageResponseBodyTaskFlowList : TeaModel {
            [NameInMap("TaskFlow")]
            [Validation(Required=false)]
            public List<ListTaskFlowsByPageResponseBodyTaskFlowListTaskFlow> TaskFlow { get; set; }
            public class ListTaskFlowsByPageResponseBodyTaskFlowListTaskFlow : TeaModel {
                /// <summary>
                /// <para>The ID of the user who created the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>51****</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The username of the user who created the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Creator_NickName</para>
                /// </summary>
                [NameInMap("CreatorNickName")]
                [Validation(Required=false)]
                public string CreatorNickName { get; set; }

                /// <summary>
                /// <para>The start time of scheduled scheduling. The task flow is not scheduled before this point in time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1970-01-01</para>
                /// </summary>
                [NameInMap("CronBeginDate")]
                [Validation(Required=false)]
                public string CronBeginDate { get; set; }

                /// <summary>
                /// <para>The end time of scheduled scheduling. The task flow is not scheduled after this point in time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-01</para>
                /// </summary>
                [NameInMap("CronEndDate")]
                [Validation(Required=false)]
                public string CronEndDate { get; set; }

                /// <summary>
                /// <para>Scheduled Cron.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 1 * * ? *</para>
                /// </summary>
                [NameInMap("CronStr")]
                [Validation(Required=false)]
                public string CronStr { get; set; }

                /// <summary>
                /// <para>Whether to enable scheduled scheduling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("CronSwitch")]
                [Validation(Required=false)]
                public bool? CronSwitch { get; set; }

                /// <summary>
                /// <para>Scheduling cycle type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>2</b>: Hourly scheduling</description></item>
                /// <item><description><b>3</b>: Daily scheduling</description></item>
                /// <item><description><b>4</b>: Weekly scheduling</description></item>
                /// <item><description><b>5</b>: Monthly scheduling</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CronType")]
                [Validation(Required=false)]
                public int? CronType { get; set; }

                /// <summary>
                /// <para>The name of the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>poc_task_test</para>
                /// </summary>
                [NameInMap("DagName")]
                [Validation(Required=false)]
                public string DagName { get; set; }

                /// <summary>
                /// <para>The user ID of the task flow owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12***89</para>
                /// </summary>
                [NameInMap("DagOwnerId")]
                [Validation(Required=false)]
                public string DagOwnerId { get; set; }

                /// <summary>
                /// <para>The username of the owner of the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Owner_NickName</para>
                /// </summary>
                [NameInMap("DagOwnerNickName")]
                [Validation(Required=false)]
                public string DagOwnerNickName { get; set; }

                /// <summary>
                /// <para>The ID of the last deployment record of the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65***</para>
                /// </summary>
                [NameInMap("DeployId")]
                [Validation(Required=false)]
                public long? DeployId { get; set; }

                /// <summary>
                /// <para>The description of the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7***</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The status of the last execution of the task flow. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: invalid</description></item>
                /// <item><description><b>1</b>: scheduling disabled</description></item>
                /// <item><description><b>2</b>: waiting to be scheduled</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LatestInstanceStatus")]
                [Validation(Required=false)]
                public int? LatestInstanceStatus { get; set; }

                /// <summary>
                /// <para>The time when the last execution record was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-13</para>
                /// </summary>
                [NameInMap("LatestInstanceTime")]
                [Validation(Required=false)]
                public string LatestInstanceTime { get; set; }

                /// <summary>
                /// <para>The ID of the application scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1245</para>
                /// </summary>
                [NameInMap("ScenarioId")]
                [Validation(Required=false)]
                public string ScenarioId { get; set; }

                /// <summary>
                /// <para>Event scheduling configuration, JSON string format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;triggerType\&quot;:\&quot;1\&quot;,\&quot;specificTime\&quot;:\&quot;2022-11-15 11:59\&quot;}</para>
                /// </summary>
                [NameInMap("ScheduleParam")]
                [Validation(Required=false)]
                public string ScheduleParam { get; set; }

                /// <summary>
                /// <para>The status of the task flow. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: invalid</description></item>
                /// <item><description><b>1</b>: scheduling disabled</description></item>
                /// <item><description><b>2</b>: waiting to be scheduled</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>Time zone setting. Default value: East 8(Asia/Shanghai).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("TimeZoneId")]
                [Validation(Required=false)]
                public string TimeZoneId { get; set; }

                /// <summary>
                /// <para>The trigger type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Periodic scheduling</description></item>
                /// <item><description><b>1</b>: Run manually</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TriggerType")]
                [Validation(Required=false)]
                public int? TriggerType { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
