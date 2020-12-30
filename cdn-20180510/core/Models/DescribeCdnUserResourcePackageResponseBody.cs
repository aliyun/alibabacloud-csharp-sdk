// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserResourcePackageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourcePackageInfos")]
        [Validation(Required=false)]
        public DescribeCdnUserResourcePackageResponseBodyResourcePackageInfos ResourcePackageInfos { get; set; }
        public class DescribeCdnUserResourcePackageResponseBodyResourcePackageInfos : TeaModel {
            [NameInMap("ResourcePackageInfo")]
            [Validation(Required=false)]
            public List<DescribeCdnUserResourcePackageResponseBodyResourcePackageInfosResourcePackageInfo> ResourcePackageInfo { get; set; }
            public class DescribeCdnUserResourcePackageResponseBodyResourcePackageInfosResourcePackageInfo : TeaModel {
                public string EndTime { get; set; }
                public string Status { get; set; }
                public string DisplayName { get; set; }
                public string StartTime { get; set; }
                public string CommodityCode { get; set; }
                public string CurrCapacity { get; set; }
                public string InitCapacity { get; set; }
                public string InstanceId { get; set; }
                public string TemplateName { get; set; }
            }
        };

    }

}
