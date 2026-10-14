// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ListOrdersResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used to retrieve more results. If a single request does not return all results, this parameter is returned. You can pass the returned token in a subsequent request to continue retrieving results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>212db86sca4384811e0b5e8707e******</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The order list.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OrderList")]
        [Validation(Required=false)]
        public List<ListOrdersResponseBodyOrderList> OrderList { get; set; }
        public class ListOrdersResponseBodyOrderList : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1910740440664****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>The billing method of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Postpaid</b>: pay-as-you-go.</para>
            /// </description></item>
            /// <item><description><para><b>Prepaid</b>: subscription.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Prepaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The commodity code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>polardb_sub: subscription in the Chinese mainland.</description></item>
            /// <item><description>polardb_sub_intl: subscription in Hong Kong (China) and outside China.</description></item>
            /// <item><description>polardb_payg: pay-as-you-go in the Chinese mainland.</description></item>
            /// <item><description>polardb_payg_intl: pay-as-you-go in Hong Kong (China) and outside China.</description></item>
            /// <item><description>polardb_sub_jushita: Jushita subscription.</description></item>
            /// <item><description>polardb_payg_jushita: Jushita pay-as-you-go.</description></item>
            /// <item><description>polardb_sub_cainiao: Cainiao subscription.</description></item>
            /// <item><description>polardb_payg_cainiao: Cainiao pay-as-you-go.<remarks>
            /// <list type="bullet">
            /// <item><description>If you use an Alibaba Cloud China Website account, you can view only the commodity codes for the Chinese mainland.</description></item>
            /// <item><description>If you use an Alibaba Cloud International Website account, you can view only the commodity codes for international regions.</description></item>
            /// <item><description>If you use a Jushita account, you can view only the commodity codes for Jushita.</description></item>
            /// <item><description>If you use a Cainiao account, you can view only the commodity codes for Cainiao.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>polardb_payg_intl</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// <para>The time is in the YYYY-MM-DDTHH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-31T16:09:13</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The cluster ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-uf6k532gav*******</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25808743077*****</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <para>The order status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>pending</b>: The task is waiting to start.</para>
            /// </description></item>
            /// <item><description><para><b>create</b>: The order has been placed and entered the production process.</para>
            /// </description></item>
            /// <item><description><para><b>fail</b>: Production failed.</para>
            /// </description></item>
            /// <item><description><para><b>cancel</b>: The order is canceled.</para>
            /// </description></item>
            /// <item><description><para><b>success</b>: Production succeeded.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("OrderStatus")]
            [Validation(Required=false)]
            public string OrderStatus { get; set; }

            /// <summary>
            /// <para>The order type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BUY: new purchase.</description></item>
            /// <item><description>UPGRADE: configuration change.</description></item>
            /// <item><description>RENEW: renewal.</description></item>
            /// <item><description>CONVERT: billing method conversion.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BUY</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// <para>The product code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polardb</para>
            /// </summary>
            [NameInMap("ProduceCode")]
            [Validation(Required=false)]
            public string ProduceCode { get; set; }

            /// <summary>
            /// <para>The region information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b></description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// <para>Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3AA69096-757C-4647-B36C-29EBC2******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
