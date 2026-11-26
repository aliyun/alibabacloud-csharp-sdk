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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the IDs of all AnalyticDB for PostgreSQL instances in a specific region.</para>
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
        /// <para>The detailed information about the execution plan. The value must be in JSON format. The content must be adjusted based on the values of the <b>PlanType</b> and <b>PlanScheduleType</b> parameters. For more information, see the following supplementary instructions.</para>
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
        /// <para>The end time of the plan. The end time must be later than the start time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required only when <b>PlanScheduleType</b> is set to <b>Regular</b>.</description></item>
        /// <item><description>This parameter is optional. If you do not specify an end time, the plan stops when the cycle ends.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-17T23:00:00Z</para>
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
        /// <item><description><b>Postpone</b>: execute later.</description></item>
        /// <item><description><b>Regular</b>: periodic execution.</description></item>
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
        /// <para>The start time of the plan. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required only when <b>PlanScheduleType</b> is set to <b>Regular</b>.</description></item>
        /// <item><description>If you do not specify this parameter, the current time is used by default.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-17T23:00:00Z</para>
        /// </summary>
        [NameInMap("PlanStartDate")]
        [Validation(Required=false)]
        public string PlanStartDate { get; set; }

        /// <summary>
        /// <para>The type of the plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PauseResume</b>: automatic start and stop.</description></item>
        /// <item><description><b>Resize</b>: instance upgrade/downgrade, which increases or decreases the number of compute nodes.</description></item>
        /// <item><description><b>ModifySpec</b>: specification change, which changes the node specifications.</description></item>
        /// <item><description><b>InPlaceModifySpec</b>: in-place elastic scaling, which scales the compute resources on the local node without changing the base specifications.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Instance upgrade/downgrade is supported only for instances in Serverless mode.</description></item>
        /// <item><description>Specification changes are supported only for instances in elastic storage mode.</description></item>
        /// <item><description>In-place elastic scaling is supported only for high availability (HA) instances in elastic storage mode.</description></item>
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
