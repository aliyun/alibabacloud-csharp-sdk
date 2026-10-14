// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticDatabaseObject : TeaModel {
        [NameInMap("DatabaseQualifiedName")]
        [Validation(Required=false)]
        public string DatabaseQualifiedName { get; set; }

        [NameInMap("DatabaseUuid")]
        [Validation(Required=false)]
        public string DatabaseUuid { get; set; }

        [NameInMap("DdlSql")]
        [Validation(Required=false)]
        public string DdlSql { get; set; }

        [NameInMap("ObjectName")]
        [Validation(Required=false)]
        public string ObjectName { get; set; }

        [NameInMap("ObjectQualifiedName")]
        [Validation(Required=false)]
        public string ObjectQualifiedName { get; set; }

        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

    }

}
