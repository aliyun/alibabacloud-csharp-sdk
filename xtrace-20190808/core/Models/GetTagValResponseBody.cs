// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class GetTagValResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TagValues")]
        [Validation(Required=false)]
        public GetTagValResponseBodyTagValues TagValues { get; set; }
        public class GetTagValResponseBodyTagValues : TeaModel {
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public List<string> TagValue { get; set; }
        };

    }

}
