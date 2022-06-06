// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeHardwareTerminalsRequest : TeaModel {
        [NameInMap("AppliedScope")]
        [Validation(Required=false)]
        public string AppliedScope { get; set; }

        [NameInMap("HardwareType")]
        [Validation(Required=false)]
        public string HardwareType { get; set; }

        [NameInMap("HardwareVersion")]
        [Validation(Required=false)]
        public string HardwareVersion { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
