// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class StopMonitorRequest : TeaModel {
        [NameInMap("TaskId")]
        [Validation(Required=true)]
        public string TaskId { get; set; }

        [NameInMap("AlgorithmVendor")]
        [Validation(Required=true)]
        public string AlgorithmVendor { get; set; }

    }

}
