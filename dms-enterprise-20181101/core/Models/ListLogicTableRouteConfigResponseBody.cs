// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListLogicTableRouteConfigResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("LogicTableRouteConfigList")]
        [Validation(Required=false)]
        public ListLogicTableRouteConfigResponseBodyLogicTableRouteConfigList LogicTableRouteConfigList { get; set; }
        public class ListLogicTableRouteConfigResponseBodyLogicTableRouteConfigList : TeaModel {
            [NameInMap("LogicTableRouteConfig")]
            [Validation(Required=false)]
            public List<ListLogicTableRouteConfigResponseBodyLogicTableRouteConfigListLogicTableRouteConfig> LogicTableRouteConfig { get; set; }
            public class ListLogicTableRouteConfigResponseBodyLogicTableRouteConfigListLogicTableRouteConfig : TeaModel {
                public string RouteExpr { get; set; }
                public string RouteKey { get; set; }
                public long? TableId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
