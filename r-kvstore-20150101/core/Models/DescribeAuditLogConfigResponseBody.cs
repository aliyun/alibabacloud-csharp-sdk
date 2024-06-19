// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeAuditLogConfigResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the audit log feature is enabled. Valid values:
        /// 
        /// *   **true**: enabled
        /// *   **false**: disabled
        /// 
        /// > You can call the [ModifyAuditLogConfig](https://help.aliyun.com/document_detail/130206.html) operation to enable or disable the audit log feature for an ApsaraDB for Redis instance.
        /// </summary>
        [NameInMap("DbAudit")]
        [Validation(Required=false)]
        public string DbAudit { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The retention period of audit logs. Unit: days.
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public string Retention { get; set; }

    }

}
