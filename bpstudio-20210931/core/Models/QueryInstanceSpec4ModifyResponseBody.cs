// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class QueryInstanceSpec4ModifyResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryInstanceSpec4ModifyResponseBodyData Data { get; set; }
        public class QueryInstanceSpec4ModifyResponseBodyData : TeaModel {
            [NameInMap("OptionalValues")]
            [Validation(Required=false)]
            public List<QueryInstanceSpec4ModifyResponseBodyDataOptionalValues> OptionalValues { get; set; }
            public class QueryInstanceSpec4ModifyResponseBodyDataOptionalValues : TeaModel {
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("Max")]
                [Validation(Required=false)]
                public double? Max { get; set; }

                [NameInMap("Min")]
                [Validation(Required=false)]
                public double? Min { get; set; }

                [NameInMap("Step")]
                [Validation(Required=false)]
                public double? Step { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
