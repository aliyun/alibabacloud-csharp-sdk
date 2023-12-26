// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeNfsAclResponseBody : TeaModel {
        /// <summary>
        /// The information about the ACL feature.
        /// </summary>
        [NameInMap("Acl")]
        [Validation(Required=false)]
        public DescribeNfsAclResponseBodyAcl Acl { get; set; }
        public class DescribeNfsAclResponseBodyAcl : TeaModel {
            /// <summary>
            /// Indicates whether the NFS ACL feature is enabled.
            /// 
            /// *   true: The NFS ACL feature is enabled.
            /// *   false: The NFS ACL feature is disabled.
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
