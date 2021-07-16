// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateRouteRuleResponseBody : TeaModel {
        /// <summary>
        /// 请求
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateRouteRuleResponseBodyData Data { get; set; }
        public class CreateRouteRuleResponseBodyData : TeaModel {
            [NameInMap("routeRuleId")]
            [Validation(Required=false)]
            public long? RouteRuleId { get; set; }
        };

    }

}
