// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class Snapshot : TeaModel {
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("CreationType")]
        [Validation(Required=false)]
        public string CreationType { get; set; }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        [NameInMap("SnapshotName")]
        [Validation(Required=false)]
        public string SnapshotName { get; set; }

        [NameInMap("SnapshotResourceId")]
        [Validation(Required=false)]
        public string SnapshotResourceId { get; set; }

        [NameInMap("SnapshotResourceType")]
        [Validation(Required=false)]
        public string SnapshotResourceType { get; set; }

        [NameInMap("SnapshotStoragePath")]
        [Validation(Required=false)]
        public string SnapshotStoragePath { get; set; }

        [NameInMap("SnapshotUrl")]
        [Validation(Required=false)]
        public string SnapshotUrl { get; set; }

        [NameInMap("WorkDir")]
        [Validation(Required=false)]
        public string WorkDir { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
