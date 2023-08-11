// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class ListSpecificAdResponseBody : TeaModel {
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
        public ListSpecificAdResponseBodyHeader Header { get; set; }
        public class ListSpecificAdResponseBodyHeader : TeaModel {
            /// <summary>
            /// costTime
            /// </summary>
            [NameInMap("CostTime")]
            [Validation(Required=false)]
            public long? CostTime { get; set; }

            /// <summary>
            /// rpcId
            /// </summary>
            [NameInMap("RpcId")]
            [Validation(Required=false)]
            public string RpcId { get; set; }

            /// <summary>
            /// traceId
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

            /// <summary>
            /// version
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListSpecificAdResponseBodyResult Result { get; set; }
        public class ListSpecificAdResponseBodyResult : TeaModel {
            [NameInMap("Bidid")]
            [Validation(Required=false)]
            public string Bidid { get; set; }

            /// <summary>
            /// id
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// seat
            /// </summary>
            [NameInMap("Seatbid")]
            [Validation(Required=false)]
            public List<ListSpecificAdResponseBodyResultSeatbid> Seatbid { get; set; }
            public class ListSpecificAdResponseBodyResultSeatbid : TeaModel {
                /// <summary>
                /// Bid
                /// </summary>
                [NameInMap("Bid")]
                [Validation(Required=false)]
                public List<ListSpecificAdResponseBodyResultSeatbidBid> Bid { get; set; }
                public class ListSpecificAdResponseBodyResultSeatbidBid : TeaModel {
                    /// <summary>
                    /// ad
                    /// </summary>
                    [NameInMap("Ads")]
                    [Validation(Required=false)]
                    public List<ListSpecificAdResponseBodyResultSeatbidBidAds> Ads { get; set; }
                    public class ListSpecificAdResponseBodyResultSeatbidBidAds : TeaModel {
                        /// <summary>
                        /// crid
                        /// </summary>
                        [NameInMap("Crid")]
                        [Validation(Required=false)]
                        public string Crid { get; set; }

                        [NameInMap("Crurl")]
                        [Validation(Required=false)]
                        public string Crurl { get; set; }

                        [NameInMap("Icon")]
                        [Validation(Required=false)]
                        public ListSpecificAdResponseBodyResultSeatbidBidAdsIcon Icon { get; set; }
                        public class ListSpecificAdResponseBodyResultSeatbidBidAdsIcon : TeaModel {
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// Interacttype
                        /// </summary>
                        [NameInMap("Interacttype")]
                        [Validation(Required=false)]
                        public int? Interacttype { get; set; }

                        [NameInMap("Itemid")]
                        [Validation(Required=false)]
                        public string Itemid { get; set; }

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

                        /// <summary>
                        /// seat
                        /// </summary>
                        [NameInMap("Seat")]
                        [Validation(Required=false)]
                        public string Seat { get; set; }

                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        [NameInMap("Trackers")]
                        [Validation(Required=false)]
                        public ListSpecificAdResponseBodyResultSeatbidBidAdsTrackers Trackers { get; set; }
                        public class ListSpecificAdResponseBodyResultSeatbidBidAdsTrackers : TeaModel {
                            [NameInMap("Imps")]
                            [Validation(Required=false)]
                            public List<string> Imps { get; set; }

                        }

                    }

                    /// <summary>
                    /// impId
                    /// </summary>
                    [NameInMap("Impid")]
                    [Validation(Required=false)]
                    public string Impid { get; set; }

                }

            }

        }

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
