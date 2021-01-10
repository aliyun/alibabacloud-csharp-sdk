// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMqSofamqLinkResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryMqSofamqLinkResponseBodyData Data { get; set; }
        public class QueryMqSofamqLinkResponseBodyData : TeaModel {
            [NameInMap("DemoProject")]
            [Validation(Required=false)]
            public string DemoProject { get; set; }
            [NameInMap("ProductDoc")]
            [Validation(Required=false)]
            public string ProductDoc { get; set; }
            [NameInMap("QuickStart")]
            [Validation(Required=false)]
            public string QuickStart { get; set; }
        };

    }

}
