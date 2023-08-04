// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds_data20220330.Models
{
    public class ExecuteStatementResult : TeaModel {
        [NameInMap("ColumnMetadata")]
        [Validation(Required=false)]
        public List<ColumnMetadata> ColumnMetadata { get; set; }

        [NameInMap("FormattedRecords")]
        [Validation(Required=false)]
        public string FormattedRecords { get; set; }

        [NameInMap("GeneratedFields")]
        [Validation(Required=false)]
        public List<Field> GeneratedFields { get; set; }

        [NameInMap("NumberOfRecordsUpdated")]
        [Validation(Required=false)]
        public long? NumberOfRecordsUpdated { get; set; }

        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<List<Field>> Records { get; set; }

    }

}
