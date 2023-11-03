// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateCommonSwitchConfigRequest : TeaModel {
        /// <summary>
        /// Specifies whether to turn on the switch for newly added servers. Valid values:
        /// 
        /// *   **add**: yes
        /// *   **del**: no
        /// </summary>
        [NameInMap("TargetDefault")]
        [Validation(Required=false)]
        public string TargetDefault { get; set; }

        /// <summary>
        /// The type of the switch.
        /// 
        /// >  You can call the [ListClientUserDefineRules](~~ListClientUserDefineRules~~) or [ListSystemClientRules](~~ListSystemClientRules~~) operation to obtain the type from the response parameter SwitchId.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
