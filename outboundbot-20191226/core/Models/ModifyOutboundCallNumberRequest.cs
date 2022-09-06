// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyOutboundCallNumberRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Number")]
        [Validation(Required=false)]
        public string Number { get; set; }

        [NameInMap("OutboundCallNumberId")]
        [Validation(Required=false)]
        public string OutboundCallNumberId { get; set; }

        [NameInMap("RateLimitCount")]
        [Validation(Required=false)]
        public int? RateLimitCount { get; set; }

        [NameInMap("RateLimitPeriod")]
        [Validation(Required=false)]
        public int? RateLimitPeriod { get; set; }

    }

}
