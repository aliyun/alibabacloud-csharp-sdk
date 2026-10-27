// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteMaliciousFileWhitelistConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the whitelist rule for sensitive file alerts in agentless detection. You can call the <a href="~~ListMaliciousFileWhitelistConfigs~~">ListMaliciousFileWhitelistConfigs</a> operation to obtain the ID of the whitelist rule for sensitive files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

    }

}
