// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateCodeInterpreterInput : TeaModel {
        /// <summary>
        /// <para>The name of the code interpreter. Use this to identify and distinguish code interpreter instances.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-code-interpreter</para>
        /// </summary>
        [NameInMap("codeInterpreterName")]
        [Validation(Required=false)]
        public string CodeInterpreterName { get; set; }

        /// <summary>
        /// <para>The amount of CPU to allocate, in cores.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>The credential ID used for authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cred-1234567890abcdef</para>
        /// </summary>
        [NameInMap("credentialId")]
        [Validation(Required=false)]
        public string CredentialId { get; set; }

        /// <summary>
        /// <para>A description of the code interpreter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Python code interpreter for data analysis</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the execution role for the code interpreter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1760720386195983:role/CodeInterpreterExecutionRole</para>
        /// </summary>
        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// <para>The amount of memory to allocate, in megabytes (MB).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>Specifies the network configuration for the code interpreter, including VPC and security group settings.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// <para>The idle timeout for a session, in seconds. If an instance has no new requests for this duration, its session expires and cannot be reused.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("sessionIdleTimeoutSeconds")]
        [Validation(Required=false)]
        public int? SessionIdleTimeoutSeconds { get; set; }

    }

}
