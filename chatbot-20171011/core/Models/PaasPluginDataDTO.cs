// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class PaasPluginDataDTO : TeaModel {
        [NameInMap("Entry")]
        [Validation(Required=false)]
        public PaasEntryDTO Entry { get; set; }

        [NameInMap("Function")]
        [Validation(Required=false)]
        public PaasFunctionDTO Function { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public PaasResponseDTO Response { get; set; }

        [NameInMap("Slot")]
        [Validation(Required=false)]
        public PaasSlotDTO Slot { get; set; }

    }

}
