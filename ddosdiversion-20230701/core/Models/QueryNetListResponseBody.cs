// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DdosDiversion20230701.Models
{
    public class QueryNetListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryNetListResponseBodyData> Data { get; set; }
        public class QueryNetListResponseBodyData : TeaModel {
            [NameInMap("Nets")]
            [Validation(Required=false)]
            public List<QueryNetListResponseBodyDataNets> Nets { get; set; }
            public class QueryNetListResponseBodyDataNets : TeaModel {
                [NameInMap("DDoSDefense")]
                [Validation(Required=false)]
                public QueryNetListResponseBodyDataNetsDDoSDefense DDoSDefense { get; set; }
                public class QueryNetListResponseBodyDataNetsDDoSDefense : TeaModel {
                    [NameInMap("CleanTh")]
                    [Validation(Required=false)]
                    public QueryNetListResponseBodyDataNetsDDoSDefenseCleanTh CleanTh { get; set; }
                    public class QueryNetListResponseBodyDataNetsDDoSDefenseCleanTh : TeaModel {
                        /// <summary>
                        /// Mbps。
                        /// </summary>
                        [NameInMap("Mbps")]
                        [Validation(Required=false)]
                        public int? Mbps { get; set; }

                        /// <summary>
                        /// Pps。
                        /// </summary>
                        [NameInMap("Pps")]
                        [Validation(Required=false)]
                        public int? Pps { get; set; }

                    }

                    [NameInMap("DjPolicy")]
                    [Validation(Required=false)]
                    public QueryNetListResponseBodyDataNetsDDoSDefenseDjPolicy DjPolicy { get; set; }
                    public class QueryNetListResponseBodyDataNetsDDoSDefenseDjPolicy : TeaModel {
                        [NameInMap("PolicyName")]
                        [Validation(Required=false)]
                        public string PolicyName { get; set; }

                    }

                    [NameInMap("HoleTh")]
                    [Validation(Required=false)]
                    public QueryNetListResponseBodyDataNetsDDoSDefenseHoleTh HoleTh { get; set; }
                    public class QueryNetListResponseBodyDataNetsDDoSDefenseHoleTh : TeaModel {
                        [NameInMap("ThreshMbps")]
                        [Validation(Required=false)]
                        public int? ThreshMbps { get; set; }

                    }

                }

                [NameInMap("Declared")]
                [Validation(Required=false)]
                public List<QueryNetListResponseBodyDataNetsDeclared> Declared { get; set; }
                public class QueryNetListResponseBodyDataNetsDeclared : TeaModel {
                    [NameInMap("Declared")]
                    [Validation(Required=false)]
                    public string Declared { get; set; }

                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                }

                [NameInMap("DeclaredState")]
                [Validation(Required=false)]
                public int? DeclaredState { get; set; }

                [NameInMap("FwdEffect")]
                [Validation(Required=false)]
                public long? FwdEffect { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("Net")]
                [Validation(Required=false)]
                public string Net { get; set; }

                [NameInMap("NetExtend")]
                [Validation(Required=false)]
                public long? NetExtend { get; set; }

                [NameInMap("NetMain")]
                [Validation(Required=false)]
                public string NetMain { get; set; }

                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                [NameInMap("SaleId")]
                [Validation(Required=false)]
                public string SaleId { get; set; }

                [NameInMap("UpstreamType")]
                [Validation(Required=false)]
                public string UpstreamType { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("Num")]
            [Validation(Required=false)]
            public long? Num { get; set; }

            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
