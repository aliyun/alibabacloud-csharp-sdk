// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class JudgeNodeMetaDesc : TeaModel {
        [NameInMap("ActualValue")]
        [Validation(Required=false)]
        public string ActualValue { get; set; }

        [NameInMap("DataType")]
        [Validation(Required=false)]
        public int? DataType { get; set; }

        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        [NameInMap("FieldType")]
        [Validation(Required=false)]
        public int? FieldType { get; set; }

        [NameInMap("Symbol")]
        [Validation(Required=false)]
        public int? Symbol { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
