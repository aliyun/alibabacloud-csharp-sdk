// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClientRatioStatisticResponseBody : TeaModel {
        /// <summary>
        /// The statistics on the client installation rate.
        /// </summary>
        [NameInMap("ClientInstallRatio")]
        [Validation(Required=false)]
        public GetClientRatioStatisticResponseBodyClientInstallRatio ClientInstallRatio { get; set; }
        public class GetClientRatioStatisticResponseBodyClientInstallRatio : TeaModel {
            /// <summary>
            /// The list of current statistics on the installation rate of the client.
            /// </summary>
            [NameInMap("CurrentItems")]
            [Validation(Required=false)]
            public List<GetClientRatioStatisticResponseBodyClientInstallRatioCurrentItems> CurrentItems { get; set; }
            public class GetClientRatioStatisticResponseBodyClientInstallRatioCurrentItems : TeaModel {
                /// <summary>
                /// The list of the statistics on the installation rate of the client by vendor.
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetClientRatioStatisticResponseBodyClientInstallRatioCurrentItemsItems> Items { get; set; }
                public class GetClientRatioStatisticResponseBodyClientInstallRatioCurrentItemsItems : TeaModel {
                    /// <summary>
                    /// The total number of assets.
                    /// </summary>
                    [NameInMap("AssetTotalCount")]
                    [Validation(Required=false)]
                    public int? AssetTotalCount { get; set; }

                    /// <summary>
                    /// The timestamp of the calculation. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("CalculateTime")]
                    [Validation(Required=false)]
                    public long? CalculateTime { get; set; }

                    /// <summary>
                    /// The installation rate. Unit: %.
                    /// </summary>
                    [NameInMap("InstallRatio")]
                    [Validation(Required=false)]
                    public double? InstallRatio { get; set; }

                    /// <summary>
                    /// The number of assets on which the client is installed.
                    /// </summary>
                    [NameInMap("InstalledAssetCount")]
                    [Validation(Required=false)]
                    public int? InstalledAssetCount { get; set; }

                }

                /// <summary>
                /// The type of the server. Valid values:
                /// 
                /// *   **0**: an asset provided by Alibaba Cloud
                /// *   **1**: a third-party cloud asset
                /// *   **2**: an asset in a data center
                /// *   **3**, **4**, **5**, and **7**: other cloud asset
                /// *   **8**: a lightweight asset
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public long? Vendor { get; set; }

            }

            /// <summary>
            /// The list of historical statistics on the installation rate of the client.
            /// </summary>
            [NameInMap("HistoryItems")]
            [Validation(Required=false)]
            public List<GetClientRatioStatisticResponseBodyClientInstallRatioHistoryItems> HistoryItems { get; set; }
            public class GetClientRatioStatisticResponseBodyClientInstallRatioHistoryItems : TeaModel {
                /// <summary>
                /// The list of statistics on the client installation rate.
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetClientRatioStatisticResponseBodyClientInstallRatioHistoryItemsItems> Items { get; set; }
                public class GetClientRatioStatisticResponseBodyClientInstallRatioHistoryItemsItems : TeaModel {
                    /// <summary>
                    /// The total number of assets.
                    /// </summary>
                    [NameInMap("AssetTotalCount")]
                    [Validation(Required=false)]
                    public int? AssetTotalCount { get; set; }

                    /// <summary>
                    /// The timestamp of the calculation. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("CalculateTime")]
                    [Validation(Required=false)]
                    public long? CalculateTime { get; set; }

                    /// <summary>
                    /// The installation rate. Unit: %.
                    /// </summary>
                    [NameInMap("InstallRatio")]
                    [Validation(Required=false)]
                    public double? InstallRatio { get; set; }

                    /// <summary>
                    /// The number of assets on which the client is installed.
                    /// </summary>
                    [NameInMap("InstalledAssetCount")]
                    [Validation(Required=false)]
                    public int? InstalledAssetCount { get; set; }

                }

                /// <summary>
                /// The type of the cloud asset. Valid values:
                /// 
                /// *   **0**: an asset provided by Alibaba Cloud
                /// *   **1**: a third-party cloud asset
                /// *   **2**: an asset in a data center
                /// *   **3**, **4**, **5**, and **7**: other cloud asset
                /// *   **8**: a simple application server
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public long? Vendor { get; set; }

            }

        }

        /// <summary>
        /// The statistics on the client online rate.
        /// </summary>
        [NameInMap("ClientOnlineRatio")]
        [Validation(Required=false)]
        public GetClientRatioStatisticResponseBodyClientOnlineRatio ClientOnlineRatio { get; set; }
        public class GetClientRatioStatisticResponseBodyClientOnlineRatio : TeaModel {
            /// <summary>
            /// The list of current statistics on the online rate of the client.
            /// </summary>
            [NameInMap("CurrentItems")]
            [Validation(Required=false)]
            public List<GetClientRatioStatisticResponseBodyClientOnlineRatioCurrentItems> CurrentItems { get; set; }
            public class GetClientRatioStatisticResponseBodyClientOnlineRatioCurrentItems : TeaModel {
                /// <summary>
                /// The list of current statistics on the online rate of the client by vendor.
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetClientRatioStatisticResponseBodyClientOnlineRatioCurrentItemsItems> Items { get; set; }
                public class GetClientRatioStatisticResponseBodyClientOnlineRatioCurrentItemsItems : TeaModel {
                    /// <summary>
                    /// The number of assets on which the client is installed.
                    /// </summary>
                    [NameInMap("AssetInstallCount")]
                    [Validation(Required=false)]
                    public int? AssetInstallCount { get; set; }

                    /// <summary>
                    /// The timestamp of the calculation. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("CalculateTime")]
                    [Validation(Required=false)]
                    public long? CalculateTime { get; set; }

                    /// <summary>
                    /// The number of online assets.
                    /// </summary>
                    [NameInMap("OnlineAssetCount")]
                    [Validation(Required=false)]
                    public int? OnlineAssetCount { get; set; }

                    /// <summary>
                    /// The online rate. Unit: %.
                    /// </summary>
                    [NameInMap("OnlineRatio")]
                    [Validation(Required=false)]
                    public double? OnlineRatio { get; set; }

                }

                /// <summary>
                /// The type of the cloud asset. Valid values:
                /// 
                /// *   **0**: an asset provided by Alibaba Cloud
                /// *   **1**: a third-party cloud asset
                /// *   **2**: an asset in a data center
                /// *   **3**, **4**, **5**, and **7**: other cloud asset
                /// *   **8**: a simple application server
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public long? Vendor { get; set; }

            }

            /// <summary>
            /// The list of historical statistics on the online rate of the client.
            /// </summary>
            [NameInMap("HistoryItems")]
            [Validation(Required=false)]
            public List<GetClientRatioStatisticResponseBodyClientOnlineRatioHistoryItems> HistoryItems { get; set; }
            public class GetClientRatioStatisticResponseBodyClientOnlineRatioHistoryItems : TeaModel {
                /// <summary>
                /// The list of historical statistics on the online rate of the client by vendor.
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetClientRatioStatisticResponseBodyClientOnlineRatioHistoryItemsItems> Items { get; set; }
                public class GetClientRatioStatisticResponseBodyClientOnlineRatioHistoryItemsItems : TeaModel {
                    /// <summary>
                    /// The number of assets on which the client is installed.
                    /// </summary>
                    [NameInMap("AssetInstallCount")]
                    [Validation(Required=false)]
                    public int? AssetInstallCount { get; set; }

                    /// <summary>
                    /// The timestamp of the calculation. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("CalculateTime")]
                    [Validation(Required=false)]
                    public long? CalculateTime { get; set; }

                    /// <summary>
                    /// The number of online assets.
                    /// </summary>
                    [NameInMap("OnlineAssetCount")]
                    [Validation(Required=false)]
                    public int? OnlineAssetCount { get; set; }

                    /// <summary>
                    /// The online rate. Unit: %.
                    /// </summary>
                    [NameInMap("OnlineRatio")]
                    [Validation(Required=false)]
                    public double? OnlineRatio { get; set; }

                }

                /// <summary>
                /// The type of the server. Valid values:
                /// 
                /// *   **0**: an asset provided by Alibaba Cloud
                /// *   **1**: a third-party cloud asset
                /// *   **2**: an asset in a data center
                /// *   **3**, **4**, **5**, and **7**: other cloud asset
                /// *   **8**: a lightweight asset
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public long? Vendor { get; set; }

            }

        }

        /// <summary>
        /// The list of time when statistics were collected.
        /// </summary>
        [NameInMap("Dates")]
        [Validation(Required=false)]
        public List<long?> Dates { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
