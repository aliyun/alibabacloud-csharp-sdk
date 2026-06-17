// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ListOrdersResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned for the current request. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. If the query results are not returned in a single call, this token is returned. Use this token in a subsequent call to retrieve the remaining results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>212db86sca4384811e0b5e8707e******</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of orders.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OrderList")]
        [Validation(Required=false)]
        public List<ListOrdersResponseBodyOrderList> OrderList { get; set; }
        public class ListOrdersResponseBodyOrderList : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
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
            /// <item><description><para><b>Postpaid</b>: pay-as-you-go</para>
            /// </description></item>
            /// <item><description><para><b>Prepaid</b>: subscription</para>
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
            /// <item><description><para>polardb_sub: subscription in the Chinese mainland.</para>
            /// </description></item>
            /// <item><description><para>polardb_sub_intl: subscription in Hong Kong (China) and regions outside China.</para>
            /// </description></item>
            /// <item><description><para>polardb_payg: pay-as-you-go in the Chinese mainland.</para>
            /// </description></item>
            /// <item><description><para>polardb_payg_intl: pay-as-you-go in Hong Kong (China) and regions outside China.</para>
            /// </description></item>
            /// <item><description><para>polardb_sub_jushita: Jushita subscription.</para>
            /// </description></item>
            /// <item><description><para>polardb_payg_jushita: Jushita pay-as-you-go.</para>
            /// </description></item>
            /// <item><description><para>polardb_sub_cainiao: Cainiao subscription.</para>
            /// </description></item>
            /// <item><description><para>polardb_payg_cainiao: Cainiao pay-as-you-go.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>If you use an Alibaba Cloud account for the China site, you can view only the commodity codes for the Chinese mainland.</para>
            /// </description></item>
            /// <item><description><para>If you use an Alibaba Cloud international site account, you can view only the commodity codes for regions outside the Chinese mainland.</para>
            /// </description></item>
            /// <item><description><para>If you use a Jushita account, you can view only the commodity codes for Jushita.</para>
            /// </description></item>
            /// <item><description><para>If you use a Cainiao account, you can view only the commodity codes for Cainiao.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>polardb_payg_intl</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The time when the order was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-31T16:09:13</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
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
            /// <para>The status of the order.</para>
            /// <list type="bullet">
            /// <item><description><para><b>pending</b>: The task is waiting to start.</para>
            /// </description></item>
            /// <item><description><para><b>create</b>: The order is placed and is being processed.</para>
            /// </description></item>
            /// <item><description><para><b>fail</b>: The instance failed to be created.</para>
            /// </description></item>
            /// <item><description><para><b>cancel</b>: The order is canceled.</para>
            /// </description></item>
            /// <item><description><para><b>success</b>: The instance is created.</para>
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
            /// <para>The type of the order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>BUY: The instance is purchased.</para>
            /// </description></item>
            /// <item><description><para>UPGRADE: The instance configuration is changed.</para>
            /// </description></item>
            /// <item><description><para>RENEW: The subscription is renewed.</para>
            /// </description></item>
            /// <item><description><para>CONVERT: The billing method is changed.</para>
            /// </description></item>
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
            /// <para>The region information</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b></para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
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
