// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSnatAttributeResponseBody : TeaModel {
        /// <summary>
        /// The time when the entry was created. The time is displayed in UTC.
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// The destination CIDR block. The rule takes effect only on requests that access the destination CIDR block.
        /// </summary>
        [NameInMap("DestCIDR")]
        [Validation(Required=false)]
        public string DestCIDR { get; set; }

        /// <summary>
        /// Timeout period.
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// The ID of the Network Address Translation (NAT) gateway.
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the SNAT entry.
        /// </summary>
        [NameInMap("SnatEntryId")]
        [Validation(Required=false)]
        public string SnatEntryId { get; set; }

        /// <summary>
        /// The name of the SNAT entry.
        /// </summary>
        [NameInMap("SnatEntryName")]
        [Validation(Required=false)]
        public string SnatEntryName { get; set; }

        /// <summary>
        /// The EIP specified in the SNAT entry. Multiple EIPs are separated by commas (,).
        /// </summary>
        [NameInMap("SnatIp")]
        [Validation(Required=false)]
        public string SnatIp { get; set; }

        /// <summary>
        /// The information about the EIP specified in the SNAT entry.
        /// </summary>
        [NameInMap("SnatIps")]
        [Validation(Required=false)]
        public List<DescribeSnatAttributeResponseBodySnatIps> SnatIps { get; set; }
        public class DescribeSnatAttributeResponseBodySnatIps : TeaModel {
            /// <summary>
            /// The time when the IP address was created. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The IP address.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The status of the IP address.
            /// 
            /// *   Running
            /// *   Stopping
            /// *   Stopped
            /// *   Starting
            /// *   Releasing
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The source CIDR block specified in the SNAT entry.
        /// </summary>
        [NameInMap("SourceCIDR")]
        [Validation(Required=false)]
        public string SourceCIDR { get; set; }

        /// <summary>
        /// The secondary EIP specified in the SNAT entry. Multiple secondary EIPs are separated by commas (,).
        /// </summary>
        [NameInMap("StandbySnatIp")]
        [Validation(Required=false)]
        public string StandbySnatIp { get; set; }

        /// <summary>
        /// The status of the secondary EIP.
        /// 
        /// *   Running
        /// *   Stopping
        /// *   Stopped
        /// *   Starting
        /// </summary>
        [NameInMap("StandbyStatus")]
        [Validation(Required=false)]
        public string StandbyStatus { get; set; }

        /// <summary>
        /// The status of the SNAT entry.
        /// 
        /// *   Pending: The SNAT entry is being created or modified.
        /// *   Available: The SNAT entry is available.
        /// *   Deleting: The SNAT entry is being deleted.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The type of the NAT. Valid values: 
        /// 
        /// - Empty: symmetric NAT.
        /// 
        /// - FullCone: full cone NAT.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
