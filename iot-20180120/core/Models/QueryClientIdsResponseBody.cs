// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryClientIdsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryClientIdsResponseBodyData Data { get; set; }
        public class QueryClientIdsResponseBodyData : TeaModel {
            [NameInMap("DynamicRegClientIds")]
            [Validation(Required=false)]
            public List<QueryClientIdsResponseBodyDataDynamicRegClientIds> DynamicRegClientIds { get; set; }
            public class QueryClientIdsResponseBodyDataDynamicRegClientIds : TeaModel {
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

            }

            [NameInMap("IotId")]
            [Validation(Required=false)]
            public string IotId { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
