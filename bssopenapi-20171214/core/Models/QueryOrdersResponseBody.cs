// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryOrdersResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryOrdersResponseBodyData Data { get; set; }
        public class QueryOrdersResponseBodyData : TeaModel {
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }
            [NameInMap("OrderList")]
            [Validation(Required=false)]
            public QueryOrdersResponseBodyDataOrderList OrderList { get; set; }
            public class QueryOrdersResponseBodyDataOrderList : TeaModel {
                [NameInMap("Order")]
                [Validation(Required=false)]
                public List<QueryOrdersResponseBodyDataOrderListOrder> Order { get; set; }
                public class QueryOrdersResponseBodyDataOrderListOrder : TeaModel {
                    [NameInMap("AfterTaxAmount")]
                    [Validation(Required=false)]
                    public string AfterTaxAmount { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    [NameInMap("OrderId")]
                    [Validation(Required=false)]
                    public string OrderId { get; set; }

                    [NameInMap("OrderType")]
                    [Validation(Required=false)]
                    public string OrderType { get; set; }

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

                    [NameInMap("RelatedOrderId")]
                    [Validation(Required=false)]
                    public string RelatedOrderId { get; set; }

                    [NameInMap("SubscriptionType")]
                    [Validation(Required=false)]
                    public string SubscriptionType { get; set; }

                    [NameInMap("Tax")]
                    [Validation(Required=false)]
                    public string Tax { get; set; }

                }

            }
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
