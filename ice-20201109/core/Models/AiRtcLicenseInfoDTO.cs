// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AiRtcLicenseInfoDTO : TeaModel {
        [NameInMap("AvailableCapacity")]
        [Validation(Required=false)]
        public long? AvailableCapacity { get; set; }

        [NameInMap("BeginOn")]
        [Validation(Required=false)]
        public string BeginOn { get; set; }

        [NameInMap("ContractNo")]
        [Validation(Required=false)]
        public string ContractNo { get; set; }

        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        [NameInMap("ExpiredOn")]
        [Validation(Required=false)]
        public string ExpiredOn { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("LicenseCount")]
        [Validation(Required=false)]
        public long? LicenseCount { get; set; }

        [NameInMap("LicenseItemId")]
        [Validation(Required=false)]
        public string LicenseItemId { get; set; }

        [NameInMap("ModificationTime")]
        [Validation(Required=false)]
        public string ModificationTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("ValidDays")]
        [Validation(Required=false)]
        public long? ValidDays { get; set; }

    }

}
