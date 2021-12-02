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
                public long? DbId { get; set; }
                public string ExtraData { get; set; }
                public long? PersonId { get; set; }
                public float? Score { get; set; }
                public long? TraceId { get; set; }
            }
        };

        /// <summary>
        /// RequestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
