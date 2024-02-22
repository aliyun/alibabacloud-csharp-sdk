// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DisconnectDesktopSessionsResponseBody : TeaModel {
        [NameInMap("InvalidSessions")]
        [Validation(Required=false)]
        public List<DisconnectDesktopSessionsResponseBodyInvalidSessions> InvalidSessions { get; set; }
        public class DisconnectDesktopSessionsResponseBodyInvalidSessions : TeaModel {
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
