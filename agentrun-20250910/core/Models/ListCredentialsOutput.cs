// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListCredentialsOutput : TeaModel {
        [NameInMap("items")]
        [Validation(Required=false)]
        public CredentialListItem Items { get; set; }

        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public string PageNum { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
