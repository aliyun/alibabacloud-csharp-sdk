// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeElasticDailyPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the current-day scaling plans.</para>
        /// </summary>
        [NameInMap("ElasticDailyPlanList")]
        [Validation(Required=false)]
        public List<DescribeElasticDailyPlanResponseBodyElasticDailyPlanList> ElasticDailyPlanList { get; set; }
        public class DescribeElasticDailyPlanResponseBodyElasticDailyPlanList : TeaModel {
            /// <summary>
            /// <para>The start date of the current-day scaling plan. The date is in the yyyy-MM-dd format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-02</para>
            /// </summary>
            [NameInMap("Day")]
            [Validation(Required=false)]
            public string Day { get; set; }

            /// <summary>
            /// <para>The number of nodes involved in the scaling plan.</para>
            /// <list type="bullet">
            /// <item><description>If ElasticPlanType is set to <b>worker</b>, a value of 0 or null is returned.</description></item>
            /// <item><description>If ElasticPlanType is set to <b>executorcombineworker</b> or <b>executor</b>, a value greater than 0 is returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ElasticNodeNum")]
            [Validation(Required=false)]
            public int? ElasticNodeNum { get; set; }

            /// <summary>
            /// <para>The type of the scaling plan. Default value: executorcombineworker. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>worker</b>: scales only elastic I/O resources.</description></item>
            /// <item><description><b>executor</b>: scales only computing resources.</description></item>
            /// <item><description><b>executorcombineworker</b>: scales both elastic I/O resources and computing resources by proportion.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>worker</para>
            /// </summary>
            [NameInMap("ElasticPlanType")]
            [Validation(Required=false)]
            public string ElasticPlanType { get; set; }

            /// <summary>
            /// <para>The resource specifications that can be scaled up by the scaling plan. Default value: 8 Core 64 GB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>8 Core 64 GB</description></item>
            /// <item><description>16 Core 64 GB</description></item>
            /// <item><description>32 Core 64 GB</description></item>
            /// <item><description>64 Core 128 GB</description></item>
            /// <item><description>12 Core 96 GB</description></item>
            /// <item><description>24 Core 96 GB</description></item>
            /// <item><description>52 Core 86 GB</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>16 Core 64 GB</para>
            /// </summary>
            [NameInMap("ElasticPlanWorkerSpec")]
            [Validation(Required=false)]
            public string ElasticPlanWorkerSpec { get; set; }

            /// <summary>
            /// <para>The actual restoration time. The time is in the yyyy-MM-dd hh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-02 16:00:00</para>
            /// </summary>
            [NameInMap("EndTs")]
            [Validation(Required=false)]
            public string EndTs { get; set; }

            /// <summary>
            /// <para>The scheduled restoration time. The time is in the yyyy-MM-dd hh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-02 16:00:00</para>
            /// </summary>
            [NameInMap("PlanEndTs")]
            [Validation(Required=false)]
            public string PlanEndTs { get; set; }

            /// <summary>
            /// <para>The name of the scaling plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>realtimeplan</para>
            /// </summary>
            [NameInMap("PlanName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }

            /// <summary>
            /// <para>The scheduled scale-up time. The time is in the yyyy-MM-dd hh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-02 15:00:00</para>
            /// </summary>
            [NameInMap("PlanStartTs")]
            [Validation(Required=false)]
            public string PlanStartTs { get; set; }

            /// <summary>
            /// <para>The name of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourcePoolName")]
            [Validation(Required=false)]
            public string ResourcePoolName { get; set; }

            /// <summary>
            /// <para>The actual scale-up time. The time is in the yyyy-MM-dd hh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-02 16:00:00</para>
            /// </summary>
            [NameInMap("StartTs")]
            [Validation(Required=false)]
            public string StartTs { get; set; }

            /// <summary>
            /// <para>The execution state of the current-day scaling plan. Multiple values are separated by commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: The scaling plan is not executed.</description></item>
            /// <item><description><b>2</b>: The scaling plan is being executed.</description></item>
            /// <item><description><b>3</b>: The scaling plan is executed.</description></item>
            /// <item><description><b>4</b>: The scaling plan fails to be executed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
