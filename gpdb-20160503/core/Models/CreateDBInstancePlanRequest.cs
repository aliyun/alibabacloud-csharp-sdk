// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateDBInstancePlanRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the IDs of all AnalyticDB for PostgreSQL instances within a region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The execution information of the plan. Specify the parameter in the JSON format. The parameter value varies based on the values of <b>PlanType</b> and <b>PlanScheduleType</b>. The following section describes the PlanConfig parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;pause&quot;:{&quot;planCronTime&quot;:&quot;0 0 12 1/1 * ? &quot;},&quot;resume&quot;:{&quot;planCronTime&quot;:&quot;0 0 0 1/1 * ? &quot;}}</para>
        /// </summary>
        [NameInMap("PlanConfig")]
        [Validation(Required=false)]
        public string PlanConfig { get; set; }

        /// <summary>
        /// <para>The description of the plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test plan</para>
        /// </summary>
        [NameInMap("PlanDesc")]
        [Validation(Required=false)]
        public string PlanDesc { get; set; }

        /// <summary>
        /// <para>The end time of the plan. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC. The end time must be later than the start time.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter must be specified only when <b>PlanScheduleType</b> is set to <b>Regular</b>.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter, the plan stops until the plan is deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-17T23:00Z</para>
        /// </summary>
        [NameInMap("PlanEndDate")]
        [Validation(Required=false)]
        public string PlanEndDate { get; set; }

        /// <summary>
        /// <para>The name of the plan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-plan</para>
        /// </summary>
        [NameInMap("PlanName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// <para>The execution mode of the plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpone</b>: The plan is executed later.</description></item>
        /// <item><description><b>Regular</b>: The plan is executed periodically.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Regular</para>
        /// </summary>
        [NameInMap("PlanScheduleType")]
        [Validation(Required=false)]
        public string PlanScheduleType { get; set; }

        /// <summary>
        /// <para>The start time of the plan. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter must be specified only when <b>PlanScheduleType</b> is set to <b>Regular</b>.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter, the current time is used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-17T23:00Z</para>
        /// </summary>
        [NameInMap("PlanStartDate")]
        [Validation(Required=false)]
        public string PlanStartDate { get; set; }

        /// <summary>
        /// <para>The type of the plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PauseResume</b>: pauses and resumes an instance.</description></item>
        /// <item><description><b>Resize</b>: changes the number of compute nodes.</description></item>
        /// <item><description><b>ModifySpec</b>: changes compute node specifications.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can specify the value to ModifySpec only for instances in elastic storage mode.</description></item>
        /// <item><description>You can specify the value to ModifySpec only for instances in elastic storage mode.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PauseResume</para>
        /// </summary>
        [NameInMap("PlanType")]
        [Validation(Required=false)]
        public string PlanType { get; set; }

    }

}
