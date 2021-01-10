// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsCloudmeshListpodsResponseBody : TeaModel {
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
        public QueryRmsCloudmeshListpodsResponseBodyResponse Response { get; set; }
        public class QueryRmsCloudmeshListpodsResponseBodyResponse : TeaModel {
            [NameInMap("ErrMsg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public QueryRmsCloudmeshListpodsResponseBodyResponseData Data { get; set; }
            public class QueryRmsCloudmeshListpodsResponseBodyResponseData : TeaModel {
                [NameInMap("TotalCnt")]
                [Validation(Required=false)]
                public string TotalCnt { get; set; }

                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<string> Items { get; set; }

            }
        };

    }

}
