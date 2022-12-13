// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListRouteRulesByServiceResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListRouteRulesByServiceResponseBodyData> Data { get; set; }
        public class ListRouteRulesByServiceResponseBodyData : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("ruleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
