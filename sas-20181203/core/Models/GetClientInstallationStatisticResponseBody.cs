// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClientInstallationStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics on the client installation rate.</para>
        /// </summary>
        [NameInMap("ClientInstallRatio")]
        [Validation(Required=false)]
        public GetClientInstallationStatisticResponseBodyClientInstallRatio ClientInstallRatio { get; set; }
        public class GetClientInstallationStatisticResponseBodyClientInstallRatio : TeaModel {
            /// <summary>
            /// <para>The current statistics on the installation rate of the client.</para>
            /// </summary>
            [NameInMap("CurrentItems")]
            [Validation(Required=false)]
            public List<GetClientInstallationStatisticResponseBodyClientInstallRatioCurrentItems> CurrentItems { get; set; }
            public class GetClientInstallationStatisticResponseBodyClientInstallRatioCurrentItems : TeaModel {
                /// <summary>
                /// <para>The current statistics on the installation rate of the client.</para>
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetClientInstallationStatisticResponseBodyClientInstallRatioCurrentItemsItems> Items { get; set; }
                public class GetClientInstallationStatisticResponseBodyClientInstallRatioCurrentItemsItems : TeaModel {
                    /// <summary>
                    /// <para>The total number of cloud assets.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AssetTotalCount")]
                    [Validation(Required=false)]
                    public int? AssetTotalCount { get; set; }

                    /// <summary>
                    /// <para>The timestamp of the calculation. Unit: millisecond.</para>
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
                /// <para>The type of the cloud asset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: a cloud asset provided by Alibaba Cloud.</description></item>
                /// <item><description><b>1</b>: a third-party cloud asset</description></item>
                /// <item><description><b>2</b>: an asset in a data center</description></item>
                /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, and <b>7</b>: other cloud asset</description></item>
                /// <item><description><b>8</b>: a lightweight cloud asset</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public long? Vendor { get; set; }

            }

            /// <summary>
            /// <para>The time when statistics were collected.</para>
            /// </summary>
            [NameInMap("Dates")]
            [Validation(Required=false)]
            public List<long?> Dates { get; set; }

            /// <summary>
            /// <para>The historical statistics on the installation rate of the agent.</para>
            /// </summary>
            [NameInMap("HistoryItems")]
            [Validation(Required=false)]
            public List<GetClientInstallationStatisticResponseBodyClientInstallRatioHistoryItems> HistoryItems { get; set; }
            public class GetClientInstallationStatisticResponseBodyClientInstallRatioHistoryItems : TeaModel {
                /// <summary>
                /// <para>The statistics on the client installation rate.</para>
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetClientInstallationStatisticResponseBodyClientInstallRatioHistoryItemsItems> Items { get; set; }
                public class GetClientInstallationStatisticResponseBodyClientInstallRatioHistoryItemsItems : TeaModel {
                    /// <summary>
                    /// <para>The total number of cloud assets.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AssetTotalCount")]
                    [Validation(Required=false)]
                    public int? AssetTotalCount { get; set; }

                    /// <summary>
                    /// <para>The timestamp of the calculation. Unit: millisecond.</para>
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
                    /// <para>The number of cloud assets on which the client is installed.</para>
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
                /// <item><description><b>0</b>: a cloud asset provided by Alibaba Cloud.</description></item>
                /// <item><description><b>1</b>: a third-party cloud asset</description></item>
                /// <item><description><b>2</b>: an asset in a data center</description></item>
                /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, and <b>7</b>: other cloud asset</description></item>
                /// <item><description><b>8</b>: a lightweight cloud asset</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public long? Vendor { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F62DD457-2588-589A-B1F6-A1245895D2AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
