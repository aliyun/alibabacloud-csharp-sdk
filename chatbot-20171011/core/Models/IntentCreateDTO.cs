// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class IntentCreateDTO : TeaModel {
        [NameInMap("IntentId")]
        [Validation(Required=false)]
        public long? IntentId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RuleCheck")]
        [Validation(Required=false)]
        public List<RuleMtopDTO> RuleCheck { get; set; }

        [NameInMap("Slot")]
        [Validation(Required=false)]
        public List<SlotrecordMtopDTO> Slot { get; set; }

        [NameInMap("UserSay")]
        [Validation(Required=false)]
        public List<UsersayMtopDTO> UserSay { get; set; }

    }

}
