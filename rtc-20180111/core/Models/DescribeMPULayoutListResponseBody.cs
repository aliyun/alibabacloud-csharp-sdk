// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeMPULayoutListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LayoutIds")]
        [Validation(Required=false)]
        public DescribeMPULayoutListResponseBodyLayoutIds LayoutIds { get; set; }
        public class DescribeMPULayoutListResponseBodyLayoutIds : TeaModel {
            [NameInMap("LayoutId")]
            [Validation(Required=false)]
            public List<string> LayoutId { get; set; }
        };

    }

}
