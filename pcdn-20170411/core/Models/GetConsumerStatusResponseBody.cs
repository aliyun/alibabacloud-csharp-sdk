// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetConsumerStatusResponseBody : TeaModel {
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("LiveMonitor")]
        [Validation(Required=false)]
        public bool? LiveMonitor { get; set; }

        [NameInMap("Audit")]
        [Validation(Required=false)]
        public int? Audit { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("IntegreatedMode")]
        [Validation(Required=false)]
        public int? IntegreatedMode { get; set; }

        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("CdnUrlRedirectFlag")]
        [Validation(Required=false)]
        public bool? CdnUrlRedirectFlag { get; set; }

        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        [NameInMap("Inservice")]
        [Validation(Required=false)]
        public bool? Inservice { get; set; }

        [NameInMap("RealtimeMonitor")]
        [Validation(Required=false)]
        public bool? RealtimeMonitor { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
