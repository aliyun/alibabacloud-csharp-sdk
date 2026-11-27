// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class CreateOutboundTaskRequest : TeaModel {
        /// <summary>
        /// <para>The calling number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>130****1111</para>
        /// </summary>
        [NameInMap("Ani")]
        [Validation(Required=false)]
        public string Ani { get; set; }

        /// <summary>
        /// <para>The call information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;dnis&quot;:&quot;1&quot;,&quot;memberId&quot;:1133,&quot;memberName&quot;:&quot;Test member&quot;,&quot;priority&quot;:10}]</para>
        /// </summary>
        [NameInMap("CallInfos")]
        [Validation(Required=false)]
        public string CallInfos { get; set; }

        /// <summary>
        /// <para>The department ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("DepartmentId")]
        [Validation(Required=false)]
        public long? DepartmentId { get; set; }

        /// <summary>
        /// <para>The task description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test task description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The end date of the task execution. The maximum time span between the start time and the end time is 7 days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-08-09</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The end time of the task execution.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The extended attributes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;remark&quot;:&quot;Outbound call test&quot;}</para>
        /// </summary>
        [NameInMap("ExtAttrs")]
        [Validation(Required=false)]
        public string ExtAttrs { get; set; }

        /// <summary>
        /// <para>The name of the skill group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test skill group</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>Instance ID of the AICCS instance. You can obtain instance ID from the Artificial Intelligence Cloud Call Service console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public int? Model { get; set; }

        /// <summary>
        /// <para>The retry interval for unanswered calls. Unit: minutes.</para>
        /// <remarks>
        /// <para>The default value is empty. If the number of retries is greater than 0, this parameter is required. The minimum time granularity is minutes, and the maximum value can be set to 48 hours.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RetryInterval")]
        [Validation(Required=false)]
        public int? RetryInterval { get; set; }

        /// <summary>
        /// <para>The number of retries for unanswered calls. Default value: <b>0</b>. Maximum value: <b>3</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RetryTime")]
        [Validation(Required=false)]
        public int? RetryTime { get; set; }

        /// <summary>
        /// <para>The ID of the skill group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("SkillGroup")]
        [Validation(Required=false)]
        public long? SkillGroup { get; set; }

        /// <summary>
        /// <para>The start date of the task execution. The maximum time span between the start time and the end time is 7 days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-08-08</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The start time of the task execution.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09:09:09</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test task</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: PREVIEW (preview)</description></item>
        /// <item><description><b>2</b>: FORECAST (forecast)</description></item>
        /// <item><description><b>3</b>: ROBOT (robot)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public int? TaskType { get; set; }

    }

}
