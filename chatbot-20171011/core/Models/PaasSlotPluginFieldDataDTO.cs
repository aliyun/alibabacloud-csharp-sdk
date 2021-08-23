// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class PaasSlotPluginFieldDataDTO : TeaModel {
        /// <summary>
        /// IntentName
        /// </summary>
        [NameInMap("IntentName")]
        [Validation(Required=false)]
        public string IntentName { get; set; }

        /// <summary>
        /// IntentId
        /// </summary>
        [NameInMap("IntentId")]
        [Validation(Required=false)]
        public string IntentId { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// IsSysIntent
        /// </summary>
        [NameInMap("IsSysIntent")]
        [Validation(Required=false)]
        public bool? IsSysIntent { get; set; }

        /// <summary>
        /// ContentSlot
        /// </summary>
        [NameInMap("ContentSlot")]
        [Validation(Required=false)]
        public List<PaasSlotConfigDTO> ContentSlot { get; set; }

    }

}
