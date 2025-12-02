// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DatabaseSummaryModel : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CreatedBySource")]
        [Validation(Required=false)]
        public string CreatedBySource { get; set; }

        [NameInMap("CreatedByUser")]
        [Validation(Required=false)]
        public string CreatedByUser { get; set; }

        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
