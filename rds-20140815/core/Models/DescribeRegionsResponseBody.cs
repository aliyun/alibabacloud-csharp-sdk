// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// The available regions and zones.
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
                /// The region name. The return value of this parameter is in the language that is specified by the **AcceptLanguage** parameter. For example, if the value of the RegionId parameter in the response is cn-hangzhou, the following values are returned for the LocalName parameter:
                /// 
                /// *   If the value of the **AcceptLanguage** parameter is **zh-CN**, the value `华东1（杭州）` is returned for the LocalName parameter.
                /// *   If the value of the **AcceptLanguage** parameter is **en-US**, the value China (Hangzhou) is returned for the LocalName parameter.
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// The endpoint that is used to connect to Alibaba Cloud services in the region. For more information, see [Endpoints](https://help.aliyun.com/document_detail/610370.html).
                /// </summary>
                [NameInMap("RegionEndpoint")]
                [Validation(Required=false)]
                public string RegionEndpoint { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The zone ID.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// The zone name. The return value of this parameter is in the language that is specified by the **AcceptLanguage** parameter. For example, if the value of the ZoneId parameter in the response is cn-hangzhou-h, the following values are returned for the ZoneName parameter:
                /// 
                /// *   If the value of the **AcceptLanguage** parameter is **zh-CN**, the `杭州 可用区 H` is returned for the ZoneName parameter.
                /// *   If the value of the **AcceptLanguage** parameter is **en-US**, the value Hangzhou Zone H is returned for the ZoneName parameter.
                /// </summary>
                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
