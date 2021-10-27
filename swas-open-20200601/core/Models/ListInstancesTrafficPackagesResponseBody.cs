// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListInstancesTrafficPackagesResponseBody : TeaModel {
        [NameInMap("InstanceTrafficPackageUsages")]
        [Validation(Required=false)]
        public List<ListInstancesTrafficPackagesResponseBodyInstanceTrafficPackageUsages> InstanceTrafficPackageUsages { get; set; }
        public class ListInstancesTrafficPackagesResponseBodyInstanceTrafficPackageUsages : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("TrafficOverflow")]
            [Validation(Required=false)]
            public long? TrafficOverflow { get; set; }

            [NameInMap("TrafficPackageRemaining")]
            [Validation(Required=false)]
            public long? TrafficPackageRemaining { get; set; }

            [NameInMap("TrafficPackageTotal")]
            [Validation(Required=false)]
            public long? TrafficPackageTotal { get; set; }

            [NameInMap("TrafficUsed")]
            [Validation(Required=false)]
            public long? TrafficUsed { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
