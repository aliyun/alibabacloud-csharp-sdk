// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateElasticPlanRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable <b>Default Proportional Scaling for EIUs</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true. In this case, storage resources are scaled along with computing resources, and the TargetSize and CronExpression parameters are not supported.</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter must be specified when Type is set to WORKER. This parameter is not required when Type is set to EXECUTOR.</para>
        /// </description></item>
        /// <item><description><para>You can enable Default Proportional Scaling for EIUs for only a single scaling plan of a cluster.</para>
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
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/454250.html">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL clusters within a region.</para>
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
        /// <para> The name must be 2 to 30 characters in length and can contain letters, digits, and underscores (_). The name must start with a letter.</para>
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
        /// <para>Specifies whether to immediately enable the scaling plan after the plan is created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <para>The name of the resource group.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you want to create a scaling plan that uses interactive resource groups, you must specify this parameter. If you want to create a scaling plan that uses elastic I/O units (EIUs), you do not need to specify this parameter.</para>
        /// </description></item>
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/459446.html">DescribeDBResourceGroup</a> operation to query the resource group name for a cluster.</para>
        /// </description></item>
        /// </list>
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

        /// <summary>
        /// <para>The type of the scaling plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EXECUTOR: the interactive resource group type, which indicates the computing resource type.</description></item>
        /// <item><description>WORKER: the EIU type.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXECUTOR</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
