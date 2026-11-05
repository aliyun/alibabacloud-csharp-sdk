// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCommonSwitchConfigRequest : TeaModel {
        /// <summary>
        /// <para>The general switch type.</para>
        /// <remarks>
        /// <para>You can obtain this parameter from the SwitchId response parameter of the <a href="~~ListClientUserDefineRules~~">ListClientUserDefineRules</a> and <a href="~~ListSystemClientRules~~">ListSystemClientRules</a> operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>USER-DEFINE-RULE-SWITCH-TYPE_180****</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
