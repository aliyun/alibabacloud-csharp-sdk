// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class E2BSandbox : TeaModel {
        /// <summary>
        /// <para>The access endpoint of the sandbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://8000-sandbox-id.example.com">https://8000-sandbox-id.example.com</a></para>
        /// </summary>
        [NameInMap("accessEndpoint")]
        [Validation(Required=false)]
        public string AccessEndpoint { get; set; }

        /// <summary>
        /// <para>The number of CPU cores used by the sandbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cpuCount")]
        [Validation(Required=false)]
        public int? CpuCount { get; set; }

        /// <summary>
        /// <para>The disk size of the sandbox, in MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("diskSizeMB")]
        [Validation(Required=false)]
        public int? DiskSizeMB { get; set; }

        /// <summary>
        /// <para>The domain name used to access the sandbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para>your-sandbox-domain</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The end time of the sandbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T01:00:00Z</para>
        /// </summary>
        [NameInMap("endAt")]
        [Validation(Required=false)]
        public string EndAt { get; set; }

        /// <summary>
        /// <para>The name of the Function Compute function corresponding to the sandbox.</para>
        /// </summary>
        [NameInMap("fcFunctionName")]
        [Validation(Required=false)]
        public string FcFunctionName { get; set; }

        /// <summary>
        /// <para>The ID of the Function Compute instance corresponding to the sandbox.</para>
        /// </summary>
        [NameInMap("fcInstanceID")]
        [Validation(Required=false)]
        public string FcInstanceID { get; set; }

        /// <summary>
        /// <para>The ID of the Function Compute session corresponding to the sandbox.</para>
        /// </summary>
        [NameInMap("fcSessionID")]
        [Validation(Required=false)]
        public string FcSessionID { get; set; }

        /// <summary>
        /// <para>The memory size of the sandbox, in MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("memoryMB")]
        [Validation(Required=false)]
        public int? MemoryMB { get; set; }

        /// <summary>
        /// <para>The custom metadata of the sandbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;team&quot;:&quot;data&quot;}</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the sandbox belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmwxqyrgwabcd</para>
        /// </summary>
        [NameInMap("resourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        /// <summary>
        /// <para>The ID of the sandbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sbx-xxx</para>
        /// </summary>
        [NameInMap("sandboxID")]
        [Validation(Required=false)]
        public string SandboxID { get; set; }

        /// <summary>
        /// <para>The start time of the sandbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("startedAt")]
        [Validation(Required=false)]
        public string StartedAt { get; set; }

        /// <summary>
        /// <para>The current state of the sandbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The unique identifier of the team to which the sandbox belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88a4c762-b0ce-4661-9413-578b2309e60f</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        /// <summary>
        /// <para>The name of the team to which the sandbox belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-team</para>
        /// </summary>
        [NameInMap("teamName")]
        [Validation(Required=false)]
        public string TeamName { get; set; }

        /// <summary>
        /// <para>The plan of the team to which the sandbox belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pro</para>
        /// </summary>
        [NameInMap("teamPlan")]
        [Validation(Required=false)]
        public string TeamPlan { get; set; }

        /// <summary>
        /// <para>The ID of the template used to create the sandbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para>your-template-id</para>
        /// </summary>
        [NameInMap("templateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

        /// <summary>
        /// <para>The name of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-template</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The ID of the user who created the sandbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("userID")]
        [Validation(Required=false)]
        public string UserID { get; set; }

    }

}
