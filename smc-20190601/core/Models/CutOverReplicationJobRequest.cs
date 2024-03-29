// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class CutOverReplicationJobRequest : TeaModel {
        /// <summary>
        /// The ID of the incremental migration job.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// Specifies whether to migrate full data for the last time. Valid Values:
        /// 
        /// *   true: migrates full data for the last time.
        /// *   false: does not migrate full data for the last time.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("SyncData")]
        [Validation(Required=false)]
        public bool? SyncData { get; set; }

    }

}
