// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateHoneypotPresetRequest : TeaModel {
        /// <summary>
        /// The name of the honeypot image.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("HoneypotImageName")]
        [Validation(Required=false)]
        public string HoneypotImageName { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The custom configurations of the honeypot template. The value is a JSON string that contains the following fields:
        /// 
        /// *   **portrait_option**: Social Source Tracing
        /// *   **burp**: Burp-specific Defense
        /// *   **trojan_git**: Git-specific Defense
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Meta")]
        [Validation(Required=false)]
        public string Meta { get; set; }

        /// <summary>
        /// The ID of the management node to which you want to deploy honeypots.
        /// 
        /// > You can call the [ListHoneypotNode](~~ListHoneypotNode~~) operation to query the IDs of management nodes.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// The custom name of the honeypot template.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PresetName")]
        [Validation(Required=false)]
        public string PresetName { get; set; }

    }

}
