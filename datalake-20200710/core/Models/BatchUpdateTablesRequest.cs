// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class BatchUpdateTablesRequest : TeaModel {
        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("IsAsync")]
        [Validation(Required=false)]
        public bool? IsAsync { get; set; }

        [NameInMap("TableInputs")]
        [Validation(Required=false)]
        public List<TableInput> TableInputs { get; set; }

    }

}
