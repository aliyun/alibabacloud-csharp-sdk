// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTimeZonesResponseBody : TeaModel {
        /// <summary>
        /// DescribeTimeZones
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The description of the time zone.
        /// </summary>
        [NameInMap("TimeZones")]
        [Validation(Required=false)]
        public DescribeTimeZonesResponseBodyTimeZones TimeZones { get; set; }
        public class DescribeTimeZonesResponseBodyTimeZones : TeaModel {
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
                /// Example 1
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The operation that you want to perform.   
                /// Set the value to **DescribeTimeZones**.
                /// </summary>
                [NameInMap("TimeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

            }

        }

    }

}
