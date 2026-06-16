// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class Browser : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the browser.</para>
        /// 
        /// <b>Example:</b>
        /// <para>browser-1234567890abcdef</para>
        /// </summary>
        [NameInMap("browserId")]
        [Validation(Required=false)]
        public string BrowserId { get; set; }

        /// <summary>
        /// <para>The name of the browser.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-browser</para>
        /// </summary>
        [NameInMap("browserName")]
        [Validation(Required=false)]
        public string BrowserName { get; set; }

        /// <summary>
        /// <para>The number of CPU cores allocated to the browser.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>The time the browser was created, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T10:30:00Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The unique identifier for the credential associated with the browser.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cred-1234567890abcdef</para>
        /// </summary>
        [NameInMap("credentialId")]
        [Validation(Required=false)]
        public string CredentialId { get; set; }

        /// <summary>
        /// <para>A user-defined description for the browser.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Web automation browser for testing</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the execution role used by the browser.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1760720386195983:role/BrowserExecutionRole</para>
        /// </summary>
        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// <para>The time the browser was last updated, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T11:45:00Z</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <para>The memory allocated to the browser, in megabytes (MB).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The network configuration for the browser.</para>
        /// </summary>
        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// <para>The recording configuration for the browser.</para>
        /// </summary>
        [NameInMap("recording")]
        [Validation(Required=false)]
        public BrowserRecordingConfiguration Recording { get; set; }

        /// <summary>
        /// <para>The current status of the browser.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The reason for the current status, if any.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Browser is ready for use</para>
        /// </summary>
        [NameInMap("statusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// <para>The unique identifier of the tenant that owns the browser.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tenant-1234567890abcdef</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
