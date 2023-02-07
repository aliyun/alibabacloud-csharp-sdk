// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySkuPriceListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySkuPriceListResponseBodyData Data { get; set; }
        public class QuerySkuPriceListResponseBodyData : TeaModel {
            [NameInMap("SkuPricePage")]
            [Validation(Required=false)]
            public QuerySkuPriceListResponseBodyDataSkuPricePage SkuPricePage { get; set; }
            public class QuerySkuPriceListResponseBodyDataSkuPricePage : TeaModel {
                [NameInMap("NextPageToken")]
                [Validation(Required=false)]
                public string NextPageToken { get; set; }

                [NameInMap("SkuPriceList")]
                [Validation(Required=false)]
                public List<QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceList> SkuPriceList { get; set; }
                public class QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceList : TeaModel {
                    [NameInMap("CskuPriceList")]
                    [Validation(Required=false)]
                    public List<QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceListCskuPriceList> CskuPriceList { get; set; }
                    public class QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceListCskuPriceList : TeaModel {
                        [NameInMap("CskuCode")]
                        [Validation(Required=false)]
                        public string CskuCode { get; set; }

                        [NameInMap("Currency")]
                        [Validation(Required=false)]
                        public string Currency { get; set; }

                        [NameInMap("Price")]
                        [Validation(Required=false)]
                        public string Price { get; set; }

                        [NameInMap("PriceMode")]
                        [Validation(Required=false)]
                        public string PriceMode { get; set; }

                        [NameInMap("PriceType")]
                        [Validation(Required=false)]
                        public string PriceType { get; set; }

                        [NameInMap("PriceUnit")]
                        [Validation(Required=false)]
                        public string PriceUnit { get; set; }

                        [NameInMap("RangeList")]
                        [Validation(Required=false)]
                        public List<QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceListCskuPriceListRangeList> RangeList { get; set; }
                        public class QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceListCskuPriceListRangeList : TeaModel {
                            [NameInMap("FactorCode")]
                            [Validation(Required=false)]
                            public string FactorCode { get; set; }

                            [NameInMap("Max")]
                            [Validation(Required=false)]
                            public string Max { get; set; }

                            [NameInMap("Min")]
                            [Validation(Required=false)]
                            public string Min { get; set; }

                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        [NameInMap("UsageUnit")]
                        [Validation(Required=false)]
                        public string UsageUnit { get; set; }

                    }

                    /// <summary>
                    /// sku code
                    /// </summary>
                    [NameInMap("SkuCode")]
                    [Validation(Required=false)]
                    public string SkuCode { get; set; }

                    [NameInMap("SkuFactorMap")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> SkuFactorMap { get; set; }

                }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
