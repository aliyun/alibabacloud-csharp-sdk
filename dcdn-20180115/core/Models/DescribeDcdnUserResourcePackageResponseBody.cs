// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserResourcePackageResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The detailed information about resource plans. The returned information is displayed in the format that is specified by the ResourcePackageInfo parameter.
        /// </summary>
        [NameInMap("ResourcePackageInfos")]
        [Validation(Required=false)]
        public DescribeDcdnUserResourcePackageResponseBodyResourcePackageInfos ResourcePackageInfos { get; set; }
        public class DescribeDcdnUserResourcePackageResponseBodyResourcePackageInfos : TeaModel {
            [NameInMap("ResourcePackageInfo")]
            [Validation(Required=false)]
            public List<DescribeDcdnUserResourcePackageResponseBodyResourcePackageInfosResourcePackageInfo> ResourcePackageInfo { get; set; }
            public class DescribeDcdnUserResourcePackageResponseBodyResourcePackageInfosResourcePackageInfo : TeaModel {
                /// <summary>
                /// The commodity code of the resource plan.
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// The remaining quota of the resource plan.
                /// 
                /// *   The unit for traffic: bytes.
                /// *   The unit for requests: count.
                /// </summary>
                [NameInMap("CurrCapacity")]
                [Validation(Required=false)]
                public string CurrCapacity { get; set; }

                /// <summary>
                /// The name of the resource plan.
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// The expiration time. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The total quota of the resource plan.
                /// 
                /// *   The unit for traffic: bytes.
                /// *   The unit for requests: count.
                /// </summary>
                [NameInMap("InitCapacity")]
                [Validation(Required=false)]
                public string InitCapacity { get; set; }

                /// <summary>
                /// The ID of the resource plan.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The validation time. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The status of the resource plan. Valid values:
                /// 
                /// *   **valid**: valid
                /// *   **closed**: expired
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The name of the template.
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

        }

    }

}
