// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetSyntheticTaskMonitorsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetSyntheticTaskMonitorsResponseBodyData> Data { get; set; }
        public class GetSyntheticTaskMonitorsResponseBodyData : TeaModel {
            [NameInMap("Busy")]
            [Validation(Required=false)]
            public long? Busy { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public long? CityCode { get; set; }

            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public long? ClientType { get; set; }

            [NameInMap("District")]
            [Validation(Required=false)]
            public string District { get; set; }

            [NameInMap("NetServiceId")]
            [Validation(Required=false)]
            public long? NetServiceId { get; set; }

            [NameInMap("NetServiceName")]
            [Validation(Required=false)]
            public string NetServiceName { get; set; }

        }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
