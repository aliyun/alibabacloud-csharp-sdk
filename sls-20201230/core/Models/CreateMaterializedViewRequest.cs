// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateMaterializedViewRequest : TeaModel {
        /// <summary>
        /// <para>The aggregation interval in minutes. The system creates aggregation tasks based on this interval.</para>
        /// </summary>
        [NameInMap("aggIntervalMins")]
        [Validation(Required=false)]
        public int? AggIntervalMins { get; set; }

        /// <summary>
        /// <para>The destination Logstore for the aggregated data from the materialized view.</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The name of the materialized view. The name must be unique within the project, 2 to 63 characters long, and contain only lowercase letters, digits, hyphens (-), and underscores (_). It must also start and end with a lowercase letter or a digit.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The query statement that defines the materialized view.</para>
        /// </summary>
        [NameInMap("originalSql")]
        [Validation(Required=false)]
        public string OriginalSql { get; set; }

        /// <summary>
        /// <para>The time when the materialized view starts to aggregate data. Specify the time as a UNIX timestamp in seconds.</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        /// <summary>
        /// <para>The time-to-live (TTL) of the data in the materialized view, in days. After this period, the data expires and is automatically deleted.</para>
        /// </summary>
        [NameInMap("ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
