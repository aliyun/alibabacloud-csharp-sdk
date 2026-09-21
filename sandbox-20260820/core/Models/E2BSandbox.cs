// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class E2BSandbox : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>sbx-xxxx.ap-southeast-1.sandbox.aliyun.com</para>
        /// </summary>
        [NameInMap("accessEndpoint")]
        [Validation(Required=false)]
        public string AccessEndpoint { get; set; }

        [NameInMap("allowInternetAccess")]
        [Validation(Required=false)]
        public bool? AllowInternetAccess { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("cpuCount")]
        [Validation(Required=false)]
        public int? CpuCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("diskSizeMB")]
        [Validation(Required=false)]
        public int? DiskSizeMB { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ap-southeast-1.sandbox.aliyun.com</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-09-04T02:03:43.826Z</para>
        /// </summary>
        [NameInMap("endAt")]
        [Validation(Required=false)]
        public string EndAt { get; set; }

        [NameInMap("envVars")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvVars { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4b1e9d07-****</para>
        /// </summary>
        [NameInMap("envdAccessToken")]
        [Validation(Required=false)]
        public string EnvdAccessToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>template-d391c80b5d1527de</para>
        /// </summary>
        [NameInMap("fcFunctionName")]
        [Validation(Required=false)]
        public string FcFunctionName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c-6a9d1501-133e6f48-b3f07782dd47</para>
        /// </summary>
        [NameInMap("fcInstanceID")]
        [Validation(Required=false)]
        public string FcInstanceID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3a7ecd09-****</para>
        /// </summary>
        [NameInMap("fcSessionID")]
        [Validation(Required=false)]
        public string FcSessionID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("generation")]
        [Validation(Required=false)]
        public int? Generation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("memoryMB")]
        [Validation(Required=false)]
        public int? MemoryMB { get; set; }

        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, string> Metadata { get; set; }

        [NameInMap("network")]
        [Validation(Required=false)]
        public E2BNetwork Network { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-****</para>
        /// </summary>
        [NameInMap("resourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        [NameInMap("runtime")]
        [Validation(Required=false)]
        public InnerSandboxRuntimeConfig Runtime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sbx-xxxx</para>
        /// </summary>
        [NameInMap("sandboxID")]
        [Validation(Required=false)]
        public string SandboxID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-09-04T02:02:43.826Z</para>
        /// </summary>
        [NameInMap("startedAt")]
        [Validation(Required=false)]
        public string StartedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eea033af-****</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("teamName")]
        [Validation(Required=false)]
        public string TeamName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eco</para>
        /// </summary>
        [NameInMap("teamPlan")]
        [Validation(Required=false)]
        public string TeamPlan { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>v9vjyzw64bsu83vw0dgs</para>
        /// </summary>
        [NameInMap("templateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>base</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000****</para>
        /// </summary>
        [NameInMap("userID")]
        [Validation(Required=false)]
        public string UserID { get; set; }

        [NameInMap("volumeMounts")]
        [Validation(Required=false)]
        public InnerSandboxVolumeMount VolumeMounts { get; set; }

    }

}
