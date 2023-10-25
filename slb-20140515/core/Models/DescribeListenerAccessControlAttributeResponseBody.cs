// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeListenerAccessControlAttributeResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the whitelist is enabled. Valid values:
        /// 
        /// *   **open_white_list**: the whitelist is enabled.
        /// *   **close**: the whitelist is disabled.
        /// </summary>
        [NameInMap("AccessControlStatus")]
        [Validation(Required=false)]
        public string AccessControlStatus { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The queried ACLs.
        /// </summary>
        [NameInMap("SourceItems")]
        [Validation(Required=false)]
        public string SourceItems { get; set; }

    }

}
