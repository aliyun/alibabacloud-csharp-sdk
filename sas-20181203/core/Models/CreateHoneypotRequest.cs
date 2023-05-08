// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateHoneypotRequest : TeaModel {
        /// <summary>
        /// The ID of the honeypot image.
        /// 
        /// > You can call the [ListAvailableHoneypot](~~ListAvailableHoneypot~~) operation to query the IDs of images from the **HoneypotImageId** response parameter.
        /// </summary>
        [NameInMap("HoneypotImageId")]
        [Validation(Required=false)]
        public string HoneypotImageId { get; set; }

        /// <summary>
        /// The name of the honeypot image.
        /// 
        /// > You can call the [ListAvailableHoneypot](~~ListAvailableHoneypot~~) operation to query the names of images from the **HoneypotImageName** response parameter.
        /// </summary>
        [NameInMap("HoneypotImageName")]
        [Validation(Required=false)]
        public string HoneypotImageName { get; set; }

        /// <summary>
        /// The custom name of the honeypot.
        /// </summary>
        [NameInMap("HoneypotName")]
        [Validation(Required=false)]
        public string HoneypotName { get; set; }

        /// <summary>
        /// The custom configuration of the honeypot in the JSON format. The value contains the following fields:
        /// 
        /// *   **trojan_git**: Git-specific Defense. Valid values:
        /// 
        ///     *   **zip**: Git Source Code Package
        ///     *   **web**: Git Directory Leak
        ///     *   **close**: Disabled
        /// 
        /// *   **trojan_git_addr**: Git Trojan Address.
        /// 
        /// *   **trojan_git.zip**: Git Trojan.
        /// 
        /// *   **burp**: Burp-specific Defense. Valid values:
        /// 
        ///     *   **open**: Enable
        ///     *   **close**: Disable
        /// 
        /// *   **portrait_option**: Source Tracing Configuration. Valid values:
        /// 
        ///     *   **false**: Disable
        ///     *   **true**: Enable
        /// </summary>
        [NameInMap("Meta")]
        [Validation(Required=false)]
        public string Meta { get; set; }

        /// <summary>
        /// The ID of the management node.
        /// 
        /// > You can call the [ListHoneypotNode](~~ListHoneypotNode~~) operation to query the IDs of management nodes.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

    }

}
