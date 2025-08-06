// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class CapacityLock : TeaModel {
        [NameInMap("availableCount")]
        [Validation(Required=false)]
        public int? AvailableCount { get; set; }

        [NameInMap("crsReservationId")]
        [Validation(Required=false)]
        public string CrsReservationId { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("gmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("lastReconcileAttemptTime")]
        [Validation(Required=false)]
        public string LastReconcileAttemptTime { get; set; }

        [NameInMap("lastSyncTime")]
        [Validation(Required=false)]
        public string LastSyncTime { get; set; }

        [NameInMap("lockProvider")]
        [Validation(Required=false)]
        public string LockProvider { get; set; }

        [NameInMap("lockedCount")]
        [Validation(Required=false)]
        public int? LockedCount { get; set; }

        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("privatePoolId")]
        [Validation(Required=false)]
        public string PrivatePoolId { get; set; }

        [NameInMap("requestedCount")]
        [Validation(Required=false)]
        public int? RequestedCount { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("usedCount")]
        [Validation(Required=false)]
        public int? UsedCount { get; set; }

        [NameInMap("zoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
