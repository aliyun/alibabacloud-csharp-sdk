// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeElasticPlanJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried scaling plan jobs.</para>
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public List<DescribeElasticPlanJobsResponseBodyJobs> Jobs { get; set; }
        public class DescribeElasticPlanJobsResponseBodyJobs : TeaModel {
            /// <summary>
            /// <para>The amount of elastic resources.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>If Type is set to EXECUTOR, ElasticAcu indicates the amount of elastic resources in the current resource group.</para>
            /// </description></item>
            /// <item><description><para>If Type is set to WORKER, ElasticAcu indicates the total amount of elastic storage resources in the current cluster.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>16ACU</para>
            /// </summary>
            [NameInMap("ElasticAcu")]
            [Validation(Required=false)]
            public string ElasticAcu { get; set; }

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
            /// <para>The end time of the scaling plan job.</para>
            /// <remarks>
            /// <para> The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-01T12:01:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The number of compute nodes or storage replica sets.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>If Type is set to EXECUTOR, InstanceSize indicates the number of compute nodes in the cluster.</para>
            /// </description></item>
            /// <item><description><para>If Type is set to EXECUTOR, InstanceSize indicates the number of storage replica sets in the cluster.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceSize")]
            [Validation(Required=false)]
            public int? InstanceSize { get; set; }

            /// <summary>
            /// <para>The amount of reserved resources.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>If Type is set to EXECUTOR, ReserveAcu indicates the amount of reserved resources in the current resource group.</para>
            /// </description></item>
            /// <item><description><para>If Type is set to WORKER, ReserveAcu indicates the total amount of reserved storage resources in the current cluster.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>16ACU</para>
            /// </summary>
            [NameInMap("ReserveAcu")]
            [Validation(Required=false)]
            public string ReserveAcu { get; set; }

            /// <summary>
            /// <para>The name of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// <para>The start time of the scaling plan job.</para>
            /// <remarks>
            /// <para> The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-01T11:01:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The state of the scaling plan job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RUNNING</description></item>
            /// <item><description>SUCCESSFUL</description></item>
            /// <item><description>FAILED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESSFUL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The desired specifications of elastic resources after scaling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32ACU</para>
            /// </summary>
            [NameInMap("TargetSize")]
            [Validation(Required=false)]
            public string TargetSize { get; set; }

            /// <summary>
            /// <para>The total amount of resources.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>If Type is set to EXECUTOR, TotalAcu indicates the total amount of computing resources in the current resource group.</para>
            /// </description></item>
            /// <item><description><para>If Type is set to WORKER, TotalAcu indicates the total amount of storage resources in the cluster.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>32ACU</para>
            /// </summary>
            [NameInMap("TotalAcu")]
            [Validation(Required=false)]
            public string TotalAcu { get; set; }

            /// <summary>
            /// <para>The type of the scaling plan job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>EXECUTOR: the interactive resource group type, which indicates the computing resource type.</description></item>
            /// <item><description>WORKER: the EIU type.</description></item>
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
        /// <para>The total number of scaling plan jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
