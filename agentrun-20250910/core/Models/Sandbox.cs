// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class Sandbox : TeaModel {
        /// <summary>
        /// <para>沙箱创建时间</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-11-26T10:54:17.770719+08:00</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-11-26T10:54:17.770719+08:00</para>
        /// </summary>
        [NameInMap("endedAt")]
        [Validation(Required=false)]
        public string EndedAt { get; set; }

        /// <summary>
        /// <para>最后更新时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-11-26T10:54:17.770719+08:00</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:ram::1760720386195983:role/aliyunfcdefaultrole</para>
        /// </summary>
        [NameInMap("sandboxArn")]
        [Validation(Required=false)]
        public string SandboxArn { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01KAWBP6JQD0J3Z34BP4WMX1KG</para>
        /// </summary>
        [NameInMap("sandboxId")]
        [Validation(Required=false)]
        public string SandboxId { get; set; }

        [NameInMap("sandboxIdleTTLInSeconds")]
        [Validation(Required=false)]
        public int? SandboxIdleTTLInSeconds { get; set; }

        /// <summary>
        /// <para>沙箱空闲超时时间（秒）</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("sandboxIdleTimeoutSeconds")]
        [Validation(Required=false)]
        public int? SandboxIdleTimeoutSeconds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8d409d30-cac1-445a-95d5-476c47780336.schema</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-template</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
