// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCloudAssetSummaryResponseBody : TeaModel {
        [NameInMap("GroupedFields")]
        [Validation(Required=false)]
        public GetCloudAssetSummaryResponseBodyGroupedFields GroupedFields { get; set; }
        public class GetCloudAssetSummaryResponseBodyGroupedFields : TeaModel {
            [NameInMap("CloudAssetSummaryMetas")]
            [Validation(Required=false)]
            public List<GetCloudAssetSummaryResponseBodyGroupedFieldsCloudAssetSummaryMetas> CloudAssetSummaryMetas { get; set; }
            public class GetCloudAssetSummaryResponseBodyGroupedFieldsCloudAssetSummaryMetas : TeaModel {
                [NameInMap("AssetSubType")]
                [Validation(Required=false)]
                public int? AssetSubType { get; set; }

                [NameInMap("AssetType")]
                [Validation(Required=false)]
                public int? AssetType { get; set; }

                [NameInMap("InstanceCount")]
                [Validation(Required=false)]
                public int? InstanceCount { get; set; }

                [NameInMap("InstanceRiskCount")]
                [Validation(Required=false)]
                public int? InstanceRiskCount { get; set; }

            }

            [NameInMap("InstanceCountTotal")]
            [Validation(Required=false)]
            public int? InstanceCountTotal { get; set; }

            [NameInMap("InstanceRiskCountTotal")]
            [Validation(Required=false)]
            public int? InstanceRiskCountTotal { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
