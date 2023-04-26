// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAuditSecurityIpResponseBody : TeaModel {
        /// <summary>
        /// The name of the review security group.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("SecurityIpList")]
        [Validation(Required=false)]
        public List<ListAuditSecurityIpResponseBodySecurityIpList> SecurityIpList { get; set; }
        public class ListAuditSecurityIpResponseBodySecurityIpList : TeaModel {
            /// <summary>
            /// The operation that you want to perform. Set the value to **ListAuditSecurityIp**.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// Queries the IP addresses in a review security group.
            /// </summary>
            [NameInMap("Ips")]
            [Validation(Required=false)]
            public string Ips { get; set; }

            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            [NameInMap("SecurityGroupName")]
            [Validation(Required=false)]
            public string SecurityGroupName { get; set; }

        }

    }

}
