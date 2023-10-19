// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeIpControlsRequest : TeaModel {
        [NameInMap("IpControlId")]
        [Validation(Required=false)]
        public string IpControlId { get; set; }

        [NameInMap("IpControlName")]
        [Validation(Required=false)]
        public string IpControlName { get; set; }

        /// <summary>
        /// The name of the ACL.
        /// </summary>
        [NameInMap("IpControlType")]
        [Validation(Required=false)]
        public string IpControlType { get; set; }

        /// <summary>
        /// ACLtest
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The type of the ACL. Valid values:
        /// 
        /// *   **ALLOW**: an IP address whitelist
        /// *   **REFUSE**: an IP address blacklist
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
