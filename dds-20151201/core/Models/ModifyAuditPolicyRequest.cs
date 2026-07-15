// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyAuditPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The source of the request. Set this parameter to <b>Console</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Console</para>
        /// </summary>
        [NameInMap("AuditLogSwitchSource")]
        [Validation(Required=false)]
        public string AuditLogSwitchSource { get; set; }

        /// <summary>
        /// <para>The status of the audit log. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>enable</b>: Enables the audit log feature.</para>
        /// </description></item>
        /// <item><description><para><b>disabled</b>: Disables the audit log feature.</para>
        /// </description></item>
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
        /// <para>This parameter is effective only for the <b>V2_Standard</b> (DAS Enterprise Edition (NoSQL Compatible) audit log) edition. It specifies the hot storage duration for the audit log. Valid values: 0 to 7. Unit: days.</para>
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
        /// <para>The edition of the audit log. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Trial</b>: Trial Edition.</para>
        /// </description></item>
        /// <item><description><para><b>Standard</b>: Standard Edition.</para>
        /// </description></item>
        /// <item><description><para><b>V2_Standard</b>: DAS Enterprise Edition (NoSQL Compatible) audit log.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The default value of this parameter is <b>Trial</b>. Starting from January 6, 2022, the Standard edition is being rolled out across regions, and new applications for the Trial edition are no longer accepted.</para>
        /// </description></item>
        /// <item><description><para>Starting from February 2026, the DAS Enterprise Edition (NoSQL Compatible) audit log will be rolled out across regions, and new applications for the Standard edition will no longer be accepted.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>For the <b>Standard</b> edition, this parameter specifies the retention period for the audit log. Valid values: 1 to 365. The default value is 30. Unit: days.</para>
        /// </description></item>
        /// <item><description><para>For the <b>V2_Standard</b> (DAS Enterprise Edition (NoSQL Compatible) audit log) edition, this parameter specifies the cold storage duration for the audit log. Valid values: 30, 180, 365, 1095, and 1825. Unit: days.</para>
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
