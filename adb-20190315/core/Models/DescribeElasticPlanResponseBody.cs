// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeElasticPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried scaling plans.</para>
        /// </summary>
        [NameInMap("ElasticPlanList")]
        [Validation(Required=false)]
        public List<DescribeElasticPlanResponseBodyElasticPlanList> ElasticPlanList { get; set; }
        public class DescribeElasticPlanResponseBodyElasticPlanList : TeaModel {
            /// <summary>
            /// <para>The number of nodes that are involved in the scaling plan.</para>
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
            /// <para>The type of the scaling plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>worker</b>: scales only elastic I/O resources.</description></item>
            /// <item><description><b>executor</b>: scales only computing resources.</description></item>
            /// <item><description><b>executorcombineworker</b> (default): scales both elastic I/O resources and computing resources by proportion.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>worker</para>
            /// </summary>
            [NameInMap("ElasticPlanType")]
            [Validation(Required=false)]
            public string ElasticPlanType { get; set; }

            /// <summary>
            /// <para>The resource specifications that can be scaled up by the scaling plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>8 Core 64 GB (default)</description></item>
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
            /// <para>Indicates whether the scaling plan takes effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b> (default)</description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The end date of the scaling plan. This parameter is returned only if the end date of the scaling plan is set. The date is in the yyyy-MM-dd format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-09</para>
            /// </summary>
            [NameInMap("EndDay")]
            [Validation(Required=false)]
            public string EndDay { get; set; }

            /// <summary>
            /// <para>The restoration time of the scaling plan. The interval between the scale-up time and the restoration time cannot be more than 24 hours. The time is in the HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The days of the month when the scaling plan was executed. A value indicates a day of the month. Multiple values are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1,15,25</para>
            /// </summary>
            [NameInMap("MonthlyRepeat")]
            [Validation(Required=false)]
            public string MonthlyRepeat { get; set; }

            /// <summary>
            /// <para>The name of the scaling plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>realtime</para>
            /// </summary>
            [NameInMap("PlanName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }

            /// <summary>
            /// <para>The name of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER_DEFAULT</para>
            /// </summary>
            [NameInMap("ResourcePoolName")]
            [Validation(Required=false)]
            public string ResourcePoolName { get; set; }

            /// <summary>
            /// <para>The start date of the scaling plan. This parameter is returned only if the start date of the scaling plan is set. The date is in the yyyy-MM-dd format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-02</para>
            /// </summary>
            [NameInMap("StartDay")]
            [Validation(Required=false)]
            public string StartDay { get; set; }

            /// <summary>
            /// <para>The scale-up time of the scaling plan. The time is in the HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The days of the week when the scaling plan was executed. Valid values: 0 to 6, which indicate Sunday to Saturday. Multiple values are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>3,4,5,6</para>
            /// </summary>
            [NameInMap("WeeklyRepeat")]
            [Validation(Required=false)]
            public string WeeklyRepeat { get; set; }

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
