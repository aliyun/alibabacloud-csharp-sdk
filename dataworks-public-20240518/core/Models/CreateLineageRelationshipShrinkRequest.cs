// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateLineageRelationshipShrinkRequest : TeaModel {
        [NameInMap("DstEntity")]
        [Validation(Required=false)]
        public string DstEntityShrink { get; set; }

        [NameInMap("SrcEntity")]
        [Validation(Required=false)]
        public string SrcEntityShrink { get; set; }

        [NameInMap("Task")]
        [Validation(Required=false)]
        public string TaskShrink { get; set; }

    }

}
