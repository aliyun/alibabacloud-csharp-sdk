// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetConsumerStatusResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("IntegreatedMode")]
        [Validation(Required=true)]
        public int? IntegreatedMode { get; set; }

        [NameInMap("Inservice")]
        [Validation(Required=true)]
        public bool? Inservice { get; set; }

        [NameInMap("RealtimeMonitor")]
        [Validation(Required=true)]
        public bool? RealtimeMonitor { get; set; }

        [NameInMap("LiveMonitor")]
        [Validation(Required=true)]
        public bool? LiveMonitor { get; set; }

        [NameInMap("CdnUrlRedirectFlag")]
        [Validation(Required=true)]
        public bool? CdnUrlRedirectFlag { get; set; }

        [NameInMap("BusinessType")]
        [Validation(Required=true)]
        public string BusinessType { get; set; }

        [NameInMap("Audit")]
        [Validation(Required=true)]
        public int? Audit { get; set; }

        [NameInMap("Comment")]
        [Validation(Required=true)]
        public string Comment { get; set; }

        [NameInMap("CreatedAt")]
        [Validation(Required=true)]
        public string CreatedAt { get; set; }

        [NameInMap("UpdatedAt")]
        [Validation(Required=true)]
        public string UpdatedAt { get; set; }

    }

}
