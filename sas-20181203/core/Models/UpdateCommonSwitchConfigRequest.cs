// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateCommonSwitchConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the switch takes effect by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>add</b>: Takes effect by default for newly added servers.</description></item>
        /// <item><description><b>del</b>: Does not take effect by default for newly added servers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>add</para>
        /// </summary>
        [NameInMap("TargetDefault")]
        [Validation(Required=false)]
        public string TargetDefault { get; set; }

        /// <summary>
        /// <para>The general switch type.</para>
        /// <remarks>
        /// <para>You can obtain this parameter from the SwitchId response parameter of the <a href="~~ListClientUserDefineRules~~">ListClientUserDefineRules</a> and <a href="~~ListSystemClientRules~~">ListSystemClientRules</a> operations.</para>
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
