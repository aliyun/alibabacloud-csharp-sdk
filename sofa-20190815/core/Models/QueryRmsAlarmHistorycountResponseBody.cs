// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsAlarmHistorycountResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public List<QueryRmsAlarmHistorycountResponseBodyResponse> Response { get; set; }
        public class QueryRmsAlarmHistorycountResponseBodyResponse : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public long? Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public long? Value { get; set; }

        }

    }

}
