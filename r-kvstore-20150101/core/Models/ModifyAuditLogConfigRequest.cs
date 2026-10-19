// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyAuditLogConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable audit logging. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the instance uses the <a href="https://help.aliyun.com/document_detail/52228.html">cluster architecture</a> or <a href="https://help.aliyun.com/document_detail/62870.html">read/write splitting architecture</a>, audit logs for data nodes and proxy nodes are enabled or disabled at the same time. You cannot enable them separately.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DbAudit")]
        [Validation(Required=false)]
        public bool? DbAudit { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call <a href="https://help.aliyun.com/document_detail/473778.html">DescribeInstances</a> to query the instance ID.</para>
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
        /// <para>The number of days for which audit logs are retained. Valid values: <b>1</b> to <b>365</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when <b>DbAudit</b> is set to <b>true</b>.</description></item>
        /// <item><description>This parameter takes effect on all instances in the current region.</description></item>
        /// </list>
        /// </remarks>
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
