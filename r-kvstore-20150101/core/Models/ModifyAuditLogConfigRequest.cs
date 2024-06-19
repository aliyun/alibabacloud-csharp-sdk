// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyAuditLogConfigRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the audit log feature. Default value: true. Valid values:
        /// 
        /// *   **true**: enables the audit log feature.
        /// *   **false**: disables the audit log feature.
        /// 
        /// > If the instance uses the [cluster architecture](https://help.aliyun.com/document_detail/52228.html) or [read/write splitting architecture](https://help.aliyun.com/document_detail/62870.html), the audit log feature is enabled or disabled for both the data nodes and proxy nodes. You cannot separately enable the audit log feature for the data nodes or proxy nodes.
        /// </summary>
        [NameInMap("DbAudit")]
        [Validation(Required=false)]
        public bool? DbAudit { get; set; }

        /// <summary>
        /// The ID of the instance. You can call the [DescribeInstances](https://help.aliyun.com/document_detail/60933.html) operation to query the ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The retention period of audit logs. Valid values: **1** to **365**. Unit: days.
        /// 
        /// > *   This parameter is required only if the **DbAudit** parameter is set to **true**.
        /// > *   The value of this parameter takes effect for all ApsaraDB for Redis instances in the current region.
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public int? Retention { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
