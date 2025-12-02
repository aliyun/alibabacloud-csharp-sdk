// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class TableDetailModel : TeaModel {
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<ColDetailModel> Columns { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CreatedBySource")]
        [Validation(Required=false)]
        public string CreatedBySource { get; set; }

        [NameInMap("CreatedByUser")]
        [Validation(Required=false)]
        public string CreatedByUser { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Parameters { get; set; }

        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("TableType")]
        [Validation(Required=false)]
        public string TableType { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
