// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteMaliciousFileWhitelistConfigRequest : TeaModel {
        /// <summary>
        /// The ID of the alert whitelist rule of sensitive files that are detected by using the agentless detection feature. You can call the [ListMaliciousFileWhitelistConfigs](~~ListMaliciousFileWhitelistConfigs~~) operation to query the IDs of alert whitelist rules.
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

    }

}
