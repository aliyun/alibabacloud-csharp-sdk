// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeAuditLogConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the audit log feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled</description></item>
        /// <item><description><b>false</b>: disabled</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/473829.html">ModifyAuditLogConfig</a> operation to enable or disable the audit log feature for a Tair (Redis OSS-compatible) instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DbAudit")]
        [Validation(Required=false)]
        public string DbAudit { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2BE6E619-A657-42E3-AD2D-18F8428A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The retention period of audit logs. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public string Retention { get; set; }

    }

}
