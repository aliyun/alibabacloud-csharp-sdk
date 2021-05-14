// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSummaryInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("AegisClientOfflineCount")]
        [Validation(Required=false)]
        public int? AegisClientOfflineCount { get; set; }

        [NameInMap("AegisClientOnlineCount")]
        [Validation(Required=false)]
        public int? AegisClientOnlineCount { get; set; }

        [NameInMap("SecurityScore")]
        [Validation(Required=false)]
        public int? SecurityScore { get; set; }

    }

}
