// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutUsersbyacountRequest : TeaModel {
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public string Accounts { get; set; }

        [NameInMap("TenantExternalId")]
        [Validation(Required=false)]
        public string TenantExternalId { get; set; }

    }

}
