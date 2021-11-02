// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class HandleSecurityEventsResponseBody : TeaModel {
        [NameInMap("HandleSecurityEventsResponse")]
        [Validation(Required=false)]
        public HandleSecurityEventsResponseBodyHandleSecurityEventsResponse HandleSecurityEventsResponse { get; set; }
        public class HandleSecurityEventsResponseBodyHandleSecurityEventsResponse : TeaModel {
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
