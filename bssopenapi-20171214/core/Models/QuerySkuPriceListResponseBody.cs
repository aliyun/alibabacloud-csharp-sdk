// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySkuPriceListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySkuPriceListResponseBodyData Data { get; set; }
        public class QuerySkuPriceListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The pricing entity SKU information.</para>
            /// </summary>
            [NameInMap("SkuPricePage")]
            [Validation(Required=false)]
            public QuerySkuPriceListResponseBodyDataSkuPricePage SkuPricePage { get; set; }
            public class QuerySkuPriceListResponseBodyDataSkuPricePage : TeaModel {
                /// <summary>
                /// <para>The token for the next page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>080112060a0422020800180022490a470342000000315333303332363436363336333433393636333136333338333733373333333133373336363336323634363336363337333836333636333636313336363433363332</para>
                /// </summary>
                [NameInMap("NextPageToken")]
                [Validation(Required=false)]
                public string NextPageToken { get; set; }

                /// <summary>
                /// <para>The SKU list.</para>
                /// </summary>
                [NameInMap("SkuPriceList")]
                [Validation(Required=false)]
                public List<QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceList> SkuPriceList { get; set; }
                public class QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceList : TeaModel {
                    /// <summary>
                    /// <para>The SKU price list.</para>
                    /// </summary>
                    [NameInMap("CskuPriceList")]
                    [Validation(Required=false)]
                    public List<QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceListCskuPriceList> CskuPriceList { get; set; }
                    public class QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceListCskuPriceList : TeaModel {
                        /// <summary>
                        /// <para>The CSKU code, which is the unique price identifier.</para>
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
                        /// <para>The price type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>hourPrice</para>
                        /// </summary>
                        [NameInMap("PriceType")]
                        [Validation(Required=false)]
                        public string PriceType { get; set; }

                        /// <summary>
                        /// <para>The price unit.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>USD/unit</para>
                        /// </summary>
                        [NameInMap("PriceUnit")]
                        [Validation(Required=false)]
                        public string PriceUnit { get; set; }

                        /// <summary>
                        /// <para>This field has a value when PriceMode is STEP_ACCUMULATION or STEP_ARRIVE, specifying the range. When PriceMode is NORMAL_PRICE, this field is NULL.</para>
                        /// </summary>
                        [NameInMap("RangeList")]
                        [Validation(Required=false)]
                        public List<QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceListCskuPriceListRangeList> RangeList { get; set; }
                        public class QuerySkuPriceListResponseBodyDataSkuPricePageSkuPriceListCskuPriceListRangeList : TeaModel {
                            /// <summary>
                            /// <para>The factor code.</para>
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
                            /// <para>The interval closure type.</para>
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
                        /// <para>unit</para>
                        /// </summary>
                        [NameInMap("UsageUnit")]
                        [Validation(Required=false)]
                        public string UsageUnit { get; set; }

                    }

                    /// <summary>
                    /// <para>sku code</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>017c15a31507bc6de22aa93777461adc</para>
                    /// </summary>
                    [NameInMap("SkuCode")]
                    [Validation(Required=false)]
                    public string SkuCode { get; set; }

                    /// <summary>
                    /// <para>The collection of factor values. Different commodities have their own factors under pricing entities. For example, the instance_type pricing entity of the ECS commodity has factors such as <c>vm_region_no, iooptimized, vm_os_kind, instance_type</c>.</para>
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
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5B803CF-94D8-43AF-ADB3-D819AAD30E27</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
