// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListMaterializedViewResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of materialized views returned on the current page.</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>A list of materialized views.</para>
        /// </summary>
        [NameInMap("materializedViews")]
        [Validation(Required=false)]
        public List<string> MaterializedViews { get; set; }

        /// <summary>
        /// <para>The total number of materialized views that match the query.</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
