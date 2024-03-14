// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcZoneResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The zones.
        /// </summary>
        [NameInMap("ZoneList")]
        [Validation(Required=false)]
        public List<DescribeVpcZoneResponseBodyZoneList> ZoneList { get; set; }
        public class DescribeVpcZoneResponseBodyZoneList : TeaModel {
            /// <summary>
            /// The name of the zone.
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// The zone ID.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            /// <summary>
            /// The zone type. Default value: AvailabilityZone. This value indicates Alibaba Cloud zones.
            /// </summary>
            [NameInMap("ZoneType")]
            [Validation(Required=false)]
            public string ZoneType { get; set; }

        }

    }

}
