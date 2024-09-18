// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DdosDiversion20230701.Models
{
    public class QueryNetListResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// 
        /// - 200: The request was successful.
        /// - Other codes: The request failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The CIDR blocks.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryNetListResponseBodyData Data { get; set; }
        public class QueryNetListResponseBodyData : TeaModel {
            /// <summary>
            /// The configuration of the CIDR block.
            /// </summary>
            [NameInMap("Nets")]
            [Validation(Required=false)]
            public List<QueryNetListResponseBodyDataNets> Nets { get; set; }
            public class QueryNetListResponseBodyDataNets : TeaModel {
                /// <summary>
                /// The DDoS mitigation configuration of the CIDR block.
                /// </summary>
                [NameInMap("DDoSDefense")]
                [Validation(Required=false)]
                public QueryNetListResponseBodyDataNetsDDoSDefense DDoSDefense { get; set; }
                public class QueryNetListResponseBodyDataNetsDDoSDefense : TeaModel {
                    /// <summary>
                    /// The configuration of traffic scrubbing.
                    /// </summary>
                    [NameInMap("CleanTh")]
                    [Validation(Required=false)]
                    public QueryNetListResponseBodyDataNetsDDoSDefenseCleanTh CleanTh { get; set; }
                    public class QueryNetListResponseBodyDataNetsDDoSDefenseCleanTh : TeaModel {
                        /// <summary>
                        /// The traffic scrubbing threshold in Mbit/s.
                        /// </summary>
                        [NameInMap("Mbps")]
                        [Validation(Required=false)]
                        public int? Mbps { get; set; }

                        /// <summary>
                        /// The traffic scrubbing threshold in packets per second (pps)
                        /// </summary>
                        [NameInMap("Pps")]
                        [Validation(Required=false)]
                        public int? Pps { get; set; }

                    }

                    /// <summary>
                    /// The configuration of the mitigation policy.
                    /// </summary>
                    [NameInMap("DjPolicy")]
                    [Validation(Required=false)]
                    public QueryNetListResponseBodyDataNetsDDoSDefenseDjPolicy DjPolicy { get; set; }
                    public class QueryNetListResponseBodyDataNetsDDoSDefenseDjPolicy : TeaModel {
                        /// <summary>
                        /// The name of the mitigation policy.
                        /// </summary>
                        [NameInMap("PolicyName")]
                        [Validation(Required=false)]
                        public string PolicyName { get; set; }

                    }

                    /// <summary>
                    /// The configuration of blackhole filtering.
                    /// </summary>
                    [NameInMap("HoleTh")]
                    [Validation(Required=false)]
                    public QueryNetListResponseBodyDataNetsDDoSDefenseHoleTh HoleTh { get; set; }
                    public class QueryNetListResponseBodyDataNetsDDoSDefenseHoleTh : TeaModel {
                        /// <summary>
                        /// The blackhole filtering threshold.
                        /// </summary>
                        [NameInMap("ThreshMbps")]
                        [Validation(Required=false)]
                        public int? ThreshMbps { get; set; }

                    }

                }

                /// <summary>
                /// The advertising details.
                /// </summary>
                [NameInMap("Declared")]
                [Validation(Required=false)]
                public List<QueryNetListResponseBodyDataNetsDeclared> Declared { get; set; }
                public class QueryNetListResponseBodyDataNetsDeclared : TeaModel {
                    /// <summary>
                    /// Indicates whether the CIDR block is advertised. Valid values:
                    /// 
                    /// - 0: The CIDR block is not advertised.
                    /// - 1: The CIDR block is advertised.
                    /// </summary>
                    [NameInMap("Declared")]
                    [Validation(Required=false)]
                    public string Declared { get; set; }

                    /// <summary>
                    /// The region in which the CIDR block is advertised.
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                }

                /// <summary>
                /// The advertising status of the CIDR block. Valid values:
                /// - 0: The CIDR block is not advertised.
                /// - 1: The CIDR block is advertised.
                /// </summary>
                [NameInMap("DeclaredState")]
                [Validation(Required=false)]
                public int? DeclaredState { get; set; }

                /// <summary>
                /// Indicates whether the forwarding configuration takes effect. Valid values:
                /// 
                /// - 0: The forwarding configuration takes effect.
                /// - 1: The forwarding configuration does not take effect.
                /// - -1: The forwarding configuration is being deleted.
                /// </summary>
                [NameInMap("FwdEffect")]
                [Validation(Required=false)]
                public long? FwdEffect { get; set; }

                /// <summary>
                /// The creation time.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The modification time.
                /// </summary>
                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// The scheduling mode.
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// The CIDR block of the anti-DDoS diversion instance.
                /// </summary>
                [NameInMap("Net")]
                [Validation(Required=false)]
                public string Net { get; set; }

                /// <summary>
                /// Indicates whether the CIDR block needs to be extended. Valid values:
                /// 
                /// - 0: The CIDR block needs to be extended.
                /// - 1: The CIDR block does not need to be extended.
                /// </summary>
                [NameInMap("NetExtend")]
                [Validation(Required=false)]
                public string NetExtend { get; set; }

                /// <summary>
                /// The primary CIDR block.
                /// </summary>
                [NameInMap("NetMain")]
                [Validation(Required=false)]
                public string NetMain { get; set; }

                /// <summary>
                /// The type of the CIDR block.
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                [NameInMap("Permit")]
                [Validation(Required=false)]
                public int? Permit { get; set; }

                /// <summary>
                /// The ID of the anti-DDoS diversion instance.
                /// </summary>
                [NameInMap("SaleId")]
                [Validation(Required=false)]
                public string SaleId { get; set; }

                /// <summary>
                /// The reinjection type.
                /// </summary>
                [NameInMap("UpstreamType")]
                [Validation(Required=false)]
                public string UpstreamType { get; set; }

                /// <summary>
                /// The user ID.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("Num")]
            [Validation(Required=false)]
            public long? Num { get; set; }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
