// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class SetWaitingRoomConfigRequest : TeaModel {
        [NameInMap("AllowPct")]
        [Validation(Required=false)]
        public int? AllowPct { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("GapTime")]
        [Validation(Required=false)]
        public int? GapTime { get; set; }

        [NameInMap("MaxTimeWait")]
        [Validation(Required=false)]
        public int? MaxTimeWait { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("WaitUri")]
        [Validation(Required=false)]
        public string WaitUri { get; set; }

        [NameInMap("WaitUrl")]
        [Validation(Required=false)]
        public string WaitUrl { get; set; }

    }

}
