// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UpdateRuleToSchemeRequest : TeaModel {
        /// <summary>
        /// <para>Workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1232927</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>Request JSON. For details, see the request parameter description below.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;schemeId&quot;:&quot;10&quot;,&quot;schemeRules&quot;:[{&quot;ruleId&quot;:229,&quot;checkType&quot;:0}]}</para>
        /// </summary>
        [NameInMap("jsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
