// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class GetAccountAliasResponseBody : TeaModel {
        /// <summary>
        /// The alias of the Alibaba Cloud account.
        /// </summary>
        [NameInMap("AccountAlias")]
        [Validation(Required=false)]
        public string AccountAlias { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
