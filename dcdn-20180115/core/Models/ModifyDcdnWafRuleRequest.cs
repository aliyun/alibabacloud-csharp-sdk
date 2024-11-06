// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class ModifyDcdnWafRuleRequest : TeaModel {
        /// <summary>
        /// <para>The new configurations of the protection rule.</para>
        /// <remarks>
        /// <para>After you modify the configurations of the protection rule, the previous configurations are overwritten.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;origin\&quot;:\&quot;custom\&quot;,\&quot;conditions\&quot;:[{\&quot;opValue\&quot;:\&quot;eq\&quot;,\&quot;key\&quot;:\&quot;URL\&quot;,\&quot;values\&quot;:\&quot;/example\&quot;},{\&quot;opValue\&quot;:\&quot;eq\&quot;,\&quot;key\&quot;:\&quot;Header\&quot;,\&quot;values\&quot;:\&quot;3333\&quot;,\&quot;subKey\&quot;:\&quot;trt\&quot;}],\&quot;actionExternal\&quot;:{},\&quot;action\&quot;:\&quot;monitor\&quot;,\&quot;ccStatus\&quot;:1,\&quot;ratelimit\&quot;:{\&quot;target\&quot;:\&quot;remote_addr\&quot;,\&quot;interval\&quot;:\&quot;5\&quot;,\&quot;threshold\&quot;:\&quot;2\&quot;,\&quot;effect\&quot;:\&quot;rule\&quot;,\&quot;status\&quot;:{\&quot;code\&quot;:\&quot;404\&quot;,\&quot;count\&quot;:\&quot;2\&quot;},\&quot;ttl\&quot;:\&quot;1800\&quot;}}\&quot;</para>
        /// </summary>
        [NameInMap("RuleConfig")]
        [Validation(Required=false)]
        public string RuleConfig { get; set; }

        /// <summary>
        /// <para>The ID of the protection rule. You can specify only one ID in each request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200001</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The new name of the protection rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The new status of the protection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("RuleStatus")]
        [Validation(Required=false)]
        public string RuleStatus { get; set; }

    }

}
