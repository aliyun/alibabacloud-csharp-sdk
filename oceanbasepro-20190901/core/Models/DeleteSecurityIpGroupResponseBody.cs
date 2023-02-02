// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DeleteSecurityIpGroupResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the deleted IP whitelist group.
        /// </summary>
        [NameInMap("SecurityIpGroup")]
        [Validation(Required=false)]
        public DeleteSecurityIpGroupResponseBodySecurityIpGroup SecurityIpGroup { get; set; }
        public class DeleteSecurityIpGroupResponseBodySecurityIpGroup : TeaModel {
            /// <summary>
            /// The ID of the OceanBase cluster.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the deleted IP address whitelist group.
            /// </summary>
            [NameInMap("SecurityIpGroupName")]
            [Validation(Required=false)]
            public string SecurityIpGroupName { get; set; }

        }

    }

}
