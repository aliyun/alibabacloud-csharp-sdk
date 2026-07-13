// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class GetTokenTrendResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTokenTrendResponseBodyData Data { get; set; }
        public class GetTokenTrendResponseBodyData : TeaModel {
            [NameInMap("GroupBy")]
            [Validation(Required=false)]
            public string GroupBy { get; set; }

            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<GetTokenTrendResponseBodyDataSeries> Series { get; set; }
            public class GetTokenTrendResponseBodyDataSeries : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<object> Data { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
