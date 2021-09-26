// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class ListAssociatedRulesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServerData")]
        [Validation(Required=false)]
        public ListAssociatedRulesResponseBodyServerData ServerData { get; set; }
        public class ListAssociatedRulesResponseBodyServerData : TeaModel {
            [NameInMap("JsonResult")]
            [Validation(Required=false)]
            public string JsonResult { get; set; }
        };

    }

}
