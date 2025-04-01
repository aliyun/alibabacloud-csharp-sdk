// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyAuditLogConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the audit log feature. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the audit log feature.</description></item>
        /// <item><description><b>false</b>: disables the audit log feature.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the instance uses the <a href="https://help.aliyun.com/document_detail/52228.html">cluster architecture</a> or <a href="https://help.aliyun.com/document_detail/62870.html">read/write splitting architecture</a>, the audit log feature is enabled or disabled for both the data nodes and proxy nodes. You cannot separately enable the audit log feature for the data nodes or proxy nodes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DbAudit")]
        [Validation(Required=false)]
        public bool? DbAudit { get; set; }

        /// <summary>
        /// <para>The ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/473778.html">DescribeInstances</a> operation to query the ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
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
        /// <para>The retention period of audit logs. Valid values: <b>1</b> to <b>365</b>. Unit: days.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required only when the <b>DbAudit</b> parameter is set to <b>true</b>.</para>
        /// </description></item>
        /// <item><description><para>The value of this parameter takes effect for all instances in the current region.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public int? Retention { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
