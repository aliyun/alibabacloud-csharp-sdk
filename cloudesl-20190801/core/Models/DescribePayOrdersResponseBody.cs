// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20190801.Models
{
    public class DescribePayOrdersResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PayOrders")]
        [Validation(Required=false)]
        public DescribePayOrdersResponseBodyPayOrders PayOrders { get; set; }
        public class DescribePayOrdersResponseBodyPayOrders : TeaModel {
            [NameInMap("PayOrderInfo")]
            [Validation(Required=false)]
            public List<DescribePayOrdersResponseBodyPayOrdersPayOrderInfo> PayOrderInfo { get; set; }
            public class DescribePayOrdersResponseBodyPayOrdersPayOrderInfo : TeaModel {
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                [NameInMap("CommodityName")]
                [Validation(Required=false)]
                public string CommodityName { get; set; }

                [NameInMap("DetailName")]
                [Validation(Required=false)]
                public string DetailName { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtPay")]
                [Validation(Required=false)]
                public string GmtPay { get; set; }

                [NameInMap("IsAccepted")]
                [Validation(Required=false)]
                public bool? IsAccepted { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("OrderStatus")]
                [Validation(Required=false)]
                public string OrderStatus { get; set; }

                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public float? OriginalAmount { get; set; }

                [NameInMap("PayAmount")]
                [Validation(Required=false)]
                public float? PayAmount { get; set; }

                [NameInMap("Quantity")]
                [Validation(Required=false)]
                public int? Quantity { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
