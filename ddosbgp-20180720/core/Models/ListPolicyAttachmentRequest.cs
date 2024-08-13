// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class ListPolicyAttachmentRequest : TeaModel {
        /// <summary>
        /// The protected objects.
        /// </summary>
        [NameInMap("IpPortProtocolList")]
        [Validation(Required=false)]
        public List<ListPolicyAttachmentRequestIpPortProtocolList> IpPortProtocolList { get; set; }
        public class ListPolicyAttachmentRequestIpPortProtocolList : TeaModel {
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
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The protocol type of the protected object. Valid values:
            /// 
            /// *   **tcp**
            /// *   **udp**
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the policy.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// The type of the policy. Valid values:
        /// 
        /// *   **default**: the default mitigation policies.
        /// *   **l3**: IP-specific mitigation policies.
        /// *   **l4**: port-specific mitigation policies.
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

    }

}
