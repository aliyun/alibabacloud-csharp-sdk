// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class LogReservePolicy : TeaModel {
        [NameInMap("expirationDays")]
        [Validation(Required=false)]
        public long? ExpirationDays { get; set; }

        [NameInMap("openHistory")]
        [Validation(Required=false)]
        public bool? OpenHistory { get; set; }

    }

}
