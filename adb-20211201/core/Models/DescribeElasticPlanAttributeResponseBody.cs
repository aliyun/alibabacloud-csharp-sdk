// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeElasticPlanAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried scaling plan.</para>
        /// </summary>
        [NameInMap("ElasticPlan")]
        [Validation(Required=false)]
        public DescribeElasticPlanAttributeResponseBodyElasticPlan ElasticPlan { get; set; }
        public class DescribeElasticPlanAttributeResponseBodyElasticPlan : TeaModel {
            /// <summary>
            /// <para>Indicates whether <b>Default Proportional Scaling for EIUs</b> is enabled. Valid values: true: Default Proportional Scaling for EIUs is enabled. If you set this parameter to true, storage resources are scaled along with computing resources. false: Default Proportional Scaling for EIUs is not enabled.</para>
            /// <remarks>
            /// <para> You can enable Default Proportional Scaling for EIUs for only a single scaling plan of a cluster. After you enable a scaling plan of the Default Proportional Scaling for EIUs type, you cannot enable scaling plans of other types.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoScale")]
            [Validation(Required=false)]
            public bool? AutoScale { get; set; }

            /// <summary>
            /// <para>A CORN expression that indicates the scaling cycle and time for the scaling plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 20 14 * * ?</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>The name of the scaling plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ElasticPlanName")]
            [Validation(Required=false)]
            public string ElasticPlanName { get; set; }

            /// <summary>
            /// <para>Indicates whether the scaling plan is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The end time of the scaling plan.</para>
            /// <remarks>
            /// <para> The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01T12:01:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The name of the resource group used by the scaling plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// <para>The start time of the scaling plan.</para>
            /// <remarks>
            /// <para> The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-01T12:01:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The amount of elastic resources after scaling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32ACU</para>
            /// </summary>
            [NameInMap("TargetSize")]
            [Validation(Required=false)]
            public string TargetSize { get; set; }

            /// <summary>
            /// <para>The type of the scaling plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EXECUTOR</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5C433C2-001F-58E3-99F5-3274C14DF8BD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
