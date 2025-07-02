// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class Permission : TeaModel {
        [NameInMap("access")]
        [Validation(Required=false)]
        public string Access { get; set; }

        [NameInMap("columns")]
        [Validation(Required=false)]
        public PermissionColumns Columns { get; set; }
        public class PermissionColumns : TeaModel {
            [NameInMap("columnNames")]
            [Validation(Required=false)]
            public List<string> ColumnNames { get; set; }

            [NameInMap("excludedColumnNames")]
            [Validation(Required=false)]
            public List<string> ExcludedColumnNames { get; set; }

        }

        [NameInMap("database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        [NameInMap("function")]
        [Validation(Required=false)]
        public string Function { get; set; }

        [NameInMap("principal")]
        [Validation(Required=false)]
        public string Principal { get; set; }

        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("table")]
        [Validation(Required=false)]
        public string Table { get; set; }

        [NameInMap("view")]
        [Validation(Required=false)]
        public string View { get; set; }

    }

}
