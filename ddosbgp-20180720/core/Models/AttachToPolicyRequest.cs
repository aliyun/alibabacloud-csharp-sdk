// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class AttachToPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The protected objects.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IpPortProtocolList")]
        [Validation(Required=false)]
        public List<AttachToPolicyRequestIpPortProtocolList> IpPortProtocolList { get; set; }
        public class AttachToPolicyRequestIpPortProtocolList : TeaModel {
            /// <summary>
            /// <para>The IP address of the protected object.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>112.124.241.***</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The port number of the protected object.</para>
            /// <remarks>
            /// <para> This parameter is available for only port-specific mitigation policies.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8*</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The protocol type of the protected object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tcp</b></description></item>
            /// <item><description><b>udp</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is available for only port-specific mitigation policies.</para>
            /// </remarks>
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

    }

}
