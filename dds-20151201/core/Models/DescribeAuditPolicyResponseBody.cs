// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAuditPolicyResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the log audit feature is enabled. Valid values:
        /// 
        /// *   Enable
        /// *   Disabled
        /// 
        /// Default value: Disabled.
        /// </summary>
        [NameInMap("LogAuditStatus")]
        [Validation(Required=false)]
        public string LogAuditStatus { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
