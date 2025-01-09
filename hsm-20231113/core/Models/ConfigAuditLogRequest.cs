// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hsm20231113.Models
{
    public class ConfigAuditLogRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the audit log feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enable</description></item>
        /// <item><description>disable</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("AuditAction")]
        [Validation(Required=false)]
        public string AuditAction { get; set; }

        /// <summary>
        /// <para>The bucket to which audit logs are delivered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hsm-log</para>
        /// </summary>
        [NameInMap("AuditOssBucket")]
        [Validation(Required=false)]
        public string AuditOssBucket { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
