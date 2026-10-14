// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigL7GlobalRuleRequest : TeaModel {
        /// <summary>
        /// <para>The domain name of the website service to configure.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The action and switch settings for global template rules. The value is a string converted from a JSON struct array. The JSON struct contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>RuleId</b>: String | Required | The rule ID.</description></item>
        /// <item><description><b>Action</b>: String | Required | The rule action. Valid values:<list type="bullet">
        /// <item><description><b>block</b>: Block.</description></item>
        /// <item><description><b>watch</b>: Monitor.</description></item>
        /// <item><description><b>challenge</b>: JavaScript Challenge.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Enabled</b>: Integer | Required | The rule switch. Valid values:<list type="bullet">
        /// <item><description><b>1</b>: enables the rule.</description></item>
        /// <item><description><b>0</b>: disables the rule.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
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
