// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class DeleteRouteRuleRequest : TeaModel {
        /// <summary>
        /// 幂等号
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [NameInMap("routeRuleId")]
        [Validation(Required=false)]
        public long? RouteRuleId { get; set; }

    }

}
