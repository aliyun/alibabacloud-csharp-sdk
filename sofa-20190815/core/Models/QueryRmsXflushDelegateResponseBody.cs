// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsXflushDelegateResponseBody : TeaModel {
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
        public QueryRmsXflushDelegateResponseBodyResponse Response { get; set; }
        public class QueryRmsXflushDelegateResponseBodyResponse : TeaModel {
            [NameInMap("Layer")]
            [Validation(Required=false)]
            public string Layer { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public QueryRmsXflushDelegateResponseBodyResponseData Data { get; set; }
            public class QueryRmsXflushDelegateResponseBodyResponseData : TeaModel {
                [NameInMap("ErrCode")]
                [Validation(Required=false)]
                public string ErrCode { get; set; }

                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                [NameInMap("ErrResolution")]
                [Validation(Required=false)]
                public string ErrResolution { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Module")]
                [Validation(Required=false)]
                public string Module { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }
        };

    }

}
