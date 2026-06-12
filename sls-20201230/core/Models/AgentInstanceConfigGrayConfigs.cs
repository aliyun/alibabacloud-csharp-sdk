// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class AgentInstanceConfigGrayConfigs : TeaModel {
        /// <summary>
        /// <para>The matching rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>appVersion=&quot;1.0.0&quot;</para>
        /// </summary>
        [NameInMap("condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        /// <summary>
        /// <para>The content of the canary release configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enable&quot;:true}</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

    }

}
