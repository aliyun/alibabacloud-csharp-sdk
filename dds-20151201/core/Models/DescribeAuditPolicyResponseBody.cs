// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAuditPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the audit log.</para>
        /// <list type="bullet">
        /// <item><description><para>Enable: The audit log is enabled.</para>
        /// </description></item>
        /// <item><description><para>Disabled: The audit log is disabled.</para>
        /// </description></item>
        /// </list>
        /// <para>The default value is Disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("LogAuditStatus")]
        [Validation(Required=false)]
        public string LogAuditStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111E7B16-0A87-4CBA-B271-F34AD61E099F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
