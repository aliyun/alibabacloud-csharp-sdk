// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeElasticPlanAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The elastic plan.</para>
        /// </summary>
        [NameInMap("ElasticPlan")]
        [Validation(Required=false)]
        public DescribeElasticPlanAttributeResponseBodyElasticPlan ElasticPlan { get; set; }
        public class DescribeElasticPlanAttributeResponseBodyElasticPlan : TeaModel {
            /// <summary>
            /// <para>Indicates whether <b>proportional default elastic scaling for the storage acceleration service (EIU)</b> is enabled.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled. After this feature is enabled, storage resources scale in or out along with the elastic scaling of compute resources.</description></item>
            /// <item><description>false: Disabled.<remarks>
            /// <para>Only one storage elastic plan with proportional default elastic scaling for the storage acceleration service (EIU) can be enabled for the entire cluster. After this type of elastic plan is enabled, no other storage elastic plans can be enabled.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoScale")]
            [Validation(Required=false)]
            public bool? AutoScale { get; set; }

            /// <summary>
            /// <para>The cron expression, which indicates the scaling cycle and scaling time of the elastic plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 20 14 * * ?</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>The name of the elastic plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ElasticPlanName")]
            [Validation(Required=false)]
            public string ElasticPlanName { get; set; }

            /// <summary>
            /// <para>Indicates whether the elastic plan is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The end time.</para>
            /// <remarks>
            /// <para>The time is in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01T12:01:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The name of the resource group to which the elastic plan belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// <para>The start time.</para>
            /// <remarks>
            /// <para>The time is in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-01T12:01:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The target specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32ACU</para>
            /// </summary>
            [NameInMap("TargetSize")]
            [Validation(Required=false)]
            public string TargetSize { get; set; }

            /// <summary>
            /// <para>The type of the elastic plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EXECUTOR</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5C433C2-001F-58E3-99F5-3274C14DF8BD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
