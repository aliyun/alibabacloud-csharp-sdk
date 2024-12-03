// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOrderDetailResponseBodyData Data { get; set; }
        public class GetOrderDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The hostname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The orders returned.</para>
            /// </summary>
            [NameInMap("OrderList")]
            [Validation(Required=false)]
            public GetOrderDetailResponseBodyDataOrderList OrderList { get; set; }
            public class GetOrderDetailResponseBodyDataOrderList : TeaModel {
                [NameInMap("Order")]
                [Validation(Required=false)]
                public List<GetOrderDetailResponseBodyDataOrderListOrder> Order { get; set; }
                public class GetOrderDetailResponseBodyDataOrderListOrder : TeaModel {
                    /// <summary>
                    /// <para>The aftertaxt amount of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AfterTaxAmount")]
                    [Validation(Required=false)]
                    public string AfterTaxAmount { get; set; }

                    /// <summary>
                    /// <para>The billing information about the configurations.</para>
                    /// </summary>
                    [NameInMap("BillModuleConfig")]
                    [Validation(Required=false)]
                    public GetOrderDetailResponseBodyDataOrderListOrderBillModuleConfig BillModuleConfig { get; set; }
                    public class GetOrderDetailResponseBodyDataOrderListOrderBillModuleConfig : TeaModel {
                        [NameInMap("billModuleConfig")]
                        [Validation(Required=false)]
                        public List<GetOrderDetailResponseBodyDataOrderListOrderBillModuleConfigBillModuleConfig> BillModuleConfig { get; set; }
                        public class GetOrderDetailResponseBodyDataOrderListOrderBillModuleConfigBillModuleConfig : TeaModel {
                            /// <summary>
                            /// <para>The API code of the configuration item.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>datadisk</para>
                            /// </summary>
                            [NameInMap("ApiCode")]
                            [Validation(Required=false)]
                            public string ApiCode { get; set; }

                            /// <summary>
                            /// <para>The attributes of the configured item.</para>
                            /// </summary>
                            [NameInMap("BillModuleProperties")]
                            [Validation(Required=false)]
                            public GetOrderDetailResponseBodyDataOrderListOrderBillModuleConfigBillModuleConfigBillModuleProperties BillModuleProperties { get; set; }
                            public class GetOrderDetailResponseBodyDataOrderListOrderBillModuleConfigBillModuleConfigBillModuleProperties : TeaModel {
                                [NameInMap("billModuleProperties")]
                                [Validation(Required=false)]
                                public List<GetOrderDetailResponseBodyDataOrderListOrderBillModuleConfigBillModuleConfigBillModulePropertiesBillModuleProperties> BillModuleProperties { get; set; }
                                public class GetOrderDetailResponseBodyDataOrderListOrderBillModuleConfigBillModuleConfigBillModulePropertiesBillModuleProperties : TeaModel {
                                    /// <summary>
                                    /// <para>The attribute code of the configured item.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>cloud_ssd</para>
                                    /// </summary>
                                    [NameInMap("AttrApiCode")]
                                    [Validation(Required=false)]
                                    public string AttrApiCode { get; set; }

                                    /// <summary>
                                    /// <para>The API code of the configured item.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>cloud_ssd</para>
                                    /// </summary>
                                    [NameInMap("ModuleApiCode")]
                                    [Validation(Required=false)]
                                    public string ModuleApiCode { get; set; }

                                    /// <summary>
                                    /// <para>The attribute value of the configuration item.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>cloud_ssd</para>
                                    /// </summary>
                                    [NameInMap("Value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                            }

                            /// <summary>
                            /// <para>The code of the configuration item.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>datadisk</para>
                            /// </summary>
                            [NameInMap("Code")]
                            [Validation(Required=false)]
                            public string Code { get; set; }

                            /// <summary>
                            /// <para>The name of the configuration item.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Data disk</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The commodity code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rds</para>
                    /// </summary>
                    [NameInMap("CommodityCode")]
                    [Validation(Required=false)]
                    public string CommodityCode { get; set; }

                    /// <summary>
                    /// <para>The configurations of the main service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DBInstanceClass:[DBInstanceClass:rds.mysql.s1.small;EngineVersion:8.0;Region:cn-qingdao;]DBFlowType:[Region:cn-qingdao;]</para>
                    /// </summary>
                    [NameInMap("Config")]
                    [Validation(Required=false)]
                    public string Config { get; set; }

                    /// <summary>
                    /// <para>The time when the order was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2017-06-08T09:41:30Z</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>The currency. Valid values: CNY, USD, and JPY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CNY</para>
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <para>The additional information about the order.</para>
                    /// </summary>
                    [NameInMap("ExtendInfos")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ExtendInfos { get; set; }

                    /// <summary>
                    /// <para>The instance IDs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[&quot;rm-bp1a2vsr018313t6o&quot;]</para>
                    /// </summary>
                    [NameInMap("InstanceIDs")]
                    [Validation(Required=false)]
                    public string InstanceIDs { get; set; }

                    /// <summary>
                    /// <para>The ID of the Resource Access Management (RAM) user that performs operations on the order. If no RAM user is involved, this parameter is empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>23424243432</para>
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>The order ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3453425324</para>
                    /// </summary>
                    [NameInMap("OrderId")]
                    [Validation(Required=false)]
                    public string OrderId { get; set; }

                    /// <summary>
                    /// <para>The type of the suborder. A value of productsuborder indicates service suborder. A value of refundsuborder indicates refund suborder.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ProductSubOrder</para>
                    /// </summary>
                    [NameInMap("OrderSubType")]
                    [Validation(Required=false)]
                    public string OrderSubType { get; set; }

                    /// <summary>
                    /// <para>The type of the order. Valid values: new, renew, upgrade, and refund.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>New</para>
                    /// </summary>
                    [NameInMap("OrderType")]
                    [Validation(Required=false)]
                    public string OrderType { get; set; }

                    /// <summary>
                    /// <para>The configuration information that is not formatted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DBInstanceClass:[DBInstanceClass:rds.mysql.s1.small;EngineVersion:8.0;Region:cn-qingdao;]DBFlowType:[Region:cn-qingdao;]</para>
                    /// </summary>
                    [NameInMap("OriginalConfig")]
                    [Validation(Required=false)]
                    public string OriginalConfig { get; set; }

                    /// <summary>
                    /// <para>The information about the configurations.</para>
                    /// </summary>
                    [NameInMap("OriginalModuleConfig")]
                    [Validation(Required=false)]
                    public GetOrderDetailResponseBodyDataOrderListOrderOriginalModuleConfig OriginalModuleConfig { get; set; }
                    public class GetOrderDetailResponseBodyDataOrderListOrderOriginalModuleConfig : TeaModel {
                        [NameInMap("originalModuleConfig")]
                        [Validation(Required=false)]
                        public List<GetOrderDetailResponseBodyDataOrderListOrderOriginalModuleConfigOriginalModuleConfig> OriginalModuleConfig { get; set; }
                        public class GetOrderDetailResponseBodyDataOrderListOrderOriginalModuleConfigOriginalModuleConfig : TeaModel {
                            /// <summary>
                            /// <para>The code of the configuration item.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>systemdisk</para>
                            /// </summary>
                            [NameInMap("Code")]
                            [Validation(Required=false)]
                            public string Code { get; set; }

                            /// <summary>
                            /// <para>The attributes of the configured item.</para>
                            /// </summary>
                            [NameInMap("ModuleProperties")]
                            [Validation(Required=false)]
                            public GetOrderDetailResponseBodyDataOrderListOrderOriginalModuleConfigOriginalModuleConfigModuleProperties ModuleProperties { get; set; }
                            public class GetOrderDetailResponseBodyDataOrderListOrderOriginalModuleConfigOriginalModuleConfigModuleProperties : TeaModel {
                                [NameInMap("moduleProperties")]
                                [Validation(Required=false)]
                                public List<GetOrderDetailResponseBodyDataOrderListOrderOriginalModuleConfigOriginalModuleConfigModulePropertiesModuleProperties> ModuleProperties { get; set; }
                                public class GetOrderDetailResponseBodyDataOrderListOrderOriginalModuleConfigOriginalModuleConfigModulePropertiesModuleProperties : TeaModel {
                                    /// <summary>
                                    /// <para>The attribute code of the configured item.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>cloud_efficiency</para>
                                    /// </summary>
                                    [NameInMap("Code")]
                                    [Validation(Required=false)]
                                    public string Code { get; set; }

                                    /// <summary>
                                    /// <para>The attribute name of the configured item.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>cloud_efficiency</para>
                                    /// </summary>
                                    [NameInMap("Name")]
                                    [Validation(Required=false)]
                                    public string Name { get; set; }

                                    /// <summary>
                                    /// <para>The attribute value of the configured item.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>cloud_efficiency</para>
                                    /// </summary>
                                    [NameInMap("Value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                            }

                            /// <summary>
                            /// <para>The name of the configuration item.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>System disk</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The currency used for payment. Valid values: CNY, USD, and JPY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CNY</para>
                    /// </summary>
                    [NameInMap("PaymentCurrency")]
                    [Validation(Required=false)]
                    public string PaymentCurrency { get; set; }

                    /// <summary>
                    /// <para>The payment state. Valid values: unpaid, paid, and canceled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Paid</para>
                    /// </summary>
                    [NameInMap("PaymentStatus")]
                    [Validation(Required=false)]
                    public string PaymentStatus { get; set; }

                    /// <summary>
                    /// <para>The time of payment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2017-06-08T09:41:30Z</para>
                    /// </summary>
                    [NameInMap("PaymentTime")]
                    [Validation(Required=false)]
                    public string PaymentTime { get; set; }

                    /// <summary>
                    /// <para>The pretax amount of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PretaxAmount")]
                    [Validation(Required=false)]
                    public string PretaxAmount { get; set; }

                    /// <summary>
                    /// <para>The pretax amount of the order in local currency.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PretaxAmountLocal")]
                    [Validation(Required=false)]
                    public string PretaxAmountLocal { get; set; }

                    /// <summary>
                    /// <para>The pretax gross amount of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PretaxGrossAmount")]
                    [Validation(Required=false)]
                    public string PretaxGrossAmount { get; set; }

                    /// <summary>
                    /// <para>The code of the main service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rds</para>
                    /// </summary>
                    [NameInMap("ProductCode")]
                    [Validation(Required=false)]
                    public string ProductCode { get; set; }

                    /// <summary>
                    /// <para>The type of the main service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rds</para>
                    /// </summary>
                    [NameInMap("ProductType")]
                    [Validation(Required=false)]
                    public string ProductType { get; set; }

                    /// <summary>
                    /// <para>The number of main services.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Quantity")]
                    [Validation(Required=false)]
                    public string Quantity { get; set; }

                    /// <summary>
                    /// <para>The region ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <para>The ID of the associated order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4353453534543</para>
                    /// </summary>
                    [NameInMap("RelatedOrderId")]
                    [Validation(Required=false)]
                    public string RelatedOrderId { get; set; }

                    /// <summary>
                    /// <para>The ID of the suborder.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>234343</para>
                    /// </summary>
                    [NameInMap("SubOrderId")]
                    [Validation(Required=false)]
                    public string SubOrderId { get; set; }

                    /// <summary>
                    /// <para>The billing method. Valid values: Subscription and PayAsYouGo.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PayAsYouGo</para>
                    /// </summary>
                    [NameInMap("SubscriptionType")]
                    [Validation(Required=false)]
                    public string SubscriptionType { get; set; }

                    /// <summary>
                    /// <para>The tax of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Tax")]
                    [Validation(Required=false)]
                    public string Tax { get; set; }

                    /// <summary>
                    /// <para>The time when the service ends.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2117-06-08T16:00:00Z</para>
                    /// </summary>
                    [NameInMap("UsageEndTime")]
                    [Validation(Required=false)]
                    public string UsageEndTime { get; set; }

                    /// <summary>
                    /// <para>The time when the service starts.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2017-06-08T16:00:00Z</para>
                    /// </summary>
                    [NameInMap("UsageStartTime")]
                    [Validation(Required=false)]
                    public string UsageStartTime { get; set; }

                }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6E068C3-25BC-455A-85FE-45F0B22ECB1F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
