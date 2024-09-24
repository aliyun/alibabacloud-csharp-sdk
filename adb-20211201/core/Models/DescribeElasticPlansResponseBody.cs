// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeElasticPlansResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried scaling plans.</para>
        /// </summary>
        [NameInMap("ElasticPlans")]
        [Validation(Required=false)]
        public List<DescribeElasticPlansResponseBodyElasticPlans> ElasticPlans { get; set; }
        public class DescribeElasticPlansResponseBodyElasticPlans : TeaModel {
            /// <summary>
            /// <para>Indicates whether <b>Proportional Default Scaling for EIUs</b> is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoScale")]
            [Validation(Required=false)]
            public bool? AutoScale { get; set; }

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
            /// <para>Indicates whether the scaling plan is immediately enabled after the plan is created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The time when the next scheduling is performed.</para>
            /// <remarks>
            /// <para>The time is in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-01T12:01:00Z</para>
            /// </summary>
            [NameInMap("NextScheduleTime")]
            [Validation(Required=false)]
            public string NextScheduleTime { get; set; }

            /// <summary>
            /// <para>The name of the resource group.</para>
            /// <remarks>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/459446.html">DescribeDBResourceGroup</a> operation to query the name of a resource group within a cluster.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

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
            /// <para>The type of the scaling plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>EXECUTOR</b>: the interactive resource group type, which specifies the computing resource type.</description></item>
            /// <item><description><b>WORKER</b>: the EIU type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EXECUTOR</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5C433C2-001F-58E3-99F5-3274C14DF8BD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
