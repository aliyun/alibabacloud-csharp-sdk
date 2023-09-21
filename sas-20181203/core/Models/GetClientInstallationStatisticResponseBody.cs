// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClientInstallationStatisticResponseBody : TeaModel {
        /// <summary>
        /// The statistics on the client installation rate.
        /// </summary>
        [NameInMap("ClientInstallRatio")]
        [Validation(Required=false)]
        public GetClientInstallationStatisticResponseBodyClientInstallRatio ClientInstallRatio { get; set; }
        public class GetClientInstallationStatisticResponseBodyClientInstallRatio : TeaModel {
            /// <summary>
            /// The current statistics on the installation rate of the client.
            /// </summary>
            [NameInMap("CurrentItems")]
            [Validation(Required=false)]
            public List<GetClientInstallationStatisticResponseBodyClientInstallRatioCurrentItems> CurrentItems { get; set; }
            public class GetClientInstallationStatisticResponseBodyClientInstallRatioCurrentItems : TeaModel {
                /// <summary>
                /// The current statistics on the installation rate of the client.
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetClientInstallationStatisticResponseBodyClientInstallRatioCurrentItemsItems> Items { get; set; }
                public class GetClientInstallationStatisticResponseBodyClientInstallRatioCurrentItemsItems : TeaModel {
                    /// <summary>
                    /// The total number of cloud assets.
                    /// </summary>
                    [NameInMap("AssetTotalCount")]
                    [Validation(Required=false)]
                    public int? AssetTotalCount { get; set; }

                    /// <summary>
                    /// The timestamp of the calculation. Unit: millisecond.
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
                /// *   **0**: a cloud asset provided by Alibaba Cloud.
                /// *   **1**: a third-party cloud asset
                /// *   **2**: an asset in a data center
                /// *   **3**, **4**, **5**, and **7**: other cloud asset
                /// *   **8**: a lightweight cloud asset
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public long? Vendor { get; set; }

            }

            /// <summary>
            /// The time when statistics were collected.
            /// </summary>
            [NameInMap("Dates")]
            [Validation(Required=false)]
            public List<long?> Dates { get; set; }

            /// <summary>
            /// The historical statistics on the installation rate of the agent.
            /// </summary>
            [NameInMap("HistoryItems")]
            [Validation(Required=false)]
            public List<GetClientInstallationStatisticResponseBodyClientInstallRatioHistoryItems> HistoryItems { get; set; }
            public class GetClientInstallationStatisticResponseBodyClientInstallRatioHistoryItems : TeaModel {
                /// <summary>
                /// The statistics on the client installation rate.
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetClientInstallationStatisticResponseBodyClientInstallRatioHistoryItemsItems> Items { get; set; }
                public class GetClientInstallationStatisticResponseBodyClientInstallRatioHistoryItemsItems : TeaModel {
                    /// <summary>
                    /// The total number of cloud assets.
                    /// </summary>
                    [NameInMap("AssetTotalCount")]
                    [Validation(Required=false)]
                    public int? AssetTotalCount { get; set; }

                    /// <summary>
                    /// The timestamp of the calculation. Unit: millisecond.
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
                    /// The number of cloud assets on which the client is installed.
                    /// </summary>
                    [NameInMap("InstalledAssetCount")]
                    [Validation(Required=false)]
                    public int? InstalledAssetCount { get; set; }

                }

                /// <summary>
                /// The type of the cloud asset. Valid values:
                /// 
                /// *   **0**: a cloud asset provided by Alibaba Cloud.
                /// *   **1**: a third-party cloud asset
                /// *   **2**: an asset in a data center
                /// *   **3**, **4**, **5**, and **7**: other cloud asset
                /// *   **8**: a lightweight cloud asset
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public long? Vendor { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
