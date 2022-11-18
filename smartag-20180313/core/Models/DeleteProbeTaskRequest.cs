// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DeleteProbeTaskRequest : TeaModel {
        [NameInMap("ProbeTaskId")]
        [Validation(Required=false)]
        public string ProbeTaskId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SagId")]
        [Validation(Required=false)]
        public string SagId { get; set; }

        [NameInMap("Sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

    }

}
