// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateSwimmingLaneRequest : TeaModel {
        [NameInMap("LaneId")]
        [Validation(Required=false)]
        public long? LaneId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("EnableRules")]
        [Validation(Required=false)]
        public bool? EnableRules { get; set; }

        [NameInMap("AppInfos")]
        [Validation(Required=false)]
        public string AppInfos { get; set; }

        [NameInMap("EntryRules")]
        [Validation(Required=false)]
        public string EntryRules { get; set; }

    }

}
