// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstancePlansResponseBody : TeaModel {
        /// <summary>
        /// <para>The error message.</para>
        /// <para>This parameter is returned only if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The queried plans.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstancePlansResponseBodyItems Items { get; set; }
        public class DescribeDBInstancePlansResponseBodyItems : TeaModel {
            [NameInMap("PlanList")]
            [Validation(Required=false)]
            public List<DescribeDBInstancePlansResponseBodyItemsPlanList> PlanList { get; set; }
            public class DescribeDBInstancePlansResponseBodyItemsPlanList : TeaModel {
                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gp-bp12ga6v69h86****</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The execution information of the plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;pause&quot;:{&quot;planCronTime&quot;:&quot;0 22 * * 5&quot;},&quot;resume&quot;:{&quot;planCronTime&quot;:&quot;0 23 * * 5&quot;}}</para>
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
                /// <para>The end time of the plan. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>This parameter is returned only for the plans that are periodically executed.</para>
                /// </description></item>
                /// <item><description><para>If you did not specify the end time when you created the plan, this parameter is not returned.</para>
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
                /// <para>The plan ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("PlanId")]
                [Validation(Required=false)]
                public string PlanId { get; set; }

                /// <summary>
                /// <para>The name of the plan.</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>Regular</para>
                /// </summary>
                [NameInMap("PlanScheduleType")]
                [Validation(Required=false)]
                public string PlanScheduleType { get; set; }

                /// <summary>
                /// <para>The start time of the plan. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>This parameter is returned only for the plans that are periodically executed.</para>
                /// </description></item>
                /// <item><description><para>If you did not specify the start time when you created the plan, the current time is returned.</para>
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
                /// <para>The status of the plan. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>active</b></description></item>
                /// <item><description><b>cancel</b></description></item>
                /// <item><description><b>deleted</b></description></item>
                /// <item><description><b>finished</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("PlanStatus")]
                [Validation(Required=false)]
                public string PlanStatus { get; set; }

                /// <summary>
                /// <para>The type of the plan. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PauseResume</b>: pauses and resumes an instance.</description></item>
                /// <item><description><b>Resize</b>: scales an instance.</description></item>
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

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34b32a0a-08ef-4a87-b6be-cdd988888888</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// <para>If the request was successful, <b>success</b> is returned. If the request failed, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
