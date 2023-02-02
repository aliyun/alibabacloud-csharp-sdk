// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstanceCreatableZoneResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of zones.
        /// </summary>
        [NameInMap("ZoneList")]
        [Validation(Required=false)]
        public List<DescribeInstanceCreatableZoneResponseBodyZoneList> ZoneList { get; set; }
        public class DescribeInstanceCreatableZoneResponseBodyZoneList : TeaModel {
            /// <summary>
            /// Indicates whether the cluster is deployed in the zone.
            /// </summary>
            [NameInMap("IsInCluster")]
            [Validation(Required=false)]
            public bool? IsInCluster { get; set; }

            /// <summary>
            /// The ID of the zone.
            /// </summary>
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

        }

    }

}
