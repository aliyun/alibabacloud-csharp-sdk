// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserBillHistoryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BillHistoryData")]
        [Validation(Required=false)]
        public DescribeCdnUserBillHistoryResponseBodyBillHistoryData BillHistoryData { get; set; }
        public class DescribeCdnUserBillHistoryResponseBodyBillHistoryData : TeaModel {
            [NameInMap("BillHistoryDataItem")]
            [Validation(Required=false)]
            public List<DescribeCdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItem> BillHistoryDataItem { get; set; }
            public class DescribeCdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItem : TeaModel {
                public string Dimension { get; set; }
                public string BillType { get; set; }
                public string BillTime { get; set; }
                public DescribeCdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingData BillingData { get; set; }
                public class DescribeCdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingData : TeaModel {
                    [NameInMap("BillingDataItem")]
                    [Validation(Required=false)]
                    public List<DescribeCdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingDataBillingDataItem> BillingDataItem { get; set; }
                    public class DescribeCdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingDataBillingDataItem : TeaModel {
                        [NameInMap("Flow")]
                        [Validation(Required=false)]
                        public float? Flow { get; set; }

                        [NameInMap("Bandwidth")]
                        [Validation(Required=false)]
                        public float? Bandwidth { get; set; }

                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public float? Count { get; set; }

                        [NameInMap("CdnRegion")]
                        [Validation(Required=false)]
                        public string CdnRegion { get; set; }

                        [NameInMap("ChargeType")]
                        [Validation(Required=false)]
                        public string ChargeType { get; set; }

                    }

                }
            }
        };

    }

}
