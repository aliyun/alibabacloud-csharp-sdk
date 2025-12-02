// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class TableSummaryModel : TeaModel {
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

        [NameInMap("MvDetailModel")]
        [Validation(Required=false)]
        public OpenStructMvDetailModel MvDetailModel { get; set; }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("SQL")]
        [Validation(Required=false)]
        public string SQL { get; set; }

        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("TableSize")]
        [Validation(Required=false)]
        public long? TableSize { get; set; }

        [NameInMap("TableType")]
        [Validation(Required=false)]
        public string TableType { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
