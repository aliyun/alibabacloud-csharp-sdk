// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeMaterialPackageInfoResponseBody : TeaModel {
        [NameInMap("MaterialPackageInfoList")]
        [Validation(Required=false)]
        public List<DescribeMaterialPackageInfoResponseBodyMaterialPackageInfoList> MaterialPackageInfoList { get; set; }
        public class DescribeMaterialPackageInfoResponseBodyMaterialPackageInfoList : TeaModel {
            [NameInMap("AuthTime")]
            [Validation(Required=false)]
            public string AuthTime { get; set; }

            [NameInMap("Authorized")]
            [Validation(Required=false)]
            public bool? Authorized { get; set; }

            [NameInMap("DisplayPrice")]
            [Validation(Required=false)]
            public string DisplayPrice { get; set; }

            [NameInMap("InitCapacity")]
            [Validation(Required=false)]
            public string InitCapacity { get; set; }

            [NameInMap("MaterialCount")]
            [Validation(Required=false)]
            public int? MaterialCount { get; set; }

            [NameInMap("MaterialPackageId")]
            [Validation(Required=false)]
            public string MaterialPackageId { get; set; }

            [NameInMap("MaterialPackagePurchaseList")]
            [Validation(Required=false)]
            public List<DescribeMaterialPackageInfoResponseBodyMaterialPackageInfoListMaterialPackagePurchaseList> MaterialPackagePurchaseList { get; set; }
            public class DescribeMaterialPackageInfoResponseBodyMaterialPackageInfoListMaterialPackagePurchaseList : TeaModel {
                [NameInMap("CurrCapacity")]
                [Validation(Required=false)]
                public string CurrCapacity { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("InitCapacity")]
                [Validation(Required=false)]
                public string InitCapacity { get; set; }

                [NameInMap("RemainingAuthTime")]
                [Validation(Required=false)]
                public string RemainingAuthTime { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
