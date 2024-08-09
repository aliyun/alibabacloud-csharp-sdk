// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Schema : TeaModel {
        [NameInMap("columns")]
        [Validation(Required=false)]
        public List<TableColumn> Columns { get; set; }

        [NameInMap("primaryKey")]
        [Validation(Required=false)]
        public List<PrimaryKey> PrimaryKey { get; set; }

        [NameInMap("watermarkSpecs")]
        [Validation(Required=false)]
        public List<WatermarkSpec> WatermarkSpecs { get; set; }

    }

}
