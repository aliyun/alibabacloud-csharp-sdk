// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class AttachToPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The list of protection objects.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IpPortProtocolList")]
        [Validation(Required=false)]
        public List<AttachToPolicyRequestIpPortProtocolList> IpPortProtocolList { get; set; }
        public class AttachToPolicyRequestIpPortProtocolList : TeaModel {
            /// <summary>
            /// <para>The IP address of the protection object.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>112.124.241.***</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The port number of the protection object.</para>
            /// <remarks>
            /// <para>Only port-specific mitigation policies support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8*</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The port range of the protection object.</para>
            /// <remarks>
            /// <para>Only port-specific mitigation policies support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8*-9*</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>The protocol type of the protection object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tcp</b>: Transmission Control Protocol.</description></item>
            /// <item><description><b>udp</b>: User Datagram Protocol.<remarks>
            /// <para>Only port-specific mitigation policies support this parameter.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>The policy ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cd8b4d70-e4e0-413a-b390-e71d********</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The version of the port-specific mitigation policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Not specified</b>: Associates the default surf anti-DDoS engine policy.</description></item>
        /// <item><description><b>2</b>: Associates the new stream anti-DDoS engine policy.<remarks>
        /// <para>Only port-specific mitigation policies support this parameter.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PortVersion")]
        [Validation(Required=false)]
        public string PortVersion { get; set; }

    }

}
