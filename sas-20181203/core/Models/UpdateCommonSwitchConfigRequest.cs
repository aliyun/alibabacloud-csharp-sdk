// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateCommonSwitchConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to turn on the switch for newly added servers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>add</b>: yes</description></item>
        /// <item><description><b>del</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>add</para>
        /// </summary>
        [NameInMap("TargetDefault")]
        [Validation(Required=false)]
        public string TargetDefault { get; set; }

        /// <summary>
        /// <para>The type of the switch.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListClientUserDefineRules~~">ListClientUserDefineRules</a> or <a href="~~ListSystemClientRules~~">ListSystemClientRules</a> operation to obtain the type from the response parameter SwitchId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>USER-DEFINE-RULE-SWITCH-TYPE_190****</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
