// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class BatchDeleteTablesRequest : TeaModel {
        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// IfExists
        /// </summary>
        [NameInMap("IfExists")]
        [Validation(Required=false)]
        public bool? IfExists { get; set; }

        [NameInMap("TableNames")]
        [Validation(Required=false)]
        public List<string> TableNames { get; set; }

    }

}
