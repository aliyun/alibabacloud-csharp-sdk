// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateHanaRestoreRequest : TeaModel {
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public long? BackupId { get; set; }

        [NameInMap("BackupPrefix")]
        [Validation(Required=false)]
        public string BackupPrefix { get; set; }

        [NameInMap("CheckAccess")]
        [Validation(Required=false)]
        public bool? CheckAccess { get; set; }

        [NameInMap("ClearLog")]
        [Validation(Required=false)]
        public bool? ClearLog { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("LogPosition")]
        [Validation(Required=false)]
        public long? LogPosition { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("RecoveryPointInTime")]
        [Validation(Required=false)]
        public long? RecoveryPointInTime { get; set; }

        [NameInMap("SidAdmin")]
        [Validation(Required=false)]
        public string SidAdmin { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("SourceClusterId")]
        [Validation(Required=false)]
        public string SourceClusterId { get; set; }

        [NameInMap("SystemCopy")]
        [Validation(Required=false)]
        public bool? SystemCopy { get; set; }

        [NameInMap("UseCatalog")]
        [Validation(Required=false)]
        public bool? UseCatalog { get; set; }

        [NameInMap("UseDelta")]
        [Validation(Required=false)]
        public bool? UseDelta { get; set; }

        [NameInMap("VolumeId")]
        [Validation(Required=false)]
        public int? VolumeId { get; set; }

    }

}
