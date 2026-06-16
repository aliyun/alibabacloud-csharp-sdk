// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateBrowserInput : TeaModel {
        /// <summary>
        /// <para>The name of the browser.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-browser</para>
        /// </summary>
        [NameInMap("browserName")]
        [Validation(Required=false)]
        public string BrowserName { get; set; }

        /// <summary>
        /// <para>The CPU cores to allocate to the browser instance.</para>
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
        /// <para>A description of the browser instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Web automation browser for testing</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ARN of the execution role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1760720386195983:role/BrowserExecutionRole</para>
        /// </summary>
        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// <para>The memory (in MB) to allocate to the browser instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The network configuration for the browser instance.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// <para>The idle time in seconds before a session expires. When a session is idle, the instance enters an idle billing mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("sessionIdleTimeoutSeconds")]
        [Validation(Required=false)]
        public int? SessionIdleTimeoutSeconds { get; set; }

    }

}
