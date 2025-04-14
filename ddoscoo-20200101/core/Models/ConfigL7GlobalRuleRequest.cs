// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigL7GlobalRuleRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;RuleId\&quot;:\&quot;global_01\&quot;,\&quot;Action\&quot;:\&quot;block\&quot;,\&quot;Enabled\&quot;:0}]</para>
        /// </summary>
        [NameInMap("RuleAttr")]
        [Validation(Required=false)]
        public string RuleAttr { get; set; }

    }

}
