// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCloudAssetSummaryRequest : TeaModel {
        [NameInMap("CloudAssetTypes")]
        [Validation(Required=false)]
        public List<GetCloudAssetSummaryRequestCloudAssetTypes> CloudAssetTypes { get; set; }
        public class GetCloudAssetSummaryRequestCloudAssetTypes : TeaModel {
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public int? AssetSubType { get; set; }

            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        /// <summary>
        /// <para>The asset type by service provider.</para>
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<int?> Vendors { get; set; }

    }

}
