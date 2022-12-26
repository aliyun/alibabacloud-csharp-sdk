// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCloudAssetDetailRequest : TeaModel {
        [NameInMap("AssetSubType")]
        [Validation(Required=false)]
        public int? AssetSubType { get; set; }

        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public int? AssetType { get; set; }

        [NameInMap("CloudAssetInstances")]
        [Validation(Required=false)]
        public List<GetCloudAssetDetailRequestCloudAssetInstances> CloudAssetInstances { get; set; }
        public class GetCloudAssetDetailRequestCloudAssetInstances : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public int? Vendor { get; set; }

    }

}
