// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeElasticDailyPlanRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Warehouse Edition (V3.0) cluster.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the cluster IDs of all AnalyticDB for MySQL Data Warehouse Edition (V3.0) clusters within a specific region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The start date of the current-day scaling plan. Specify the date in the yyyy-MM-dd format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-02</para>
        /// </summary>
        [NameInMap("ElasticDailyPlanDay")]
        [Validation(Required=false)]
        public string ElasticDailyPlanDay { get; set; }

        /// <summary>
        /// <para>The execution state of the current-day scaling plan. Separate multiple values with commas (,). Valid values:</para>
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
        [NameInMap("ElasticDailyPlanStatusList")]
        [Validation(Required=false)]
        public string ElasticDailyPlanStatusList { get; set; }

        /// <summary>
        /// <para>The name of the scaling plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 30 characters in length.</description></item>
        /// <item><description>The name can contain letters, digits, and underscores (_).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>realtimeplan</para>
        /// </summary>
        [NameInMap("ElasticPlanName")]
        [Validation(Required=false)]
        public string ElasticPlanName { get; set; }

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
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/466685.html">DescribeDBResourceGroup</a> operation to query the resource group name.</para>
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
