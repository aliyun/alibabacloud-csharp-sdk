// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsUserResourcePackageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourcePackageInfos")]
        [Validation(Required=false)]
        public DescribeVsUserResourcePackageResponseBodyResourcePackageInfos ResourcePackageInfos { get; set; }
        public class DescribeVsUserResourcePackageResponseBodyResourcePackageInfos : TeaModel {
            [NameInMap("ResourcePackageInfo")]
            [Validation(Required=false)]
            public List<DescribeVsUserResourcePackageResponseBodyResourcePackageInfosResourcePackageInfo> ResourcePackageInfo { get; set; }
            public class DescribeVsUserResourcePackageResponseBodyResourcePackageInfosResourcePackageInfo : TeaModel {
                public string CommodityCode { get; set; }
                public string CurrCapacity { get; set; }
                public string DisplayName { get; set; }
                public string InitCapacity { get; set; }
                public string InstanceId { get; set; }
                public string Status { get; set; }
            }
        };

    }

}
