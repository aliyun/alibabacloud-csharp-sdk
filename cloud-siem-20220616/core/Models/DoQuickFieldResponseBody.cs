// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DoQuickFieldResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DoQuickFieldResponseBodyData Data { get; set; }
        public class DoQuickFieldResponseBodyData : TeaModel {
            [NameInMap("AggQueryd")]
            [Validation(Required=false)]
            public string AggQueryd { get; set; }

            [NameInMap("CompleteOrNot")]
            [Validation(Required=false)]
            public bool? CompleteOrNot { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("HasSQL")]
            [Validation(Required=false)]
            public bool? HasSQL { get; set; }

            [NameInMap("Keys")]
            [Validation(Required=false)]
            public List<string> Keys { get; set; }

            [NameInMap("Limited")]
            [Validation(Required=false)]
            public long? Limited { get; set; }

            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<object> Logs { get; set; }

            [NameInMap("PQuery")]
            [Validation(Required=false)]
            public string PQuery { get; set; }

            [NameInMap("ProcessedRows")]
            [Validation(Required=false)]
            public long? ProcessedRows { get; set; }

            [NameInMap("QueryMode")]
            [Validation(Required=false)]
            public int? QueryMode { get; set; }

            [NameInMap("WhereQuery")]
            [Validation(Required=false)]
            public string WhereQuery { get; set; }

        }

        [NameInMap("DyCode")]
        [Validation(Required=false)]
        public string DyCode { get; set; }

        [NameInMap("DyMessage")]
        [Validation(Required=false)]
        public string DyMessage { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

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
