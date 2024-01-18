// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryOrderInfoAfterSaleResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public QueryOrderInfoAfterSaleResponseBodyModel Model { get; set; }
        public class QueryOrderInfoAfterSaleResponseBodyModel : TeaModel {
            [NameInMap("CashAmount")]
            [Validation(Required=false)]
            public string CashAmount { get; set; }

            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            [NameInMap("ExtJson")]
            [Validation(Required=false)]
            public string ExtJson { get; set; }

            [NameInMap("LmOrderId")]
            [Validation(Required=false)]
            public long? LmOrderId { get; set; }

            [NameInMap("LogisticsList")]
            [Validation(Required=false)]
            public QueryOrderInfoAfterSaleResponseBodyModelLogisticsList LogisticsList { get; set; }
            public class QueryOrderInfoAfterSaleResponseBodyModelLogisticsList : TeaModel {
                [NameInMap("Logistics")]
                [Validation(Required=false)]
                public List<QueryOrderInfoAfterSaleResponseBodyModelLogisticsListLogistics> Logistics { get; set; }
                public class QueryOrderInfoAfterSaleResponseBodyModelLogisticsListLogistics : TeaModel {
                    [NameInMap("LogisticsCompanyCode")]
                    [Validation(Required=false)]
                    public string LogisticsCompanyCode { get; set; }

                    [NameInMap("LogisticsCompanyName")]
                    [Validation(Required=false)]
                    public string LogisticsCompanyName { get; set; }

                    [NameInMap("LogisticsNo")]
                    [Validation(Required=false)]
                    public string LogisticsNo { get; set; }

                    [NameInMap("LogisticsStatus")]
                    [Validation(Required=false)]
                    public string LogisticsStatus { get; set; }

                }

            }

            [NameInMap("OrderStatus")]
            [Validation(Required=false)]
            public string OrderStatus { get; set; }

            [NameInMap("Points")]
            [Validation(Required=false)]
            public long? Points { get; set; }

            [NameInMap("PointsAmount")]
            [Validation(Required=false)]
            public long? PointsAmount { get; set; }

            [NameInMap("RefundAmount")]
            [Validation(Required=false)]
            public long? RefundAmount { get; set; }

            [NameInMap("RefundPoints")]
            [Validation(Required=false)]
            public long? RefundPoints { get; set; }

            [NameInMap("RefundRate")]
            [Validation(Required=false)]
            public string RefundRate { get; set; }

            [NameInMap("RefundStatus")]
            [Validation(Required=false)]
            public string RefundStatus { get; set; }

            [NameInMap("ShopName")]
            [Validation(Required=false)]
            public string ShopName { get; set; }

            [NameInMap("ShopServiceTelephone")]
            [Validation(Required=false)]
            public string ShopServiceTelephone { get; set; }

            [NameInMap("TbOrderId")]
            [Validation(Required=false)]
            public long? TbOrderId { get; set; }

            [NameInMap("XiaomiCode")]
            [Validation(Required=false)]
            public string XiaomiCode { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
