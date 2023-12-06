// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCommonSwitchConfigRequest : TeaModel {
        /// <summary>
        /// The type of the common switch.
        /// 
        /// >  You can call the [ListClientUserDefineRules](~~ListClientUserDefineRules~~) or [ListSystemClientRules](~~ListSystemClientRules~~) operation to obtain the switch type from the response parameter SwitchId.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
