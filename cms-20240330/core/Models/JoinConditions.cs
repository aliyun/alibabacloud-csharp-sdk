// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class JoinConditions : TeaModel {
        [NameInMap("lhsField")]
        [Validation(Required=false)]
        public string LhsField { get; set; }

        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("rhsField")]
        [Validation(Required=false)]
        public string RhsField { get; set; }

    }

}
