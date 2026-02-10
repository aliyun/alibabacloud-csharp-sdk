// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOrderDetailResponseBodyData Data { get; set; }
        public class GetOrderDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("OrderList")]
            [Validation(Required=false)]
            public GetOrderDetailResponseBodyDataOrderList OrderList { get; set; }
            public class GetOrderDetailResponseBodyDataOrderList : TeaModel {
                [NameInMap("Order")]
                [Validation(Required=false)]
                public List<GetOrderDetailResponseBodyDataOrderListOrder> Order { get; set; }
                public class GetOrderDetailResponseBodyDataOrderListOrder : TeaModel {
                    [NameInMap("AfterTaxAmount")]
                    [Validation(Required=false)]
                    public string AfterTaxAmount { get; set; }

                    [NameInMap("BillModuleConfig")]
                    [Validation(Required=false)]
                    public GetOrderDetailResponseBodyDataOrderListOrderBillModuleConfig BillModuleConfig { get; set; }
                    public class GetOrderDetailResponseBodyDataOrderListOrderBillModuleConfig : TeaModel {
                        [NameInMap("billModuleConfig")]
                        [Validation(Required=false)]
                        public List<GetOrderDetailResponseBodyDataOrderListOrderBillModuleConfigBillModuleConfig> BillModuleConfig { get; set; }
                        public class GetOrderDetailResponseBodyDataOrderListOrderBillModuleConfigBillModuleConfig : TeaModel {
                            [NameInMap("ApiCode")]
                            [Validation(Required=false)]
                            public string ApiCode { get; set; }

                            [NameInMap("BillModuleProperties")]
                            [Validation(Required=false)]
                            public GetOrderDetailResponseBodyDataOrderListOrderBillModuleConfigBillModuleConfigBillModuleProperties BillModuleProperties { get; set; }
                            public class GetOrderDetailResponseBodyDataOrderListOrderBillModuleConfigBillModuleConfigBillModuleProperties : TeaModel {
                                [NameInMap("billModuleProperties")]
                                [Validation(Required=false)]
                                public List<GetOrderDetailResponseBodyDataOrderListOrderBillModuleConfigBillModuleConfigBillModulePropertiesBillModuleProperties> BillModuleProperties { get; set; }
                                public class GetOrderDetailResponseBodyDataOrderListOrderBillModuleConfigBillModuleConfigBillModulePropertiesBillModuleProperties : TeaModel {
                                    [NameInMap("AttrApiCode")]
                                    [Validation(Required=false)]
                                    public string AttrApiCode { get; set; }

                                    [NameInMap("ModuleApiCode")]
                                    [Validation(Required=false)]
                                    public string ModuleApiCode { get; set; }

                                    [NameInMap("Value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                            }

                            [NameInMap("Code")]
                            [Validation(Required=false)]
                            public string Code { get; set; }

                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                    }

                    [NameInMap("CommodityCode")]
                    [Validation(Required=false)]
                    public string CommodityCode { get; set; }

                    [NameInMap("Config")]
                    [Validation(Required=false)]
                    public string Config { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    [NameInMap("ExtendInfos")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ExtendInfos { get; set; }

                    [NameInMap("InstanceIds")]
                    [Validation(Required=false)]
                    public string InstanceIds { get; set; }

                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("OrderId")]
                    [Validation(Required=false)]
                    public string OrderId { get; set; }

                    [NameInMap("OrderSubType")]
                    [Validation(Required=false)]
                    public string OrderSubType { get; set; }

                    [NameInMap("OrderType")]
                    [Validation(Required=false)]
                    public string OrderType { get; set; }

                    [NameInMap("OriginalConfig")]
                    [Validation(Required=false)]
                    public string OriginalConfig { get; set; }

                    [NameInMap("OriginalModuleConfig")]
                    [Validation(Required=false)]
                    public GetOrderDetailResponseBodyDataOrderListOrderOriginalModuleConfig OriginalModuleConfig { get; set; }
                    public class GetOrderDetailResponseBodyDataOrderListOrderOriginalModuleConfig : TeaModel {
                        [NameInMap("originalModuleConfig")]
                        [Validation(Required=false)]
                        public List<GetOrderDetailResponseBodyDataOrderListOrderOriginalModuleConfigOriginalModuleConfig> OriginalModuleConfig { get; set; }
                        public class GetOrderDetailResponseBodyDataOrderListOrderOriginalModuleConfigOriginalModuleConfig : TeaModel {
                            [NameInMap("Code")]
                            [Validation(Required=false)]
                            public string Code { get; set; }

                            [NameInMap("ModuleProperties")]
                            [Validation(Required=false)]
                            public GetOrderDetailResponseBodyDataOrderListOrderOriginalModuleConfigOriginalModuleConfigModuleProperties ModuleProperties { get; set; }
                            public class GetOrderDetailResponseBodyDataOrderListOrderOriginalModuleConfigOriginalModuleConfigModuleProperties : TeaModel {
                                [NameInMap("moduleProperties")]
                                [Validation(Required=false)]
                                public List<GetOrderDetailResponseBodyDataOrderListOrderOriginalModuleConfigOriginalModuleConfigModulePropertiesModuleProperties> ModuleProperties { get; set; }
                                public class GetOrderDetailResponseBodyDataOrderListOrderOriginalModuleConfigOriginalModuleConfigModulePropertiesModuleProperties : TeaModel {
                                    [NameInMap("Code")]
                                    [Validation(Required=false)]
                                    public string Code { get; set; }

                                    [NameInMap("Name")]
                                    [Validation(Required=false)]
                                    public string Name { get; set; }

                                    [NameInMap("Value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                            }

                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                    }

                    [NameInMap("PaymentCurrency")]
                    [Validation(Required=false)]
                    public string PaymentCurrency { get; set; }

                    [NameInMap("PaymentStatus")]
                    [Validation(Required=false)]
                    public string PaymentStatus { get; set; }

                    [NameInMap("PaymentTime")]
                    [Validation(Required=false)]
                    public string PaymentTime { get; set; }

                    [NameInMap("PretaxAmount")]
                    [Validation(Required=false)]
                    public string PretaxAmount { get; set; }

                    [NameInMap("PretaxAmountLocal")]
                    [Validation(Required=false)]
                    public string PretaxAmountLocal { get; set; }

                    [NameInMap("PretaxGrossAmount")]
                    [Validation(Required=false)]
                    public string PretaxGrossAmount { get; set; }

                    [NameInMap("ProductCode")]
                    [Validation(Required=false)]
                    public string ProductCode { get; set; }

                    [NameInMap("ProductType")]
                    [Validation(Required=false)]
                    public string ProductType { get; set; }

                    [NameInMap("Quantity")]
                    [Validation(Required=false)]
                    public string Quantity { get; set; }

                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    [NameInMap("RelatedOrderId")]
                    [Validation(Required=false)]
                    public string RelatedOrderId { get; set; }

                    [NameInMap("SubOrderId")]
                    [Validation(Required=false)]
                    public string SubOrderId { get; set; }

                    [NameInMap("SubscriptionType")]
                    [Validation(Required=false)]
                    public string SubscriptionType { get; set; }

                    [NameInMap("Tax")]
                    [Validation(Required=false)]
                    public string Tax { get; set; }

                    [NameInMap("UsageEndTime")]
                    [Validation(Required=false)]
                    public string UsageEndTime { get; set; }

                    [NameInMap("UsageStartTime")]
                    [Validation(Required=false)]
                    public string UsageStartTime { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D6E068C3-25BC-455A-85FE-45F0B22ECB1F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
