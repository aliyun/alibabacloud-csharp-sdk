// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeMeshWorkloadVersionStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WorkloadVersions")]
        [Validation(Required=false)]
        public Dictionary<string, WorkloadVersionsValue> WorkloadVersions { get; set; }

    }

}
