// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateMaterializedViewRequest : TeaModel {
        /// <summary>
        /// <para>The refresh interval of the materialized view, in minutes.</para>
        /// </summary>
        [NameInMap("aggIntervalMins")]
        [Validation(Required=false)]
        public int? AggIntervalMins { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically refresh the materialized view.</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The new SQL query for the materialized view. Updating the query rebuilds the view.</para>
        /// </summary>
        [NameInMap("originalSql")]
        [Validation(Required=false)]
        public string OriginalSql { get; set; }

        /// <summary>
        /// <para>The data retention period (TTL) of the materialized view, in days.</para>
        /// </summary>
        [NameInMap("ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
