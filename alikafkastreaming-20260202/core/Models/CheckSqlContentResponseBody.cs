// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AlikafkaStreaming20260202.Models
{
    public class CheckSqlContentResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CheckSqlContentResponseBodyData Data { get; set; }
        public class CheckSqlContentResponseBodyData : TeaModel {
            [NameInMap("ErrorList")]
            [Validation(Required=false)]
            public List<CheckSqlContentResponseBodyDataErrorList> ErrorList { get; set; }
            public class CheckSqlContentResponseBodyDataErrorList : TeaModel {
                [NameInMap("CodeSnippet")]
                [Validation(Required=false)]
                public string CodeSnippet { get; set; }

                [NameInMap("ColumnNumber")]
                [Validation(Required=false)]
                public int? ColumnNumber { get; set; }

                [NameInMap("EndColumnNumber")]
                [Validation(Required=false)]
                public int? EndColumnNumber { get; set; }

                [NameInMap("EndLineNumber")]
                [Validation(Required=false)]
                public int? EndLineNumber { get; set; }

                [NameInMap("ErrorType")]
                [Validation(Required=false)]
                public string ErrorType { get; set; }

                [NameInMap("LineNumber")]
                [Validation(Required=false)]
                public int? LineNumber { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            [NameInMap("Valid")]
            [Validation(Required=false)]
            public bool? Valid { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
