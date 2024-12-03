// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySkuPriceListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data that is returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySkuPriceListResponseBodyData Data { get; set; }
        public class QuerySkuPriceListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The SKUs of the pricing object.</para>
            /// </summary>
            [NameInMap("SkuPricePage")]
            [Validation(Required=false)]
            public QuerySkuPriceListResponseBodyDataSkuPricePage SkuPricePage { get; set; }
            public class QuerySkuPriceListResponseBodyDataSkuPricePage : TeaModel {
                /// <summary>
                /// <para>The token that is used to query the next page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>080112060a0422020800180022490a470342000000315333303332363436363336333433393636333136333338333733373333333133373336363336323634363336363337333836333636333636313336363433363332</para>
                /// </summary>
                [NameInMap("NextPageToken")]
                [Validation(Required=false)]
                public string NextPageToken { get; set; }

                /// <summary>
                /// <para>The SKUs.</para>
                /// </summary>
                [NameInMap("SkuPriceList")]
                [Validation(Required=false)]
                public List<QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceList> SkuPriceList { get; set; }
                public class QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceList : TeaModel {
                    /// <summary>
                    /// <para>The prices of the SKUs.</para>
                    /// </summary>
                    [NameInMap("CskuPriceList")]
                    [Validation(Required=false)]
                    public List<QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceListCskuPriceList> CskuPriceList { get; set; }
                    public class QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceListCskuPriceList : TeaModel {
                        /// <summary>
                        /// <para>The unique code of the SKU price.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ac74dd7b52ae6389ddef099283fb8275</para>
                        /// </summary>
                        [NameInMap("CskuCode")]
                        [Validation(Required=false)]
                        public string CskuCode { get; set; }

                        /// <summary>
                        /// <para>The currency.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CNY</para>
                        /// </summary>
                        [NameInMap("Currency")]
                        [Validation(Required=false)]
                        public string Currency { get; set; }

                        /// <summary>
                        /// <para>The price.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Price")]
                        [Validation(Required=false)]
                        public string Price { get; set; }

                        /// <summary>
                        /// <para>The pricing mode.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>STEP_ARRIVE</para>
                        /// </summary>
                        [NameInMap("PriceMode")]
                        [Validation(Required=false)]
                        public string PriceMode { get; set; }

                        /// <summary>
                        /// <para>The pricing type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>hourPrice</para>
                        /// </summary>
                        [NameInMap("PriceType")]
                        [Validation(Required=false)]
                        public string PriceType { get; set; }

                        /// <summary>
                        /// <para>The unit of the price.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>USD (per unit)</para>
                        /// </summary>
                        [NameInMap("PriceUnit")]
                        [Validation(Required=false)]
                        public string PriceUnit { get; set; }

                        /// <summary>
                        /// <para>If the PriceMode parameter is set to STEP_ACCUMULATION or STEP_ARRIVE, the value of this field exists and specifies the range. If the PriceMode parameter is set to NORMAL_PRICE, the value of this field is null.</para>
                        /// </summary>
                        [NameInMap("RangeList")]
                        [Validation(Required=false)]
                        public List<QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceListCskuPriceListRangeList> RangeList { get; set; }
                        public class QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceListCskuPriceListRangeList : TeaModel {
                            /// <summary>
                            /// <para>The code of the pricing factor.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>212fbd27866307fc79ecf06934a88b2c</para>
                            /// </summary>
                            [NameInMap("FactorCode")]
                            [Validation(Required=false)]
                            public string FactorCode { get; set; }

                            /// <summary>
                            /// <para>The maximum value.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Max")]
                            [Validation(Required=false)]
                            public string Max { get; set; }

                            /// <summary>
                            /// <para>The minimum value.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("Min")]
                            [Validation(Required=false)]
                            public string Min { get; set; }

                            /// <summary>
                            /// <para>The closure type of the interval.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>LORC</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        /// <summary>
                        /// <para>The usage unit.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Count</para>
                        /// </summary>
                        [NameInMap("UsageUnit")]
                        [Validation(Required=false)]
                        public string UsageUnit { get; set; }

                    }

                    /// <summary>
                    /// <para>The code of the SKU.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>017c15a31507bc6de22aa93777461adc</para>
                    /// </summary>
                    [NameInMap("SkuCode")]
                    [Validation(Required=false)]
                    public string SkuCode { get; set; }

                    /// <summary>
                    /// <para>The values of the pricing factors.</para>
                    /// </summary>
                    [NameInMap("SkuFactorMap")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> SkuFactorMap { get; set; }

                }

                /// <summary>
                /// <para>The total number of SKUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18732</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5B803CF-94D8-43AF-ADB3-D819AAD30E27</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
