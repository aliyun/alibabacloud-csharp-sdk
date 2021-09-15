// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateRestoreJobRequest : TeaModel {
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        [NameInMap("SnapshotHash")]
        [Validation(Required=false)]
        public string SnapshotHash { get; set; }

        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

        [NameInMap("SnapshotVersion")]
        [Validation(Required=false)]
        public string SnapshotVersion { get; set; }

        [NameInMap("Includes")]
        [Validation(Required=false)]
        public string Includes { get; set; }

    }

}
