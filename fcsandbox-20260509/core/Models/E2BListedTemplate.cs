// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class E2BListedTemplate : TeaModel {
        /// <summary>
        /// <para>The build status of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ready</para>
        /// </summary>
        [NameInMap("buildStatus")]
        [Validation(Required=false)]
        public string BuildStatus { get; set; }

        /// <summary>
        /// <para>The category of the template.</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The container image configuration of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;image&quot;:&quot;registry.cn-hangzhou.aliyuncs.com/demo/nginx:latest&quot;}</para>
        /// </summary>
        [NameInMap("containerConfiguration")]
        [Validation(Required=false)]
        public ContainerConfiguration ContainerConfiguration { get; set; }

        /// <summary>
        /// <para>The number of CPU cores configured for the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cpuCount")]
        [Validation(Required=false)]
        public int? CpuCount { get; set; }

        /// <summary>
        /// <para>The time when the template was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The name of the Function Compute function corresponding to the template.</para>
        /// </summary>
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// <para>The log configuration of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;project&quot;:&quot;sandbox-project&quot;,&quot;logstore&quot;:&quot;sandbox-logstore&quot;}</para>
        /// </summary>
        [NameInMap("logConfiguration")]
        [Validation(Required=false)]
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// <para>The memory size configured for the template, in MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("memoryMB")]
        [Validation(Required=false)]
        public int? MemoryMB { get; set; }

        /// <summary>
        /// <para>The list of template names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;my-template&quot;]</para>
        /// </summary>
        [NameInMap("names")]
        [Validation(Required=false)]
        public List<string> Names { get; set; }

        /// <summary>
        /// <para>Indicates whether the template is publicly available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("public")]
        [Validation(Required=false)]
        public bool? Public { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the template belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmwxqyrgwabcd</para>
        /// </summary>
        [NameInMap("resourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        /// <summary>
        /// <para>The reason for the build status of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Image pull failed</para>
        /// </summary>
        [NameInMap("statusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// <para>The list of tags for the template.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<E2BTemplateTag> Tags { get; set; }

        /// <summary>
        /// <para>The unique identifier of the team to which the template belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88a4c762-b0ce-4661-9413-578b2309e60f</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        /// <summary>
        /// <para>The name of the team to which the template belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-team</para>
        /// </summary>
        [NameInMap("teamName")]
        [Validation(Required=false)]
        public string TeamName { get; set; }

        /// <summary>
        /// <para>The plan of the team to which the template belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pro</para>
        /// </summary>
        [NameInMap("teamPlan")]
        [Validation(Required=false)]
        public string TeamPlan { get; set; }

        /// <summary>
        /// <para>The unique identifier of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>your-template-id</para>
        /// </summary>
        [NameInMap("templateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

        /// <summary>
        /// <para>The time when the template was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <para>The ID of the user who created the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("userID")]
        [Validation(Required=false)]
        public string UserID { get; set; }

    }

}
