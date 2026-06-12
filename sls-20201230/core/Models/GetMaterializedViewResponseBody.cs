// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetMaterializedViewResponseBody : TeaModel {
        /// <summary>
        /// <para>The time interval for data aggregation, in minutes.</para>
        /// </summary>
        [NameInMap("aggIntervalMins")]
        [Validation(Required=false)]
        public int? AggIntervalMins { get; set; }

        /// <summary>
        /// <para>Specifies whether the materialized view is active. Valid values are <c>true</c> and <c>false</c>.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The destination logstore that stores the aggregated data.</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The name of the materialized view.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The SQL query that defines the materialized view.</para>
        /// </summary>
        [NameInMap("originalSql")]
        [Validation(Required=false)]
        public string OriginalSql { get; set; }

        /// <summary>
        /// <para>The time when the materialized view was created. The value is a Unix timestamp.</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        /// <summary>
        /// <para>The time to live (ttl) of the data in the destination logstore, in days.</para>
        /// </summary>
        [NameInMap("ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
