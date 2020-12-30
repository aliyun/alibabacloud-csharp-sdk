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
                [NameInMap("BillingDataItem")]
                [Validation(Required=false)]
                public List<DescribeCdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingDataItem> BillingDataItem { get; set; }
                public class DescribeCdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingDataItem : TeaModel {
                    [NameInMap("Bandwidth")]
                    [Validation(Required=false)]
                    public float? Bandwidth { get; set; }

                    [NameInMap("ChargeType")]
                    [Validation(Required=false)]
                    public string ChargeType { get; set; }

                    [NameInMap("Flow")]
                    [Validation(Required=false)]
                    public float? Flow { get; set; }

                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public float? Count { get; set; }

                    [NameInMap("CdnRegion")]
                    [Validation(Required=false)]
                    public string CdnRegion { get; set; }

                }

            }
        };

    }

}
