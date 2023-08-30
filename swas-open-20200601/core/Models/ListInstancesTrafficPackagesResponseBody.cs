// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListInstancesTrafficPackagesResponseBody : TeaModel {
        /// <summary>
        /// The data transfers that exceed the quota of the data transfer plan in the current month. Unit: bytes.
        /// </summary>
        [NameInMap("InstanceTrafficPackageUsages")]
        [Validation(Required=false)]
        public List<ListInstancesTrafficPackagesResponseBodyInstanceTrafficPackageUsages> InstanceTrafficPackageUsages { get; set; }
        public class ListInstancesTrafficPackagesResponseBodyInstanceTrafficPackageUsages : TeaModel {
            /// <summary>
            /// The ID of the simple application server.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The data transfers that exceeds the quota of the data transfer plan in the current month. Unit: Byte.
            /// </summary>
            [NameInMap("TrafficOverflow")]
            [Validation(Required=false)]
            public long? TrafficOverflow { get; set; }

            /// <summary>
            /// The unused quota of the data transfer plan in the current month. Unit: Byte.
            /// </summary>
            [NameInMap("TrafficPackageRemaining")]
            [Validation(Required=false)]
            public long? TrafficPackageRemaining { get; set; }

            /// <summary>
            /// The quota of the data transfer plan in the current month. Unit: Byte.
            /// 
            /// >  TrafficPackageTotal = TrafficUsed + TrafficPackageRemaining
            /// </summary>
            [NameInMap("TrafficPackageTotal")]
            [Validation(Required=false)]
            public long? TrafficPackageTotal { get; set; }

            /// <summary>
            /// The used quota of the data transfer plan in the current month. Unit: Byte.
            /// </summary>
            [NameInMap("TrafficUsed")]
            [Validation(Required=false)]
            public long? TrafficUsed { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
