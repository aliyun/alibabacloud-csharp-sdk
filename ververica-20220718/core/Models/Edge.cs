// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Edge : TeaModel {
        /// <summary>
        /// <para>The field-level data lineage.</para>
        /// </summary>
        [NameInMap("columnLineage")]
        [Validation(Required=false)]
        public List<Relation> ColumnLineage { get; set; }

        /// <summary>
        /// <para>The table-level data lineage.</para>
        /// </summary>
        [NameInMap("tableLineage")]
        [Validation(Required=false)]
        public List<Relation> TableLineage { get; set; }

    }

}
