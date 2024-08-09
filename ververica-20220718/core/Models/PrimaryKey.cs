// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class PrimaryKey : TeaModel {
        [NameInMap("columns")]
        [Validation(Required=false)]
        public List<string> Columns { get; set; }

        [NameInMap("constraintName")]
        [Validation(Required=false)]
        public string ConstraintName { get; set; }

    }

}
