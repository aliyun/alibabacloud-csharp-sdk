// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class IntentCreateDTO : TeaModel {
        /// <summary>
        /// IntentId
        /// </summary>
        [NameInMap("IntentId")]
        [Validation(Required=false)]
        public long? IntentId { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// UserSay
        /// </summary>
        [NameInMap("UserSay")]
        [Validation(Required=false)]
        public List<UsersayMtopDTO> UserSay { get; set; }

        /// <summary>
        /// RuleCheck
        /// </summary>
        [NameInMap("RuleCheck")]
        [Validation(Required=false)]
        public List<RuleMtopDTO> RuleCheck { get; set; }

        [NameInMap("Slot")]
        [Validation(Required=false)]
        public List<SlotrecordMtopDTO> Slot { get; set; }

    }

}
