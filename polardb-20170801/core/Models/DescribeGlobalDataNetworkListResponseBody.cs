// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeGlobalDataNetworkListResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the Global Data Networks (GDNs).</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeGlobalDataNetworkListResponseBodyItems Items { get; set; }
        public class DescribeGlobalDataNetworkListResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The list of GDN networks.</para>
            /// </summary>
            [NameInMap("Networks")]
            [Validation(Required=false)]
            public List<DescribeGlobalDataNetworkListResponseBodyItemsNetworks> Networks { get; set; }
            public class DescribeGlobalDataNetworkListResponseBodyItemsNetworks : TeaModel {
                /// <summary>
                /// <para>The synchronization channels.</para>
                /// </summary>
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public List<DescribeGlobalDataNetworkListResponseBodyItemsNetworksChannels> Channels { get; set; }
                public class DescribeGlobalDataNetworkListResponseBodyItemsNetworksChannels : TeaModel {
                    /// <summary>
                    /// <para>The ID of the synchronization channel.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>gdc-xxx</para>
                    /// </summary>
                    [NameInMap("ChannelId")]
                    [Validation(Required=false)]
                    public string ChannelId { get; set; }

                    /// <summary>
                    /// <para>The status of the synchronization channel. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>Creating</b>: The channel is being created.</para>
                    /// </description></item>
                    /// <item><description><para><b>Running</b>: The channel is running.</para>
                    /// </description></item>
                    /// <item><description><para><b>Syncing</b>: The channel is synchronizing data.</para>
                    /// </description></item>
                    /// <item><description><para><b>SyncFinished</b>: Data synchronization is complete.</para>
                    /// </description></item>
                    /// <item><description><para><b>SyncFailed</b>: Data synchronization failed.</para>
                    /// </description></item>
                    /// <item><description><para><b>SyncPartialFailed</b>: Data synchronization partially failed.</para>
                    /// </description></item>
                    /// <item><description><para><b>Stopped</b>: The channel is stopped.</para>
                    /// </description></item>
                    /// <item><description><para><b>Maintaining</b>: The channel is under maintenance.</para>
                    /// </description></item>
                    /// <item><description><para><b>Restarting</b>: The channel is restarting.</para>
                    /// </description></item>
                    /// <item><description><para><b>Locking</b>: The channel is being locked.</para>
                    /// </description></item>
                    /// <item><description><para><b>Locked</b>: The channel is locked.</para>
                    /// </description></item>
                    /// <item><description><para><b>Unlocking</b>: The channel is being unlocked.</para>
                    /// </description></item>
                    /// <item><description><para><b>Deleting</b>: The channel is being deleted.</para>
                    /// </description></item>
                    /// <item><description><para><b>Deleted</b>: The channel is deleted.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Syncing</para>
                    /// </summary>
                    [NameInMap("ChannelStatus")]
                    [Validation(Required=false)]
                    public string ChannelStatus { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the source path is frozen during data transmission.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("FreezeSourceDuringSync")]
                    [Validation(Required=false)]
                    public bool? FreezeSourceDuringSync { get; set; }

                    /// <summary>
                    /// <para>The synchronization progress.</para>
                    /// <remarks>
                    /// <para>The value is a percentage that is accurate to two decimal places.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>11.45%</para>
                    /// </summary>
                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public string Progress { get; set; }

                }

                /// <summary>
                /// <para>The time when the GDN was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-03-25T09:37:10Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the GDN.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mygdn</para>
                /// </summary>
                [NameInMap("NetworkDescription")]
                [Validation(Required=false)]
                public string NetworkDescription { get; set; }

                /// <summary>
                /// <para>The ID of the GDN.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gdn-xxx</para>
                /// </summary>
                [NameInMap("NetworkId")]
                [Validation(Required=false)]
                public string NetworkId { get; set; }

                /// <summary>
                /// <para>The status of the GDN. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Creating</b>: The GDN is being created.</para>
                /// </description></item>
                /// <item><description><para><b>Running</b>: The GDN is running.</para>
                /// </description></item>
                /// <item><description><para><b>Syncing</b>: The GDN is synchronizing data.</para>
                /// </description></item>
                /// <item><description><para><b>SyncFinished</b>: Data synchronization is complete.</para>
                /// </description></item>
                /// <item><description><para><b>SyncFailed</b>: Data synchronization failed.</para>
                /// </description></item>
                /// <item><description><para><b>SyncPartialFailed</b>: Data synchronization partially failed.</para>
                /// </description></item>
                /// <item><description><para><b>Stopped</b>: The GDN is stopped.</para>
                /// </description></item>
                /// <item><description><para><b>Maintaining</b>: The GDN is under maintenance.</para>
                /// </description></item>
                /// <item><description><para><b>Restarting</b>: The GDN is restarting.</para>
                /// </description></item>
                /// <item><description><para><b>Locking</b>: The GDN is being locked.</para>
                /// </description></item>
                /// <item><description><para><b>Locked</b>: The GDN is locked.</para>
                /// </description></item>
                /// <item><description><para><b>Unlocking</b>: The GDN is being unlocked.</para>
                /// </description></item>
                /// <item><description><para><b>Deleting</b>: The GDN is being deleted.</para>
                /// </description></item>
                /// <item><description><para><b>Deleted</b>: The GDN is deleted.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("NetworkStatus")]
                [Validation(Required=false)]
                public string NetworkStatus { get; set; }

                /// <summary>
                /// <para>The network topology of the GDN.</para>
                /// </summary>
                [NameInMap("NetworkTopology")]
                [Validation(Required=false)]
                public DescribeGlobalDataNetworkListResponseBodyItemsNetworksNetworkTopology NetworkTopology { get; set; }
                public class DescribeGlobalDataNetworkListResponseBodyItemsNetworksNetworkTopology : TeaModel {
                    /// <summary>
                    /// <para>The synchronization destinations.</para>
                    /// </summary>
                    [NameInMap("Destinations")]
                    [Validation(Required=false)]
                    public List<DescribeGlobalDataNetworkListResponseBodyItemsNetworksNetworkTopologyDestinations> Destinations { get; set; }
                    public class DescribeGlobalDataNetworkListResponseBodyItemsNetworksNetworkTopologyDestinations : TeaModel {
                        /// <summary>
                        /// <para>The destination path.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/</para>
                        /// </summary>
                        [NameInMap("DestinationFileSystemPath")]
                        [Validation(Required=false)]
                        public string DestinationFileSystemPath { get; set; }

                        /// <summary>
                        /// <para>Destination PolarDB instance</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>pfs-xxx</para>
                        /// </summary>
                        [NameInMap("DestinationId")]
                        [Validation(Required=false)]
                        public string DestinationId { get; set; }

                        /// <summary>
                        /// <para>The region of the destination.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-beijing</para>
                        /// </summary>
                        [NameInMap("DestinationRegion")]
                        [Validation(Required=false)]
                        public string DestinationRegion { get; set; }

                        /// <summary>
                        /// <para>The type of the destination. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>pfs</b>: Polarlakebase High-performance Edition.</para>
                        /// </description></item>
                        /// <item><description><para><b>pcs</b>: Polarlakebase Cold Storage Edition.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>pfs</para>
                        /// </summary>
                        [NameInMap("DestinationType")]
                        [Validation(Required=false)]
                        public string DestinationType { get; set; }

                    }

                    /// <summary>
                    /// <para>The synchronization sources.</para>
                    /// </summary>
                    [NameInMap("Sources")]
                    [Validation(Required=false)]
                    public List<DescribeGlobalDataNetworkListResponseBodyItemsNetworksNetworkTopologySources> Sources { get; set; }
                    public class DescribeGlobalDataNetworkListResponseBodyItemsNetworksNetworkTopologySources : TeaModel {
                        /// <summary>
                        /// <para>The source path.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/</para>
                        /// </summary>
                        [NameInMap("SourceFileSystemPath")]
                        [Validation(Required=false)]
                        public string SourceFileSystemPath { get; set; }

                        /// <summary>
                        /// <para>The ID of the source Polarlakebase instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>pcs-xxx</para>
                        /// </summary>
                        [NameInMap("SourceId")]
                        [Validation(Required=false)]
                        public string SourceId { get; set; }

                        /// <summary>
                        /// <para>The region of the source.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-wulanchabu</para>
                        /// </summary>
                        [NameInMap("SourceRegion")]
                        [Validation(Required=false)]
                        public string SourceRegion { get; set; }

                        /// <summary>
                        /// <para>The type of the source. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>pfs</b>: Polarlakebase High-performance Edition.</para>
                        /// </description></item>
                        /// <item><description><para><b>pcs</b>: Polarlakebase Cold Storage Edition.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>pcs</para>
                        /// </summary>
                        [NameInMap("SourceType")]
                        [Validation(Required=false)]
                        public string SourceType { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public string PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD35F3-F3-44CA-AFFF-BAF869******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public string TotalRecordCount { get; set; }

    }

}
