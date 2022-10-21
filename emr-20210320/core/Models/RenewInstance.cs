// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class RenewInstance : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RenewDuration")]
        [Validation(Required=false)]
        public int? RenewDuration { get; set; }

        [NameInMap("RenewDurationUnit")]
        [Validation(Required=false)]
        public string RenewDurationUnit { get; set; }

    }

}
