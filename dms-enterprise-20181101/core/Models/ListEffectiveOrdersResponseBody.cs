// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListEffectiveOrdersResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("OrderSummary")]
        [Validation(Required=false)]
        public List<ListEffectiveOrdersResponseBodyOrderSummary> OrderSummary { get; set; }
        public class ListEffectiveOrdersResponseBodyOrderSummary : TeaModel {
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("CommodityType")]
            [Validation(Required=false)]
            public string CommodityType { get; set; }

            [NameInMap("OrderList")]
            [Validation(Required=false)]
            public List<ListEffectiveOrdersResponseBodyOrderSummaryOrderList> OrderList { get; set; }
            public class ListEffectiveOrdersResponseBodyOrderSummaryOrderList : TeaModel {
                [NameInMap("BuyerId")]
                [Validation(Required=false)]
                public string BuyerId { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("InsNum")]
                [Validation(Required=false)]
                public string InsNum { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            [NameInMap("TotalQuota")]
            [Validation(Required=false)]
            public int? TotalQuota { get; set; }

            [NameInMap("VersionType")]
            [Validation(Required=false)]
            public string VersionType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
