// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class E2BSandbox : TeaModel {
        /// <summary>
        /// <para>The access endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sbx-xxxx.ap-southeast-1.sandbox.aliyun.com</para>
        /// </summary>
        [NameInMap("accessEndpoint")]
        [Validation(Required=false)]
        public string AccessEndpoint { get; set; }

        /// <summary>
        /// <para>Specifies whether the sandbox is allowed to access external networks.</para>
        /// </summary>
        [NameInMap("allowInternetAccess")]
        [Validation(Required=false)]
        public bool? AllowInternetAccess { get; set; }

        /// <summary>
        /// <para>The vCPU specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("cpuCount")]
        [Validation(Required=false)]
        public int? CpuCount { get; set; }

        /// <summary>
        /// <para>The ephemeral disk specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("diskSizeMB")]
        [Validation(Required=false)]
        public int? DiskSizeMB { get; set; }

        /// <summary>
        /// <para>The access domain name of the sandbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-1.sandbox.aliyun.com</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-04T02:03:43.826Z</para>
        /// </summary>
        [NameInMap("endAt")]
        [Validation(Required=false)]
        public string EndAt { get; set; }

        /// <summary>
        /// <para>The environment variables.</para>
        /// </summary>
        [NameInMap("envVars")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvVars { get; set; }

        /// <summary>
        /// <para>The authentication credential for accessing the envd daemon process inside the sandbox, in UUID format. Automatically generated only when secure is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4b1e9d07-****</para>
        /// </summary>
        [NameInMap("envdAccessToken")]
        [Validation(Required=false)]
        public string EnvdAccessToken { get; set; }

        /// <summary>
        /// <para>The Function Compute function name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>template-d391c80b5d1527de</para>
        /// </summary>
        [NameInMap("fcFunctionName")]
        [Validation(Required=false)]
        public string FcFunctionName { get; set; }

        /// <summary>
        /// <para>The Function Compute instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-6a9d1501-133e6f48-b3f07782dd47</para>
        /// </summary>
        [NameInMap("fcInstanceID")]
        [Validation(Required=false)]
        public string FcInstanceID { get; set; }

        /// <summary>
        /// <para>The Function Compute session ID corresponding to the sandbox, in UUID format. Used to locate the underlying session when pausing, resuming, or deleting the sandbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3a7ecd09-****</para>
        /// </summary>
        [NameInMap("fcSessionID")]
        [Validation(Required=false)]
        public string FcSessionID { get; set; }

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
        /// <para>The memory specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("memoryMB")]
        [Validation(Required=false)]
        public int? MemoryMB { get; set; }

        /// <summary>
        /// <para>The metadata configuration.</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// <para>The network configuration.</para>
        /// </summary>
        [NameInMap("network")]
        [Validation(Required=false)]
        public E2BNetwork Network { get; set; }

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
        /// <para>The runtime configuration.</para>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public InnerSandboxRuntimeConfig Runtime { get; set; }

        /// <summary>
        /// <para>The unique identifier of the sandbox.</para>
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
        /// <para>2026-09-04T02:02:43.826Z</para>
        /// </summary>
        [NameInMap("startedAt")]
        [Validation(Required=false)]
        public string StartedAt { get; set; }

        /// <summary>
        /// <para>The sandbox status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>running: Running.</description></item>
        /// <item><description>pausing: Pausing.</description></item>
        /// <item><description>paused: Paused.</description></item>
        /// <item><description>resuming: Resuming.</description></item>
        /// <item><description>pause_fail: Pause failed.</description></item>
        /// <item><description>resume_fail: Resume failed.</description></item>
        /// <item><description>snapshotting: Creating a snapshot.</description></item>
        /// <item><description>snapshot_failed: Snapshot creation failed.</description></item>
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
        /// <para>eea033af-****</para>
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
        /// <para>v9vjyzw64bsu83vw0dgs</para>
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

        /// <summary>
        /// <para>The mount configuration.</para>
        /// </summary>
        [NameInMap("volumeMounts")]
        [Validation(Required=false)]
        public InnerSandboxVolumeMount VolumeMounts { get; set; }

    }

}
