// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// - **2xx**: The call was successful.
        /// - **3xx**: The call was redirected.
        /// - **4xx**: The call failed.
        /// - **5xx**: A server error occurred.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// No request parameters are required.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeRegionsResponseBodyRegions Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyRegionsRegion> Region { get; set; }
            public class DescribeRegionsResponseBodyRegionsRegion : TeaModel {
                /// <summary>
                /// The list of regions.
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// The ID of the region. Valid values:
                /// 
                /// *   **cn-hangzhou**: the ID of the China (Hangzhou) region
                /// *   **cn-shanghai**: the ID of the China (Shanghai) region
                /// *   **cn-beijing**: the ID of the China (Beijing) region
                /// *   **cn-zhangjiakou**: the ID of the China (Zhangjiakou) region
                /// *   **cn-shenzhen**: the ID of the China (Shenzhen) region
                /// *   **cn-guangzhou**: the ID of the China (Guangzhou) region
                /// *   **cn-hongkong**: the ID of the China (Hong Kong) region
                /// *   **ap-southeast-1**: the ID of the Singapore region
                /// *   **us-west-1**: the ID of the US (Silicon Valley) region
                /// </summary>
                [NameInMap("RecommendZones")]
                [Validation(Required=false)]
                public DescribeRegionsResponseBodyRegionsRegionRecommendZones RecommendZones { get; set; }
                public class DescribeRegionsResponseBodyRegionsRegionRecommendZones : TeaModel {
                    [NameInMap("RecommendZone")]
                    [Validation(Required=false)]
                    public List<string> RecommendZone { get; set; }

                }

                /// <summary>
                /// The name of the region. Valid values:
                /// 
                /// *   **China (Hangzhou)**
                /// *   **China (Shanghai)**
                /// *   **China (Beijing)**
                /// *   **China (Zhangjiakou)**
                /// *   **China (Shenzhen)**
                /// *   **China (Guangzhou)**
                /// *   **China (Hong Kong)**
                /// *   **Singapore (Singapore)**
                /// *   **US (Silicon Valley)**
                /// </summary>
                [NameInMap("RegionEndpoint")]
                [Validation(Required=false)]
                public string RegionEndpoint { get; set; }

                /// <summary>
                /// The endpoint of the region. Valid values:
                /// 
                /// *   **sae.cn-hangzhou.aliyuncs.com**
                /// *   **sae.cn-shanghai.aliyuncs.com**
                /// *   **sae.cn-beijing.aliyuncs.com**
                /// *   **sae.cn-zhangjiakou.aliyuncs.com**
                /// *   **sae.cn-shenzhen.aliyuncs.com**
                /// *   **sae.cn-guangzhou.aliyuncs.com**
                /// *   **sae.cn-hongkong.aliyuncs.com**
                /// *   **sae.ap-southeast-1.aliyuncs.com**
                /// *   **sae.us-west-1.aliyuncs.com**
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// The returned information.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
