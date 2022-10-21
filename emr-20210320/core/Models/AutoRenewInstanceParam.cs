// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class AutoRenewInstanceParam : TeaModel {
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public string AutoRenewDuration { get; set; }

        [NameInMap("AutoRenewDurationUnit")]
        [Validation(Required=false)]
        public string AutoRenewDurationUnit { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
