// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class VerifyAdvertisingResponseBody : TeaModel {
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
        public VerifyAdvertisingResponseBodyHeader Header { get; set; }
        public class VerifyAdvertisingResponseBodyHeader : TeaModel {
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
        public VerifyAdvertisingResponseBodyResult Result { get; set; }
        public class VerifyAdvertisingResponseBodyResult : TeaModel {
            [NameInMap("Bidid")]
            [Validation(Required=false)]
            public string Bidid { get; set; }

            /// <summary>
            /// id
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Seatbid")]
            [Validation(Required=false)]
            public List<VerifyAdvertisingResponseBodyResultSeatbid> Seatbid { get; set; }
            public class VerifyAdvertisingResponseBodyResultSeatbid : TeaModel {
                /// <summary>
                /// bid
                /// </summary>
                [NameInMap("Bid")]
                [Validation(Required=false)]
                public List<VerifyAdvertisingResponseBodyResultSeatbidBid> Bid { get; set; }
                public class VerifyAdvertisingResponseBodyResultSeatbidBid : TeaModel {
                    [NameInMap("Ads")]
                    [Validation(Required=false)]
                    public List<VerifyAdvertisingResponseBodyResultSeatbidBidAds> Ads { get; set; }
                    public class VerifyAdvertisingResponseBodyResultSeatbidBidAds : TeaModel {
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
                        public VerifyAdvertisingResponseBodyResultSeatbidBidAdsIcon Icon { get; set; }
                        public class VerifyAdvertisingResponseBodyResultSeatbidBidAdsIcon : TeaModel {
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("Images")]
                        [Validation(Required=false)]
                        public List<VerifyAdvertisingResponseBodyResultSeatbidBidAdsImages> Images { get; set; }
                        public class VerifyAdvertisingResponseBodyResultSeatbidBidAdsImages : TeaModel {
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

                        /// <summary>
                        /// Interacttype
                        /// </summary>
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

                        /// <summary>
                        /// seat
                        /// </summary>
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
                        public VerifyAdvertisingResponseBodyResultSeatbidBidAdsTrackers Trackers { get; set; }
                        public class VerifyAdvertisingResponseBodyResultSeatbidBidAdsTrackers : TeaModel {
                            [NameInMap("Imps")]
                            [Validation(Required=false)]
                            public List<string> Imps { get; set; }

                        }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

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
