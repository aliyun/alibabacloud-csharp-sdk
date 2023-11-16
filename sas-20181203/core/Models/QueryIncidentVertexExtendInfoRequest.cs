// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryIncidentVertexExtendInfoRequest : TeaModel {
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        [NameInMap("RelationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        [NameInMap("VertexId")]
        [Validation(Required=false)]
        public string VertexId { get; set; }

        [NameInMap("VertexLabel")]
        [Validation(Required=false)]
        public string VertexLabel { get; set; }

    }

}
