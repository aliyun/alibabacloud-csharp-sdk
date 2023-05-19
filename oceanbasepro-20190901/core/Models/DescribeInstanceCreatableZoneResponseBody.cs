// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstanceCreatableZoneResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the cluster is deployed in the zone.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The operation that you want to perform.   
        /// Set the value to **DescribeInstanceCreatableZone**.
        /// </summary>
        [NameInMap("ZoneList")]
        [Validation(Required=false)]
        public List<DescribeInstanceCreatableZoneResponseBodyZoneList> ZoneList { get; set; }
        public class DescribeInstanceCreatableZoneResponseBodyZoneList : TeaModel {
            [NameInMap("IsInCluster")]
            [Validation(Required=false)]
            public bool? IsInCluster { get; set; }

            /// <summary>
            /// DescribeInstanceCreatableZone
            /// </summary>
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

        }

    }

}
