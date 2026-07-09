// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class QueryCostCenterResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The data list.</para>
        /// </summary>
        [NameInMap("CostCenterResourceDtoList")]
        [Validation(Required=false)]
        public List<QueryCostCenterResourceResponseBodyCostCenterResourceDtoList> CostCenterResourceDtoList { get; set; }
        public class QueryCostCenterResourceResponseBodyCostCenterResourceDtoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>AUTO_ALLOCATE</para>
            /// </summary>
            [NameInMap("AddStrategy")]
            [Validation(Required=false)]
            public string AddStrategy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>自动分配</para>
            /// </summary>
            [NameInMap("AddStrategyName")]
            [Validation(Required=false)]
            public string AddStrategyName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ApplicablePeriodNum")]
            [Validation(Required=false)]
            public long? ApplicablePeriodNum { get; set; }

            /// <summary>
            /// <para>The apportionment item code of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ApportionItemCode")]
            [Validation(Required=false)]
            public string ApportionItemCode { get; set; }

            /// <summary>
            /// <para>The apportionment item name of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ApportionItemName")]
            [Validation(Required=false)]
            public string ApportionItemName { get; set; }

            /// <summary>
            /// <para>The commodity code of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>otsbag</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The commodity name of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>云数据库</para>
            /// </summary>
            [NameInMap("CommodityName")]
            [Validation(Required=false)]
            public string CommodityName { get; set; }

            /// <summary>
            /// <para>The cost center code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>code</para>
            /// </summary>
            [NameInMap("CostCenterCode")]
            [Validation(Required=false)]
            public string CostCenterCode { get; set; }

            /// <summary>
            /// <para>The creation time of the cost center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-18 12:12:25</para>
            /// </summary>
            [NameInMap("CostCenterCreateTime")]
            [Validation(Required=false)]
            public string CostCenterCreateTime { get; set; }

            /// <summary>
            /// <para>The cost center ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("CostCenterId")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            /// <summary>
            /// <para>The cost center name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("CostCenterName")]
            [Validation(Required=false)]
            public string CostCenterName { get; set; }

            /// <summary>
            /// <para>The last update time of the cost center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-18 16:12:25</para>
            /// </summary>
            [NameInMap("CostCenterUpdateTime")]
            [Validation(Required=false)]
            public string CostCenterUpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("FinanceUnitRuleVersion")]
            [Validation(Required=false)]
            public long? FinanceUnitRuleVersion { get; set; }

            /// <summary>
            /// <para>The billing granularity ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou;standard</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("MasterCommodityCode")]
            [Validation(Required=false)]
            public string MasterCommodityCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i-xxxxx</para>
            /// </summary>
            [NameInMap("MasterInstanceId")]
            [Validation(Required=false)]
            public string MasterInstanceId { get; set; }

            /// <summary>
            /// <para>The customer ID to which the cost center belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567812345678</para>
            /// </summary>
            [NameInMap("OwnerAccountId")]
            [Validation(Required=false)]
            public long? OwnerAccountId { get; set; }

            /// <summary>
            /// <para>The customer name to which the cost center belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>客户A</para>
            /// </summary>
            [NameInMap("OwnerAccountName")]
            [Validation(Required=false)]
            public string OwnerAccountName { get; set; }

            /// <summary>
            /// <para>The parent cost center ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("ParentCostCenterId")]
            [Validation(Required=false)]
            public long? ParentCostCenterId { get; set; }

            /// <summary>
            /// <para>The product code, which is the same as the product code in Cost Center bills.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds</para>
            /// </summary>
            [NameInMap("PipCode")]
            [Validation(Required=false)]
            public string PipCode { get; set; }

            /// <summary>
            /// <para>The product name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>云数据库</para>
            /// </summary>
            [NameInMap("PipName")]
            [Validation(Required=false)]
            public string PipName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>202509</para>
            /// </summary>
            [NameInMap("RecentBillingMonth")]
            [Validation(Required=false)]
            public long? RecentBillingMonth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>上海</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The resource group to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>默认资源组</para>
            /// </summary>
            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public string ResourceGroup { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSSBAG-cn-v0h1s4hma018</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The custom alias of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testResource</para>
            /// </summary>
            [NameInMap("ResourceNick")]
            [Validation(Required=false)]
            public string ResourceNick { get; set; }

            /// <summary>
            /// <para>The resource source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AUTO_ALLOCATE: automatically allocated.</description></item>
            /// <item><description>MANUAL_ALLOCATE: manually allocated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MANUAL_ALLOCATE</para>
            /// </summary>
            [NameInMap("ResourceSource")]
            [Validation(Required=false)]
            public string ResourceSource { get; set; }

            /// <summary>
            /// <para>The tag of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag</para>
            /// </summary>
            [NameInMap("ResourceTag")]
            [Validation(Required=false)]
            public string ResourceTag { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FPT_ossbag_absolute_Storage_bj</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The last update time of the cost center. This is a reserved field and is currently unavailable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-18 16:12:25</para>
            /// </summary>
            [NameInMap("ResourceUpdateTime")]
            [Validation(Required=false)]
            public string ResourceUpdateTime { get; set; }

            /// <summary>
            /// <para>The owner user ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567812345678</para>
            /// </summary>
            [NameInMap("ResourceUserId")]
            [Validation(Required=false)]
            public long? ResourceUserId { get; set; }

            /// <summary>
            /// <para>The owner username of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@test.aliyun.com">test@test.aliyun.com</a></para>
            /// </summary>
            [NameInMap("ResourceUserName")]
            [Validation(Required=false)]
            public string ResourceUserName { get; set; }

            /// <summary>
            /// <para>The root cost center ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("RootCostCenterId")]
            [Validation(Required=false)]
            public long? RootCostCenterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>202509</para>
            /// </summary>
            [NameInMap("StartBillingMonth")]
            [Validation(Required=false)]
            public long? StartBillingMonth { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records per query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The metadata of the response structure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>The token for the next query. An empty NextToken indicates that there are no more results.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJwYWdlTnVtIjoyLCJwYWdlU2l6ZSI6MTB9</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79EE7556-0CFD-44EB-9CD6-B3B526E3A85F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
