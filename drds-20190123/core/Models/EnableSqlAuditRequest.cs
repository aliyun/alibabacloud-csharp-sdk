// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class EnableSqlAuditRequest : TeaModel {
        /// <summary>
        /// The name of the database for which you want to enable the SQL audit feature.
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// The ID of the PolarDB-X 1.0 instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// Specifies whether to backtrack historical SQL statements for auditing.
        /// </summary>
        [NameInMap("IsRecall")]
        [Validation(Required=false)]
        public bool? IsRecall { get; set; }

        /// <summary>
        /// The timestamp that indicates when the backtracking ends. Unit: milliseconds.
        /// 
        /// > The end time of the backtracking must be later than the start time of the backtracking.
        /// </summary>
        [NameInMap("RecallEndTimestamp")]
        [Validation(Required=false)]
        public string RecallEndTimestamp { get; set; }

        /// <summary>
        /// The timestamp that indicates when the backtracking starts. Unit: milliseconds.
        /// </summary>
        [NameInMap("RecallStartTimestamp")]
        [Validation(Required=false)]
        public string RecallStartTimestamp { get; set; }

    }

}
