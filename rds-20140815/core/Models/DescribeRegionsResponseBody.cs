// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the available regions and zones.
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeRegionsResponseBodyRegions Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            [NameInMap("RDSRegion")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyRegionsRDSRegion> RDSRegion { get; set; }
            public class DescribeRegionsResponseBodyRegionsRDSRegion : TeaModel {
                /// <summary>
                /// The name of the region. The return value of the LocalName parameter is in the language that is specified by the **AcceptLanguage** parameter. For example, if the value of the RegionId parameter in the response is cn-hangzhou, the following values are returned for the LocalName parameter:
                /// 
                /// *   If the value of the **AcceptLanguage** parameter is **zh-CN**, the value China (Hangzhou)  is returned for the LocalName parameter.
                /// *   If the value of the **AcceptLanguage** parameter is **en-US**, the value China (Hangzhou) is returned for the LocalName parameter.
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// The endpoint that is used to connect to Alibaba Cloud services in the region. For more information, see [Request structure](~~26223~~).
                /// </summary>
                [NameInMap("RegionEndpoint")]
                [Validation(Required=false)]
                public string RegionEndpoint { get; set; }

                /// <summary>
                /// The ID of the region.
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
                /// The name of the zone. The return value of the ZoneName parameter is in the language that is specified by the **AcceptLanguage** parameter. For example, if the value of the RegionId parameter in the response is cn-hangzhou-h, the following values are returned for the LocalName parameter:
                /// 
                /// *   If the value of the **AcceptLanguage** parameter is **zh-CN**, the value Hangzhou Zone H is returned for the LocalName parameter.
                /// *   If the value of the **AcceptLanguage** parameter is **en-US**, the value Hangzhou Zone H is returned for the LocalName parameter.
                /// </summary>
                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
