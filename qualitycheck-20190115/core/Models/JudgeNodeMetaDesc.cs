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

        [NameInMap("ExpressionMetaDesc")]
        [Validation(Required=false)]
        public JudgeNodeMetaDescExpressionMetaDesc ExpressionMetaDesc { get; set; }
        public class JudgeNodeMetaDescExpressionMetaDesc : TeaModel {
            [NameInMap("LeftFieldType")]
            [Validation(Required=false)]
            public int? LeftFieldType { get; set; }

            [NameInMap("LeftOperand")]
            [Validation(Required=false)]
            public string LeftOperand { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("RightFieldType")]
            [Validation(Required=false)]
            public int? RightFieldType { get; set; }

            [NameInMap("RightOperand")]
            [Validation(Required=false)]
            public string RightOperand { get; set; }

            [NameInMap("RoundingMode")]
            [Validation(Required=false)]
            public string RoundingMode { get; set; }

        }

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
