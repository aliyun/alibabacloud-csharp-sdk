// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeElasticDailyPlanRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Data Warehouse Edition cluster.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> to query the IDs of all Data Warehouse Edition clusters in the destination region.</para>
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
        /// <para>The start date of the daily scaling plan. Specify the date in the yyyy-MM-dd format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-02</para>
        /// </summary>
        [NameInMap("ElasticDailyPlanDay")]
        [Validation(Required=false)]
        public string ElasticDailyPlanDay { get; set; }

        /// <summary>
        /// <para>The execution status of the daily scaling plan. To query multiple statuses, separate them with commas (,). Valid values:</para>
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
        [NameInMap("ElasticDailyPlanStatusList")]
        [Validation(Required=false)]
        public string ElasticDailyPlanStatusList { get; set; }

        /// <summary>
        /// <para>The name of the scaling plan. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>It must be 2 to 30 characters in length.</para>
        /// </description></item>
        /// <item><description><para>It must consist of uppercase letters, lowercase letters, digits, and underscores (_).</para>
        /// </description></item>
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
        /// <para>Call <a href="https://help.aliyun.com/document_detail/466685.html">DescribeDBResourceGroup</a> to query the name of the resource group.</para>
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
