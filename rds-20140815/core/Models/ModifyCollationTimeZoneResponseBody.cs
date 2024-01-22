// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyCollationTimeZoneResponseBody : TeaModel {
        /// <summary>
        /// The character set collation of the instance.
        /// </summary>
        [NameInMap("Collation")]
        [Validation(Required=false)]
        public string Collation { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The task ID.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The time zone.
        /// </summary>
        [NameInMap("Timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

    }

}
