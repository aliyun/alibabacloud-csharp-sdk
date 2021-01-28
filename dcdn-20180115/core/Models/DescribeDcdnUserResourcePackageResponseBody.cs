// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserResourcePackageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourcePackageInfos")]
        [Validation(Required=false)]
        public DescribeDcdnUserResourcePackageResponseBodyResourcePackageInfos ResourcePackageInfos { get; set; }
        public class DescribeDcdnUserResourcePackageResponseBodyResourcePackageInfos : TeaModel {
            [NameInMap("ResourcePackageInfo")]
            [Validation(Required=false)]
            public List<DescribeDcdnUserResourcePackageResponseBodyResourcePackageInfosResourcePackageInfo> ResourcePackageInfo { get; set; }
            public class DescribeDcdnUserResourcePackageResponseBodyResourcePackageInfosResourcePackageInfo : TeaModel {
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
