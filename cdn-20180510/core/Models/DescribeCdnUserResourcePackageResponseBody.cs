// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserResourcePackageResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84839536-2B7E-457D-9D8C-82E6C7D4E1A3</para>
        /// </summary>
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
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                [NameInMap("CurrCapacity")]
                [Validation(Required=false)]
                public string CurrCapacity { get; set; }

                [NameInMap("CurrCapacityBaseUnit")]
                [Validation(Required=false)]
                public string CurrCapacityBaseUnit { get; set; }

                [NameInMap("CurrCapacityShowUnit")]
                [Validation(Required=false)]
                public string CurrCapacityShowUnit { get; set; }

                [NameInMap("CurrCapacityShowValue")]
                [Validation(Required=false)]
                public string CurrCapacityShowValue { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("InitCapacity")]
                [Validation(Required=false)]
                public string InitCapacity { get; set; }

                [NameInMap("InitCapacityBaseUnit")]
                [Validation(Required=false)]
                public string InitCapacityBaseUnit { get; set; }

                [NameInMap("InitCapacityShowUnit")]
                [Validation(Required=false)]
                public string InitCapacityShowUnit { get; set; }

                [NameInMap("InitCapacityShowValue")]
                [Validation(Required=false)]
                public string InitCapacityShowValue { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

        }

    }

}
