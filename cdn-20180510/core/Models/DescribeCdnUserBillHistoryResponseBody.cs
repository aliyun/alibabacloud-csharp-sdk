// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserBillHistoryResponseBody : TeaModel {
        /// <summary>
        /// The billing history returned.
        /// </summary>
        [NameInMap("BillHistoryData")]
        [Validation(Required=false)]
        public DescribeCdnUserBillHistoryResponseBodyBillHistoryData BillHistoryData { get; set; }
        public class DescribeCdnUserBillHistoryResponseBodyBillHistoryData : TeaModel {
            [NameInMap("BillHistoryDataItem")]
            [Validation(Required=false)]
            public List<DescribeCdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItem> BillHistoryDataItem { get; set; }
            public class DescribeCdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItem : TeaModel {
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
                public DescribeCdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingData BillingData { get; set; }
                public class DescribeCdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingData : TeaModel {
                    [NameInMap("BillingDataItem")]
                    [Validation(Required=false)]
                    public List<DescribeCdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingDataBillingDataItem> BillingDataItem { get; set; }
                    public class DescribeCdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingDataBillingDataItem : TeaModel {
                        /// <summary>
                        /// The bandwidth. Unit: bit/s.
                        /// </summary>
                        [NameInMap("Bandwidth")]
                        [Validation(Required=false)]
                        public float? Bandwidth { get; set; }

                        /// <summary>
                        /// The billable region. Valid values:
                        /// 
                        /// *   **CN**: Chinese mainland
                        /// *   **OverSeas**: outside the Chinese mainland
                        /// *   **AP1**: Asia Pacific 1
                        /// *   **AP2**: Asia Pacific 2
                        /// *   **AP3**: Asia Pacific 3
                        /// *   **NA**: North America
                        /// *   **SA**: South America
                        /// *   **EU**: Europe
                        /// *   **MEAA**: Middle East and Africa
                        /// </summary>
                        [NameInMap("CdnRegion")]
                        [Validation(Required=false)]
                        public string CdnRegion { get; set; }

                        /// <summary>
                        /// The billing method. Valid values:
                        /// 
                        /// *   **StaticHttp**: static HTTP requests
                        /// *   **DynamicHttp**: dynamic HTTP requests
                        /// *   **DynamicHttps**: dynamic HTTPS requests
                        /// </summary>
                        [NameInMap("ChargeType")]
                        [Validation(Required=false)]
                        public string ChargeType { get; set; }

                        /// <summary>
                        /// The number of requests.
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
