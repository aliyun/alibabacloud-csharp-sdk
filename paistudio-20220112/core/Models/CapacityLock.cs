// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class CapacityLock : TeaModel {
        /// <summary>
        /// <para>The number of available instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("availableCount")]
        [Validation(Required=false)]
        public int? AvailableCount { get; set; }

        /// <summary>
        /// <para>The ID of the capacity reservation.</para>
        /// </summary>
        [NameInMap("crsReservationId")]
        [Validation(Required=false)]
        public string CrsReservationId { get; set; }

        /// <summary>
        /// <para>The description of the capacity reservation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test capacity reservation</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The expiration time of the capacity reservation.</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// </summary>
        [NameInMap("gmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The ID of the capacity reservation lock record.</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ml.gp7vf.16.40xlarge</para>
        /// </summary>
        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The time of the last reconciliation attempt.</para>
        /// </summary>
        [NameInMap("lastReconcileAttemptTime")]
        [Validation(Required=false)]
        public string LastReconcileAttemptTime { get; set; }

        /// <summary>
        /// <para>The last synchronization time.</para>
        /// </summary>
        [NameInMap("lastSyncTime")]
        [Validation(Required=false)]
        public string LastSyncTime { get; set; }

        /// <summary>
        /// <para>The lock service provider.</para>
        /// </summary>
        [NameInMap("lockProvider")]
        [Validation(Required=false)]
        public string LockProvider { get; set; }

        /// <summary>
        /// <para>The number of locked instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("lockedCount")]
        [Validation(Required=false)]
        public int? LockedCount { get; set; }

        /// <summary>
        /// <para>The operator.</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The ID of the private pool.</para>
        /// </summary>
        [NameInMap("privatePoolId")]
        [Validation(Required=false)]
        public string PrivatePoolId { get; set; }

        /// <summary>
        /// <para>The number of requested instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("requestedCount")]
        [Validation(Required=false)]
        public int? RequestedCount { get; set; }

        /// <summary>
        /// <para>The status.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The number of used instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("usedCount")]
        [Validation(Required=false)]
        public int? UsedCount { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu-a</para>
        /// </summary>
        [NameInMap("zoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
