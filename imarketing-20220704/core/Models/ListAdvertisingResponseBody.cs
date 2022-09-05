// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class ListAdvertisingResponseBody : TeaModel {
        [NameInMap("Errorcode")]
        [Validation(Required=false)]
        public string Errorcode { get; set; }

        [NameInMap("Errormsg")]
        [Validation(Required=false)]
        public string Errormsg { get; set; }

        [NameInMap("Ext")]
        [Validation(Required=false)]
        public Dictionary<string, string> Ext { get; set; }

        [NameInMap("Header")]
        [Validation(Required=false)]
        public ListAdvertisingResponseBodyHeader Header { get; set; }
        public class ListAdvertisingResponseBodyHeader : TeaModel {
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
        public ListAdvertisingResponseBodyResult Result { get; set; }
        public class ListAdvertisingResponseBodyResult : TeaModel {
            [NameInMap("Bidid")]
            [Validation(Required=false)]
            public string Bidid { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Seatbid")]
            [Validation(Required=false)]
            public List<ListAdvertisingResponseBodyResultSeatbid> Seatbid { get; set; }
            public class ListAdvertisingResponseBodyResultSeatbid : TeaModel {
                [NameInMap("Bid")]
                [Validation(Required=false)]
                public List<ListAdvertisingResponseBodyResultSeatbidBid> Bid { get; set; }
                public class ListAdvertisingResponseBodyResultSeatbidBid : TeaModel {
                    [NameInMap("Ads")]
                    [Validation(Required=false)]
                    public List<ListAdvertisingResponseBodyResultSeatbidBidAds> Ads { get; set; }
                    public class ListAdvertisingResponseBodyResultSeatbidBidAds : TeaModel {
                        [NameInMap("Crid")]
                        [Validation(Required=false)]
                        public string Crid { get; set; }

                        [NameInMap("Crurl")]
                        [Validation(Required=false)]
                        public string Crurl { get; set; }

                        [NameInMap("Icon")]
                        [Validation(Required=false)]
                        public ListAdvertisingResponseBodyResultSeatbidBidAdsIcon Icon { get; set; }
                        public class ListAdvertisingResponseBodyResultSeatbidBidAdsIcon : TeaModel {
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("Images")]
                        [Validation(Required=false)]
                        public List<ListAdvertisingResponseBodyResultSeatbidBidAdsImages> Images { get; set; }
                        public class ListAdvertisingResponseBodyResultSeatbidBidAdsImages : TeaModel {
                            [NameInMap("Desc")]
                            [Validation(Required=false)]
                            public string Desc { get; set; }

                            [NameInMap("Format")]
                            [Validation(Required=false)]
                            public string Format { get; set; }

                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

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

                        [NameInMap("Price")]
                        [Validation(Required=false)]
                        public string Price { get; set; }

                        [NameInMap("Seat")]
                        [Validation(Required=false)]
                        public string Seat { get; set; }

                        [NameInMap("Style")]
                        [Validation(Required=false)]
                        public string Style { get; set; }

                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        [NameInMap("Trackers")]
                        [Validation(Required=false)]
                        public ListAdvertisingResponseBodyResultSeatbidBidAdsTrackers Trackers { get; set; }
                        public class ListAdvertisingResponseBodyResultSeatbidBidAdsTrackers : TeaModel {
                            [NameInMap("Imps")]
                            [Validation(Required=false)]
                            public List<string> Imps { get; set; }

                        }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

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
