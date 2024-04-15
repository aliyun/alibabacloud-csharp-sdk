// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopOversoldGroupRequest : TeaModel {
        [NameInMap("ConcurrenceCount")]
        [Validation(Required=false)]
        public int? ConcurrenceCount { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("IdleDisconnectDuration")]
        [Validation(Required=false)]
        public long? IdleDisconnectDuration { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("KeepDuration")]
        [Validation(Required=false)]
        public int? KeepDuration { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OversoldGroupId")]
        [Validation(Required=false)]
        public string OversoldGroupId { get; set; }

        [NameInMap("OversoldUserCount")]
        [Validation(Required=false)]
        public int? OversoldUserCount { get; set; }

        [NameInMap("OversoldWarn")]
        [Validation(Required=false)]
        public int? OversoldWarn { get; set; }

        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        [NameInMap("StopDuration")]
        [Validation(Required=false)]
        public int? StopDuration { get; set; }

    }

}
