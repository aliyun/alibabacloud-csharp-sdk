// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeAuditLogConfigResponseBody : TeaModel {
        /// <summary>
        /// The ID of the instance. You can call the [DescribeInstances](~~60933~~) operation to query the ID of the instance.
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
        /// Indicates whether the audit log feature is enabled. Valid values:
        /// 
        /// *   **true**: The audit log feature is enabled.
        /// *   **false**: The audit log feature is disabled.
        /// 
        /// >  You can call the [ModifyAuditLogConfig](~~130206~~) operation to enable or disable the audit log feature for an ApsaraDB for Redis instance.
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public string Retention { get; set; }

    }

}
