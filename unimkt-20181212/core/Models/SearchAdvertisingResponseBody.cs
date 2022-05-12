// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class SearchAdvertisingResponseBody : TeaModel {
        /// <summary>
        /// errorCode
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// ext
        /// </summary>
        [NameInMap("Ext")]
        [Validation(Required=false)]
        public Dictionary<string, string> Ext { get; set; }

        /// <summary>
        /// header
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public SearchAdvertisingResponseBodyHeader Header { get; set; }
        public class SearchAdvertisingResponseBodyHeader : TeaModel {
            [NameInMap("CostTime")]
            [Validation(Required=false)]
            public long? CostTime { get; set; }
            [NameInMap("RpcId")]
            [Validation(Required=false)]
            public string RpcId { get; set; }
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public SearchAdvertisingResponseBodyResult Result { get; set; }
        public class SearchAdvertisingResponseBodyResult : TeaModel {
            [NameInMap("Bidid")]
            [Validation(Required=false)]
            public string Bidid { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("Seatbid")]
            [Validation(Required=false)]
            public List<SearchAdvertisingResponseBodyResultSeatbid> Seatbid { get; set; }
            public class SearchAdvertisingResponseBodyResultSeatbid : TeaModel {
                public List<SearchAdvertisingResponseBodyResultSeatbidBid> Bid { get; set; }
                public class SearchAdvertisingResponseBodyResultSeatbidBid : TeaModel {
                    public List<SearchAdvertisingResponseBodyResultSeatbidBidAds> Ads { get; set; }
                    public class SearchAdvertisingResponseBodyResultSeatbidBidAds : TeaModel {
                        public string Brandid { get; set; }
                        public string Commission { get; set; }
                        public string Crid { get; set; }
                        public string Crurl { get; set; }
                        public string Id { get; set; }
                        public int? Interacttype { get; set; }
                        public string Labeltype { get; set; }
                        public List<string> Landingurls { get; set; }
                        public string Marketingtype { get; set; }
                        public string Objective { get; set; }
                        public string Style { get; set; }
                        public string Title { get; set; }
                        public SearchAdvertisingResponseBodyResultSeatbidBidAdsTrackers Trackers { get; set; }
                        public class SearchAdvertisingResponseBodyResultSeatbidBidAdsTrackers : TeaModel {
                            [NameInMap("Impressions")]
                            [Validation(Required=false)]
                            public List<string> Impressions { get; set; }

                        }
                        public string Type { get; set; }
                        public SearchAdvertisingResponseBodyResultSeatbidBidAdsIcon Icon { get; set; }
                        public class SearchAdvertisingResponseBodyResultSeatbidBidAdsIcon : TeaModel {
                            [NameInMap("url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }
                    }
                    public string Impid { get; set; }
                }
            }
        };

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
