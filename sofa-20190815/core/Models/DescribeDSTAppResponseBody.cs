// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeDSTAppResponseBody : TeaModel {
        [NameInMap("App")]
        [Validation(Required=false)]
        public DescribeDSTAppResponseBodyApp App { get; set; }
        public class DescribeDSTAppResponseBodyApp : TeaModel {
            [NameInMap("BizLogEnabled")]
            [Validation(Required=false)]
            public bool? BizLogEnabled { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Collected")]
            [Validation(Required=false)]
            public bool? Collected { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
