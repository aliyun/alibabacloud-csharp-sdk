// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CookieSessionAffinityConfig : TeaModel {
        [NameInMap("disableSessionIdReuse")]
        [Validation(Required=false)]
        public bool? DisableSessionIdReuse { get; set; }

        [NameInMap("sessionConcurrencyPerInstance")]
        [Validation(Required=false)]
        public long? SessionConcurrencyPerInstance { get; set; }

        [NameInMap("sessionIdleTimeoutInSeconds")]
        [Validation(Required=false)]
        public long? SessionIdleTimeoutInSeconds { get; set; }

        [NameInMap("sessionTTLInSeconds")]
        [Validation(Required=false)]
        public long? SessionTTLInSeconds { get; set; }

    }

}
