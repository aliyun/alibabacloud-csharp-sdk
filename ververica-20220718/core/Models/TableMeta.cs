// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class TableMeta : TeaModel {
        [NameInMap("catalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        [NameInMap("databaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("tableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
