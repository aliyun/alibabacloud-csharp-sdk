// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightSegmentAvailableCertResponseBody : TeaModel {
        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightSegmentAvailableCertResponseBodyModule Module { get; set; }
        public class IntlFlightSegmentAvailableCertResponseBodyModule : TeaModel {
            [NameInMap("segment_available_cert_list")]
            [Validation(Required=false)]
            public List<IntlFlightSegmentAvailableCertResponseBodyModuleSegmentAvailableCertList> SegmentAvailableCertList { get; set; }
            public class IntlFlightSegmentAvailableCertResponseBodyModuleSegmentAvailableCertList : TeaModel {
                [NameInMap("cert_types")]
                [Validation(Required=false)]
                public List<int?> CertTypes { get; set; }

                [NameInMap("segment_position")]
                [Validation(Required=false)]
                public IntlFlightSegmentAvailableCertResponseBodyModuleSegmentAvailableCertListSegmentPosition SegmentPosition { get; set; }
                public class IntlFlightSegmentAvailableCertResponseBodyModuleSegmentAvailableCertListSegmentPosition : TeaModel {
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result_code")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("result_msg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
