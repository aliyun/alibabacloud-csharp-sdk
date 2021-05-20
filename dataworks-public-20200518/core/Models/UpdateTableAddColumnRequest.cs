// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateTableAddColumnRequest : TeaModel {
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        [NameInMap("Column")]
        [Validation(Required=false)]
        public List<UpdateTableAddColumnRequestColumn> Column { get; set; }
        public class UpdateTableAddColumnRequestColumn : TeaModel {
            [NameInMap("ColumnNameCn")]
            [Validation(Required=false)]
            public string ColumnNameCn { get; set; }

            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("ColumnType")]
            [Validation(Required=false)]
            public string ColumnType { get; set; }

        }

    }

}
