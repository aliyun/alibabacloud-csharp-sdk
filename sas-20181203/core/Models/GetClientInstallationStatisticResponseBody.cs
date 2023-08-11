// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClientInstallationStatisticResponseBody : TeaModel {
        [NameInMap("ClientInstallRatio")]
        [Validation(Required=false)]
        public GetClientInstallationStatisticResponseBodyClientInstallRatio ClientInstallRatio { get; set; }
        public class GetClientInstallationStatisticResponseBodyClientInstallRatio : TeaModel {
            [NameInMap("CurrentItems")]
            [Validation(Required=false)]
            public List<GetClientInstallationStatisticResponseBodyClientInstallRatioCurrentItems> CurrentItems { get; set; }
            public class GetClientInstallationStatisticResponseBodyClientInstallRatioCurrentItems : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetClientInstallationStatisticResponseBodyClientInstallRatioCurrentItemsItems> Items { get; set; }
                public class GetClientInstallationStatisticResponseBodyClientInstallRatioCurrentItemsItems : TeaModel {
                    [NameInMap("AssetTotalCount")]
                    [Validation(Required=false)]
                    public int? AssetTotalCount { get; set; }

                    [NameInMap("CalculateTime")]
                    [Validation(Required=false)]
                    public long? CalculateTime { get; set; }

                    [NameInMap("InstallRatio")]
                    [Validation(Required=false)]
                    public double? InstallRatio { get; set; }

                    [NameInMap("InstalledAssetCount")]
                    [Validation(Required=false)]
                    public int? InstalledAssetCount { get; set; }

                }

                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public long? Vendor { get; set; }

            }

            [NameInMap("Dates")]
            [Validation(Required=false)]
            public List<long?> Dates { get; set; }

            [NameInMap("HistoryItems")]
            [Validation(Required=false)]
            public List<GetClientInstallationStatisticResponseBodyClientInstallRatioHistoryItems> HistoryItems { get; set; }
            public class GetClientInstallationStatisticResponseBodyClientInstallRatioHistoryItems : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetClientInstallationStatisticResponseBodyClientInstallRatioHistoryItemsItems> Items { get; set; }
                public class GetClientInstallationStatisticResponseBodyClientInstallRatioHistoryItemsItems : TeaModel {
                    [NameInMap("AssetTotalCount")]
                    [Validation(Required=false)]
                    public int? AssetTotalCount { get; set; }

                    [NameInMap("CalculateTime")]
                    [Validation(Required=false)]
                    public long? CalculateTime { get; set; }

                    [NameInMap("InstallRatio")]
                    [Validation(Required=false)]
                    public double? InstallRatio { get; set; }

                    [NameInMap("InstalledAssetCount")]
                    [Validation(Required=false)]
                    public int? InstalledAssetCount { get; set; }

                }

                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public long? Vendor { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
