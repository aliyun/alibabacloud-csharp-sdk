// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClientRatioStatisticResponseBody : TeaModel {
        [NameInMap("ClientInstallRatio")]
        [Validation(Required=false)]
        public GetClientRatioStatisticResponseBodyClientInstallRatio ClientInstallRatio { get; set; }
        public class GetClientRatioStatisticResponseBodyClientInstallRatio : TeaModel {
            [NameInMap("CurrentItems")]
            [Validation(Required=false)]
            public List<GetClientRatioStatisticResponseBodyClientInstallRatioCurrentItems> CurrentItems { get; set; }
            public class GetClientRatioStatisticResponseBodyClientInstallRatioCurrentItems : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetClientRatioStatisticResponseBodyClientInstallRatioCurrentItemsItems> Items { get; set; }
                public class GetClientRatioStatisticResponseBodyClientInstallRatioCurrentItemsItems : TeaModel {
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

            [NameInMap("HistoryItems")]
            [Validation(Required=false)]
            public List<GetClientRatioStatisticResponseBodyClientInstallRatioHistoryItems> HistoryItems { get; set; }
            public class GetClientRatioStatisticResponseBodyClientInstallRatioHistoryItems : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetClientRatioStatisticResponseBodyClientInstallRatioHistoryItemsItems> Items { get; set; }
                public class GetClientRatioStatisticResponseBodyClientInstallRatioHistoryItemsItems : TeaModel {
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

        [NameInMap("ClientOnlineRatio")]
        [Validation(Required=false)]
        public GetClientRatioStatisticResponseBodyClientOnlineRatio ClientOnlineRatio { get; set; }
        public class GetClientRatioStatisticResponseBodyClientOnlineRatio : TeaModel {
            [NameInMap("CurrentItems")]
            [Validation(Required=false)]
            public List<GetClientRatioStatisticResponseBodyClientOnlineRatioCurrentItems> CurrentItems { get; set; }
            public class GetClientRatioStatisticResponseBodyClientOnlineRatioCurrentItems : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetClientRatioStatisticResponseBodyClientOnlineRatioCurrentItemsItems> Items { get; set; }
                public class GetClientRatioStatisticResponseBodyClientOnlineRatioCurrentItemsItems : TeaModel {
                    [NameInMap("AssetInstallCount")]
                    [Validation(Required=false)]
                    public int? AssetInstallCount { get; set; }

                    [NameInMap("CalculateTime")]
                    [Validation(Required=false)]
                    public long? CalculateTime { get; set; }

                    [NameInMap("OnlineAssetCount")]
                    [Validation(Required=false)]
                    public int? OnlineAssetCount { get; set; }

                    [NameInMap("OnlineRatio")]
                    [Validation(Required=false)]
                    public double? OnlineRatio { get; set; }

                }

                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public long? Vendor { get; set; }

            }

            [NameInMap("HistoryItems")]
            [Validation(Required=false)]
            public List<GetClientRatioStatisticResponseBodyClientOnlineRatioHistoryItems> HistoryItems { get; set; }
            public class GetClientRatioStatisticResponseBodyClientOnlineRatioHistoryItems : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetClientRatioStatisticResponseBodyClientOnlineRatioHistoryItemsItems> Items { get; set; }
                public class GetClientRatioStatisticResponseBodyClientOnlineRatioHistoryItemsItems : TeaModel {
                    [NameInMap("AssetInstallCount")]
                    [Validation(Required=false)]
                    public int? AssetInstallCount { get; set; }

                    [NameInMap("CalculateTime")]
                    [Validation(Required=false)]
                    public long? CalculateTime { get; set; }

                    [NameInMap("OnlineAssetCount")]
                    [Validation(Required=false)]
                    public int? OnlineAssetCount { get; set; }

                    [NameInMap("OnlineRatio")]
                    [Validation(Required=false)]
                    public double? OnlineRatio { get; set; }

                }

                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public long? Vendor { get; set; }

            }

        }

        [NameInMap("Dates")]
        [Validation(Required=false)]
        public List<long?> Dates { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
