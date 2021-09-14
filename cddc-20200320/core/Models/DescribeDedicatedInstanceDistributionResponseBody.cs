// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeDedicatedInstanceDistributionResponseBody : TeaModel {
        [NameInMap("DBClass")]
        [Validation(Required=false)]
        public Dictionary<string, object> DBClass { get; set; }

        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public Dictionary<string, object> DBVersion { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public int? InstanceCount { get; set; }

        [NameInMap("DBType")]
        [Validation(Required=false)]
        public Dictionary<string, object> DBType { get; set; }

        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

    }

}
