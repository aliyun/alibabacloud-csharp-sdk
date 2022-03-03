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
                public string FlowCount { get; set; }
                public List<GetCardFlowInfoResponseBodyDataListCardMonthFlowListDayFlow> ListDayFlow { get; set; }
                public class GetCardFlowInfoResponseBodyDataListCardMonthFlowListDayFlow : TeaModel {
                    public string Day { get; set; }
                    public string Flow { get; set; }
                }
                public string Month { get; set; }
            }
            [NameInMap("ListPackageDTO")]
            [Validation(Required=false)]
            public List<GetCardFlowInfoResponseBodyDataListPackageDTO> ListPackageDTO { get; set; }
            public class GetCardFlowInfoResponseBodyDataListPackageDTO : TeaModel {
                public string EffectiveTime { get; set; }
                public string ExpireTime { get; set; }
                public string PackageName { get; set; }
                public string Remark { get; set; }
            }
            [NameInMap("ListVendorDetail")]
            [Validation(Required=false)]
            public List<GetCardFlowInfoResponseBodyDataListVendorDetail> ListVendorDetail { get; set; }
            public class GetCardFlowInfoResponseBodyDataListVendorDetail : TeaModel {
                public string NetWorkDelay { get; set; }
                public string SignalStrength { get; set; }
                public string Vendor { get; set; }
            }
        };

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
