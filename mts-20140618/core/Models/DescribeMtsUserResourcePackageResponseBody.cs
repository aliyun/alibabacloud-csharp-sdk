// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class DescribeMtsUserResourcePackageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourcePackageInfos")]
        [Validation(Required=false)]
        public DescribeMtsUserResourcePackageResponseBodyResourcePackageInfos ResourcePackageInfos { get; set; }
        public class DescribeMtsUserResourcePackageResponseBodyResourcePackageInfos : TeaModel {
            [NameInMap("ResourcePackageInfo")]
            [Validation(Required=false)]
            public List<DescribeMtsUserResourcePackageResponseBodyResourcePackageInfosResourcePackageInfo> ResourcePackageInfo { get; set; }
            public class DescribeMtsUserResourcePackageResponseBodyResourcePackageInfosResourcePackageInfo : TeaModel {
                public string DisplayName { get; set; }
                public string Status { get; set; }
                public string CommodityCode { get; set; }
                public string CurrCapacity { get; set; }
                public string InitCapacity { get; set; }
                public string InstanceId { get; set; }
            }
        };

    }

}
