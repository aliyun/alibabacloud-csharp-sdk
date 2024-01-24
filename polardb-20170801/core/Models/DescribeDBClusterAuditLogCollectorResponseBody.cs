// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterAuditLogCollectorResponseBody : TeaModel {
        /// <summary>
        /// The status of SQL collector. Valid values:
        /// 
        /// *   Enable
        /// *   Disabled
        /// </summary>
        [NameInMap("CollectorStatus")]
        [Validation(Required=false)]
        public string CollectorStatus { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
