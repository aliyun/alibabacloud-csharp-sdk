// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAuditSecurityIpResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the review security group.
        /// </summary>
        [NameInMap("SecurityIpList")]
        [Validation(Required=false)]
        public List<ListAuditSecurityIpResponseBodySecurityIpList> SecurityIpList { get; set; }
        public class ListAuditSecurityIpResponseBodySecurityIpList : TeaModel {
            /// <summary>
            /// The time when the review security group was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The IP addresses in the review security group.
            /// </summary>
            [NameInMap("Ips")]
            [Validation(Required=false)]
            public string Ips { get; set; }

            /// <summary>
            /// The time when the review security group was last modified. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// The name of the review security group.
            /// </summary>
            [NameInMap("SecurityGroupName")]
            [Validation(Required=false)]
            public string SecurityGroupName { get; set; }

        }

    }

}
