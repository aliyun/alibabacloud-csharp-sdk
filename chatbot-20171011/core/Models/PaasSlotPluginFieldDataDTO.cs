// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class PaasSlotPluginFieldDataDTO : TeaModel {
        [NameInMap("ContentSlot")]
        [Validation(Required=false)]
        public List<PaasSlotConfigDTO> ContentSlot { get; set; }

        [NameInMap("IntentId")]
        [Validation(Required=false)]
        public string IntentId { get; set; }

        [NameInMap("IntentName")]
        [Validation(Required=false)]
        public string IntentName { get; set; }

        [NameInMap("IsSysIntent")]
        [Validation(Required=false)]
        public bool? IsSysIntent { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
