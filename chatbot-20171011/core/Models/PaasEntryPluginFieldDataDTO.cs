// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class PaasEntryPluginFieldDataDTO : TeaModel {
        [NameInMap("ContentEntry")]
        [Validation(Required=false)]
        public List<PaasConditionSetDTO> ContentEntry { get; set; }

        [NameInMap("LifeSpan")]
        [Validation(Required=false)]
        public long? LifeSpan { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
