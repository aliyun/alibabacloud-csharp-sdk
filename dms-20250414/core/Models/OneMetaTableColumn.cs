// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class OneMetaTableColumn : TeaModel {
        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        [NameInMap("ColumnType")]
        [Validation(Required=false)]
        public string ColumnType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EngineMeta")]
        [Validation(Required=false)]
        public OneMetaTableColumnEngineMeta EngineMeta { get; set; }

        [NameInMap("Position")]
        [Validation(Required=false)]
        public int? Position { get; set; }

    }

}
