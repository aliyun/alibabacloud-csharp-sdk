// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class AttachToPolicyRequest : TeaModel {
        /// <summary>
        /// The protected objects.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IpPortProtocolList")]
        [Validation(Required=false)]
        public List<AttachToPolicyRequestIpPortProtocolList> IpPortProtocolList { get; set; }
        public class AttachToPolicyRequestIpPortProtocolList : TeaModel {
            /// <summary>
            /// The IP address of the protected object.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The port number of the protected object.
            /// 
            /// >  This parameter is available for only port-specific mitigation policies.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The protocol type of the protected object. Valid values:
            /// 
            /// *   **tcp**
            /// *   **udp**
            /// 
            /// >  This parameter is available for only port-specific mitigation policies.
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// The policy ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
