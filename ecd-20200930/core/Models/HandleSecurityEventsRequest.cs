// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class HandleSecurityEventsRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        [NameInMap("OperationParams")]
        [Validation(Required=false)]
        public string OperationParams { get; set; }

        [NameInMap("SecurityEvent")]
        [Validation(Required=false)]
        public List<HandleSecurityEventsRequestSecurityEvent> SecurityEvent { get; set; }
        public class HandleSecurityEventsRequestSecurityEvent : TeaModel {
            [NameInMap("SecurityEventId")]
            [Validation(Required=false)]
            public string SecurityEventId { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

        }

    }

}
