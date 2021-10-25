// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDiagnosisSQLInfoRequest : TeaModel {
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ProcessId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        [NameInMap("ProcessStartTime")]
        [Validation(Required=false)]
        public long? ProcessStartTime { get; set; }

        [NameInMap("ProcessState")]
        [Validation(Required=false)]
        public string ProcessState { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("ProcessRcHost")]
        [Validation(Required=false)]
        public string ProcessRcHost { get; set; }

    }

}
