// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20180528.Models
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
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                [NameInMap("CurrCapacity")]
                [Validation(Required=false)]
                public string CurrCapacity { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("InitCapacity")]
                [Validation(Required=false)]
                public string InitCapacity { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

    }

}
