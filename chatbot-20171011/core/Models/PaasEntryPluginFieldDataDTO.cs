// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class PaasEntryPluginFieldDataDTO : TeaModel {
        /// <summary>
        /// ContentEntry
        /// </summary>
        [NameInMap("ContentEntry")]
        [Validation(Required=false)]
        public List<PaasConditionSetDTO> ContentEntry { get; set; }

        /// <summary>
        /// LifeSpan
        /// </summary>
        [NameInMap("LifeSpan")]
        [Validation(Required=false)]
        public long? LifeSpan { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
