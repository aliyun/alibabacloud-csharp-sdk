// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class TableResult : TeaModel {
        [NameInMap("rowUpdates")]
        [Validation(Required=false)]
        public List<RowUpdate> RowUpdates { get; set; }

        [NameInMap("tableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
