// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class E2BListedSandbox : TeaModel {
        /// <summary>
        /// <para>The number of vCPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("cpuCount")]
        [Validation(Required=false)]
        public int? CpuCount { get; set; }

        /// <summary>
        /// <para>The temporary disk specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("diskSizeMB")]
        [Validation(Required=false)]
        public int? DiskSizeMB { get; set; }

        /// <summary>
        /// <para>The end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-03T02:06:37.932Z</para>
        /// </summary>
        [NameInMap("endAt")]
        [Validation(Required=false)]
        public string EndAt { get; set; }

        /// <summary>
        /// <para>The sandbox version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("generation")]
        [Validation(Required=false)]
        public int? Generation { get; set; }

        /// <summary>
        /// <para>The memory specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("memoryMB")]
        [Validation(Required=false)]
        public int? MemoryMB { get; set; }

        /// <summary>
        /// <para>The metadata.</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-****</para>
        /// </summary>
        [NameInMap("resourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        /// <summary>
        /// <para>The sandbox ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sbx-xxxx</para>
        /// </summary>
        [NameInMap("sandboxID")]
        [Validation(Required=false)]
        public string SandboxID { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-03T02:05:37.932Z</para>
        /// </summary>
        [NameInMap("startedAt")]
        [Validation(Required=false)]
        public string StartedAt { get; set; }

        /// <summary>
        /// <para>The sandbox status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>running: Running.</description></item>
        /// <item><description>pausing: Being paused.</description></item>
        /// <item><description>paused: Paused.</description></item>
        /// <item><description>resuming: Being resumed.</description></item>
        /// <item><description>pause_fail: Failed to pause.</description></item>
        /// <item><description>resume_fail: Failed to resume.</description></item>
        /// <item><description>snapshotting: Creating a snapshot.</description></item>
        /// <item><description>snapshot_failed: Failed to create a snapshot.</description></item>
        /// <item><description>terminated: Terminated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The unique identifier of the team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9f5a1fe9-****</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        /// <summary>
        /// <para>The team name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("teamName")]
        [Validation(Required=false)]
        public string TeamName { get; set; }

        /// <summary>
        /// <para>The QoS version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eco</para>
        /// </summary>
        [NameInMap("teamPlan")]
        [Validation(Required=false)]
        public string TeamPlan { get; set; }

        /// <summary>
        /// <para>The unique identifier of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f1l97phhfw6ox18iwcfk</para>
        /// </summary>
        [NameInMap("templateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

        /// <summary>
        /// <para>The template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The UID of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000****</para>
        /// </summary>
        [NameInMap("userID")]
        [Validation(Required=false)]
        public string UserID { get; set; }

    }

}
