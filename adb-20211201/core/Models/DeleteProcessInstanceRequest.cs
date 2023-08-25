// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DeleteProcessInstanceRequest : TeaModel {
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("ProcessInstanceId")]
        [Validation(Required=false)]
        public long? ProcessInstanceId { get; set; }

        [NameInMap("ProjectCode")]
        [Validation(Required=false)]
        public long? ProjectCode { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
