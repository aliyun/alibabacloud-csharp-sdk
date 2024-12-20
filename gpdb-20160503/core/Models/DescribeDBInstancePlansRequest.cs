// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstancePlansRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the information about all AnalyticDB for PostgreSQL instances within a region, including instance IDs.</para>
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
        /// <para>The time that is used to filter plans. If you specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format, the plans that are created before this time are returned. The time must be in UTC. If you do not specify this parameter, all plans are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-17T23:00Z</para>
        /// </summary>
        [NameInMap("PlanCreateDate")]
        [Validation(Required=false)]
        public string PlanCreateDate { get; set; }

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
        /// <para>The plan ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/449398.html">DescribeDBInstancePlans</a> operation to query the information about plans, including plan IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// <para>The execution mode of the plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpone</b>: The plan is executed later.</description></item>
        /// <item><description><b>Regular</b>: The plan is executed periodically.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Regular</para>
        /// </summary>
        [NameInMap("PlanScheduleType")]
        [Validation(Required=false)]
        public string PlanScheduleType { get; set; }

        /// <summary>
        /// <para>The type of the plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PauseResume</b>: pauses and resumes an instance.</description></item>
        /// <item><description><b>Resize</b>: scales an instance.</description></item>
        /// <item><description><b>ModifySpec</b>: changes compute node specifications.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PauseResume</para>
        /// </summary>
        [NameInMap("PlanType")]
        [Validation(Required=false)]
        public string PlanType { get; set; }

    }

}
