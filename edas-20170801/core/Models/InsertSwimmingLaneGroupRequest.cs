// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertSwimmingLaneGroupRequest : TeaModel {
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("EntryApp")]
        [Validation(Required=false)]
        public string EntryApp { get; set; }

        [NameInMap("AppIds")]
        [Validation(Required=false)]
        public string AppIds { get; set; }

        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

    }

}
