// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListRouteRulesByAssignWhoIdResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListRouteRulesByAssignWhoIdResponseBodyData> Data { get; set; }
        public class ListRouteRulesByAssignWhoIdResponseBodyData : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ruleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("tenantRamId")]
            [Validation(Required=false)]
            public long? TenantRamId { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
