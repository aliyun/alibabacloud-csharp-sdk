// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class SearchAdvertisingResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("Ext")]
        [Validation(Required=false)]
        public Dictionary<string, string> Ext { get; set; }

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

        }

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
                [NameInMap("Bid")]
                [Validation(Required=false)]
                public List<SearchAdvertisingResponseBodyResultSeatbidBid> Bid { get; set; }
                public class SearchAdvertisingResponseBodyResultSeatbidBid : TeaModel {
                    [NameInMap("Ads")]
                    [Validation(Required=false)]
                    public List<SearchAdvertisingResponseBodyResultSeatbidBidAds> Ads { get; set; }
                    public class SearchAdvertisingResponseBodyResultSeatbidBidAds : TeaModel {
                        [NameInMap("Brandid")]
                        [Validation(Required=false)]
                        public string Brandid { get; set; }

                        [NameInMap("Commission")]
                        [Validation(Required=false)]
                        public string Commission { get; set; }

                        [NameInMap("Crid")]
                        [Validation(Required=false)]
                        public string Crid { get; set; }

                        [NameInMap("Crurl")]
                        [Validation(Required=false)]
                        public string Crurl { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("Interacttype")]
                        [Validation(Required=false)]
                        public int? Interacttype { get; set; }

                        [NameInMap("Labeltype")]
                        [Validation(Required=false)]
                        public string Labeltype { get; set; }

                        [NameInMap("Landingurls")]
                        [Validation(Required=false)]
                        public List<string> Landingurls { get; set; }

                        [NameInMap("Marketingtype")]
                        [Validation(Required=false)]
                        public string Marketingtype { get; set; }

                        [NameInMap("Objective")]
                        [Validation(Required=false)]
                        public string Objective { get; set; }

                        [NameInMap("Style")]
                        [Validation(Required=false)]
                        public string Style { get; set; }

                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        [NameInMap("Trackers")]
                        [Validation(Required=false)]
                        public SearchAdvertisingResponseBodyResultSeatbidBidAdsTrackers Trackers { get; set; }
                        public class SearchAdvertisingResponseBodyResultSeatbidBidAdsTrackers : TeaModel {
                            [NameInMap("Impressions")]
                            [Validation(Required=false)]
                            public List<string> Impressions { get; set; }

                        }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("icon")]
                        [Validation(Required=false)]
                        public SearchAdvertisingResponseBodyResultSeatbidBidAdsIcon Icon { get; set; }
                        public class SearchAdvertisingResponseBodyResultSeatbidBidAdsIcon : TeaModel {
                            [NameInMap("url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                    }

                    [NameInMap("Impid")]
                    [Validation(Required=false)]
                    public string Impid { get; set; }

                }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
