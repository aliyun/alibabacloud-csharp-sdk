// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class RowUpdate : TeaModel {
        [NameInMap("row")]
        [Validation(Required=false)]
        public Row Row { get; set; }

        [NameInMap("rowKind")]
        [Validation(Required=false)]
        public string RowKind { get; set; }

    }

}
