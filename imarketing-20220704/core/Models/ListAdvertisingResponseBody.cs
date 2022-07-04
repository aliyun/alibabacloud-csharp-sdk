// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class ListAdvertisingResponseBody : TeaModel {
        /// <summary>
        /// errorCode
        /// </summary>
        [NameInMap("Errorcode")]
        [Validation(Required=false)]
        public string Errorcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [NameInMap("Errormsg")]
        [Validation(Required=false)]
        public string Errormsg { get; set; }

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
        };

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
                public List<ListAdvertisingResponseBodyResultSeatbidBid> Bid { get; set; }
                public class ListAdvertisingResponseBodyResultSeatbidBid : TeaModel {
                    public List<ListAdvertisingResponseBodyResultSeatbidBidAds> Ads { get; set; }
                    public class ListAdvertisingResponseBodyResultSeatbidBidAds : TeaModel {
                        public string Crid { get; set; }
                        public string Crurl { get; set; }
                        public ListAdvertisingResponseBodyResultSeatbidBidAdsIcon Icon { get; set; }
                        public class ListAdvertisingResponseBodyResultSeatbidBidAdsIcon : TeaModel {
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }
                        public string Id { get; set; }
                        public List<ListAdvertisingResponseBodyResultSeatbidBidAdsImages> Images { get; set; }
                        public class ListAdvertisingResponseBodyResultSeatbidBidAdsImages : TeaModel {
                            public string Desc { get; set; }
                            public string Format { get; set; }
                            public string Url { get; set; }
                        }
                        public int? Interacttype { get; set; }
                        public string Labeltype { get; set; }
                        public List<string> Landingurls { get; set; }
                        public string Marketingtype { get; set; }
                        public string Objective { get; set; }
                        public string Price { get; set; }
                        public string Seat { get; set; }
                        public string Style { get; set; }
                        public string Title { get; set; }
                        public ListAdvertisingResponseBodyResultSeatbidBidAdsTrackers Trackers { get; set; }
                        public class ListAdvertisingResponseBodyResultSeatbidBidAdsTrackers : TeaModel {
                            [NameInMap("Imps")]
                            [Validation(Required=false)]
                            public List<string> Imps { get; set; }

                        }
                        public string Type { get; set; }
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
