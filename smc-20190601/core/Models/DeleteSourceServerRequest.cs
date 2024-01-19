// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class DeleteSourceServerRequest : TeaModel {
        /// <summary>
        /// Specifies whether to forcibly delete the migration source. Valid values:
        /// 
        /// *   true: forcibly deletes the migration source and the migration job created for the migration source, and releases the intermediate resources of the migration job.
        /// *   false: does not delete the migration source if a migration job is created for the migration source.
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The migration source ID.
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

    }

}
