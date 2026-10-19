// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyAuditPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The source of the audit log request. Valid value: <b>Console</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Console</para>
        /// </summary>
        [NameInMap("AuditLogSwitchSource")]
        [Validation(Required=false)]
        public string AuditLogSwitchSource { get; set; }

        /// <summary>
        /// <para>The status of audit logging. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enable</b>: Enables audit logging.</description></item>
        /// <item><description><b>disabled</b>: Disables audit logging.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public string AuditStatus { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp1785659e3f****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>This parameter takes effect only in the V2_Standard edition (DAS Enterprise Edition NoSQL-compatible audit logs) and specifies the hot storage duration of audit logs. Valid values: 0 to 7. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("HotStoragePeriod")]
        [Validation(Required=false)]
        public int? HotStoragePeriod { get; set; }

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
        /// <para>The edition of audit logging. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Trial</b>: Free Trial edition.</description></item>
        /// <item><description><b>Standard</b>: Standard edition.</description></item>
        /// <item><description><b>V2_Standard</b>: DAS Enterprise Edition (NoSQL-compatible) audit logs.<remarks>
        /// <list type="bullet">
        /// <item><description>The default value is <b>Trial</b>. Starting from January 6, 2022, the Standard edition of audit logs is gradually rolled out across regions, and applications for the Free Trial edition are no longer accepted.</description></item>
        /// <item><description>Starting from February 2026, DAS Enterprise Edition (NoSQL-compatible) audit logs are gradually rolled out across regions, and applications for the Standard edition are no longer accepted.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>In the Standard edition, this parameter specifies the retention period of audit logs. Valid values: 1 to 365. Default value: 30. Unit: days.</para>
        /// </description></item>
        /// <item><description><para>In the V2_Standard edition (DAS Enterprise Edition NoSQL-compatible audit logs), this parameter specifies the cold storage duration of audit logs. Valid values: 30, 180, 365, 1095, and 1825. Unit: days.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("StoragePeriod")]
        [Validation(Required=false)]
        public int? StoragePeriod { get; set; }

    }

}
