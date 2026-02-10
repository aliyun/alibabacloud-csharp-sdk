// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class OneMetaTableIndex : TeaModel {
        [NameInMap("ColumnNames")]
        [Validation(Required=false)]
        public List<string> ColumnNames { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("IndexName")]
        [Validation(Required=false)]
        public string IndexName { get; set; }

        [NameInMap("IndexType")]
        [Validation(Required=false)]
        public string IndexType { get; set; }

        [NameInMap("Primary")]
        [Validation(Required=false)]
        public bool? Primary { get; set; }

        [NameInMap("RealColumnNames")]
        [Validation(Required=false)]
        public List<string> RealColumnNames { get; set; }

        [NameInMap("Unique")]
        [Validation(Required=false)]
        public bool? Unique { get; set; }

    }

}
