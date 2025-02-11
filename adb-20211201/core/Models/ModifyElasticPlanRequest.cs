// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyElasticPlanRequest : TeaModel {
        /// <summary>
        /// <para>A CORN expression that specifies the scaling cycle and time for the scaling plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 20 14 * * ?</para>
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL clusters within a region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-wz9509beptiz****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The name of the scaling plan.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/601334.html">DescribeElasticPlans</a> operation to query the names of scaling plans.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ElasticPlanName")]
        [Validation(Required=false)]
        public string ElasticPlanName { get; set; }

        /// <summary>
        /// <para>The end time of the scaling plan.</para>
        /// <remarks>
        /// <para> Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-01T12:01:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The start time of the scaling plan.</para>
        /// <remarks>
        /// <para> Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-01T12:01:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The desired specifications of elastic resources after scaling.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If the scaling plan uses <b>EIUs</b> and <b>Default Proportional Scaling for EIUs</b> is enabled, you do not need to specify this parameter. In other cases, you must specify this parameter.</para>
        /// </description></item>
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/601278.html">DescribeElasticPlanSpecifications</a> operation to query the specifications that are supported for scaling plans.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>32ACU</para>
        /// </summary>
        [NameInMap("TargetSize")]
        [Validation(Required=false)]
        public string TargetSize { get; set; }

    }

}
