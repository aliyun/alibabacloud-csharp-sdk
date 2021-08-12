// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryPrepaidCardsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPrepaidCardsResponseBodyData Data { get; set; }
        public class QueryPrepaidCardsResponseBodyData : TeaModel {
            [NameInMap("PrepaidCard")]
            [Validation(Required=false)]
            public List<QueryPrepaidCardsResponseBodyDataPrepaidCard> PrepaidCard { get; set; }
            public class QueryPrepaidCardsResponseBodyDataPrepaidCard : TeaModel {
                public string Status { get; set; }
                public string ExpiryTime { get; set; }
                public string GrantedTime { get; set; }
                public string NominalValue { get; set; }
                public string EffectiveTime { get; set; }
                public string PrepaidCardNo { get; set; }
                public string ApplicableScenarios { get; set; }
                public long? PrepaidCardId { get; set; }
                public string ApplicableProducts { get; set; }
                public string Balance { get; set; }
            }
        };

    }

}
