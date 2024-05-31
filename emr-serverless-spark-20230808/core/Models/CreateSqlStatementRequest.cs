// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CreateSqlStatementRequest : TeaModel {
        [NameInMap("codeContent")]
        [Validation(Required=false)]
        public string CodeContent { get; set; }

        [NameInMap("defaultCatalog")]
        [Validation(Required=false)]
        public string DefaultCatalog { get; set; }

        [NameInMap("defaultDatabase")]
        [Validation(Required=false)]
        public string DefaultDatabase { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("sqlComputeId")]
        [Validation(Required=false)]
        public string SqlComputeId { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
