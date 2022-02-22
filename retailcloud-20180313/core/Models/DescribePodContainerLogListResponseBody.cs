// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class DescribePodContainerLogListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("ErrMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribePodContainerLogListResponseBodyResult Result { get; set; }
        public class DescribePodContainerLogListResponseBodyResult : TeaModel {
            [NameInMap("ContainerLogList")]
            [Validation(Required=false)]
            public List<DescribePodContainerLogListResponseBodyResultContainerLogList> ContainerLogList { get; set; }
            public class DescribePodContainerLogListResponseBodyResultContainerLogList : TeaModel {
                public string ContainerName { get; set; }
                public string Content { get; set; }
                public string PodName { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
