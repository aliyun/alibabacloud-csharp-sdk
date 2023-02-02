// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantZonesReadResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The zone information of the tenant.
        /// </summary>
        [NameInMap("TenantZones")]
        [Validation(Required=false)]
        public List<DescribeTenantZonesReadResponseBodyTenantZones> TenantZones { get; set; }
        public class DescribeTenantZonesReadResponseBodyTenantZones : TeaModel {
            /// <summary>
            /// Indicates whether the zone can be set as the primary zone.
            /// </summary>
            [NameInMap("IsElectable")]
            [Validation(Required=false)]
            public bool? IsElectable { get; set; }

            /// <summary>
            /// Indicates whether the zone is the primary zone.
            /// </summary>
            [NameInMap("IsPrimary")]
            [Validation(Required=false)]
            public bool? IsPrimary { get; set; }

            /// <summary>
            /// Indicates whether a read-only connection has been created.
            /// </summary>
            [NameInMap("IsReadOnlyAddressMaster")]
            [Validation(Required=false)]
            public bool? IsReadOnlyAddressMaster { get; set; }

            /// <summary>
            /// Indicates whether a read-only connection needs to be created for the zone.
            /// </summary>
            [NameInMap("IsReadable")]
            [Validation(Required=false)]
            public string IsReadable { get; set; }

            /// <summary>
            /// The ID of the zone.
            /// </summary>
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

        }

    }

}
