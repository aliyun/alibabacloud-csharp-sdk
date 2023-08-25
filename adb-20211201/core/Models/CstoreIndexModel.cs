// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CstoreIndexModel : TeaModel {
        [NameInMap("ColumnOrds")]
        [Validation(Required=false)]
        public List<string> ColumnOrds { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("IndexColumns")]
        [Validation(Required=false)]
        public List<FieldSchemaModel> IndexColumns { get; set; }

        [NameInMap("IndexName")]
        [Validation(Required=false)]
        public string IndexName { get; set; }

        [NameInMap("IndexType")]
        [Validation(Required=false)]
        public string IndexType { get; set; }

        [NameInMap("Options")]
        [Validation(Required=false)]
        public Dictionary<string, string> Options { get; set; }

        [NameInMap("PhysicalTableName")]
        [Validation(Required=false)]
        public string PhysicalTableName { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
