// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExportJobsOssRequest : TeaModel {
        [NameInMap("ExportType")]
        [Validation(Required=false)]
        public string ExportType { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("TopologyJobId")]
        [Validation(Required=false)]
        public long? TopologyJobId { get; set; }

    }

}
