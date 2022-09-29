// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class SearchBodyTraceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchBodyTraceResponseBodyData Data { get; set; }
        public class SearchBodyTraceResponseBodyData : TeaModel {
            [NameInMap("MatchList")]
            [Validation(Required=false)]
            public List<SearchBodyTraceResponseBodyDataMatchList> MatchList { get; set; }
            public class SearchBodyTraceResponseBodyDataMatchList : TeaModel {
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                [NameInMap("ExtraData")]
                [Validation(Required=false)]
                public string ExtraData { get; set; }

                [NameInMap("PersonId")]
                [Validation(Required=false)]
                public long? PersonId { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                [NameInMap("TraceId")]
                [Validation(Required=false)]
                public long? TraceId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
