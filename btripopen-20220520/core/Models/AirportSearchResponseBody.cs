// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class AirportSearchResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public AirportSearchResponseBodyModule Module { get; set; }
        public class AirportSearchResponseBodyModule : TeaModel {
            [NameInMap("cities")]
            [Validation(Required=false)]
            public List<AirportSearchResponseBodyModuleCities> Cities { get; set; }
            public class AirportSearchResponseBodyModuleCities : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("distance")]
                [Validation(Required=false)]
                public int? Distance { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("travel_name")]
                [Validation(Required=false)]
                public string TravelName { get; set; }

            }

            [NameInMap("nearby")]
            [Validation(Required=false)]
            public bool? Nearby { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
