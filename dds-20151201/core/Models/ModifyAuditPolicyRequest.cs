// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyAuditPolicyRequest : TeaModel {
        /// <summary>
        /// The request source for the audit log feature. Set the value to **Console**.
        /// </summary>
        [NameInMap("AuditLogSwitchSource")]
        [Validation(Required=false)]
        public string AuditLogSwitchSource { get; set; }

        /// <summary>
        /// Specifies whether the audit log feature is enabled. Valid values:
        /// 
        /// *   **enable**
        /// *   **disabled**
        /// </summary>
        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public string AuditStatus { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The type of the audit log feature. Valid values:
        /// 
        /// *   **Trail**: the free trial edition
        /// *   **Standard**: the official edition
        /// 
        /// >  Default value: **Trial**. Starting from January 6, 2022, the official edition of the audit log feature has been launched in all regions, and new applications for the free trial edition have ended. We recommend that you set this parameter to **Standard**.
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// The log retention period. Valid values: 1 to 365 days. Default value: 30 days.
        /// </summary>
        [NameInMap("StoragePeriod")]
        [Validation(Required=false)]
        public int? StoragePeriod { get; set; }

    }

}
