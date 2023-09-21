// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotStatisticsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHoneypotStatisticsResponseBodyData Data { get; set; }
        public class GetHoneypotStatisticsResponseBodyData : TeaModel {
            [NameInMap("TotalHoneypotCount")]
            [Validation(Required=false)]
            public int? TotalHoneypotCount { get; set; }

            [NameInMap("TotalNodeStatus")]
            [Validation(Required=false)]
            public int? TotalNodeStatus { get; set; }

            [NameInMap("TotalProbeCount")]
            [Validation(Required=false)]
            public int? TotalProbeCount { get; set; }

            [NameInMap("UsedHoneypotCount")]
            [Validation(Required=false)]
            public int? UsedHoneypotCount { get; set; }

            [NameInMap("UsedHostProbeCount")]
            [Validation(Required=false)]
            public int? UsedHostProbeCount { get; set; }

            [NameInMap("UsedProbeCount")]
            [Validation(Required=false)]
            public int? UsedProbeCount { get; set; }

            [NameInMap("UsedVpcProbeCount")]
            [Validation(Required=false)]
            public int? UsedVpcProbeCount { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
