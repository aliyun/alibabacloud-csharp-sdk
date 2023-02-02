// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeZonesResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of zones.
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public List<DescribeZonesResponseBodyZones> Zones { get; set; }
        public class DescribeZonesResponseBodyZones : TeaModel {
            /// <summary>
            /// The deployment mode.
            /// </summary>
            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            /// <summary>
            /// The series of the OceanBase cluster. Valid values:   
            /// NORMAL: the high availability version. This is the default value.
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public string Series { get; set; }

            /// <summary>
            /// The list of zone IDs.   
            /// For a cluster with multiple zones, separate the zone names with commas (,).
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            /// <summary>
            /// The name of the zone.
            /// </summary>
            [NameInMap("ZoneName")]
            [Validation(Required=false)]
            public string ZoneName { get; set; }

        }

    }

}
