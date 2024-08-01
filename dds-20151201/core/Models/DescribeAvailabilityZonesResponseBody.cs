// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAvailabilityZonesResponseBody : TeaModel {
        /// <summary>
        /// The details of the zones in which you can create ApsaraDB for MongoDB instances.
        /// </summary>
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<DescribeAvailabilityZonesResponseBodyAvailableZones> AvailableZones { get; set; }
        public class DescribeAvailabilityZonesResponseBodyAvailableZones : TeaModel {
            /// <summary>
            /// The ID of the region. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/61933.html) operation to query the latest available regions.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the zone.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            /// <summary>
            /// The name of the zone.
            /// 
            /// The return value of the ZoneName parameter is in the language that is specified by the **AcceptLanguage** parameter. For example, if the value of the ZoneId parameter in the response is **cn-hangzhou-h**, the following values are returned for the ZoneName parameter:
            /// 
            /// *   If the value of the **AcceptLanguage** parameter is **zh**, **H** is returned for the ZoneName parameter.
            /// *   If the value of the **AcceptLanguage** parameter is **en**, **Hangzhou Zone H** is returned for the ZoneName parameter.
            /// </summary>
            [NameInMap("ZoneName")]
            [Validation(Required=false)]
            public string ZoneName { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
