// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicTemplate : TeaModel {
        /// <summary>
        /// <para>The creation time of the template, in UTC and formatted as RFC 3339.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-20T08:30:00Z</para>
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The template name, which is unique within the same team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python-data-analysis</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group to which the team belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-****</para>
        /// </summary>
        [NameInMap("resourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        /// <summary>
        /// <para>The runtime configuration of the template, which determines the specifications and environment of sandbox instances created from this template.</para>
        /// </summary>
        [NameInMap("runtimeConfig")]
        [Validation(Required=false)]
        public PublicTemplateRuntimeConfig RuntimeConfig { get; set; }

        /// <summary>
        /// <para>The current status of the template.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public PublicTemplateStatus Status { get; set; }

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
        /// <para>The sandbox template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tm-8f3a2c7b5e14d806</para>
        /// </summary>
        [NameInMap("templateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

    }

}
