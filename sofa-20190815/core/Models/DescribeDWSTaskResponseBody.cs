// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeDWSTaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeDWSTaskResponseBodyData> Data { get; set; }
        public class DescribeDWSTaskResponseBodyData : TeaModel {
            [NameInMap("Number")]
            [Validation(Required=false)]
            public long? Number { get; set; }

            [NameInMap("NewTaskStatus")]
            [Validation(Required=false)]
            public string NewTaskStatus { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
