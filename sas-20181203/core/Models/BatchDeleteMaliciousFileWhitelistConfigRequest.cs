// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class BatchDeleteMaliciousFileWhitelistConfigRequest : TeaModel {
        /// <summary>
        /// <para>The list of sensitive file whitelist rule IDs. Call <a href="~~ListMaliciousFileWhitelistConfigs~~">ListMaliciousFileWhitelistConfigs</a> to obtain the IDs of sensitive file whitelist rules.</para>
        /// </summary>
        [NameInMap("ConfigIdList")]
        [Validation(Required=false)]
        public List<long?> ConfigIdList { get; set; }

    }

}
