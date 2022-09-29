// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkcard20210520.Models
{
    public class GetCardFlowInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCardFlowInfoResponseBodyData Data { get; set; }
        public class GetCardFlowInfoResponseBodyData : TeaModel {
            [NameInMap("ListCardMonthFlow")]
            [Validation(Required=false)]
            public List<GetCardFlowInfoResponseBodyDataListCardMonthFlow> ListCardMonthFlow { get; set; }
            public class GetCardFlowInfoResponseBodyDataListCardMonthFlow : TeaModel {
                [NameInMap("FlowCount")]
                [Validation(Required=false)]
                public string FlowCount { get; set; }

                [NameInMap("ListDayFlow")]
                [Validation(Required=false)]
                public List<GetCardFlowInfoResponseBodyDataListCardMonthFlowListDayFlow> ListDayFlow { get; set; }
                public class GetCardFlowInfoResponseBodyDataListCardMonthFlowListDayFlow : TeaModel {
                    [NameInMap("Day")]
                    [Validation(Required=false)]
                    public string Day { get; set; }

                    [NameInMap("Flow")]
                    [Validation(Required=false)]
                    public string Flow { get; set; }

                }

                [NameInMap("Month")]
                [Validation(Required=false)]
                public string Month { get; set; }

            }

            [NameInMap("ListPackageDTO")]
            [Validation(Required=false)]
            public List<GetCardFlowInfoResponseBodyDataListPackageDTO> ListPackageDTO { get; set; }
            public class GetCardFlowInfoResponseBodyDataListPackageDTO : TeaModel {
                [NameInMap("EffectiveTime")]
                [Validation(Required=false)]
                public string EffectiveTime { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("PackageName")]
                [Validation(Required=false)]
                public string PackageName { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

            }

            [NameInMap("ListVendorDetail")]
            [Validation(Required=false)]
            public List<GetCardFlowInfoResponseBodyDataListVendorDetail> ListVendorDetail { get; set; }
            public class GetCardFlowInfoResponseBodyDataListVendorDetail : TeaModel {
                [NameInMap("NetWorkDelay")]
                [Validation(Required=false)]
                public string NetWorkDelay { get; set; }

                [NameInMap("Ratio")]
                [Validation(Required=false)]
                public string Ratio { get; set; }

                [NameInMap("SignalStrength")]
                [Validation(Required=false)]
                public string SignalStrength { get; set; }

                [NameInMap("UsedFlow")]
                [Validation(Required=false)]
                public string UsedFlow { get; set; }

                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public string Vendor { get; set; }

            }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("LocalizedMessage")]
        [Validation(Required=false)]
        public string LocalizedMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
