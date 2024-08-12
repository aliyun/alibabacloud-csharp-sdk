// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class SetDeviceOtaAutoStatusRequest : TeaModel {
        [NameInMap("AutoUpdate")]
        [Validation(Required=false)]
        public int? AutoUpdate { get; set; }

        [NameInMap("AutoUpdateTimeSchedule")]
        [Validation(Required=false)]
        public string AutoUpdateTimeSchedule { get; set; }

        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public int? ClientType { get; set; }

        [NameInMap("ForceUpgrade")]
        [Validation(Required=false)]
        public int? ForceUpgrade { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
