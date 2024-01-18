// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class AncillarySuggestResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public AncillarySuggestResponseBodyData Data { get; set; }
        public class AncillarySuggestResponseBodyData : TeaModel {
            [NameInMap("seg_ancillary_map_list")]
            [Validation(Required=false)]
            public List<AncillarySuggestResponseBodyDataSegAncillaryMapList> SegAncillaryMapList { get; set; }
            public class AncillarySuggestResponseBodyDataSegAncillaryMapList : TeaModel {
                [NameInMap("ancillary")]
                [Validation(Required=false)]
                public AncillarySuggestResponseBodyDataSegAncillaryMapListAncillary Ancillary { get; set; }
                public class AncillarySuggestResponseBodyDataSegAncillaryMapListAncillary : TeaModel {
                    [NameInMap("ancillary_id")]
                    [Validation(Required=false)]
                    public string AncillaryId { get; set; }

                    [NameInMap("ancillary_type")]
                    [Validation(Required=false)]
                    public int? AncillaryType { get; set; }

                    /// <summary>
                    /// 行李辅营详情
                    /// </summary>
                    [NameInMap("baggage_ancillary")]
                    [Validation(Required=false)]
                    public AncillarySuggestResponseBodyDataSegAncillaryMapListAncillaryBaggageAncillary BaggageAncillary { get; set; }
                    public class AncillarySuggestResponseBodyDataSegAncillaryMapListAncillaryBaggageAncillary : TeaModel {
                        /// <summary>
                        /// 行李件数 取值如：3、2、1、0、-2。 -2 表示计重
                        /// </summary>
                        [NameInMap("baggage_amount")]
                        [Validation(Required=false)]
                        public int? BaggageAmount { get; set; }

                        /// <summary>
                        /// 行李重量，0-50。isAllWeght=true 时，表示所有件数总重量。
                        /// </summary>
                        [NameInMap("baggage_weight")]
                        [Validation(Required=false)]
                        public int? BaggageWeight { get; set; }

                        /// <summary>
                        /// 行李重量单位
                        /// </summary>
                        [NameInMap("baggage_weight_unit")]
                        [Validation(Required=false)]
                        public string BaggageWeightUnit { get; set; }

                        /// <summary>
                        /// 是否所有行李重量
                        /// </summary>
                        [NameInMap("is_all_weight")]
                        [Validation(Required=false)]
                        public bool? IsAllWeight { get; set; }

                        /// <summary>
                        /// 总价
                        /// </summary>
                        [NameInMap("price")]
                        [Validation(Required=false)]
                        public double? Price { get; set; }

                    }

                }

                [NameInMap("segment_id_list")]
                [Validation(Required=false)]
                public List<string> SegmentIdList { get; set; }

            }

            [NameInMap("solution_id")]
            [Validation(Required=false)]
            public string SolutionId { get; set; }

        }

        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
