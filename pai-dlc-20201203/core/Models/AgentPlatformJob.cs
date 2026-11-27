// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class AgentPlatformJob : TeaModel {
        /// <summary>
        /// <para>The ID of the AP task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-job-example</para>
        /// </summary>
        [NameInMap("AgentJobId")]
        [Validation(Required=false)]
        public string AgentJobId { get; set; }

        /// <summary>
        /// <para>The attempt number of the current task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Attempt")]
        [Validation(Required=false)]
        public long? Attempt { get; set; }

        /// <summary>
        /// <para>The creation time in UTC RFC3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-30T06:00:00Z</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The execution duration of the current attempt in milliseconds. This value is returned only when the task is in a terminal state and both the completion time and execution duration are valid. Otherwise, null is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1250</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("DurationMs")]
        [Validation(Required=false)]
        public long? DurationMs { get; set; }

        /// <summary>
        /// <para>The completion time in UTC RFC3339 format. Returns null if the task is not in a terminal state or the completion time is invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-30T06:00:01.250Z</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("FinishedAt")]
        [Validation(Required=false)]
        public string FinishedAt { get; set; }

        /// <summary>
        /// <para>The ID of the AP task instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sample-001</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the DLC job to which the task belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc5yfk7eyg95lac</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The sandbox ID of the current attempt. Returns null if no matching information is found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sandbox-example</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("SandboxId")]
        [Validation(Required=false)]
        public string SandboxId { get; set; }

        /// <summary>
        /// <para>The sandbox resource summary of the current attempt. Returns null if no matching information is found.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("SandboxInfo")]
        [Validation(Required=false)]
        public AgentSandboxInfo SandboxInfo { get; set; }

        /// <summary>
        /// <para>The status of the AP task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The AP task tags, returned in the original content and order. Returns [] if the value is missing, null, or an empty array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;scenario:swe&quot;]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <para>The name of the AP template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>swe-bench</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

    }

}
