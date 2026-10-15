// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class E2BListedTemplate : TeaModel {
        /// <summary>
        /// <para>The template build status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>waiting: Waiting to build.</description></item>
        /// <item><description>building: Building.</description></item>
        /// <item><description>ready: Build succeeded.</description></item>
        /// <item><description>error: Build failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ready</para>
        /// </summary>
        [NameInMap("buildStatus")]
        [Validation(Required=false)]
        public string BuildStatus { get; set; }

        /// <summary>
        /// <para>The template category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>builtin: A system built-in template.</description></item>
        /// <item><description>custom: A user-created template.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The container image configuration of the template.</para>
        /// </summary>
        [NameInMap("containerConfiguration")]
        [Validation(Required=false)]
        public ContainerConfiguration ContainerConfiguration { get; set; }

        /// <summary>
        /// <para>The CPU specification of the sandbox instance, in cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("cpuCount")]
        [Validation(Required=false)]
        public int? CpuCount { get; set; }

        /// <summary>
        /// <para>The creation time in UTC, in RFC 3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-20T08:30:00Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The Function Compute function name that the template currently points to. This value is empty when the template is in a failed state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sandbox-tm-8f3a2c7b5e14d806</para>
        /// </summary>
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// <para>The log delivery configuration of the template.</para>
        /// </summary>
        [NameInMap("logConfiguration")]
        [Validation(Required=false)]
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// <para>The memory specification of the sandbox instance, in MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("memoryMB")]
        [Validation(Required=false)]
        public int? MemoryMB { get; set; }

        /// <summary>
        /// <para>The list of template names, including the template name and all its aliases.</para>
        /// </summary>
        [NameInMap("names")]
        [Validation(Required=false)]
        public List<string> Names { get; set; }

        /// <summary>
        /// <para>Indicates whether the template is public to all teams.</para>
        /// </summary>
        [NameInMap("public")]
        [Validation(Required=false)]
        public bool? Public { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud resource group ID to which the team belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-****</para>
        /// </summary>
        [NameInMap("resourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        /// <summary>
        /// <para>The desensitized description of the reason why the template build failed. This value is empty when the build succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Failed to pull the source image: invalid authentication credentials</para>
        /// </summary>
        [NameInMap("statusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// <para>The list of template labels. Each label points to a specific build.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<E2BTemplateTag> Tags { get; set; }

        /// <summary>
        /// <para>The ID of the team to which the resource belongs, in UUID format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5f4a2c18-****</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        /// <summary>
        /// <para>The team name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sandbox-dev</para>
        /// </summary>
        [NameInMap("teamName")]
        [Validation(Required=false)]
        public string TeamName { get; set; }

        /// <summary>
        /// <para>The team plan specification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>eco: economy.</description></item>
        /// <item><description>std: standard.</description></item>
        /// <item><description>pro: professional.</description></item>
        /// <item><description>ent: enterprise.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>std</para>
        /// </summary>
        [NameInMap("teamPlan")]
        [Validation(Required=false)]
        public string TeamPlan { get; set; }

        /// <summary>
        /// <para>The sandbox template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tm-8f3a2c7b5e14d806</para>
        /// </summary>
        [NameInMap("templateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

        /// <summary>
        /// <para>The last update time in UTC, in RFC 3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-21T09:15:30Z</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <para>The user ID of the resource creator, in UUID format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9c1d4e72-****</para>
        /// </summary>
        [NameInMap("userID")]
        [Validation(Required=false)]
        public string UserID { get; set; }

    }

}
