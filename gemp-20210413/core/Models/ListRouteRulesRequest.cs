// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListRouteRulesRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("notFilterRouteRuleDeleted")]
        [Validation(Required=false)]
        public bool? NotFilterRouteRuleDeleted { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("routeType")]
        [Validation(Required=false)]
        public long? RouteType { get; set; }

        [NameInMap("ruleName")]
        [Validation(Required=false)]
        public byte[] RuleName { get; set; }

        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public byte[] ServiceName { get; set; }

    }

}
