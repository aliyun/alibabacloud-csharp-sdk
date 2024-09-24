// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClientRatioStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics on the client installation rate.</para>
        /// </summary>
        [NameInMap("ClientInstallRatio")]
        [Validation(Required=false)]
        public GetClientRatioStatisticResponseBodyClientInstallRatio ClientInstallRatio { get; set; }
        public class GetClientRatioStatisticResponseBodyClientInstallRatio : TeaModel {
            /// <summary>
            /// <para>The list of current statistics on the installation rate of the client.</para>
            /// </summary>
            [NameInMap("CurrentItems")]
            [Validation(Required=false)]
            public List<GetClientRatioStatisticResponseBodyClientInstallRatioCurrentItems> CurrentItems { get; set; }
            public class GetClientRatioStatisticResponseBodyClientInstallRatioCurrentItems : TeaModel {
                /// <summary>
                /// <para>The list of the statistics on the installation rate of the client by vendor.</para>
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetClientRatioStatisticResponseBodyClientInstallRatioCurrentItemsItems> Items { get; set; }
                public class GetClientRatioStatisticResponseBodyClientInstallRatioCurrentItemsItems : TeaModel {
                    /// <summary>
                    /// <para>The total number of assets.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AssetTotalCount")]
                    [Validation(Required=false)]
                    public int? AssetTotalCount { get; set; }

                    /// <summary>
                    /// <para>The timestamp of the calculation. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1687759630045</para>
                    /// </summary>
                    [NameInMap("CalculateTime")]
                    [Validation(Required=false)]
                    public long? CalculateTime { get; set; }

                    /// <summary>
                    /// <para>The installation rate. Unit: %.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>70.00</para>
                    /// </summary>
                    [NameInMap("InstallRatio")]
                    [Validation(Required=false)]
                    public double? InstallRatio { get; set; }

                    /// <summary>
                    /// <para>The number of assets on which the client is installed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>70</para>
                    /// </summary>
                    [NameInMap("InstalledAssetCount")]
                    [Validation(Required=false)]
                    public int? InstalledAssetCount { get; set; }

                }

                /// <summary>
                /// <para>The type of the server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: an asset provided by Alibaba Cloud</description></item>
                /// <item><description><b>1</b>: a third-party cloud asset</description></item>
                /// <item><description><b>2</b>: an asset in a data center</description></item>
                /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, and <b>7</b>: other cloud asset</description></item>
                /// <item><description><b>8</b>: a lightweight asset</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public long? Vendor { get; set; }

            }

            /// <summary>
            /// <para>The list of historical statistics on the installation rate of the client.</para>
            /// </summary>
            [NameInMap("HistoryItems")]
            [Validation(Required=false)]
            public List<GetClientRatioStatisticResponseBodyClientInstallRatioHistoryItems> HistoryItems { get; set; }
            public class GetClientRatioStatisticResponseBodyClientInstallRatioHistoryItems : TeaModel {
                /// <summary>
                /// <para>The list of statistics on the client installation rate.</para>
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetClientRatioStatisticResponseBodyClientInstallRatioHistoryItemsItems> Items { get; set; }
                public class GetClientRatioStatisticResponseBodyClientInstallRatioHistoryItemsItems : TeaModel {
                    /// <summary>
                    /// <para>The total number of assets.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AssetTotalCount")]
                    [Validation(Required=false)]
                    public int? AssetTotalCount { get; set; }

                    /// <summary>
                    /// <para>The timestamp of the calculation. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1687759630045</para>
                    /// </summary>
                    [NameInMap("CalculateTime")]
                    [Validation(Required=false)]
                    public long? CalculateTime { get; set; }

                    /// <summary>
                    /// <para>The installation rate. Unit: %.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80.00</para>
                    /// </summary>
                    [NameInMap("InstallRatio")]
                    [Validation(Required=false)]
                    public double? InstallRatio { get; set; }

                    /// <summary>
                    /// <para>The number of assets on which the client is installed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("InstalledAssetCount")]
                    [Validation(Required=false)]
                    public int? InstalledAssetCount { get; set; }

                }

                /// <summary>
                /// <para>The type of the cloud asset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: an asset provided by Alibaba Cloud</description></item>
                /// <item><description><b>1</b>: a third-party cloud asset</description></item>
                /// <item><description><b>2</b>: an asset in a data center</description></item>
                /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, and <b>7</b>: other cloud asset</description></item>
                /// <item><description><b>8</b>: a simple application server</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public long? Vendor { get; set; }

            }

        }

        /// <summary>
        /// <para>The statistics on the client online rate.</para>
        /// </summary>
        [NameInMap("ClientOnlineRatio")]
        [Validation(Required=false)]
        public GetClientRatioStatisticResponseBodyClientOnlineRatio ClientOnlineRatio { get; set; }
        public class GetClientRatioStatisticResponseBodyClientOnlineRatio : TeaModel {
            /// <summary>
            /// <para>The list of current statistics on the online rate of the client.</para>
            /// </summary>
            [NameInMap("CurrentItems")]
            [Validation(Required=false)]
            public List<GetClientRatioStatisticResponseBodyClientOnlineRatioCurrentItems> CurrentItems { get; set; }
            public class GetClientRatioStatisticResponseBodyClientOnlineRatioCurrentItems : TeaModel {
                /// <summary>
                /// <para>The list of current statistics on the online rate of the client by vendor.</para>
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetClientRatioStatisticResponseBodyClientOnlineRatioCurrentItemsItems> Items { get; set; }
                public class GetClientRatioStatisticResponseBodyClientOnlineRatioCurrentItemsItems : TeaModel {
                    /// <summary>
                    /// <para>The number of assets on which the client is installed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("AssetInstallCount")]
                    [Validation(Required=false)]
                    public int? AssetInstallCount { get; set; }

                    /// <summary>
                    /// <para>The timestamp of the calculation. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1687759630045</para>
                    /// </summary>
                    [NameInMap("CalculateTime")]
                    [Validation(Required=false)]
                    public long? CalculateTime { get; set; }

                    /// <summary>
                    /// <para>The number of online assets.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("OnlineAssetCount")]
                    [Validation(Required=false)]
                    public int? OnlineAssetCount { get; set; }

                    /// <summary>
                    /// <para>The online rate. Unit: %.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20.00</para>
                    /// </summary>
                    [NameInMap("OnlineRatio")]
                    [Validation(Required=false)]
                    public double? OnlineRatio { get; set; }

                }

                /// <summary>
                /// <para>The type of the cloud asset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: an asset provided by Alibaba Cloud</description></item>
                /// <item><description><b>1</b>: a third-party cloud asset</description></item>
                /// <item><description><b>2</b>: an asset in a data center</description></item>
                /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, and <b>7</b>: other cloud asset</description></item>
                /// <item><description><b>8</b>: a simple application server</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public long? Vendor { get; set; }

            }

            /// <summary>
            /// <para>The list of historical statistics on the online rate of the client.</para>
            /// </summary>
            [NameInMap("HistoryItems")]
            [Validation(Required=false)]
            public List<GetClientRatioStatisticResponseBodyClientOnlineRatioHistoryItems> HistoryItems { get; set; }
            public class GetClientRatioStatisticResponseBodyClientOnlineRatioHistoryItems : TeaModel {
                /// <summary>
                /// <para>The list of historical statistics on the online rate of the client by vendor.</para>
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetClientRatioStatisticResponseBodyClientOnlineRatioHistoryItemsItems> Items { get; set; }
                public class GetClientRatioStatisticResponseBodyClientOnlineRatioHistoryItemsItems : TeaModel {
                    /// <summary>
                    /// <para>The number of assets on which the client is installed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("AssetInstallCount")]
                    [Validation(Required=false)]
                    public int? AssetInstallCount { get; set; }

                    /// <summary>
                    /// <para>The timestamp of the calculation. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1687759630045</para>
                    /// </summary>
                    [NameInMap("CalculateTime")]
                    [Validation(Required=false)]
                    public long? CalculateTime { get; set; }

                    /// <summary>
                    /// <para>The number of online assets.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("OnlineAssetCount")]
                    [Validation(Required=false)]
                    public int? OnlineAssetCount { get; set; }

                    /// <summary>
                    /// <para>The online rate. Unit: %.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>40.00</para>
                    /// </summary>
                    [NameInMap("OnlineRatio")]
                    [Validation(Required=false)]
                    public double? OnlineRatio { get; set; }

                }

                /// <summary>
                /// <para>The type of the server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: an asset provided by Alibaba Cloud</description></item>
                /// <item><description><b>1</b>: a third-party cloud asset</description></item>
                /// <item><description><b>2</b>: an asset in a data center</description></item>
                /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, and <b>7</b>: other cloud asset</description></item>
                /// <item><description><b>8</b>: a lightweight asset</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public long? Vendor { get; set; }

            }

        }

        /// <summary>
        /// <para>The list of time when statistics were collected.</para>
        /// </summary>
        [NameInMap("Dates")]
        [Validation(Required=false)]
        public List<long?> Dates { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4EB8B1C-1DEC-5E18-BCD0-D1BBB3936FA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
