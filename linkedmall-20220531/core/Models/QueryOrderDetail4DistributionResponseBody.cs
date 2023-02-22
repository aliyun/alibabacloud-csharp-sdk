// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class QueryOrderDetail4DistributionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public QueryOrderDetail4DistributionResponseBodyModel Model { get; set; }
        public class QueryOrderDetail4DistributionResponseBodyModel : TeaModel {
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            [NameInMap("DistributionOrderId")]
            [Validation(Required=false)]
            public string DistributionOrderId { get; set; }

            [NameInMap("DistributorId")]
            [Validation(Required=false)]
            public string DistributorId { get; set; }

            [NameInMap("LogisticsStatus")]
            [Validation(Required=false)]
            public string LogisticsStatus { get; set; }

            [NameInMap("OrderAmount")]
            [Validation(Required=false)]
            public string OrderAmount { get; set; }

            [NameInMap("OrderStatus")]
            [Validation(Required=false)]
            public string OrderStatus { get; set; }

            [NameInMap("SubOrderList")]
            [Validation(Required=false)]
            public List<QueryOrderDetail4DistributionResponseBodyModelSubOrderList> SubOrderList { get; set; }
            public class QueryOrderDetail4DistributionResponseBodyModelSubOrderList : TeaModel {
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                [NameInMap("ItemPic")]
                [Validation(Required=false)]
                public string ItemPic { get; set; }

                [NameInMap("ItemPrice")]
                [Validation(Required=false)]
                public List<QueryOrderDetail4DistributionResponseBodyModelSubOrderListItemPrice> ItemPrice { get; set; }
                public class QueryOrderDetail4DistributionResponseBodyModelSubOrderListItemPrice : TeaModel {
                    [NameInMap("FundAmountMoney")]
                    [Validation(Required=false)]
                    public string FundAmountMoney { get; set; }

                }

                [NameInMap("ItemTitle")]
                [Validation(Required=false)]
                public string ItemTitle { get; set; }

                [NameInMap("LogisticsStatus")]
                [Validation(Required=false)]
                public string LogisticsStatus { get; set; }

                [NameInMap("MainDistributionOrderId")]
                [Validation(Required=false)]
                public string MainDistributionOrderId { get; set; }

                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                [NameInMap("OrderStatus")]
                [Validation(Required=false)]
                public string OrderStatus { get; set; }

                [NameInMap("SkuId")]
                [Validation(Required=false)]
                public string SkuId { get; set; }

                [NameInMap("SkuName")]
                [Validation(Required=false)]
                public string SkuName { get; set; }

                [NameInMap("SubDistributionOrderId")]
                [Validation(Required=false)]
                public string SubDistributionOrderId { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// pageSize
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
