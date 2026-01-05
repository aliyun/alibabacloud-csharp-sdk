// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class EnableNetworkInterfaceQoSRequest : TeaModel {
        /// <summary>
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
        /// <para>QoS Speed Limit Settings</para>
        /// </summary>
        [NameInMap("QoS")]
        [Validation(Required=false)]
        public EnableNetworkInterfaceQoSRequestQoS QoS { get; set; }
        public class EnableNetworkInterfaceQoSRequestQoS : TeaModel {
            /// <summary>
            /// <para>The maximum inbound internal bandwidth.</para>
            /// <para>Unit: kbit/s, step size: 1000 (1Mbps), value range: [50000, +♾️)</para>
            /// 
            /// <b>Example:</b>
            /// <para>50000</para>
            /// </summary>
            [NameInMap("BandwidthRx")]
            [Validation(Required=false)]
            public long? BandwidthRx { get; set; }

            /// <summary>
            /// <para>The maximum outbound internal bandwidth.</para>
            /// <para>Unit: kbit/s, step size: 1000 (1Mbps), value range: [50000, +♾️)</para>
            /// 
            /// <b>Example:</b>
            /// <para>50000</para>
            /// </summary>
            [NameInMap("BandwidthTx")]
            [Validation(Required=false)]
            public long? BandwidthTx { get; set; }

            /// <summary>
            /// <para>Maximum Number of Sessions</para>
            /// <para>Step size: 10000, value range: [10000, +♾️)</para>
            /// 
            /// <b>Example:</b>
            /// <para>50000</para>
            /// </summary>
            [NameInMap("ConcurrentConnections")]
            [Validation(Required=false)]
            public long? ConcurrentConnections { get; set; }

            /// <summary>
            /// <para>The inbound packet forwarding rate over the internal network.</para>
            /// <para>Unit: pps, step size: 10000, value range: [10000, +♾️)</para>
            /// 
            /// <b>Example:</b>
            /// <para>50000</para>
            /// </summary>
            [NameInMap("PpsRx")]
            [Validation(Required=false)]
            public long? PpsRx { get; set; }

            /// <summary>
            /// <para>The outbound packet forwarding rate over the internal network.</para>
            /// <para>Unit: pps, step size: 10000, value range: [10000, +♾️)</para>
            /// 
            /// <b>Example:</b>
            /// <para>50000</para>
            /// </summary>
            [NameInMap("PpsTx")]
            [Validation(Required=false)]
            public long? PpsTx { get; set; }

        }

        /// <summary>
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
