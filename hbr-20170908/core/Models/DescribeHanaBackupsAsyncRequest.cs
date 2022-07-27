// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeHanaBackupsAsyncRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("IncludeDifferential")]
        [Validation(Required=false)]
        public bool? IncludeDifferential { get; set; }

        [NameInMap("IncludeIncremental")]
        [Validation(Required=false)]
        public bool? IncludeIncremental { get; set; }

        [NameInMap("IncludeLog")]
        [Validation(Required=false)]
        public bool? IncludeLog { get; set; }

        [NameInMap("LogPosition")]
        [Validation(Required=false)]
        public long? LogPosition { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RecoveryPointInTime")]
        [Validation(Required=false)]
        public long? RecoveryPointInTime { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("SourceClusterId")]
        [Validation(Required=false)]
        public string SourceClusterId { get; set; }

        [NameInMap("SystemCopy")]
        [Validation(Required=false)]
        public bool? SystemCopy { get; set; }

        [NameInMap("UseBackint")]
        [Validation(Required=false)]
        public bool? UseBackint { get; set; }

        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

        [NameInMap("VolumeId")]
        [Validation(Required=false)]
        public int? VolumeId { get; set; }

    }

}
