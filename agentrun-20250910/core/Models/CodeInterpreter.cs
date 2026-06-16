// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CodeInterpreter : TeaModel {
        /// <summary>
        /// <para>The unique identifier for the CodeInterpreter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ci-1234567890abcdef</para>
        /// </summary>
        [NameInMap("codeInterpreterId")]
        [Validation(Required=false)]
        public string CodeInterpreterId { get; set; }

        /// <summary>
        /// <para>A user-defined name for the CodeInterpreter instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-code-interpreter</para>
        /// </summary>
        [NameInMap("codeInterpreterName")]
        [Validation(Required=false)]
        public string CodeInterpreterName { get; set; }

        /// <summary>
        /// <para>The number of CPU cores allocated to the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>The creation timestamp for the CodeInterpreter, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T10:30:00Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The description of the CodeInterpreter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Python code interpreter for data analysis</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ARN of the execution role for this CodeInterpreter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1760720386195983:role/CodeInterpreterExecutionRole</para>
        /// </summary>
        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// <para>The last update timestamp for the CodeInterpreter, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T11:45:00Z</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <para>The memory allocated to the instance, in MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The network configuration for the CodeInterpreter.</para>
        /// </summary>
        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// <para>The current status of the CodeInterpreter, such as READY or TERMINATED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The reason for the current status, if applicable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Code interpreter is ready for use</para>
        /// </summary>
        [NameInMap("statusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// <para>The unique identifier for the tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tenant-1234567890abcdef</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
