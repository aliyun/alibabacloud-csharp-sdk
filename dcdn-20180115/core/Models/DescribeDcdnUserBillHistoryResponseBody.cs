// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserBillHistoryResponseBody : TeaModel {
        /// <summary>
        /// The billing history returned.
        /// </summary>
        [NameInMap("BillHistoryData")]
        [Validation(Required=false)]
        public DescribeDcdnUserBillHistoryResponseBodyBillHistoryData BillHistoryData { get; set; }
        public class DescribeDcdnUserBillHistoryResponseBodyBillHistoryData : TeaModel {
            [NameInMap("BillHistoryDataItem")]
            [Validation(Required=false)]
            public List<DescribeDcdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItem> BillHistoryDataItem { get; set; }
            public class DescribeDcdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItem : TeaModel {
                /// <summary>
                /// The beginning of the time range that was queried.
                /// </summary>
                [NameInMap("BillTime")]
                [Validation(Required=false)]
                public string BillTime { get; set; }

                /// <summary>
                /// The metering method.
                /// </summary>
                [NameInMap("BillType")]
                [Validation(Required=false)]
                public string BillType { get; set; }

                /// <summary>
                /// The billable items.
                /// </summary>
                [NameInMap("BillingData")]
                [Validation(Required=false)]
                public DescribeDcdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingData BillingData { get; set; }
                public class DescribeDcdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingData : TeaModel {
                    [NameInMap("BillingDataItem")]
                    [Validation(Required=false)]
                    public List<DescribeDcdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingDataBillingDataItem> BillingDataItem { get; set; }
                    public class DescribeDcdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingDataBillingDataItem : TeaModel {
                        /// <summary>
                        /// The bandwidth. Unit: bit/s.
                        /// </summary>
                        [NameInMap("Bandwidth")]
                        [Validation(Required=false)]
                        public float? Bandwidth { get; set; }

                        /// <summary>
                        /// The region for which the billing records are generated. Valid values: **CN**, **OverSeas**, **AP1**, **AP2**, **AP3**, **NA**, **SA**, **EU**, and **MEAA**.
                        /// </summary>
                        [NameInMap("CdnRegion")]
                        [Validation(Required=false)]
                        public string CdnRegion { get; set; }

                        /// <summary>
                        /// The billing method of the disk. Valid values: **StaticHttp**, **DynamicHttp**, and **DynamicHttps**.
                        /// </summary>
                        [NameInMap("ChargeType")]
                        [Validation(Required=false)]
                        public string ChargeType { get; set; }

                        /// <summary>
                        /// The number of billing entries.
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public float? Count { get; set; }

                        /// <summary>
                        /// The amount of network traffic. Unit: bytes.
                        /// </summary>
                        [NameInMap("Flow")]
                        [Validation(Required=false)]
                        public float? Flow { get; set; }

                    }

                }

                /// <summary>
                /// The dimension.
                /// </summary>
                [NameInMap("Dimension")]
                [Validation(Required=false)]
                public string Dimension { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
