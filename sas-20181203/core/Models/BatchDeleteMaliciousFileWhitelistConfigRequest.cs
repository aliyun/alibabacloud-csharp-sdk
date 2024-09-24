// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class BatchDeleteMaliciousFileWhitelistConfigRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the whitelist rules. You can call the <a href="~~ListMaliciousFileWhitelistConfigs~~">ListMaliciousFileWhitelistConfigs</a> operation to query the IDs of whitelist rules.</para>
        /// </summary>
        [NameInMap("ConfigIdList")]
        [Validation(Required=false)]
        public List<long?> ConfigIdList { get; set; }

    }

}
