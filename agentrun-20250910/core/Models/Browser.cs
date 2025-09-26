// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class Browser : TeaModel {
        [NameInMap("browserId")]
        [Validation(Required=false)]
        public string BrowserId { get; set; }

        [NameInMap("browserName")]
        [Validation(Required=false)]
        public string BrowserName { get; set; }

        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("credentialId")]
        [Validation(Required=false)]
        public string CredentialId { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <para>内存资源配置（单位：MB）</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        [NameInMap("recording")]
        [Validation(Required=false)]
        public BrowserRecordingConfiguration Recording { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>当前状态的原因说明（如适用）</para>
        /// </summary>
        [NameInMap("statusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
