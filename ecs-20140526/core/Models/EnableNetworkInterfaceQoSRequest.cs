// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class EnableNetworkInterfaceQoSRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Elastic Network Interface (ENI).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-2zeh9atclduxvf1z****</para>
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The QoS bandwidth throttling settings.</para>
        /// </summary>
        [NameInMap("QoS")]
        [Validation(Required=false)]
        public EnableNetworkInterfaceQoSRequestQoS QoS { get; set; }
        public class EnableNetworkInterfaceQoSRequestQoS : TeaModel {
            /// <summary>
            /// <para>The maximum inbound internal bandwidth limit.</para>
            /// <para>Unit: Kbit/s. Step size: 1000 (1 Mbit/s). Valid values: [50000, +∞).</para>
            /// 
            /// <b>Example:</b>
            /// <para>50000</para>
            /// </summary>
            [NameInMap("BandwidthRx")]
            [Validation(Required=false)]
            public long? BandwidthRx { get; set; }

            /// <summary>
            /// <para>The maximum outbound internal bandwidth limit.</para>
            /// <para>Unit: Kbit/s. Step size: 1000 (1 Mbit/s). Valid values: [50000, +∞).</para>
            /// 
            /// <b>Example:</b>
            /// <para>50000</para>
            /// </summary>
            [NameInMap("BandwidthTx")]
            [Validation(Required=false)]
            public long? BandwidthTx { get; set; }

            /// <summary>
            /// <para>The maximum number of sessions.</para>
            /// <para>Step size: 10000. Valid values: [10000, +∞).</para>
            /// 
            /// <b>Example:</b>
            /// <para>50000</para>
            /// </summary>
            [NameInMap("ConcurrentConnections")]
            [Validation(Required=false)]
            public long? ConcurrentConnections { get; set; }

            /// <summary>
            /// <para>The inbound internal packet forwarding rate.</para>
            /// <para>Unit: PPS. Step size: 10000. Valid values: [10000, +∞).</para>
            /// 
            /// <b>Example:</b>
            /// <para>50000</para>
            /// </summary>
            [NameInMap("PpsRx")]
            [Validation(Required=false)]
            public long? PpsRx { get; set; }

            /// <summary>
            /// <para>The outbound internal packet forwarding rate.</para>
            /// <para>Unit: PPS. Step size: 10000. Valid values: [10000, +∞).</para>
            /// 
            /// <b>Example:</b>
            /// <para>50000</para>
            /// </summary>
            [NameInMap("PpsTx")]
            [Validation(Required=false)]
            public long? PpsTx { get; set; }

        }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
