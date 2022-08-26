// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class AirportSearchResponseBody : TeaModel {
        [NameInMap("module")]
        [Validation(Required=false)]
        public AirportSearchResponseBodyModule Module { get; set; }
        public class AirportSearchResponseBodyModule : TeaModel {
            [NameInMap("cities")]
            [Validation(Required=false)]
            public List<AirportSearchResponseBodyModuleCities> Cities { get; set; }
            public class AirportSearchResponseBodyModuleCities : TeaModel {
                public string Code { get; set; }
                public int? Distance { get; set; }
                public string Name { get; set; }
                public string TravelName { get; set; }
            }
            [NameInMap("nearby")]
            [Validation(Required=false)]
            public bool? Nearby { get; set; }
        };

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result_code")]
        [Validation(Required=false)]
        public int? ResultCode { get; set; }

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
