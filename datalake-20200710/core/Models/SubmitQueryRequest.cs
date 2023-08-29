// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class SubmitQueryRequest : TeaModel {
        [NameInMap("catalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        [NameInMap("sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
