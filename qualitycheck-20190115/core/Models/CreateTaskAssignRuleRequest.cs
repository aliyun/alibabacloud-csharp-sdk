// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class CreateTaskAssignRuleRequest : TeaModel {
        /// <summary>
        /// <para>Workspace ID.</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>A complete JSON string. For details, see the parameter descriptions below.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;callType&quot;:&quot;0&quot;,&quot;durationMin&quot;:1,&quot;durationMax&quot;:300,&quot;agents&quot;:[{&quot;agentId&quot;:&quot;202526561358712105&quot;,&quot;agentName&quot;:&quot;agent&quot;}],&quot;rules&quot;:[{&quot;rid&quot;:15659}],&quot;reviewers&quot;:[{&quot;reviewerId&quot;:&quot;255746168704895558&quot;,&quot;reviewerName&quot;:&quot;0917质检员&quot;},{&quot;reviewerId&quot;:&quot;268370362815185444&quot;,&quot;reviewerName&quot;:&quot;0710质检员&quot;}],&quot;skillGroups&quot;:[{&quot;skillName&quot;:&quot;客服组&quot;}],&quot;priority&quot;:5}</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
