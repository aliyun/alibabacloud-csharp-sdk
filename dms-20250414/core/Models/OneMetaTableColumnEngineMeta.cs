// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class OneMetaTableColumnEngineMeta : TeaModel {
        [NameInMap("AutoIncrement")]
        [Validation(Required=false)]
        public bool? AutoIncrement { get; set; }

        [NameInMap("DataLength")]
        [Validation(Required=false)]
        public long? DataLength { get; set; }

        [NameInMap("DataPrecision")]
        [Validation(Required=false)]
        public int? DataPrecision { get; set; }

        [NameInMap("DataScale")]
        [Validation(Required=false)]
        public int? DataScale { get; set; }

        [NameInMap("DefaultValue")]
        [Validation(Required=false)]
        public string DefaultValue { get; set; }

        [NameInMap("Encoding")]
        [Validation(Required=false)]
        public string Encoding { get; set; }

        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        [NameInMap("GenerationColumn")]
        [Validation(Required=false)]
        public bool? GenerationColumn { get; set; }

        [NameInMap("GenerationExpression")]
        [Validation(Required=false)]
        public string GenerationExpression { get; set; }

        [NameInMap("Nullable")]
        [Validation(Required=false)]
        public bool? Nullable { get; set; }

    }

}
