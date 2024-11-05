// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyAuditPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The request source for the audit log feature. Set the value to <b>Console</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Console</para>
        /// </summary>
        [NameInMap("AuditLogSwitchSource")]
        [Validation(Required=false)]
        public string AuditLogSwitchSource { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the audit log feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enable</b></description></item>
        /// <item><description><b>disabled</b></description></item>
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
        /// <para>The type of the audit log feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Trail</b>: free trial edition.</description></item>
        /// <item><description><b>Standard</b>: official edition.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is <b>Trail</b>. Starting from January 6, 2022, the official edition of the audit log feature has been launched in all regions, and the free trial edition of the feature can no longer be applied for. We recommend that you set this parameter to <b>Standard</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The log retention period. Valid values: 1 to 365 days. Default value: 30 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("StoragePeriod")]
        [Validation(Required=false)]
        public int? StoragePeriod { get; set; }

    }

}
