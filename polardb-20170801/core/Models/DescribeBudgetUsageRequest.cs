// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBudgetUsageRequest : TeaModel {
        /// <summary>
        /// <para>The reference ID of the budget dimension. If BudgetDimensionType is set to Global, set this parameter to Global. If BudgetDimensionType is set to Consumer, set this parameter to the consumer ID returned by DescribeBudgetPolicies, such as consumer-xxx. If BudgetDimensionType is set to ConsumerGroup, set this parameter to the consumer group ID, such as cg-xxx.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Global</para>
        /// </summary>
        [NameInMap("BudgetDimensionRefId")]
        [Validation(Required=false)]
        public string BudgetDimensionRefId { get; set; }

        /// <summary>
        /// <para>The budget dimension type. Valid values: Global (global budget), Consumer (consumer budget), and ConsumerGroup (consumer group budget).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Global</para>
        /// </summary>
        [NameInMap("BudgetDimensionType")]
        [Validation(Required=false)]
        public string BudgetDimensionType { get; set; }

        /// <summary>
        /// <para>The ID of the gateway instance to query. This parameter is required. If this parameter is not specified, the API returns InvalidPolarGatewayInstanceId.NotFound (404).</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-123</para>
        /// </summary>
        [NameInMap("GwClusterId")]
        [Validation(Required=false)]
        public string GwClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the gateway instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
