// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class ModifyElasticPlanRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Warehouse Edition (V3.0) cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL Data Warehouse Edition (V3.0) clusters within a region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1rqvm70uh2v****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether the scaling plan takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default)</description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ElasticPlanEnable")]
        [Validation(Required=false)]
        public bool? ElasticPlanEnable { get; set; }

        /// <summary>
        /// <para>The end date of the scaling plan. Specify the date in the yyyy-MM-dd format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-09</para>
        /// </summary>
        [NameInMap("ElasticPlanEndDay")]
        [Validation(Required=false)]
        public string ElasticPlanEndDay { get; set; }

        /// <summary>
        /// <para>The dates of the month when you want to execute the scaling plan. A number specifies a date of the month. Separate multiple values with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,15,25</para>
        /// </summary>
        [NameInMap("ElasticPlanMonthlyRepeat")]
        [Validation(Required=false)]
        public string ElasticPlanMonthlyRepeat { get; set; }

        /// <summary>
        /// <para>The name of the scaling plan.</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 30 characters in length.</description></item>
        /// <item><description>The name can contain letters, digits, and underscores (_).</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/190596.html">DescribeElasticPlan</a> operation to query the information about all scaling plans of a cluster, including the scaling plan names.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>realtime</para>
        /// </summary>
        [NameInMap("ElasticPlanName")]
        [Validation(Required=false)]
        public string ElasticPlanName { get; set; }

        /// <summary>
        /// <para>The number of nodes that are involved in the scaling plan.</para>
        /// <list type="bullet">
        /// <item><description>If ElasticPlanType is set to <b>worker</b>, you can set this parameter to 0 or leave this parameter empty.</description></item>
        /// <item><description>If ElasticPlanType is set to <b>executorcombineworker</b> or <b>executor</b>, you must set this parameter to a value that is greater than 0.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ElasticPlanNodeNum")]
        [Validation(Required=false)]
        public int? ElasticPlanNodeNum { get; set; }

        /// <summary>
        /// <para>The start date of the scaling plan. Specify the date in the yyyy-MM-dd format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-02</para>
        /// </summary>
        [NameInMap("ElasticPlanStartDay")]
        [Validation(Required=false)]
        public string ElasticPlanStartDay { get; set; }

        /// <summary>
        /// <para>The restoration time of the scaling plan. Specify the time on the hour in the HH:mm:ss format. The interval between the scale-up time and the restoration time cannot be more than 24 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10:00:00</para>
        /// </summary>
        [NameInMap("ElasticPlanTimeEnd")]
        [Validation(Required=false)]
        public string ElasticPlanTimeEnd { get; set; }

        /// <summary>
        /// <para>The scale-up time of the scaling plan. Specify the time on the hour in the HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8:00:00</para>
        /// </summary>
        [NameInMap("ElasticPlanTimeStart")]
        [Validation(Required=false)]
        public string ElasticPlanTimeStart { get; set; }

        /// <summary>
        /// <para>The type of the scaling plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>worker</b>: scales only elastic I/O resources.</description></item>
        /// <item><description><b>executor</b>: scales only computing resources.</description></item>
        /// <item><description><b>executorcombineworker</b> (default): scales both elastic I/O resources and computing resources by proportion.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you want to set this parameter to <b>executorcombineworker</b>, make sure that the cluster runs a minor version of 3.1.3.2 or later.</para>
        /// </description></item>
        /// <item><description><para>If you want to set this parameter to <b>worker</b> or <b>executor</b>, make sure that the cluster runs a minor version of 3.1.6.1 or later and a ticket is submitted. After your request is approved, you can set this parameter to <b>worker</b> or <b>executor</b>.</para>
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
        /// <para>The days of the week when you want to execute the scaling plan. Valid values: 0 to 6, which indicate Sunday to Saturday. Separate multiple values with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3,4,5</para>
        /// </summary>
        [NameInMap("ElasticPlanWeeklyRepeat")]
        [Validation(Required=false)]
        public string ElasticPlanWeeklyRepeat { get; set; }

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

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/466685.html">DescribeDBResourceGroup</a> operation to query the resource group name.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ResourcePoolName")]
        [Validation(Required=false)]
        public string ResourcePoolName { get; set; }

    }

}
