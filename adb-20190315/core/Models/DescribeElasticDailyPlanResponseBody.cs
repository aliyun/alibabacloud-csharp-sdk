// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeElasticDailyPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of daily scaling plans.</para>
        /// </summary>
        [NameInMap("ElasticDailyPlanList")]
        [Validation(Required=false)]
        public List<DescribeElasticDailyPlanResponseBodyElasticDailyPlanList> ElasticDailyPlanList { get; set; }
        public class DescribeElasticDailyPlanResponseBodyElasticDailyPlanList : TeaModel {
            /// <summary>
            /// <para>The start date of the daily scaling plan. The date is in the yyyy-MM-dd format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-02</para>
            /// </summary>
            [NameInMap("Day")]
            [Validation(Required=false)]
            public string Day { get; set; }

            /// <summary>
            /// <para>The number of nodes for the scaling plan.</para>
            /// <list type="bullet">
            /// <item><description><para>If ElasticPlanType is set to <b>worker</b>, this parameter is not returned or the returned value is 0.</para>
            /// </description></item>
            /// <item><description><para>If ElasticPlanType is set to <b>executorcombineworker</b> or <b>executor</b>, a value greater than 0 is returned.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ElasticNodeNum")]
            [Validation(Required=false)]
            public int? ElasticNodeNum { get; set; }

            /// <summary>
            /// <para>The resource type for the scaling plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>worker</b>: scales only elastic I/O resources.</para>
            /// </description></item>
            /// <item><description><para><b>executor</b>: scales only computing resources.</para>
            /// </description></item>
            /// <item><description><para><b>executorcombineworker</b> (default): scales both computing resources and elastic I/O resources based on the default ratio.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>worker</para>
            /// </summary>
            [NameInMap("ElasticPlanType")]
            [Validation(Required=false)]
            public string ElasticPlanType { get; set; }

            /// <summary>
            /// <para>The resource specifications that are supported for scaling. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>8 Core 64 GB (default)</para>
            /// </description></item>
            /// <item><description><para>16 Core 64 GB</para>
            /// </description></item>
            /// <item><description><para>32 Core 64 GB</para>
            /// </description></item>
            /// <item><description><para>64 Core 128 GB</para>
            /// </description></item>
            /// <item><description><para>12 Core 96 GB</para>
            /// </description></item>
            /// <item><description><para>24 Core 96 GB</para>
            /// </description></item>
            /// <item><description><para>52 Core 86 GB</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>16 Core 64 GB</para>
            /// </summary>
            [NameInMap("ElasticPlanWorkerSpec")]
            [Validation(Required=false)]
            public string ElasticPlanWorkerSpec { get; set; }

            /// <summary>
            /// <para>The actual time when the scaled-out resources were reverted. The time is in the yyyy-MM-dd hh:mm:ss format and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-02 16:00:00</para>
            /// </summary>
            [NameInMap("EndTs")]
            [Validation(Required=false)]
            public string EndTs { get; set; }

            /// <summary>
            /// <para>The scheduled time to revert the scaled-out resources. The time is in the yyyy-MM-dd hh:mm:ss format and is displayed in UTC.</para>
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
            /// <para>The scheduled scale-out time. The time is in the yyyy-MM-dd hh:mm:ss format and is displayed in UTC.</para>
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
            /// <para>The actual scale-out time. The time is in the yyyy-MM-dd hh:mm:ss format and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-02 16:00:00</para>
            /// </summary>
            [NameInMap("StartTs")]
            [Validation(Required=false)]
            public string StartTs { get; set; }

            /// <summary>
            /// <para>The execution status of the daily scaling plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Not executed.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Executing.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: Succeeded.</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: Failed.</para>
            /// </description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
