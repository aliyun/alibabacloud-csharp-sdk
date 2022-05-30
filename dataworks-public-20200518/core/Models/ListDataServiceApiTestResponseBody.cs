// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServiceApiTestResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDataServiceApiTestResponseBodyData> Data { get; set; }
        public class ListDataServiceApiTestResponseBodyData : TeaModel {
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public long? ApiId { get; set; }

            [NameInMap("CostTime")]
            [Validation(Required=false)]
            public int? CostTime { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("ParamMap")]
            [Validation(Required=false)]
            public string ParamMap { get; set; }

            [NameInMap("RetCode")]
            [Validation(Required=false)]
            public long? RetCode { get; set; }

            [NameInMap("RetResult")]
            [Validation(Required=false)]
            public string RetResult { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TestId")]
            [Validation(Required=false)]
            public long? TestId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
