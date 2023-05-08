// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeServiceLinkedRoleStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status information about the service-linked role.
        /// </summary>
        [NameInMap("RoleStatus")]
        [Validation(Required=false)]
        public DescribeServiceLinkedRoleStatusResponseBodyRoleStatus RoleStatus { get; set; }
        public class DescribeServiceLinkedRoleStatusResponseBodyRoleStatus : TeaModel {
            /// <summary>
            /// Indicates whether the service-linked role is created. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

    }

}
