// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCommonSwitchConfigRequest : TeaModel {
        /// <summary>
        /// <para>The type of the common switch.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListClientUserDefineRules~~">ListClientUserDefineRules</a> or <a href="~~ListSystemClientRules~~">ListSystemClientRules</a> operation to obtain the switch type from the response parameter SwitchId.</para>
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
