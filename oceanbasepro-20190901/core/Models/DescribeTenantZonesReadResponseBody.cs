// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantZonesReadResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether a read-only connection needs to be created for the zone.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("TenantZones")]
        [Validation(Required=false)]
        public List<DescribeTenantZonesReadResponseBodyTenantZones> TenantZones { get; set; }
        public class DescribeTenantZonesReadResponseBodyTenantZones : TeaModel {
            /// <summary>
            /// Example 1
            /// </summary>
            [NameInMap("IsElectable")]
            [Validation(Required=false)]
            public bool? IsElectable { get; set; }

            [NameInMap("IsPrimary")]
            [Validation(Required=false)]
            public bool? IsPrimary { get; set; }

            [NameInMap("IsReadOnlyAddressMaster")]
            [Validation(Required=false)]
            public bool? IsReadOnlyAddressMaster { get; set; }

            [NameInMap("IsReadable")]
            [Validation(Required=false)]
            public string IsReadable { get; set; }

            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

        }

    }

}
