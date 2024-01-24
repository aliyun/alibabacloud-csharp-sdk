// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeBackupDbsRequest : TeaModel {
        /// <summary>
        /// Query by backup set ID
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// The ID of a DRDS instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// Query by restoration time.
        /// </summary>
        [NameInMap("PreferredRestoreTime")]
        [Validation(Required=false)]
        public string PreferredRestoreTime { get; set; }

    }

}
