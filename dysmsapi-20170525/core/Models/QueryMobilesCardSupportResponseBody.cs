// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QueryMobilesCardSupportResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryMobilesCardSupportResponseBodyData Data { get; set; }
        public class QueryMobilesCardSupportResponseBodyData : TeaModel {
            [NameInMap("QueryResult")]
            [Validation(Required=false)]
            public List<QueryMobilesCardSupportResponseBodyDataQueryResult> QueryResult { get; set; }
            public class QueryMobilesCardSupportResponseBodyDataQueryResult : TeaModel {
                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                [NameInMap("Support")]
                [Validation(Required=false)]
                public bool? Support { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
