// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetLhmAgentStatusRequest : TeaModel {
        /// <summary>
        /// <para>The Agent type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: data validation (the only type currently supported).</description></item>
        /// <item><description>1: metadata.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("agentType")]
        [Validation(Required=false)]
        public int? AgentType { get; set; }

        /// <summary>
        /// <para>The skill name. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lhm-data-validation-skill</para>
        /// </summary>
        [NameInMap("skillName")]
        [Validation(Required=false)]
        public string SkillName { get; set; }

    }

}
