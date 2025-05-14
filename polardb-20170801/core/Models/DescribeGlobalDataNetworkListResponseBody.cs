// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeGlobalDataNetworkListResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeGlobalDataNetworkListResponseBodyItems Items { get; set; }
        public class DescribeGlobalDataNetworkListResponseBodyItems : TeaModel {
            [NameInMap("Networks")]
            [Validation(Required=false)]
            public List<DescribeGlobalDataNetworkListResponseBodyItemsNetworks> Networks { get; set; }
            public class DescribeGlobalDataNetworkListResponseBodyItemsNetworks : TeaModel {
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public List<DescribeGlobalDataNetworkListResponseBodyItemsNetworksChannels> Channels { get; set; }
                public class DescribeGlobalDataNetworkListResponseBodyItemsNetworksChannels : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>gdc-xxx</para>
                    /// </summary>
                    [NameInMap("ChannelId")]
                    [Validation(Required=false)]
                    public string ChannelId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Syncing</para>
                    /// </summary>
                    [NameInMap("ChannelStatus")]
                    [Validation(Required=false)]
                    public string ChannelStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("FreezeSourceDuringSync")]
                    [Validation(Required=false)]
                    public bool? FreezeSourceDuringSync { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>11.45%</para>
                    /// </summary>
                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public string Progress { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-03-25T09:37:10Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mygdn</para>
                /// </summary>
                [NameInMap("NetworkDescription")]
                [Validation(Required=false)]
                public string NetworkDescription { get; set; }

                /// <summary>
                /// <para>GDN ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>gdn-xxx</para>
                /// </summary>
                [NameInMap("NetworkId")]
                [Validation(Required=false)]
                public string NetworkId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("NetworkStatus")]
                [Validation(Required=false)]
                public string NetworkStatus { get; set; }

                [NameInMap("NetworkTopology")]
                [Validation(Required=false)]
                public DescribeGlobalDataNetworkListResponseBodyItemsNetworksNetworkTopology NetworkTopology { get; set; }
                public class DescribeGlobalDataNetworkListResponseBodyItemsNetworksNetworkTopology : TeaModel {
                    [NameInMap("Destinations")]
                    [Validation(Required=false)]
                    public List<DescribeGlobalDataNetworkListResponseBodyItemsNetworksNetworkTopologyDestinations> Destinations { get; set; }
                    public class DescribeGlobalDataNetworkListResponseBodyItemsNetworksNetworkTopologyDestinations : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>/</para>
                        /// </summary>
                        [NameInMap("DestinationFileSystemPath")]
                        [Validation(Required=false)]
                        public string DestinationFileSystemPath { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>pfs-xxx</para>
                        /// </summary>
                        [NameInMap("DestinationId")]
                        [Validation(Required=false)]
                        public string DestinationId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cn-beijing</para>
                        /// </summary>
                        [NameInMap("DestinationRegion")]
                        [Validation(Required=false)]
                        public string DestinationRegion { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>pfs</para>
                        /// </summary>
                        [NameInMap("DestinationType")]
                        [Validation(Required=false)]
                        public string DestinationType { get; set; }

                    }

                    [NameInMap("Sources")]
                    [Validation(Required=false)]
                    public List<DescribeGlobalDataNetworkListResponseBodyItemsNetworksNetworkTopologySources> Sources { get; set; }
                    public class DescribeGlobalDataNetworkListResponseBodyItemsNetworksNetworkTopologySources : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>/</para>
                        /// </summary>
                        [NameInMap("SourceFileSystemPath")]
                        [Validation(Required=false)]
                        public string SourceFileSystemPath { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>oss-xxx</para>
                        /// </summary>
                        [NameInMap("SourceId")]
                        [Validation(Required=false)]
                        public string SourceId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cn-wulanchabu</para>
                        /// </summary>
                        [NameInMap("SourceRegion")]
                        [Validation(Required=false)]
                        public string SourceRegion { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>oss</para>
                        /// </summary>
                        [NameInMap("SourceType")]
                        [Validation(Required=false)]
                        public string SourceType { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public string PageRecordCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CD35F3-F3-44CA-AFFF-BAF869******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public string TotalRecordCount { get; set; }

    }

}
