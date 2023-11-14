// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateImageVulWhitelistTargetRequest : TeaModel {
        /// <summary>
        /// The whitelist ID.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

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
        /// The reason why you add the vulnerability to the whitelist.
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// The source of the whitelist. Valid values:
        /// 
        /// *   **image**
        /// *   **agentless**
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The vulnerability that you want to add to the whitelist. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **type**: The type of the vulnerability. The value is fixed to repo.
        /// *   **target**: The content of the vulnerability. The value is in the format of Namespace/Image repository.
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

    }

}
