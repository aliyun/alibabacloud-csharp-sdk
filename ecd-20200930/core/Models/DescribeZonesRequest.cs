// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeZonesRequest : TeaModel {
        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The type of the zone. Default value: `AvailabilityZone`. This value indicates Alibaba Cloud zones.
        /// </summary>
        [NameInMap("ZoneType")]
        [Validation(Required=false)]
        public string ZoneType { get; set; }

    }

}
