// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateAgentlessScanTaskRequest : TeaModel {
        [NameInMap("AutoDeleteDays")]
        [Validation(Required=false)]
        public int? AutoDeleteDays { get; set; }

        [NameInMap("ReleaseAfterScan")]
        [Validation(Required=false)]
        public bool? ReleaseAfterScan { get; set; }

        [NameInMap("ScanDataDisk")]
        [Validation(Required=false)]
        public bool? ScanDataDisk { get; set; }

        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public int? TargetType { get; set; }

        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
