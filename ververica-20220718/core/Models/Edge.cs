// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Edge : TeaModel {
        [NameInMap("columnLineage")]
        [Validation(Required=false)]
        public List<Relation> ColumnLineage { get; set; }

        [NameInMap("tableLineage")]
        [Validation(Required=false)]
        public List<Relation> TableLineage { get; set; }

    }

}
