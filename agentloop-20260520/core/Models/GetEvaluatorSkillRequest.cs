// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetEvaluatorSkillRequest : TeaModel {
        /// <summary>
        /// <para>The name of the AgentSpace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod-agentspace</para>
        /// </summary>
        [NameInMap("agentSpace")]
        [Validation(Required=false)]
        public string AgentSpace { get; set; }

        /// <summary>
        /// <para>The version number of the custom evaluator to which the queried skill belongs. If omitted, the latestVersion of the evaluator is used. The revision number of the skill itself is specified by version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("evaluatorVersion")]
        [Validation(Required=false)]
        public string EvaluatorVersion { get; set; }

        /// <summary>
        /// <para>The version of the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1782816000000</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
