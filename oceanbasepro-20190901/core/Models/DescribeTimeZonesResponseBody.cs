// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTimeZonesResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The time zones supported by the tenant.
        /// </summary>
        [NameInMap("TimeZones")]
        [Validation(Required=false)]
        public DescribeTimeZonesResponseBodyTimeZones TimeZones { get; set; }
        public class DescribeTimeZonesResponseBodyTimeZones : TeaModel {
            /// <summary>
            /// The default time zone.
            /// </summary>
            [NameInMap("Default")]
            [Validation(Required=false)]
            public string Default { get; set; }

            /// <summary>
            /// The list of time zones.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeTimeZonesResponseBodyTimeZonesList> List { get; set; }
            public class DescribeTimeZonesResponseBodyTimeZonesList : TeaModel {
                /// <summary>
                /// The description of the time zone.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the time zone.
                /// </summary>
                [NameInMap("TimeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

            }

        }

    }

}
