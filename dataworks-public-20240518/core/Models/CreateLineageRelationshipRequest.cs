// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateLineageRelationshipRequest : TeaModel {
        [NameInMap("DstEntity")]
        [Validation(Required=false)]
        public LineageEntity DstEntity { get; set; }

        [NameInMap("SrcEntity")]
        [Validation(Required=false)]
        public LineageEntity SrcEntity { get; set; }

        [NameInMap("Task")]
        [Validation(Required=false)]
        public LineageTask Task { get; set; }

    }

}
