// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySkuPriceListResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data that is returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySkuPriceListResponseBodyData Data { get; set; }
        public class QuerySkuPriceListResponseBodyData : TeaModel {
            /// <summary>
            /// The SKUs of the pricing object.
            /// </summary>
            [NameInMap("SkuPricePage")]
            [Validation(Required=false)]
            public QuerySkuPriceListResponseBodyDataSkuPricePage SkuPricePage { get; set; }
            public class QuerySkuPriceListResponseBodyDataSkuPricePage : TeaModel {
                /// <summary>
                /// The token that is used to query the next page.
                /// </summary>
                [NameInMap("NextPageToken")]
                [Validation(Required=false)]
                public string NextPageToken { get; set; }

                /// <summary>
                /// The SKUs.
                /// </summary>
                [NameInMap("SkuPriceList")]
                [Validation(Required=false)]
                public List<QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceList> SkuPriceList { get; set; }
                public class QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceList : TeaModel {
                    /// <summary>
                    /// The prices of the SKUs.
                    /// </summary>
                    [NameInMap("CskuPriceList")]
                    [Validation(Required=false)]
                    public List<QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceListCskuPriceList> CskuPriceList { get; set; }
                    public class QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceListCskuPriceList : TeaModel {
                        /// <summary>
                        /// The unique code of the SKU price.
                        /// </summary>
                        [NameInMap("CskuCode")]
                        [Validation(Required=false)]
                        public string CskuCode { get; set; }

                        /// <summary>
                        /// The currency.
                        /// </summary>
                        [NameInMap("Currency")]
                        [Validation(Required=false)]
                        public string Currency { get; set; }

                        /// <summary>
                        /// The price.
                        /// </summary>
                        [NameInMap("Price")]
                        [Validation(Required=false)]
                        public string Price { get; set; }

                        /// <summary>
                        /// The pricing mode.
                        /// </summary>
                        [NameInMap("PriceMode")]
                        [Validation(Required=false)]
                        public string PriceMode { get; set; }

                        /// <summary>
                        /// The pricing type.
                        /// </summary>
                        [NameInMap("PriceType")]
                        [Validation(Required=false)]
                        public string PriceType { get; set; }

                        /// <summary>
                        /// The unit of the price.
                        /// </summary>
                        [NameInMap("PriceUnit")]
                        [Validation(Required=false)]
                        public string PriceUnit { get; set; }

                        /// <summary>
                        /// If the PriceMode parameter is set to STEP_ACCUMULATION or STEP_ARRIVE, the value of this field exists and specifies the range. If the PriceMode parameter is set to NORMAL_PRICE, the value of this field is null.
                        /// </summary>
                        [NameInMap("RangeList")]
                        [Validation(Required=false)]
                        public List<QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceListCskuPriceListRangeList> RangeList { get; set; }
                        public class QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceListCskuPriceListRangeList : TeaModel {
                            /// <summary>
                            /// The code of the pricing factor.
                            /// </summary>
                            [NameInMap("FactorCode")]
                            [Validation(Required=false)]
                            public string FactorCode { get; set; }

                            /// <summary>
                            /// The maximum value.
                            /// </summary>
                            [NameInMap("Max")]
                            [Validation(Required=false)]
                            public string Max { get; set; }

                            /// <summary>
                            /// The minimum value.
                            /// </summary>
                            [NameInMap("Min")]
                            [Validation(Required=false)]
                            public string Min { get; set; }

                            /// <summary>
                            /// The closure type of the interval.
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        /// <summary>
                        /// The usage unit.
                        /// </summary>
                        [NameInMap("UsageUnit")]
                        [Validation(Required=false)]
                        public string UsageUnit { get; set; }

                    }

                    /// <summary>
                    /// The code of the SKU.
                    /// </summary>
                    [NameInMap("SkuCode")]
                    [Validation(Required=false)]
                    public string SkuCode { get; set; }

                    /// <summary>
                    /// The values of the pricing factors.
                    /// </summary>
                    [NameInMap("SkuFactorMap")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> SkuFactorMap { get; set; }

                }

                /// <summary>
                /// The total number of SKUs.
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

        /// <summary>
        /// The message that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
