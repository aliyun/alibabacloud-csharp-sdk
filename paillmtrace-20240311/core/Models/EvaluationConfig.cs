// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class EvaluationConfig : TeaModel {
        [NameInMap("Answer")]
        [Validation(Required=false)]
        public EvaluationConfigAnswer Answer { get; set; }
        public class EvaluationConfigAnswer : TeaModel {
            [NameInMap("JsonPathInSpan")]
            [Validation(Required=false)]
            public string JsonPathInSpan { get; set; }

            [NameInMap("JsonPathInSpanValue")]
            [Validation(Required=false)]
            public string JsonPathInSpanValue { get; set; }

            [NameInMap("SpanName")]
            [Validation(Required=false)]
            public string SpanName { get; set; }

        }

        [NameInMap("Context")]
        [Validation(Required=false)]
        public EvaluationConfigContext Context { get; set; }
        public class EvaluationConfigContext : TeaModel {
            [NameInMap("JsonPathInSpan")]
            [Validation(Required=false)]
            public string JsonPathInSpan { get; set; }

            [NameInMap("JsonPathInSpanValue")]
            [Validation(Required=false)]
            public string JsonPathInSpanValue { get; set; }

            [NameInMap("SpanName")]
            [Validation(Required=false)]
            public string SpanName { get; set; }

        }

        [NameInMap("Query")]
        [Validation(Required=false)]
        public EvaluationConfigQuery Query { get; set; }
        public class EvaluationConfigQuery : TeaModel {
            [NameInMap("JsonPathInSpan")]
            [Validation(Required=false)]
            public string JsonPathInSpan { get; set; }

            [NameInMap("JsonPathInSpanValue")]
            [Validation(Required=false)]
            public string JsonPathInSpanValue { get; set; }

            [NameInMap("SpanName")]
            [Validation(Required=false)]
            public string SpanName { get; set; }

        }

    }

}
