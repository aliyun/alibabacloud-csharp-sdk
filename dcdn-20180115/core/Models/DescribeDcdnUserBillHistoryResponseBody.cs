// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserBillHistoryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BillHistoryData")]
        [Validation(Required=false)]
        public DescribeDcdnUserBillHistoryResponseBodyBillHistoryData BillHistoryData { get; set; }
        public class DescribeDcdnUserBillHistoryResponseBodyBillHistoryData : TeaModel {
            [NameInMap("BillHistoryDataItem")]
            [Validation(Required=false)]
            public List<DescribeDcdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItem> BillHistoryDataItem { get; set; }
            public class DescribeDcdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItem : TeaModel {
                [NameInMap("BillingDataItem")]
                [Validation(Required=false)]
                public List<DescribeDcdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingDataItem> BillingDataItem { get; set; }
                public class DescribeDcdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingDataItem : TeaModel {
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
